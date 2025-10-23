namespace Lagerverwaltung
{
	partial class WarehouseManagementControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvLagerorte = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.NumUCapacity = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCapacity = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvLagerorte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvLagerorte
			// 
			this.dgvLagerorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLagerorte.Location = new System.Drawing.Point(24, 68);
			this.dgvLagerorte.Name = "dgvLagerorte";
			this.dgvLagerorte.RowTemplate.Height = 25;
			this.dgvLagerorte.Size = new System.Drawing.Size(834, 326);
			this.dgvLagerorte.TabIndex = 0;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(597, 604);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "REFRESH";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(209, 451);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 23);
			this.txtName.TabIndex = 6;
			// 
			// NumUCapacity
			// 
			this.NumUCapacity.Location = new System.Drawing.Point(209, 438);
			this.NumUCapacity.Name = "NumUCapacity";
			this.NumUCapacity.Size = new System.Drawing.Size(120, 23);
			this.NumUCapacity.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(57, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "NEW";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(138, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "DELETE";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(708, 604);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "OK";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(116, 457);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(37, 15);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "name";
			// 
			// lblCapacity
			// 
			this.lblCapacity.AutoSize = true;
			this.lblCapacity.Location = new System.Drawing.Point(116, 500);
			this.lblCapacity.Name = "lblCapacity";
			this.lblCapacity.Size = new System.Drawing.Size(51, 15);
			this.lblCapacity.TabIndex = 12;
			this.lblCapacity.Text = "capacity";
			// 
			// WarehouseManagementControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblCapacity);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.NumUCapacity);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvLagerorte);
			this.Name = "WarehouseManagementControl";
			this.Size = new System.Drawing.Size(887, 648);
			((System.ComponentModel.ISupportInitialize)(this.dgvLagerorte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvLagerorte;
		private ComboBox cmbArtikelFilter;
		private DataGridView dgvArticles;
		private Label label1;
		private Label label2;
		private Button btnRefresh;
		private TextBox txtName;
		private NumericUpDown NumUCapacity;
		private Button button2;
		private Button button3;
		private Button button4;
		private Label lblName;
		private Label lblCapacity;
	}
}
