using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    static class Menu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Welcome to the restaurants database!");
            Console.WriteLine("Please enter a command:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("s | Seed database (add dummy data)");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 | View list of restaurants");
            Console.WriteLine("2 | View menu of specific restaurant");
            Console.WriteLine("3 | View restaurants by type");
            Console.WriteLine("4 | View list of reviews of specific dish (from a specific restaurant)");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("5 | Add new restaurant");
            Console.WriteLine("6 | Add new dish to restaurant");
            Console.WriteLine("7 | Add table to restaurant");
            Console.WriteLine("8 | Add waiter to restaurant");
            Console.WriteLine("9 | Add restaurant review");
            Console.WriteLine("0 | Add dish review");
            Console.WriteLine("g | Add guest to restaurant");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
        }
    }
}