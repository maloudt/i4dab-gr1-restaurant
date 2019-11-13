using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

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
            }
        }

        public static void AddDish(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException e)
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
        }

        public static void AddTable(restaurantsContext db)
        {
            string addr = Utilities.ReqAddr();
            try
            {
                var restaurant = db.Restaurant.Where(p => p.AddressRes.Equals(addr));
            }
            catch (ArgumentNullException e)
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
        }
    }
}
