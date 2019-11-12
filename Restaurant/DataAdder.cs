using System;
using System.Collections.Generic;
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
    }
}
