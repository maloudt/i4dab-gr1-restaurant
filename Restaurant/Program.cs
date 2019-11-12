using System;
using System.Runtime.InteropServices.ComTypes;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            restaurantsContext db = new restaurantsContext();

            DataSeeder.SeedData();
            
            Views.ViewMenu(db, "Lillegade 134, 8000 Aarhus C");
            Views.ViewRestaurantsByType(db, "Bøfhus");
        }
    }
}