using Lagerverwaltung.Services;
using Lagerverwaltung.Style;
using System.Windows.Forms;

namespace Lagerverwaltung
{
	public partial class WarehouseManagementControl : UserControl
	{
		private List<Article> allArticles;
		private List<Warehouse> allLocation;

		public WarehouseManagementControl()
		{
			InitializeComponent();
			StyleManager.ApplyTheme(this);

			// Beim Laden des UserControls Daten laden
			this.Load += async (s, e) => await LoadArticles();

			// Auswahländerung im DataGridView
			dgvLagerorte.SelectionChanged += DVarticles_SelectionChanged;
			dgvLagerorte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvLagerorte.MultiSelect = false;
		}

		// Lädt Artikel und Lagerorte und zeigt sie im DataGridView an
		private async Task LoadArticles()
		{
			try
			{
				allArticles = await ArticleService.GetAllAsync();
				allLocation = await WarehouseService.GetAllLocationsAsync();

				dgvLagerorte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dgvLagerorte.DataSource = allLocation
					.Select(l => new
					{
						name = l.name,
						capacity = l.maxCapacity
					}).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		// Zeigt die gewählten Lagerortdaten im Formular an
		private void DVarticles_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvLagerorte.CurrentRow != null && dgvLagerorte.CurrentRow.DataBoundItem != null)
			{
				dynamic selectedItem = dgvLagerorte.CurrentRow.DataBoundItem;

				txtName.Text = selectedItem.name?.ToString() ?? "";
				NumUCapacity.Text = selectedItem.capacity?.ToString();
			}
		}

		

		// Lädt alle Daten neu (Artikel + Lagerorte)
		public async Task ReloadData()
		{
			allArticles = await ArticleService.GetAllAsync();
			allLocation = await WarehouseService.GetAllLocationsAsync();

			dgvLagerorte.DataSource = allLocation;

			dgvArticles.DataSource = allArticles.Select(a => new
			{
				name = a.name,
				price = a.price,
				storageLocationName = allLocation.FirstOrDefault(l => l.id == a.storageLocationId)?.name ?? "Unknown"
			}).ToList();
		}


		// Button zum Neuladen der Daten
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			_ = ReloadData();
		}

	}
}
