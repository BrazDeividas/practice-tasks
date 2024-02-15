﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodSystemAPI.Entities;

public partial class FoodDbContext : DbContext
{
    public FoodDbContext()
    {
    }

    public FoodDbContext(DbContextOptions<FoodDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:SqlServer");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("category");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.ToTable("ingredient");

            entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");
            entity.Property(e => e.CalciumMg).HasColumnName("calcium_mg");
            entity.Property(e => e.CarbG).HasColumnName("carb_g");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CopperMcg).HasColumnName("copper_mcg");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EnergyKcal).HasColumnName("energy_kcal");
            entity.Property(e => e.FatG).HasColumnName("fat_g");
            entity.Property(e => e.FiberG).HasColumnName("fiber_g");
            entity.Property(e => e.FolateMcg).HasColumnName("folate_mcg");
            entity.Property(e => e.IronMg).HasColumnName("iron_mg");
            entity.Property(e => e.MagnesiumMg).HasColumnName("magnesium_mg");
            entity.Property(e => e.ManganeseMg).HasColumnName("manganese_mg");
            entity.Property(e => e.NiacinMg).HasColumnName("niacin_mg");
            entity.Property(e => e.PotassiumMg).HasColumnName("potassium_mg");
            entity.Property(e => e.ProteinG).HasColumnName("protein_g");
            entity.Property(e => e.RiboflavinMg).HasColumnName("riboflavin_mg");
            entity.Property(e => e.SaturatedFatsG).HasColumnName("saturated_fats_g");
            entity.Property(e => e.SeleniumMcg).HasColumnName("selenium_mcg");
            entity.Property(e => e.SodiumMg).HasColumnName("sodium_mg");
            entity.Property(e => e.SugarG).HasColumnName("sugar_g");
            entity.Property(e => e.ThiaminMg).HasColumnName("thiamin_mg");
            entity.Property(e => e.VitaMcg).HasColumnName("vita_mcg");
            entity.Property(e => e.Vitb12Mcg).HasColumnName("vitb12_mcg");
            entity.Property(e => e.Vitb6Mg).HasColumnName("vitb6_mg");
            entity.Property(e => e.VitcMg).HasColumnName("vitc_mg");
            entity.Property(e => e.Vitd2Mcg).HasColumnName("vitd2_mcg");
            entity.Property(e => e.ViteMg).HasColumnName("vite_mg");
            entity.Property(e => e.ZincMg).HasColumnName("zinc_mg");

            entity.HasOne(d => d.Category).WithMany(p => p.Ingredients)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ingredient_category");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.ToTable("recipe");

            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");
            entity.Property(e => e.CookingTime).HasColumnName("cooking_time");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PreparationTime).HasColumnName("preparation_time");
            entity.Property(e => e.Servings).HasColumnName("servings");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recipe_user");
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recipe_ingredient");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.AmountType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("amount_type");
            entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");
            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

            entity.HasOne(d => d.Ingredient).WithMany()
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recipe_ingredient_ingredient");

            entity.HasOne(d => d.Recipe).WithMany()
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_recipe_ingredient_recipe");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.HasIndex(e => e.Username, "IX_user").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("password_hash");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}