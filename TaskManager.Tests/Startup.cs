using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.AspNetCore.Mvc.Testing;


namespace TaskManager.Tests;

public class Startup : IClassFixture<WebApplicationFactory<Program>>
{
    private WebApplicationFactory<Program> clientFactory = new();
    readonly string taskEndpoint = "/task";
    [Fact]
    public async Task ThereShouldBeAGetAllTasksEndpoint()
    {
        //Arrange
        var client = clientFactory.CreateClient();//We need the app

        //act

        var result = await client.GetAsync(taskEndpoint);

        //Assert
        result.EnsureSuccessStatusCode();
    }

    [Fact]
    public async Task GetAllTasksEndpoint_ShouldReturnAnEmptyList()
    {
        //Arrange 
        var client = clientFactory.CreateClient();


        //Act
        var result = await client.GetFromJsonAsync<List<string>>(taskEndpoint);

        //Assert
        Assert.Equal([], result);
    }
}
