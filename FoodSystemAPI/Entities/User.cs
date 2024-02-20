﻿using System;
using System.Collections.Generic;

namespace FoodSystemAPI.Entities;

public class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public byte[] PasswordHash { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual UserMetrics UserMetrics { get; set; } = null!;

    public virtual MealPlan MealPlan { get; set; } = null!;
}
