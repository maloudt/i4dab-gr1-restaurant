﻿using System;
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
                Console.WriteLine("Add new restaurant: 5");
                Console.WriteLine("Add new dish to restaurant: 6");
                Console.WriteLine("Add table to restaurant: 7");
                Console.WriteLine("Add waiter to restaurant: 8");
                Console.WriteLine("Add review to restaurant or dish: 9");
                Console.WriteLine("Add guest to restaurant: 0");


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
                        Views.ViewMenu(db, Utilities.ReqAddr());
                        break;
                    case ConsoleKey.D3:
                        Views.ViewRestaurantsByType(db, Utilities.ReqType());
                        break;
                    case ConsoleKey.D4:
                        Views.ViewDishReviews(db, Utilities.ReqAddr());
                        break;
                    case ConsoleKey.D5:
                        DataAdder.AddRestaurant(db);
                        break;
                    case ConsoleKey.D6:
                        DataAdder.AddTable(db);
                        break;
                    case ConsoleKey.D7:
                        DataAdder.AddWaiter(db);
                        break;
                    case ConsoleKey.D8:
                        DataAdder.AddWaiter(db);
                        break;
                    default:
                        break;

                }

                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("");
            }

        }

    }
}