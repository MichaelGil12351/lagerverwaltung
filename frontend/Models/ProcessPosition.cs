using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
	public class ProcessPosition
	{
		//public int? id { get; set; }
		public int articleId { get; set; }
		public int? sourceLocationId { get; set; }  // null 
		public int targetLocationId { get; set; }
		public int quantity { get; set; }
		public DateTime? timestamp { get; set; }

	}
}