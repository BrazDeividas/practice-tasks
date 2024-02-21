using FoodSystemAPI.DTOs;
using FoodSystemAPI.Entities;

namespace FoodSystemAPI.Services;

public interface IRecipeService
{
    Task<IEnumerable<ReceiveServerRecipeDto>> GetRecipesAsync(string searchQuery);
}