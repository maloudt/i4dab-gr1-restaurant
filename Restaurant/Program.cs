using System;
using System.Runtime.InteropServices.ComTypes;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            restaurantsContext db = new restaurantsContext();

            ////************INSERT RESTAURANTS***********
            //var restaurant = db.Restaurant;
            //Restaurant kaspars = new Restaurant()
            //{
            //    AddressRes = "hejvej",
            //    NameRes = "Kaspars",
            //    Type = "Fiskerestaurant"
            //};
            //db.Add(kaspars);

            ////************INSERT DISHES*****************
            //var dish = db.Dish;
            //Dish stjerneskud = new Dish()
            //{
            //    DishName = "Stjerneskud",
            //    DishDescription = "Det lækreste stjerneskud nogensinde",
            //    Price = 145,
            //    Category = "Fisk",
            //    AddressRes = "hejvej"
            //};
            //db.Add(stjerneskud);

            ////************INSERT TABLES****************
            //var table = db.TableRes;
            //var bord = new TableRes()
            //{
            //    TableNumber = 1,
            //    Chairs = 2,
            //    AddressRes = "hejvej"
            //};
            //db.Add(bord);

            ////************INSERT WAITERS**************
            //var waiter = db.Waiter;
            //var tjener = new Waiter()
            //{
            //    Salary = 1000,
            //    AddressRes = "hejvej"
            //};
            //db.Add(tjener);

            ////************INSERT GUESTS***************
            //var guest = db.Guest;
            //var gaest1 = new Guest()
            //{
            //    NameBooker = "Carsten",
            //    TableNumber = 1,
            //    PartySize = 2,
            //    Time = new DateTime(2019,11,10,18,00,00),
            //    AddressRes = "hejvej"
            //};
            //db.Add(gaest1);

            ////************INSERT REVIEWS**************
            //var review = db.Review;
            //var anmeldelse1 = new Review()
            //{
            //    DishId = 1,
            //    ReviewerName = "Carsten",
            //    Stars = 5,
            //    ReviewText = "Super godt stjerneskud",
            //    Time = new DateTime(2019, 11, 10, 18, 00, 00),
            //    AddressRes = "hejvej"
            //};
            //db.Add(anmeldelse1);

            //db.SaveChanges();


            Views.ViewMenu(db, "hejvej");
            Views.ViewRestaurantsByType(db, "Fiskerestaurant");
        }
    }
}