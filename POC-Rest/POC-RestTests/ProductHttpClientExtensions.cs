using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace POC_RestTests
{
    static class ProductExtensions
    {
        internal static async Task<HttpResponseMessage> GetProducts(this HttpClient client)
        {
            var products = await client.GetAsync(new Uri("api/product", UriKind.Relative));
            products.EnsureSuccessStatusCode();
            return products;
        }
    }
}
