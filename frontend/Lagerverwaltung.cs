using Lagerverwaltung.UC;
using Lagerverwaltung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lagerverwaltung
{
	public partial class Lagerverwaltung : Form
	{

		
		private ArticleManagementControl m_articleCtrl;
		private WarehouseManagementControl m_storageLocationCtrl;
		private OperationsControl m_operationsCtrl;
		public Lagerverwaltung()
		{
			
			InitializeComponent();
			this.Text = "Lager";
			UserControlsConfiguration();
			MenuConfigurationOptimal();
			
		}

		private void changeUC(object sender, EventArgs e)
		{
			if (LVmenuMain.SelectedItems.Count > 0)
			{
				string selected = LVmenuMain.SelectedItems[0].Text;

				switch (selected)
				{
					case "Article":
						LoadUserControl(new ArticleManagementControl());
						break;
					case "Warehouse":
						LoadUserControl(new WarehouseManagementControl());
						break;
					case "Movement":
						LoadUserControl(new OperationsControl());
						break;
					case "Exit":
						Exit();
						break;
				}
			}
		}

		private void LoadUserControl(UserControl uc)
		{
			panelContent.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panelContent.Controls.Add(uc);
		}
		public void Exit()
		{
			var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				Application.Exit();
		}


		public void UserControlsConfiguration()
		{
			m_articleCtrl = new ArticleManagementControl();
			m_storageLocationCtrl = new WarehouseManagementControl();
			m_operationsCtrl = new OperationsControl();

			m_articleCtrl.Dock = DockStyle.Fill;
			m_storageLocationCtrl.Dock = DockStyle.Fill;
			m_operationsCtrl.Dock = DockStyle.Fill;

			panelContent.Controls.Add(m_articleCtrl);
			panelContent.Controls.Add(m_storageLocationCtrl);
			panelContent.Controls.Add(m_operationsCtrl);

			m_articleCtrl.Visible = false;
			m_storageLocationCtrl.Visible = false;
			m_operationsCtrl.Visible = false;
		}

		public void MenuConfigurationOptimal()
		{
			LVmenuMain.View = View.SmallIcon;
			LVmenuMain.Alignment = ListViewAlignment.Left;
			LVmenuMain.HeaderStyle = ColumnHeaderStyle.None;
			LVmenuMain.FullRowSelect = true;
			LVmenuMain.BorderStyle = BorderStyle.None;
			LVmenuMain.BackColor = Color.FromArgb(240, 248, 255);
			LVmenuMain.ForeColor = Color.Black;
			LVmenuMain.Font = new Font("Segoe UI", 10, FontStyle.Regular);

			ImageList iconList = new ImageList();
			iconList.ImageSize = new Size(24, 24);
			iconList.Images.Add("article", Properties.Resources.inventary);
			iconList.Images.Add("warehouse", Properties.Resources.erstellen);
			iconList.Images.Add("movement", Properties.Resources.movement);
			iconList.Images.Add("settings", Properties.Resources.settings);
			iconList.Images.Add("exit", Properties.Resources.exit);
			LVmenuMain.SmallImageList = iconList;

			LVmenuMain.Items.Clear();
			LVmenuMain.Items.Add(new ListViewItem("Article", "article"));
			LVmenuMain.Items.Add(new ListViewItem("Warehouse", "warehouse"));
			LVmenuMain.Items.Add(new ListViewItem("Movement", "movement"));
			LVmenuMain.Items.Add(new ListViewItem("Configuration", "settings"));
			LVmenuMain.Items.Add(new ListViewItem("Exit", "exit"));

			LVmenuMain.OwnerDraw = false;
		}
	}




	
	

}
