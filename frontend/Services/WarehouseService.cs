
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lagerverwaltung.Services
{
	public  class WarehouseService
	{
		public static async Task<List<Warehouse>> GetAllLocationsAsync()
		{
			return await ApiClient.GetAsync<List<Warehouse>>("api/warehouse/all");
		}

		public static async Task<bool> RegisterMovementAsync(Movement movement)
		{
			var response = await ApiClient.PostAsync("movements", movement);
			return response.IsSuccessStatusCode;
		}
		public static async Task<bool> CreateAsync(Warehouse warehouse)
		{
			var response = await ApiClient.PostAsync("/api/warehouse", warehouse);
			return response.IsSuccessStatusCode;
		}



		public  async Task<List<Movement>> GetMovementsAsync()
		{
			return await ApiClient.GetAsync<List<Movement>>("movements");
		}
	

}
}
