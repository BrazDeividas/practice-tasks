using System.Diagnostics;
using FoodSystemClient.DTOs;
using FoodSystemClient.Models;
using FoodSystemClient.Wrappers;

namespace FoodSystemClient.Services;

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;

    public UserService(IHttpClientFactory clientFactory)
    {
        _httpClient = clientFactory.CreateClient("FoodSystemAPI");
    }

    public async Task<UserMetrics> GetUserMetrics(int userId)
    {
        var response = await _httpClient.GetFromJsonAsync<Response<UserMetrics>>($"api/User/metrics/{userId}");
        
        if (response.Data == null)
        {
            return null;
        }
        
        return response.Data;
    }

    public async Task<int> PostUserMetrics(UserMetrics userMetrics, int userId)
    {
        var userMetricsDto = new PostUserMetricsDto
        {
            UserId = userId,
            Age = userMetrics.Age,
            Height = userMetrics.Height,
            Weight = userMetrics.Weight,
            Sex = userMetrics.Sex.ToString(),
            ActivityLevel = userMetrics.ActivityLevel.ToString()
        };

        var response = await _httpClient.PostAsJsonAsync("api/User/metrics", userMetricsDto);

        return (int)response.StatusCode;
    }
}