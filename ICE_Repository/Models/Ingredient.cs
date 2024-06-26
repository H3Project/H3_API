﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientsId { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]public Category category { get; set; } = new Category();
        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe recipes { get; set; } = new Recipe();
        //[JsonIgnore] public List<RecipeIngredientJOIN> RecipeIngredientJOINs { get; set; } = new List<RecipeIngredientJOIN> { };
    }

    public class IngredientCategoryJOIN
    {
        [Key] public int IngredientCategoryJOINId { get; set; }

        public int IngredientId { get; set; }
        [JsonIgnore] public Ingredient ingredient { get; set; } = new Ingredient();

        public int CategoryId { get; set; }
        [JsonIgnore] public Category category { get; set; } = new Category();
    }
}
