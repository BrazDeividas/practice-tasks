﻿using System;
using System.Collections.Generic;

namespace FoodSystemAPI.Entities;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
