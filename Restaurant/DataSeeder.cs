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


            //************INSERT RESTAURANT REVIEWS**************
            var review = db.Review;

            // Lillegade *******************************
            var review1 = new Review()
            {
                DishId = null,
                ReviewerName = "Carsten",
                Stars = 5,
                ReviewText = "Fin estaurant",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(review1);

            var review2 = new Review()
            {
                DishId = null,
                ReviewerName = "Frederik",
                Stars = 3,
                ReviewText = "Kunne vaere bedre",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(review2);

            var review3 = new Review()
            {
                DishId = null,
                ReviewerName = "Peter",
                Stars = 1,
                ReviewText = "Daarlig service",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(review3);

            var review4 = new Review()
            {
                DishId = null,
                ReviewerName = "Suzanne",
                Stars = 4,
                ReviewText = "God mad",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(review4);

            var review5 = new Review()
            {
                DishId = null,
                ReviewerName = "Jens",
                Stars = 4,
                ReviewText = "Fint",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(review5);

            // Rosenkrantzgade *************************
            var review6 = new Review()
            {
                DishId = null,
                ReviewerName = "Bo",
                Stars = 3,
                ReviewText = "Fint",
                Time = DateTime.Now,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(review6);

            // Fiskehusvej *****************************
            var review7 = new Review()
            {
                DishId = null,
                ReviewerName = "Franz",
                Stars = 5,
                ReviewText = "God fisk",
                Time = DateTime.Now,
                AddressRes = "Fiskehusvej"
            };
            db.Add(review7);




            //************INSERT DISH REVIEWS**************
            // Lillegade dish 1 ***************************
            var dishReview1 = new Review()
            {
                DishId = 1,
                ReviewerName = "Carsten",
                Stars = 5,
                ReviewText = "Super god bof!",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(dishReview1);

            var dishReview2 = new Review()
            {
                DishId = 1,
                ReviewerName = "Frederik",
                Stars = 3,
                ReviewText = "Kunne vaere bedre",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(dishReview2);

            var dishReview3 = new Review()
            {
                DishId = 1,
                ReviewerName = "Lars",
                Stars = 3,
                ReviewText = "OK",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(dishReview3);

            // Lillegade dish 2 ***************************
            var dishReview4 = new Review()
            {
                DishId = 2,
                ReviewerName = "Mette",
                Stars = 5,
                ReviewText = "Yummy!",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(dishReview4);

            var dishReview5 = new Review()
            {
                DishId = 2,
                ReviewerName = "Abraham",
                Stars = 3,
                ReviewText = "Fin bof",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(dishReview5);

            // Lillegade dish 3 ***************************
            var dishReview13 = new Review()
            {
                DishId = 3,
                ReviewerName = "Sandra",
                Stars = 3,
                ReviewText = "Meget lille bof",
                Time = DateTime.Now,
                AddressRes = "Lillegade"
            };
            db.Add(dishReview13);

            // Rosenkrantzgade dish 1 *********************
            var dishReview6 = new Review()
            {
                DishId = 2,
                ReviewerName = "Karl",
                Stars = 5,
                ReviewText = "Altid godt",
                Time = DateTime.Now,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(dishReview6);

            // Rosenkrantzgade dish 2 *********************
            var dishReview7 = new Review()
            {
                DishId = 2,
                ReviewerName = "Karl",
                Stars = 5,
                ReviewText = "Altid godt",
                Time = DateTime.Now,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(dishReview7);

            var dishReview8 = new Review()
            {
                DishId = 2,
                ReviewerName = "Preben",
                Stars = 4,
                ReviewText = "Godt",
                Time = DateTime.Now,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(dishReview8);

            // Rosenkrantzgade dish 3 *********************
            var dishReview9 = new Review()
            {
                DishId = 3,
                ReviewerName = "Tuomas",
                Stars = 5,
                ReviewText = "Yas",
                Time = DateTime.Now,
                AddressRes = "Rosenkrantzgade"
            };
            db.Add(dishReview9);

            // Fiskehusvej dish 1 *************************
            var dishReview10 = new Review()
            {
                DishId = 2,
                ReviewerName = "Brendan",
                Stars = 5,
                ReviewText = "Altid godt",
                Time = DateTime.Now,
                AddressRes = "Fiskehusvej"
            };
            db.Add(dishReview10);

            var dishReview11 = new Review()
            {
                DishId = 1,
                ReviewerName = "Sara",
                Stars = 3,
                ReviewText = "OK fisk",
                Time = DateTime.Now,
                AddressRes = "Fiskehusvej"
            };
            db.Add(dishReview11);

            // Fiskehusvej dish 2 *************************
            var dishReview12 = new Review()
            {
                DishId = 2,
                ReviewerName = "Finn",
                Stars = 4,
                ReviewText = "Mhmm",
                Time = DateTime.Now,
                AddressRes = "Fiskehusvej"
            };
            db.Add(dishReview12);


            db.SaveChanges();
        }
    }
}
