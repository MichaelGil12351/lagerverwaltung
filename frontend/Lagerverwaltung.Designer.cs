namespace Lagerverwaltung
{
	partial class Lagerverwaltung
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lagerverwaltung));
			this.LVmenuMain = new System.Windows.Forms.ListView();
			this.panelContent = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// LVmenuMain
			// 
			this.LVmenuMain.Location = new System.Drawing.Point(-1, 0);
			this.LVmenuMain.Name = "LVmenuMain";
			this.LVmenuMain.Size = new System.Drawing.Size(208, 767);
			this.LVmenuMain.TabIndex = 7;
			this.LVmenuMain.UseCompatibleStateImageBehavior = false;
			this.LVmenuMain.View = System.Windows.Forms.View.SmallIcon;
			this.LVmenuMain.SelectedIndexChanged += new System.EventHandler(this.changeUC);
			// 
			// panelContent
			// 
			this.panelContent.AutoSize = true;
			this.panelContent.BackColor = System.Drawing.Color.Transparent;
			this.panelContent.Location = new System.Drawing.Point(213, 3);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(953, 764);
			this.panelContent.TabIndex = 1;
			// 
			// Lagerverwaltung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1164, 768);
			this.Controls.Add(this.LVmenuMain);
			this.Controls.Add(this.panelContent);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Lagerverwaltung";
			this.Text = "LagerverwaltungForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Panel panelContent;
		private ListView LVmenuMain;
	}
}