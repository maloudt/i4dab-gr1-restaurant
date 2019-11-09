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

                if (reviewList.Count() != 0)
                {
                    int totalRating = 0;
                    foreach (var review in reviewList)
                    {
                        totalRating += review.Stars;
                    }

                    int avgRating = totalRating / reviewList.Count();

                    Console.WriteLine($"Average rating: {avgRating}");
                }
                else
                {
                    Console.WriteLine("Currently no reviews for this dish");
                }
                Console.WriteLine();
            }
        }

        public static void ViewRestaurantsByType(restaurantsContext context, string type)
        {
            List<Restaurant> resList = context.Restaurant.Where(p => p.Type.Equals(type)).ToList();

            foreach (var restaurant in resList)
            {
                Console.WriteLine($"Name: {restaurant.NameRes}");

                List<Review> reviewList = restaurant.Review.ToList();

                if (reviewList.Count() != 0)
                {
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
                }
                else
                {
                    Console.WriteLine("Currently no reviews");
                }
                

                Console.WriteLine();
            }
        }
    }
}
