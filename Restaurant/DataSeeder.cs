using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    static class DataSeeder
    {
        public static void SeedData()
        {
            restaurantsContext db = new restaurantsContext();

            //************INSERT RESTAURANTS***********
            var restaurant = db.Restaurant;
            Restaurant kaspers = new Restaurant()
            {
                AddressRes = "Lillegade",
                NameRes = "Kaspers Bofhus",
                Type = "Bofhus"
            };
            db.Add(kaspers);

            Restaurant jensens = new Restaurant()
            {
                AddressRes = "Rosenkrantzgade",
                NameRes = "Jensens Bofhus",
                Type = "Bofhus"
            };
            db.Add(jensens);

            Restaurant fiskens = new Restaurant()
            {
                AddressRes = "Fiskehusvej",
                NameRes = "Thanks For All the Fisk",
                Type = "Fisk"
            };
            db.Add(fiskens);


            //************INSERT DISHES*****************
            var dish = db.Dish;

            // Lillegade *******************************
            Dish bof = new Dish()
            {
                DishName = "Bof",
                DishDescription = "Den lækreste bof i huset",
                Price = 199,
                Category = "Bof",
                AddressRes = "Lillegade"
            };
            db.Add(bof);

            Dish megabof = new Dish()
            {
                DishName = "MEGA Bof",
                DishDescription = "Den lækreste MEGA bof i huset",
                Price = 259,
                Category = "Bof",
                AddressRes = "Lillegade"
            };
            db.Add(megabof);

            Dish minibof = new Dish()
            {
                DishName = "mini Bof",
                DishDescription = "Den lækreste mini bof i huset",
                Price = 129,
                Category = "Bof",
                AddressRes = "Lillegade"
            };
            db.Add(minibof);

            // Rosenkrantzgade *************************
            Dish salatbar = new Dish()
            {
                DishName = "Salatbar",
                DishDescription = "Tag selv salatbar - all you can eat",
                Price = 49,
                Category = "Salat",
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(salatbar);

            Dish nachos = new Dish()
            {
                DishName = "Nachos",
                DishDescription = "Sprode tortillachips med ched ­dar og jalapeños. Serveres med guacamole, salsa og creme fraiche",
                Price = 69,
                Category = "Frokost",
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(nachos);

            Dish hakkebof = new Dish()
            {
                DishName = "Herregårds-hakkebof",
                DishDescription = "Hakkebof serveres med lune ærter, tykke fries og Jensens Bearnaisesauce",
                Price = 79,
                Category = "Frokost",
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(hakkebof);

            // Fiskehusvej *****************************
            Dish rogn = new Dish()
            {
                DishName = "Stenbiderrogn",
                DishDescription = "Yummmm lidt æg til vinen",
                Price = 110,
                Category = "Fisk",
                AddressRes = "Fiskehusvej"
            };
            db.Add(rogn);

            Dish deller = new Dish()
            {
                DishName = "Fiskefrikadeller",
                DishDescription = "Dejlig saftige fiskefrikedeller af den bedste torsk fra Gudenåen",
                Price = 150,
                Category = "Fisk",
                AddressRes = "Fiskehusvej"
            };
            db.Add(deller);

            //************INSERT TABLES****************
            var table = db.TableRes;

            // Lillegade *******************************
            var bord1 = new TableRes()
            {
                TableNumber = 1,
                Chairs = 2,
                AddressRes = "Lillegade"
            };
            db.Add(bord1);

            var bord2 = new TableRes()
            {
                TableNumber = 2,
                Chairs = 4,
                AddressRes = "Lillegade"
            };
            db.Add(bord2);

            var bord3 = new TableRes()
            {
                TableNumber = 3,
                Chairs = 4,
                AddressRes = "Lillegade"
            };
            db.Add(bord3);

            // Rosenkrantzgade *************************
            var bord4 = new TableRes()
            {
                TableNumber = 4,
                Chairs = 4,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(bord4);

            var bord5 = new TableRes()
            {
                TableNumber = 5,
                Chairs = 4,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(bord5);

            // Fiskehusvej *****************************
            var bord6 = new TableRes()
            {
                TableNumber = 6,
                Chairs = 6,
                AddressRes = "Fiskehusvej"
            };
            db.Add(bord6);

            var bord7 = new TableRes()
            {
                TableNumber = 7,
                Chairs = 2,
                AddressRes = "Fiskehusvej"
            };
            db.Add(bord7);

            var bord8 = new TableRes()
            {
                TableNumber = 8,
                Chairs = 4,
                AddressRes = "Fiskehusvej"
            };
            db.Add(bord8);

            //************INSERT WAITERS**************

            var waiter = db.Waiter;
            var tjener1 = new Waiter()
            {
                Salary = 120000,
                AddressRes = "Lillegade"
            };
            db.Add(tjener1);

            var tjener2 = new Waiter()
            {
                Salary = 12000,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(tjener2);

            var tjener3 = new Waiter()
            {
                Salary = 20000,
                AddressRes = "Fiskehusvej"
            };
            db.Add(tjener3);

            //************INSERT GUESTS
            var guest = db.Guest;

            // Lillegade *******************************
            var gaest1 = new Guest()
            {
                NameBooker = "Carsten",
                TableNumber = 1,
                PartySize = 2,
                Time = new DateTime(2019, 11, 10, 18, 00, 00),
                AddressRes = "Lillegade"
            };
            db.Add(gaest1);

            var gaest2 = new Guest()
            {
                NameBooker = "Lillian",
                TableNumber = 2,
                PartySize = 4,
                Time = new DateTime(2019, 11, 10, 19, 30, 00),
                AddressRes = "Lillegade"
            };
            db.Add(gaest2);

            // Rosenkrantzgade *************************
            var gaest3 = new Guest()
            {
                NameBooker = "Suzanne",
                TableNumber = 4,
                PartySize = 3,
                Time = new DateTime(2019, 11, 11, 12, 30, 00),
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(gaest3);

            var gaest4 = new Guest()
            {
                NameBooker = "Allan",
                TableNumber = 5,
                PartySize = 4,
                Time = new DateTime(2019, 11, 14, 14, 15, 00),
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(gaest4);

            // Fiskehusvej *****************************
            var gaest5 = new Guest()
            {
                NameBooker = "Niklas",
                TableNumber = 7,
                PartySize = 1,
                Time = new DateTime(2019, 12, 24, 12, 00, 00),
                AddressRes = "Fiskehusvej"
            };
            db.Add(gaest5);

            //************INSERT REVIEWS**************
            var review = db.Review;

            // Lillegade *******************************
            // Rosenkrantzgade *************************
            // Fiskehusvej *****************************

            var anmeldelse1 = new Review()
            {
                DishId = 1,
                ReviewerName = "Carsten",
                Stars = 5,
                ReviewText = "Super god bof!",
                Time = new DateTime(2019, 11, 10, 18, 00, 00),
                AddressRes = "Lillegade"
            };
            db.Add(anmeldelse1);

            var anmeldelse2 = new Review()
            {
                DishId = 1,
                ReviewerName = "Frederik",
                Stars = 3,
                ReviewText = "Kunne vaere bedre",
                Time = new DateTime(2019, 09, 16, 18, 00, 00),
                AddressRes = "Lillegade"
            };
            db.Add(anmeldelse2);



            db.SaveChanges();
        }
    }
}
