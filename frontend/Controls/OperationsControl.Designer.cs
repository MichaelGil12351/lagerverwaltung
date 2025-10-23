namespace Lagerverwaltung.UC
{
	partial class OperationsControl
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtgMovements = new System.Windows.Forms.DataGridView();
			this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.numStock = new System.Windows.Forms.NumericUpDown();
			this.cmbToWarehouse = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbFromWarehouse = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtArticle = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgMovements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtArticle);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dtgMovements);
			this.panel1.Controls.Add(this.dateTimeBox);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.numStock);
			this.panel1.Controls.Add(this.cmbToWarehouse);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.cmbFromWarehouse);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(966, 624);
			this.panel1.TabIndex = 25;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(17, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 15);
			this.label10.TabIndex = 45;
			this.label10.Text = "Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(-129, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 15);
			this.label7.TabIndex = 44;
			this.label7.Text = "Processes";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 403);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 15);
			this.label1.TabIndex = 43;
			this.label1.Text = "Relocation";
			// 
			// dtgMovements
			// 
			this.dtgMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgMovements.Location = new System.Drawing.Point(17, 100);
			this.dtgMovements.Name = "dtgMovements";
			this.dtgMovements.RowTemplate.Height = 25;
			this.dtgMovements.Size = new System.Drawing.Size(867, 266);
			this.dtgMovements.TabIndex = 42;
			// 
			// dateTimeBox
			// 
			this.dateTimeBox.Location = new System.Drawing.Point(17, 60);
			this.dateTimeBox.Name = "dateTimeBox";
			this.dateTimeBox.Size = new System.Drawing.Size(200, 23);
			this.dateTimeBox.TabIndex = 40;
			this.dateTimeBox.ValueChanged += new System.EventHandler(this.dateTimePickerWarehouse_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(-129, 193);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 15);
			this.label9.TabIndex = 39;
			this.label9.Text = "Article: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(-129, 163);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 15);
			this.label8.TabIndex = 38;
			this.label8.Text = "Date: ";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(-120, 300);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 37;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(-120, 245);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 36;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(36, 574);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 34;
			this.button1.Text = "Change";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// numStock
			// 
			this.numStock.Location = new System.Drawing.Point(167, 536);
			this.numStock.Name = "numStock";
			this.numStock.Size = new System.Drawing.Size(120, 23);
			this.numStock.TabIndex = 33;
			// 
			// cmbToWarehouse
			// 
			this.cmbToWarehouse.FormattingEnabled = true;
			this.cmbToWarehouse.Location = new System.Drawing.Point(349, 507);
			this.cmbToWarehouse.Name = "cmbToWarehouse";
			this.cmbToWarehouse.Size = new System.Drawing.Size(121, 23);
			this.cmbToWarehouse.TabIndex = 32;
			// 
			// label6
			// 
			this.label6.AllowDrop = true;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(296, 515);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 15);
			this.label6.TabIndex = 31;
			this.label6.Text = "To";
			// 
			// cmbFromWarehouse
			// 
			this.cmbFromWarehouse.FormattingEnabled = true;
			this.cmbFromWarehouse.Location = new System.Drawing.Point(167, 506);
			this.cmbFromWarehouse.Name = "cmbFromWarehouse";
			this.cmbFromWarehouse.Size = new System.Drawing.Size(100, 23);
			this.cmbFromWarehouse.TabIndex = 30;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(167, 438);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
			this.dateTimePicker1.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 536);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 15);
			this.label5.TabIndex = 28;
			this.label5.Text = "Quantity: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 444);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 27;
			this.label4.Text = "Date: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 506);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 15);
			this.label3.TabIndex = 26;
			this.label3.Text = "From: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 476);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 15);
			this.label2.TabIndex = 25;
			this.label2.Text = "Article: ";
			// 
			// txtArticle
			// 
			this.txtArticle.Location = new System.Drawing.Point(167, 473);
			this.txtArticle.Name = "txtArticle";
			this.txtArticle.Size = new System.Drawing.Size(200, 23);
			this.txtArticle.TabIndex = 46;
			// 
			// OperationsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "OperationsControl";
			this.Size = new System.Drawing.Size(920, 627);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgMovements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label label7;
		private Label label1;
		private DataGridView dtgMovements;
		private DateTimePicker dateTimePicker2;
		private Label label9;
		private Label label8;
		private Button button4;
		private Button button3;
		private Button button2;
		private Button button1;
		private NumericUpDown numStock;
		private ComboBox cmbToWarehouse;
		private Label label6;
		private ComboBox cmbFromWarehouse;
		private DateTimePicker dateTimePicker1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label10;
		private DateTimePicker dateTimeBox;
		private TextBox txtArticle;
	}
}
