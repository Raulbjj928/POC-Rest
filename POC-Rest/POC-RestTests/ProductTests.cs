using Xunit;

namespace POC_RestTests
{
    public class ProductTests
    {
        [Fact]
        public void Test1()
        {
            using var api = new SUTApi();
            var client = api.CreateClient();

            Assert.Equal(System.Net.HttpStatusCode.OK, client.GetProducts().GetAwaiter().GetResult().StatusCode);
        }
    }
}
