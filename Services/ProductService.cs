using BlazorUltimaDjent.Models;
using System.Net.Http.Json;

namespace BlazorUltimaDjent.Services;

public class ProductService
{
    private readonly HttpClient _http;

    // Constructor injection — same as ASP.NET Core DI
    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _http.GetFromJsonAsync<List<Product>>("data/products.json")
               ?? new List<Product>();
    }
}