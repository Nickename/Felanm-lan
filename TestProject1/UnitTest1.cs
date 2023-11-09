using ErrorReport.Data;
using ErrorReport;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Get()
        {
            //Arrange
            var webApplicationFactory = new WebApplicationFactory<ErrorReport.Program>();
            var httpClient = webApplicationFactory.CreateDefaultClient();

            //Act
            var response = await httpClient.GetFromJsonAsync<IEnumerable<Report>>("https://localhost:7128/api/Report");

            //Assert
            Assert.Equal(2, response.Count());
        }
        [Fact]
        public async Task CreateTest()
        {
            //Arrange

            var webApplicationFactory = new WebApplicationFactory<ErrorReport.Program>();
            var httpClient = webApplicationFactory.CreateDefaultClient();

            var expected = await httpClient.GetFromJsonAsync<IEnumerable<Report>>("https://localhost:7128/api/Report");          
            var report = new Report() {Innehåll = "Innehållet", Rubrik = "Rubriken", Sammanfattning = "Sammanfattningen", Återskapande = ""};

            //Act
            await httpClient.PostAsJsonAsync($"https://localhost:7128/api/Report", report);
            var response = await httpClient.GetFromJsonAsync<IEnumerable<Report>>("https://localhost:7128/api/Report");

            //Assert
            Assert.Equal(expected.Count()+1, response.Count());
        }
        [Fact]
        public async Task DeleteTest()
        {
            //Arrange
            var webApplicationFactory = new WebApplicationFactory<ErrorReport.Program>();
            var httpClient = webApplicationFactory.CreateDefaultClient();
            var reportList = await httpClient.GetFromJsonAsync<IEnumerable<Report>>("https://localhost:7128/api/Report");

            //Act
            var response = await httpClient.DeleteAsync($"https://localhost:7128/api/Report/{reportList.FirstOrDefault().Id}");

            //Assert
            Assert.Equal("OK", response.StatusCode.ToString());
        }
    }
}