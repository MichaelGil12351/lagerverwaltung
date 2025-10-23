using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Services
{
	public  class ArticleService
	{
		public static async Task<List<Article>> GetAllAsync()
		{
			return await ApiClient.GetAsync<List<Article>>("api/article/all");
		}

		public static async Task<Article> GetByIdAsync(int id)
		{
			return await ApiClient.GetAsync<Article>($"articles/{id}");
		}

		public  static async Task<bool> CreateAsync(Article article)
		{
			var response = await ApiClient.PostAsync("/api/article", article);
			return response.IsSuccessStatusCode;
		}

		public static async Task<bool> UpdateAsync(int id, Article article)
		{
			var response = await ApiClient.PutAsync($"articles/{id}", article);
			return response.IsSuccessStatusCode;
		}

		public static async Task<bool> DeleteAsync(int id)
		{
			var response = await ApiClient.DeleteAsync($"articles/{id}");
			return response.IsSuccessStatusCode;
		}
	}
}
