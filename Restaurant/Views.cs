using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Views
    {

        public static void ViewMenu(restaurantsContext context, string address)
        {
            Console.WriteLine($"Viewing menu of {address}");
            foreach (var dish in context.Dish.Where(p => p.AddressRes.Equals(address)).ToList())
            {
                Console.WriteLine($"Dish: {dish.DishName}");

                Console.WriteLine($"Price: {dish.Price}");

                List<Review> reviewList = context.Review.Where(p => p.DishId.Equals(dish.DishId)).ToList();
                if (reviewList.Any())
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
            Console.WriteLine($"Viewing all restaurants of type {type}");

            foreach (var restaurant in context.Restaurant.Where(p => p.Type.Equals(type)).ToList())
            {
                Console.WriteLine($"Name: {restaurant.NameRes}");

                List<Review> reviewList = context.Review
                    .Where(p=>p.AddressRes.Equals(restaurant.AddressRes))
                    .ToList();

                if (reviewList.Any())
                {
                    int totalRating = 0;
                    foreach (var review in reviewList)
                    {
                        totalRating += review.Stars;
                    }

                    int avgRating = totalRating / reviewList.Count();

                    Console.WriteLine($"Average rating: {avgRating}");

                    for (int i = 0; i < 4 && i < reviewList.Count(); i++)
                    {
                        Console.WriteLine(reviewList[i].ReviewText);
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
