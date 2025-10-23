
using Lagerverwaltung.Services;
using Lagerverwaltung.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lagerverwaltung.UC
{
	public partial class OperationsControl : UserControl
	{
		private List<ProcessPosition> allProcesses;

		public OperationsControl()
		{
			InitializeComponent();

			dtgMovements.SelectionChanged += dtgMovements_SelectionChanged;

			// Setzt das aktuelle Datum im DateTimePicker
			dateTimeBox.Value = DateTime.Today;

			// Lädt Daten beim Start des Controls
			this.Load += ArticleManagementControl_Load;

			// Wendet das visuelle Design an
			StyleManager.ApplyTheme(this);
		}

		//
		private async void dtgMovements_SelectionChanged(object sender, EventArgs e)
		{
			if (dtgMovements.CurrentRow != null && dtgMovements.CurrentRow.DataBoundItem != null)
			{
				dynamic selectedItem = dtgMovements.CurrentRow.DataBoundItem;

				txtArticle.Text = selectedItem.Article?.ToString() ?? "";

				if (int.TryParse(selectedItem.Quantity?.ToString(), out int qty))
					numStock.Value = qty;
				else
					numStock.Value = 0;

				// Von-Lagerort setzen (einfacher Text, nur Anzeige)
				cmbFromWarehouse.Items.Clear();
				cmbFromWarehouse.Items.Add(selectedItem.From?.ToString() ?? "N/A");
				cmbFromWarehouse.SelectedIndex = 0;
				cmbFromWarehouse.Enabled = false;

				// Ziel-Lagerorte laden und passenden selektieren
				await LoadWarehousesToComboBoxAsync();
				cmbToWarehouse.SelectedIndex = cmbToWarehouse.FindStringExact(selectedItem.To?.ToString() ?? "");

				// Datum setzen
				if (DateTime.TryParse(selectedItem.Date?.ToString(), out DateTime date))
					dateTimePicker1.Value = date;
				else
					dateTimePicker1.Value = DateTime.Today;
			}
		}



		// Wird beim Laden des Controls aufgerufen
		private async void ArticleManagementControl_Load(object sender, EventArgs e)
		{
			dateTimeBox.Value = DateTime.Today;
			await LoadFilteredProcessesByDate();
		}

		// Wird ausgelöst, wenn das Datum geändert wird
		private async void dateTimePickerWarehouse_ValueChanged(object sender, EventArgs e)
		{
			await LoadFilteredProcessesByDate();
		}

		// Lädt alle Prozessdaten (nicht gefiltert)
		private async Task LoadArticles()
		{
			try
			{
				var allProcesses = await ProcessService.GetAllAsync();
				var warehouses = await WarehouseService.GetAllLocationsAsync();
				var articles = await ArticleService.GetAllAsync();

				var result = allProcesses.Select(process => new
				{
					Article = articles.FirstOrDefault(a => a.id == process.articleId)?.name ?? "Unbekannt",
					Quantity = process.quantity,
					From = warehouses.FirstOrDefault(w => w.id == process.sourceLocationId)?.name ?? "N/V",
					To = warehouses.FirstOrDefault(w => w.id == process.targetLocationId)?.name ?? "N/V",
					Date = process.timestamp?.ToString("yyyy-MM-dd HH:mm") ?? "-"
				}).ToList();

				dtgMovements.AutoGenerateColumns = true;
				dtgMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dtgMovements.DataSource = result;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Fehler beim Laden der Daten: {ex.Message}");
			}
		}

		// Lädt nur Prozesse, die am ausgewählten Datum durchgeführt wurden
		private async Task LoadFilteredProcessesByDate()
		{
			try
			{
				var selectedDate = dateTimeBox.Value.Date;

				var allProcesses = await ProcessService.GetAllAsync();
				var warehouses = await WarehouseService.GetAllLocationsAsync();
				var articles = await ArticleService.GetAllAsync();

				var filteredProcesses = allProcesses
					.Where(p => p.timestamp.HasValue && p.timestamp.Value.Date == selectedDate)
					.Select(process => new
					{
						Article = articles.FirstOrDefault(a => a.id == process.articleId)?.name ?? "Unbekannt",
						Quantity = process.quantity,
						From = warehouses.FirstOrDefault(w => w.id == process.sourceLocationId)?.name ?? "N/V",
						To = warehouses.FirstOrDefault(w => w.id == process.targetLocationId)?.name ?? "N/V",
						Date = process.timestamp?.ToString("yyyy-MM-dd HH:mm") ?? "-"
					})
					.ToList();

				dtgMovements.AutoGenerateColumns = true;
				dtgMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dtgMovements.DataSource = filteredProcesses;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Fehler beim Filtern der Prozesse: {ex.Message}");
			}
		}
		// Lädt alle Lagerorte asynchron in das Ziel-ComboBox
		private async Task LoadWarehousesToComboBoxAsync()
		{
			try
			{
				var warehouses = await WarehouseService.GetAllLocationsAsync();
				cmbToWarehouse.DataSource = warehouses;
				cmbToWarehouse.DisplayMember = "name";   // Was angezeigt wird
				cmbToWarehouse.ValueMember = "id";       // Der tatsächliche Wert
				cmbFromWarehouse.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Fehler beim Laden der Lagerorte: {ex.Message}");
			}
		}
	}
}
