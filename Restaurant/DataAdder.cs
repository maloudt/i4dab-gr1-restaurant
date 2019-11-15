using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Restaurant
{
    static class DataAdder
    {
        public static void AddRestaurant(restaurantsContext db)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Type:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();

            try
            {
                Restaurant newRestaurant = new Restaurant()
                {
                    AddressRes = address,
                    NameRes = name,
                    Type = type
                };
                db.Add(newRestaurant);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Restaurant already exists in database");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }

        public static void AddDish(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No restaurant exists with that address (address is case sensitive)");
            }

            Console.WriteLine("Enter name of dish:");
            string dishName = Console.ReadLine();
            Console.WriteLine("Enter dish description:");
            string dishDesc = Console.ReadLine();
            Console.WriteLine("Enter price of dish:");
            int dishPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter category of dish:");
            string dishCat = Console.ReadLine();
            Console.WriteLine("Adding dish...");

            try
            {
                Dish newDish = new Dish()
                {
                    DishName = dishName,
                    DishDescription = dishDesc,
                    Price = dishPrice,
                    Category = dishCat
                    };
                db.Add(newDish);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }

        public static void AddTable(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No restaurant exists with that address (address is case sensitive)");
            }

            Console.WriteLine("Enter table number:");
            int tableNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of chairs:");
            int chairNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adding table...");

            try
            {
                TableRes newTable = new TableRes()
                {
                    TableNumber = tableNo,
                    Chairs = chairNo,
                    AddressRes = addr
                };
                db.Add(newTable);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }

        public static void AddWaiter(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No restaurant exists with that address (address is case sensitive)");
            }

            Console.WriteLine("Enter assigned table number:");
            int tableNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adding dish...");

            try
            {
                Waiter newWaiter = new Waiter()
                {
                    TableNumber = tableNo,
                    Salary = salary,
                    AddressRes = addr
                };
                db.Add(newWaiter);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }

        public static void AddReview(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No restaurant exists with that address (address is case sensitive)");
            }

            Console.WriteLine("Enter reviewer name:");
            string revName = Console.ReadLine();
            Console.WriteLine("Enter amount of stars:");
            int stars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter review text:");
            string reviewText = Console.ReadLine();

            Console.WriteLine("Adding review...");

            try
            {
                Review newReview = new Review()
                {
                    ReviewerName = revName,
                    DishId = null,
                    Stars = stars,
                    ReviewText = reviewText,
                    Time = DateTime.Now,
                    AddressRes = addr
                };
                db.Add(newReview);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }

        public static void AddReviewDish(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No restaurant exists with that address (address is case sensitive)");
            }

            Console.WriteLine("Enter reviewer name:");
            string DishRevName = Console.ReadLine();
            Console.WriteLine("Enter dish id:");
            int dishID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount of stars:");
            int starsDish = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter review text:");
            string dishReviewText = Console.ReadLine();

            Console.WriteLine("Adding review...");

            try
            {
                Review newReview = new Review()
                {
                    DishId = dishID,
                    ReviewerName = dishReviewText,
                    Stars = starsDish,
                    ReviewText = dishReviewText,
                    Time = DateTime.Now,
                    AddressRes = addr
                };
                db.Add(newReview);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }


        public static void AddGuest(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No restaurant exists with that address (address is case sensitive)");
            }

            Console.WriteLine("Enter the name of the reservation booker:");
            string booker = Console.ReadLine();
            Console.WriteLine("Enter how many people are in the party:");
            int partySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time of the reservation (format 'yyyy-mm-dd hh:ss'):");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter assigned table number:");
            int tableNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adding reservation...");

            try
            {
                Guest newGuest = new Guest()
                {
                    NameBooker = booker,
                    TableNumber = tableNo,
                    PartySize = partySize,
                    Time = time,
                    AddressRes = addr
                };
                db.Add(newGuest);
                db.SaveChanges();
                Console.WriteLine("Added to database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------");
        }

    }
}
