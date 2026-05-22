using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace RentaBike.Api.BddTests;

public class SaludarEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public SaludarEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Given_the_API_is_running_When_requesting_saludar_Then_it_returns_a_greeting()
    {
        var response = await _client.GetAsync("/saludar");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("Hola desde RentaBike", await response.Content.ReadAsStringAsync());
    }
}
