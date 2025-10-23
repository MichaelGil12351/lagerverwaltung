using Lagerverwaltung.Services;
using Lagerverwaltung.Style;
using Lagerverwaltung.UC;
using System.Drawing.Drawing2D;

namespace Lagerverwaltung
{
	public partial class ArticleManagementControl : UserControl
	{
		private List<Article> allArticles;
		private List<Warehouse> warehouses;

		public ArticleManagementControl()
		{
			InitializeComponent();
			StyleManager.ApplyTheme(this);

			// Beim Laden des UserControls Artikel laden
			this.Load += async (s, e) => await LoadArticles();

			// Event-Handler für Auswahl in DataGridView
			dataGridViewArtikel.SelectionChanged += DVarticles_SelectionChanged;

			lblEdit.Visible = false;
			lblNEW.Visible = false;

			// DataGridView-Einstellungen
			dataGridViewArtikel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewArtikel.MultiSelect = false;
		}

		// Lädt alle Artikel und zugehörige Lagerorte in die DataGridView
		private async Task LoadArticles()
		{
			try
			{
				allArticles = await ArticleService.GetAllAsync();
				warehouses = await WarehouseService.GetAllLocationsAsync();

				dataGridViewArtikel.AutoGenerateColumns = true;
				dataGridViewArtikel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				dataGridViewArtikel.DataSource = allArticles
					.Select((Article a) => new
					{
						name = a.name,
						price = a.price,
						datum = a.createdAt,
						storagelocationname = warehouses.FirstOrDefault((Warehouse l) => l.id == a.storageLocationId)?.name ?? "unknown"
					}).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		// Wird aufgerufen, wenn ein Artikel aus der Liste ausgewählt wird
		private async void DVarticles_SelectionChanged(object sender, EventArgs e)
		{
			lblNEW.Visible = false;

			if (dataGridViewArtikel.CurrentRow != null && dataGridViewArtikel.CurrentRow.DataBoundItem != null)
			{
				dynamic selectedItem = dataGridViewArtikel.CurrentRow.DataBoundItem;

				textBoxName.Text = selectedItem.name?.ToString() ?? "";
				dateTimePicker1.Text = selectedItem.datum?.ToString("yyyy-MM-dd") ?? "";
				nPrice.Text = selectedItem.price?.ToString();
				lblEdit.Visible = true;

				await LoadWarehousesAsync();

				cmbLager.DropDownStyle = ComboBoxStyle.DropDownList;
				cmbLager.DataSource = null;
				cmbLager.Items.Clear();
				cmbLager.Items.Add(selectedItem.storagelocationname ?? "Unknown");
				cmbLager.SelectedIndex = 0;
				cmbLager.Enabled = false;
			}
		}

		// Erstellt einen neuen Artikel und speichert ihn in der Datenbank
		private async void btnSave_Click(object sender, EventArgs e)
		{
			if (cmbLager.SelectedValue == null)
			{
				MessageBox.Show("Please select a warehouse.");
				return;
			}

			var article = new Article
			{
				name = textBoxName.Text,
				description = textBoxDescription.Text,
				price = (int)nPrice.Value,
				createdAt = DateTime.Now,
				storageLocationId = (int)cmbLager.SelectedValue
			};

			var success = await ArticleService.CreateAsync(article);

			if (success)
			{
				MessageBox.Show("Article created successfully.");
				ClearFields(Parent);
			}
			else
			{
				MessageBox.Show("Failed to create article.");
			}
		}

		// Lädt alle Lagerorte für ComboBox (z.B. beim Erstellen)
		private async Task LoadWarehousesAsync()
		{
			var warehouses = await WarehouseService.GetAllLocationsAsync();
			cmbLager.DataSource = warehouses;
			cmbLager.DisplayMember = "Name";
			cmbLager.ValueMember = "Id";
		}

		// Leert alle Eingabefelder rekursiv
		public void ClearFields(Control parent)
		{
			foreach (Control control in parent.Controls)
			{
				if (control is TextBox textBox)
				{
					textBox.Text = string.Empty;
				}
				else if (control is ComboBox comboBox)
				{
					comboBox.SelectedIndex = -1;
				}
				else if (control.HasChildren)
				{
					ClearFields(control);
				}
			}
		}

		// Aktiviert das Formular zur Erstellung eines neuen Artikels
		private async void btnNewArticle_Click(object sender, EventArgs e)
		{
			lblNEW.Visible = true;
			lblEdit.Visible = false;

			textBoxName.Text = "";
			textBoxDescription.Text = "";
			nPrice.Value = 0;
			cmbLager.Enabled = true;

			var warehouses = await WarehouseService.GetAllLocationsAsync();

			cmbLager.DataSource = warehouses;
			cmbLager.SelectedIndex = -1;
			cmbLager.DisplayMember = "name";  // Zeigt den Namen an
			cmbLager.ValueMember = "id";      // Der tatsächliche Wert

			if (cmbLager.Items.Count > 0)
				cmbLager.SelectedIndex = 0;

			textBoxName.Focus();
		}
	}
}
