using System.Net.Http.Json;

namespace TestVersioning;

public class UnitTest : IClassFixture<ApplicationFactory<Program>>
{
    private readonly HttpClient _httpClient;
    public UnitTest(ApplicationFactory<Program> factory)
    {
        _httpClient = factory.CreateClient();
    }
    [Fact]
    public async void Test1()
    {
        var response = await _httpClient.GetAsync("/api/v1/WeatherForecast");
        var result = await response.Content.ReadFromJsonAsync<IEnumerable<VersioningInAspNetCore.ResponseModel.V1.WeatherForecast>>();
        Assert.NotNull(result);
    }

    [Fact]
    public async void Test2()
    {
        var response = await _httpClient.GetAsync("/api/v2/WeatherForecast");
        var result = await response.Content.ReadFromJsonAsync<IEnumerable<VersioningInAspNetCore.ResponseModel.V2.WeatherForecast>>();
        Assert.NotNull(result);
    }
}