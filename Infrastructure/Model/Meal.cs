using Infrastructure.Model;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MealItem> MealItems { get; set; }
    }
}
