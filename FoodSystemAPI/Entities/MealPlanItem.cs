namespace FoodSystemAPI.Entities;

public class MealPlanItem
{
    public int MealPlanItemId { get; set; }

    public int MealPlanId { get; set; }
    
    public int RecipeId { get; set; }

    public virtual MealPlan MealPlan { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}