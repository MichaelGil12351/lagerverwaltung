using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lagerverwaltung.Services
{
	public static class ApiClient
	{
		private static readonly HttpClient client = new HttpClient
		{
			BaseAddress = new Uri("http://localhost:8081")
		};

		public static async Task<T> GetAsync<T>(string endpoint)
		{
			var response = await client.GetAsync(endpoint);
			response.EnsureSuccessStatusCode();
			string json = await response.Content.ReadAsStringAsync();
			return JsonSerializer.Deserialize<T>(json);
		}

		public static async Task<HttpResponseMessage> PostAsync<T>(string endpoint, T data)
		{
			var options = new JsonSerializerOptions
			{
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			};
			string json = JsonSerializer.Serialize(data, options);
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			return await client.PostAsync(endpoint, content);
		}

		public static async Task<HttpResponseMessage> PutAsync<T>(string endpoint, T data)
		{
			string json = JsonSerializer.Serialize(data);
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			return await client.PutAsync(endpoint, content);
		}

		public static async Task<HttpResponseMessage> DeleteAsync(string endpoint)
		{
			return await client.DeleteAsync(endpoint);
		}
	}
}
