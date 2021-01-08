using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task RetrieveListClientes() 
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("https://sampleapiproject.azurewebsites.net/api/cliente/listclientes"))
                {
                    string apiResponse = await response.Result.Content.ReadAsStringAsync();
                    Assert.IsNotNull(apiResponse);
                }
            }
        }
    }
}