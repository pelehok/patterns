using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BuilderPatternDemo
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();

            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total cost: " + vegMeal.getCost());

            Meal nonvegMeal = mealBuilder.prepareNonVegMeal();

            Console.WriteLine("Veg Meal");
            nonvegMeal.showItems();
            Console.WriteLine("Total cost: " + nonvegMeal.getCost());

            Console.ReadKey();
        }
    }
}
