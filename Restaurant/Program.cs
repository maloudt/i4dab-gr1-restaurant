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
            Menu.PrintMenu();

            while (true)
            {
                Console.WriteLine("Press m for menu\n");

                ConsoleKeyInfo pressed = Console.ReadKey();
                Console.WriteLine("");
                switch (pressed.Key)
                {
                    case ConsoleKey.M:
                        Menu.PrintMenu();
                        break;
                    case ConsoleKey.S:
                        DataSeeder.SeedData();
                        Console.WriteLine("Seeding database...");
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Views.ViewAllRestaurants(db);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Views.ViewMenu(db, Utilities.ReqAddr());
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Views.ViewRestaurantsByType(db, Utilities.ReqType());
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Views.ViewDishReviews(db, Utilities.ReqAddr());
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        DataAdder.AddRestaurant(db);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        DataAdder.AddDish(db);
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        DataAdder.AddTable(db);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        DataAdder.AddWaiter(db);
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        DataAdder.AddReview(db);
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        DataAdder.AddReviewDish(db);
                        break;
                    case ConsoleKey.G:
                        DataAdder.AddGuest(db);
                        break;
                    default:
                        Console.WriteLine("Not implemented");
                        break;

                }

                Console.WriteLine("");
            }

        }

    }
}