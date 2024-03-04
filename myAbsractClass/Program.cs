using System;
namespace SodaRating
{
    interface IDrink
    {
        //Properties
        public string Soda { get; set; }
        public int Rating { get; set; }
        public string DrinkAgain { get; set; }

    }
    class Program
    {
        class  Drink : IDrink
        {
            public string Soda { get; set; }
            public int Rating { get; set; }
            public string DrinkAgain{ get; set; }

            public Drink()
            {
                Soda = string.Empty;
                Rating = 0;
                DrinkAgain = string.Empty;
            }
            public Drink( string soda, int rating, string drinkagain)
            {
                Soda = soda;
                Rating = rating;
                DrinkAgain = drinkagain;
            }
            public string DisplayDrinkInfo()
            {
                return "Drink Name:" + Soda + "\n" + "Rating:" + Rating + "\n" + "Would you drink it again?:" + DrinkAgain;
            }
        }
        static void Main(string[] args)
        {
            


            Console.WriteLine("What is the drink name?");
            string soda = Console.ReadLine();

            Console.WriteLine("What do you rate the drink?");
            int rating = int.Parse( Console.ReadLine());

            Console.WriteLine("Would you drink this drink again?");
            string drinkagain = Console.ReadLine();

            Drink newdrink = new Drink(soda, rating, drinkagain);

            Console.WriteLine(newdrink.DisplayDrinkInfo());



            Drink drpepper = new Drink("Dr. Pepper", 10, "Yes");
            Console.WriteLine(drpepper.DisplayDrinkInfo());

        }
    }
}