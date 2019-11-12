using System;
using System.Runtime.InteropServices.ComTypes;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            restaurantsContext db = new restaurantsContext();
            
            Views.ViewMenu(db, "hejvej");
            Views.ViewRestaurantsByType(db, "Fiskerestaurant");
            Views.ViewDishReviews(db, "hejvej");
        }
    }
}