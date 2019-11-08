using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Views
    {

        public static void ViewMenu(restaurantsContext context, string name)
        {
            List<Dish> dishList = context.Dish.Where(p => p.AddressRes.Equals(name)).ToList();

            foreach (var dish in dishList)
            {
                List<Review> reviewList = dish.Review.ToList();
                Console.WriteLine($"Dish: {dish.DishName}");
                Console.WriteLine($"Price: {dish.Price}");

                int totalRating = 0;
                foreach (var review in reviewList)
                {
                    totalRating += review.Stars;
                }

                int avgRating = totalRating / reviewList.Count();

                Console.WriteLine($"Average rating: {avgRating}");
            }
        }

        public static void ViewRestaurantsByType(restaurantsContext context, string type)
        {
            List<Restaurant> resList = context.Restaurant.Where(p => p.Type.Equals(type)).ToList();

            foreach (var restaurant in resList)
            {
                Console.WriteLine($"Name: {restaurant.NameRes}");

                List<Review> reviewList = restaurant.Review.ToList();

                int totalRating = 0;
                foreach (var review in reviewList)
                {
                    totalRating += review.Stars;
                }

                int avgRating = totalRating / reviewList.Count();

                Console.WriteLine($"Average rating: {avgRating}");

                for (int i = 0; i < 4; i++)
                {
                    if (reviewList[i] != null)
                    {
                        Console.WriteLine(reviewList[i].ReviewText);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
