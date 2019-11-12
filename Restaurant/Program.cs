using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            restaurantsContext db = new restaurantsContext();

            while (true)
            {
                Console.WriteLine("Welcome to the restaurants database!");
                Console.WriteLine("Please enter a command:");
                Console.WriteLine("Seed database: s");
                Console.WriteLine("View list of restaurants: 1");
                Console.WriteLine("View menu of restaurant: 2");
                Console.WriteLine("View restaurants by type: 3");
                Console.WriteLine("View dish reviews of restaurant: 4");

                ConsoleKeyInfo pressed = Console.ReadKey();
                Console.WriteLine("");
                switch (pressed.Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("Seeding database...");
                        break;
                    case ConsoleKey.D1:
                        Views.ViewAllRestaurants(db);
                        break;
                    case ConsoleKey.D2:
                        Views.ViewMenu(db, ReqAddr());
                        break;
                    case ConsoleKey.D3:
                        Views.ViewRestaurantsByType(db, ReqType());
                        break;
                    case ConsoleKey.D4:
                        Views.ViewDishReviews(db, ReqAddr());
                        break;
                    case ConsoleKey.D5:
                        DataAdder.AddRestaurant(db);
                        break;
                    default:
                        break;

                }

                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("");
            }

        }

        public static string ReqAddr()
        {
            Console.WriteLine("Please enter restaurant address:");
            return Console.ReadLine();
        }

        public static string ReqType()
        {
            Console.WriteLine("Please enter restaurant type:");
            return Console.ReadLine();
        }
    }
}