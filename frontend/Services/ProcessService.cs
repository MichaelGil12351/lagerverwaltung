using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Services
{
	internal class ProcessService
	{
		public static async Task<List<ProcessPosition>> GetAllAsync()
		{
			return await ApiClient.GetAsync<List<ProcessPosition>>("api/process/all");
		}

		public static async Task<ProcessPosition> GetByIdAsync(int id)
		{
			return await ApiClient.GetAsync<ProcessPosition>($"process/{id}");
		}

		public static async Task<bool> CreateAsync(ProcessPosition process)
		{
			var response = await ApiClient.PostAsync("/api/process", process);
			return response.IsSuccessStatusCode;
		}

		public static async Task<bool> UpdateAsync(int id, ProcessPosition article)
		{
			var response = await ApiClient.PutAsync($"process/{id}", article);
			return response.IsSuccessStatusCode;
		}

		public static async Task<bool> DeleteAsync(int id)
		{
			var response = await ApiClient.DeleteAsync($"process/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}
