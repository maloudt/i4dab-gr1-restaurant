using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Views
    {

        public void ViewMenu(restaurantsContext context, Restaurant restaurant)
        {
            List<Dish> dishList = context.Dish.Where(p => p.AddressRes.Equals(restaurant.AddressRes)).ToList();

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
    }
}
