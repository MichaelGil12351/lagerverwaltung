using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
	public class Movement
	{
		 
      public int id { get; set; }
		public int quantity { get; set; }
		public List<ProcessPosition> processes { get; set; }

		//public User user { get; set; }
	}
}

