using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Lagerverwaltung { 
	public class Article
	{


			public int? id { get; set; }
			public string name { get; set; }
			public string description { get; set; }
			public string form { get; set; }
			public int? price { get; set; }
			public DateTime? createdAt { get; set; }

		  public int? storageLocationId { get; set; }
	}
}

