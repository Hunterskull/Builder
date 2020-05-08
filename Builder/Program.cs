using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MealBuilder();

            var burgerMeal = builder.PrepareBurgerMeal();
            Console.WriteLine("BurgerMeal: ");
            burgerMeal.ShowItems();
            Console.WriteLine($"Costs: {burgerMeal.GetCosts().ToString("c")}");

            var chickenMeal = builder.PrepareChickenBurger();
            Console.WriteLine("ChickenMeal: ");
            chickenMeal.ShowItems();
            Console.WriteLine($"Costs: {chickenMeal.GetCosts().ToString("c")}");


            Console.ReadLine();
        }
    }
}
