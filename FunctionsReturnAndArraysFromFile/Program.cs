using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();




        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");


        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coca cola", "fanta", "sprite", };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);


            string randomdrinks = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomdrinks}");
        }
        private static void DisplayRandomMovie()
        {
            string[] Movies = { "Die Hard", "Hobbit", "Home Alone", "Fast and Furious", };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Movies.Length);

            string randomMovies = Movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovies}");

        }
    }
}





