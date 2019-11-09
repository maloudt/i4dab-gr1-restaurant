using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            restaurantsContext database = new restaurantsContext();
            Views.ViewMenu(database, "Kaspars");
            Views.ViewRestaurantsByType(database, "Café");
        }
    }
}