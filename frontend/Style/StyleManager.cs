using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Style
{
	public static class StyleManager
	{
		public static void ApplyTheme(Control parent)
		{
			parent.BackColor = Color.FromArgb(208, 231, 234); 
			parent.Font = new Font("Segoe UI", 10);

			foreach (Control ctrl in parent.Controls)
			{
				if (ctrl is Label label)
				{
					label.ForeColor = Color.FromArgb(50, 50, 50);
					label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
				}
				else if (ctrl is Button btn)
				{
					btn.BackColor = Color.FromArgb(150, 190, 200);
					btn.ForeColor = Color.White;
					btn.FlatStyle = FlatStyle.Flat;
					btn.FlatAppearance.BorderSize = 0;
					btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
					btn.MouseEnter -= Button_MouseEnter;
					btn.MouseLeave -= Button_MouseLeave;

					btn.MouseEnter += Button_MouseEnter;
					btn.MouseLeave += Button_MouseLeave;
				}
				else if (ctrl is ComboBox combo)
				{
					combo.DropDownStyle = ComboBoxStyle.DropDownList;
					combo.BackColor = Color.White;
					combo.FlatStyle = FlatStyle.Flat;
				}
				else if (ctrl is DateTimePicker dtp)
				{
					dtp.CalendarForeColor = Color.Black;
					dtp.CalendarMonthBackground = Color.White;
				}
				

				if (ctrl.HasChildren)
					ApplyTheme(ctrl);


				
			}
			
		}
		private static void Button_MouseEnter(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				btn.BackColor = Color.FromArgb(130, 170, 180);
			}
		}

		private static void Button_MouseLeave(object sender, EventArgs e)
		{
			if (sender is Button btn)
			{
				btn.BackColor = Color.FromArgb(130, 170, 180);
			}
		}
	}
}
