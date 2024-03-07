﻿// <auto-generated />
using System;
using FoodSystemAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodSystemAPI.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20240307122000_add-user-points")]
    partial class adduserpoints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodSystemAPI.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.HasKey("CategoryId");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ingredient_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<double>("CalciumMg")
                        .HasColumnType("float")
                        .HasColumnName("calcium_mg");

                    b.Property<double>("CarbG")
                        .HasColumnType("float")
                        .HasColumnName("carb_g");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<double>("CopperMcg")
                        .HasColumnType("float")
                        .HasColumnName("copper_mcg");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("description");

                    b.Property<int>("EnergyKcal")
                        .HasColumnType("int")
                        .HasColumnName("energy_kcal");

                    b.Property<double>("FatG")
                        .HasColumnType("float")
                        .HasColumnName("fat_g");

                    b.Property<double>("FiberG")
                        .HasColumnType("float")
                        .HasColumnName("fiber_g");

                    b.Property<double>("FolateMcg")
                        .HasColumnType("float")
                        .HasColumnName("folate_mcg");

                    b.Property<double>("IronMg")
                        .HasColumnType("float")
                        .HasColumnName("iron_mg");

                    b.Property<double>("MagnesiumMg")
                        .HasColumnType("float")
                        .HasColumnName("magnesium_mg");

                    b.Property<double>("ManganeseMg")
                        .HasColumnType("float")
                        .HasColumnName("manganese_mg");

                    b.Property<double>("NiacinMg")
                        .HasColumnType("float")
                        .HasColumnName("niacin_mg");

                    b.Property<double>("PotassiumMg")
                        .HasColumnType("float")
                        .HasColumnName("potassium_mg");

                    b.Property<double>("ProteinG")
                        .HasColumnType("float")
                        .HasColumnName("protein_g");

                    b.Property<double>("RiboflavinMg")
                        .HasColumnType("float")
                        .HasColumnName("riboflavin_mg");

                    b.Property<double>("SaturatedFatsG")
                        .HasColumnType("float")
                        .HasColumnName("saturated_fats_g");

                    b.Property<double>("SeleniumMcg")
                        .HasColumnType("float")
                        .HasColumnName("selenium_mcg");

                    b.Property<double>("SodiumMg")
                        .HasColumnType("float")
                        .HasColumnName("sodium_mg");

                    b.Property<double>("SugarG")
                        .HasColumnType("float")
                        .HasColumnName("sugar_g");

                    b.Property<double>("ThiaminMg")
                        .HasColumnType("float")
                        .HasColumnName("thiamin_mg");

                    b.Property<double>("VitaMcg")
                        .HasColumnType("float")
                        .HasColumnName("vita_mcg");

                    b.Property<double>("Vitb12Mcg")
                        .HasColumnType("float")
                        .HasColumnName("vitb12_mcg");

                    b.Property<double>("Vitb6Mg")
                        .HasColumnType("float")
                        .HasColumnName("vitb6_mg");

                    b.Property<double>("VitcMg")
                        .HasColumnType("float")
                        .HasColumnName("vitc_mg");

                    b.Property<double>("Vitd2Mcg")
                        .HasColumnType("float")
                        .HasColumnName("vitd2_mcg");

                    b.Property<double>("ViteMg")
                        .HasColumnType("float")
                        .HasColumnName("vite_mg");

                    b.Property<double>("ZincMg")
                        .HasColumnType("float")
                        .HasColumnName("zinc_mg");

                    b.HasKey("IngredientId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ingredient", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.MealPlan", b =>
                {
                    b.Property<int>("MealPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("meal_plan_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealPlanId"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_date");

                    b.Property<int>("TotalCalories")
                        .HasColumnType("int")
                        .HasColumnName("total_calories");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("MealPlanId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("meal_plan", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.MealPlanItem", b =>
                {
                    b.Property<int>("MealPlanItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("meal_plan_item_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealPlanItemId"));

                    b.Property<int>("MealPlanId")
                        .HasColumnType("int")
                        .HasColumnName("meal_plan_id");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.HasKey("MealPlanItemId");

                    b.HasIndex("MealPlanId");

                    b.HasIndex("RecipeId")
                        .IsUnique();

                    b.ToTable("meal_plan_item", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<int>("Calories")
                        .HasColumnType("int")
                        .HasColumnName("calories");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("image_url");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4000)")
                        .HasColumnName("instructions");

                    b.Property<int>("Servings")
                        .HasColumnType("int")
                        .HasColumnName("servings");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("recipe", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("binary(64)")
                        .HasColumnName("password_hash")
                        .IsFixedLength();

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "Username" }, "IX_user")
                        .IsUnique();

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.UserMetrics", b =>
                {
                    b.Property<int>("UserMetricsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_metrics_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserMetricsId"));

                    b.Property<int>("ActivityLevel")
                        .HasColumnType("int")
                        .HasColumnName("activity_level");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<int>("Height")
                        .HasColumnType("int")
                        .HasColumnName("height");

                    b.Property<int>("Sex")
                        .HasColumnType("int")
                        .HasColumnName("sex");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("Weight")
                        .HasColumnType("int")
                        .HasColumnName("weight");

                    b.HasKey("UserMetricsId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("user_metrics", (string)null);
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.UserPoints", b =>
                {
                    b.Property<int>("UserPointsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_points_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPointsId"));

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("points");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("UserPointsId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("user_points", (string)null);
                });

            modelBuilder.Entity("RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("RecipeIngredient");
                });

            modelBuilder.Entity("UserIngredient", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("UserIngredient");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.Ingredient", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.Category", "Category")
                        .WithMany("Ingredients")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_ingredient_category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.MealPlan", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.User", "User")
                        .WithOne("MealPlan")
                        .HasForeignKey("FoodSystemAPI.Entities.MealPlan", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK_meal_plan_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.MealPlanItem", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.MealPlan", "MealPlan")
                        .WithMany("MealPlanItems")
                        .HasForeignKey("MealPlanId")
                        .IsRequired()
                        .HasConstraintName("FK_meal_plan_item_meal_plan");

                    b.HasOne("FoodSystemAPI.Entities.Recipe", "Recipe")
                        .WithOne("MealPlanItem")
                        .HasForeignKey("FoodSystemAPI.Entities.MealPlanItem", "RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_meal_plan_item_recipe");

                    b.Navigation("MealPlan");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.Recipe", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_recipe_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.UserMetrics", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.User", "User")
                        .WithOne("UserMetrics")
                        .HasForeignKey("FoodSystemAPI.Entities.UserMetrics", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK_user_metrics_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.UserPoints", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.User", "User")
                        .WithOne("UserPoints")
                        .HasForeignKey("FoodSystemAPI.Entities.UserPoints", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK_user_points_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecipeIngredient", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodSystemAPI.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserIngredient", b =>
                {
                    b.HasOne("FoodSystemAPI.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodSystemAPI.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.Category", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.MealPlan", b =>
                {
                    b.Navigation("MealPlanItems");
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.Recipe", b =>
                {
                    b.Navigation("MealPlanItem")
                        .IsRequired();
                });

            modelBuilder.Entity("FoodSystemAPI.Entities.User", b =>
                {
                    b.Navigation("MealPlan")
                        .IsRequired();

                    b.Navigation("Recipes");

                    b.Navigation("UserMetrics")
                        .IsRequired();

                    b.Navigation("UserPoints")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
