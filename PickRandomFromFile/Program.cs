using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randommovie;

            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randommovie = GetRandomFromFile("movies.txt");




            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randommovie} ");

            
            



        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string filename)
        {
            string filePath = $@"C:\Users\...\samples\{filename}";
            string [] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;



        }
    }
}
