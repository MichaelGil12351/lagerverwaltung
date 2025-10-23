namespace Lagerverwaltung
{
	partial class ArticleManagementControl
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.pnlDTArticles = new System.Windows.Forms.Panel();
			this.btnDeleteArticle = new System.Windows.Forms.Button();
			this.btnNewArticle = new System.Windows.Forms.Button();
			this.dataGridViewArtikel = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblEdit = new System.Windows.Forms.Label();
			this.lblNEW = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.nPrice = new System.Windows.Forms.NumericUpDown();
			this.cmbLager = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelMain.SuspendLayout();
			this.pnlDTArticles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikel)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.pnlDTArticles);
			this.panelMain.Controls.Add(this.panel1);
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1326, 823);
			this.panelMain.TabIndex = 0;
			// 
			// pnlDTArticles
			// 
			this.pnlDTArticles.Controls.Add(this.btnDeleteArticle);
			this.pnlDTArticles.Controls.Add(this.btnNewArticle);
			this.pnlDTArticles.Controls.Add(this.dataGridViewArtikel);
			this.pnlDTArticles.Location = new System.Drawing.Point(13, 3);
			this.pnlDTArticles.Name = "pnlDTArticles";
			this.pnlDTArticles.Size = new System.Drawing.Size(1299, 268);
			this.pnlDTArticles.TabIndex = 35;
			// 
			// btnDeleteArticle
			// 
			this.btnDeleteArticle.Location = new System.Drawing.Point(208, 3);
			this.btnDeleteArticle.Name = "btnDeleteArticle";
			this.btnDeleteArticle.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteArticle.TabIndex = 49;
			this.btnDeleteArticle.Text = "DELETE";
			this.btnDeleteArticle.UseVisualStyleBackColor = true;
			// 
			// btnNewArticle
			// 
			this.btnNewArticle.Location = new System.Drawing.Point(117, 3);
			this.btnNewArticle.Name = "btnNewArticle";
			this.btnNewArticle.Size = new System.Drawing.Size(75, 23);
			this.btnNewArticle.TabIndex = 48;
			this.btnNewArticle.Text = "NEW";
			this.btnNewArticle.UseVisualStyleBackColor = true;
			this.btnNewArticle.Click += new System.EventHandler(this.btnNewArticle_Click);
			// 
			// dataGridViewArtikel
			// 
			this.dataGridViewArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewArtikel.Location = new System.Drawing.Point(117, 44);
			this.dataGridViewArtikel.Name = "dataGridViewArtikel";
			this.dataGridViewArtikel.RowTemplate.Height = 25;
			this.dataGridViewArtikel.Size = new System.Drawing.Size(786, 211);
			this.dataGridViewArtikel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblEdit);
			this.panel1.Controls.Add(this.lblNEW);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.cmbLager);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.textBoxDescription);
			this.panel1.Controls.Add(this.textBoxName);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(139, 277);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(777, 486);
			this.panel1.TabIndex = 34;
			// 
			// lblEdit
			// 
			this.lblEdit.AutoSize = true;
			this.lblEdit.Location = new System.Drawing.Point(99, 21);
			this.lblEdit.Name = "lblEdit";
			this.lblEdit.Size = new System.Drawing.Size(30, 15);
			this.lblEdit.TabIndex = 49;
			this.lblEdit.Text = "EDIT";
			// 
			// lblNEW
			// 
			this.lblNEW.AutoSize = true;
			this.lblNEW.Location = new System.Drawing.Point(49, 21);
			this.lblNEW.Name = "lblNEW";
			this.lblNEW.Size = new System.Drawing.Size(33, 15);
			this.lblNEW.TabIndex = 48;
			this.lblNEW.Text = "NEW";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.nPrice);
			this.panel2.Location = new System.Drawing.Point(389, 145);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(237, 180);
			this.panel2.TabIndex = 47;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 28;
			this.label4.Text = "Price: ";
			// 
			// nPrice
			// 
			this.nPrice.Location = new System.Drawing.Point(131, 11);
			this.nPrice.Name = "nPrice";
			this.nPrice.Size = new System.Drawing.Size(56, 23);
			this.nPrice.TabIndex = 30;
			// 
			// cmbLager
			// 
			this.cmbLager.FormattingEnabled = true;
			this.cmbLager.Location = new System.Drawing.Point(116, 145);
			this.cmbLager.Name = "cmbLager";
			this.cmbLager.Size = new System.Drawing.Size(121, 23);
			this.cmbLager.TabIndex = 45;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(646, 335);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(90, 30);
			this.btnSave.TabIndex = 32;
			this.btnSave.Text = "OK";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 148);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 15);
			this.label10.TabIndex = 44;
			this.label10.Text = "Warenhouse";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(1, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 15);
			this.label9.TabIndex = 42;
			this.label9.Text = "Datum: ";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(82, 55);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
			this.dateTimePicker1.TabIndex = 41;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(501, 81);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(235, 23);
			this.textBoxDescription.TabIndex = 40;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(501, 52);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(235, 23);
			this.textBoxName.TabIndex = 39;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(389, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 15);
			this.label3.TabIndex = 38;
			this.label3.Text = "Description: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(389, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 15);
			this.label2.TabIndex = 37;
			this.label2.Text = "Name:";
			// 
			// ArticleManagementControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelMain);
			this.Name = "ArticleManagementControl";
			this.Size = new System.Drawing.Size(1326, 823);
			this.panelMain.ResumeLayout(false);
			this.pnlDTArticles.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikel)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panelMain;
		private Button btnSave;
		private Panel panel1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown nPrice;
		private Label label5;
		private Label label4;
		private ComboBox lagerComboBox;
		private Label label10;
		private Label label9;
		private DateTimePicker dateTimePicker1;
		private TextBox textBoxDescription;
		private TextBox textBoxName;
		private Label label3;
		private Label label2;
		private Panel panel2;
		private Panel pnlDTArticles;
		private DataGridView dataGridViewArtikel;
		private Button btnDeleteArticle;
		private Button btnNewArticle;
		private ComboBox cmbLager;
		private NumericUpDown nStock;
		private Label lblNEW;
		private Label lblEdit;
	}
}
