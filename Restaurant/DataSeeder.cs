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
                AddressRes = "Lillegade 134, 8000 Aarhus C",
                NameRes = "Kaspers Bøfhus",
                Type = "Bøfhus"
            };
            db.Add(kaspers);

            Restaurant jensens = new Restaurant()
            {
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus",
                NameRes = "Jensens Bøfhus",
                Type = "Bøfhus"
            };
            db.Add(jensens);

            Restaurant fiskens = new Restaurant()
            {
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N",
                NameRes = "Thanks For All the Fisk",
                Type = "Fisk"
            };
            db.Add(fiskens);


            //************INSERT DISHES*****************
            var dish = db.Dish;
            Dish bof = new Dish()
            {
                DishName = "Bøf",
                DishDescription = "Den lækreste bøf i huset",
                Price = 199,
                Category = "Bøf",
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(bof);

            Dish megabof = new Dish()
            {
                DishName = "MEGA Bøf",
                DishDescription = "Den lækreste MEGA bøf i huset",
                Price = 259,
                Category = "Bøf",
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(megabof);

            Dish minibof = new Dish()
            {
                DishName = "mini Bøf",
                DishDescription = "Den lækreste mini bøf i huset",
                Price = 129,
                Category = "Bøf",
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(minibof);

            Dish salatbar = new Dish()
            {
                DishName = "Salatbar",
                DishDescription = "Tag selv salatbar - all you can eat",
                Price = 49,
                Category = "Salat",
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(salatbar);

            Dish nachos = new Dish()
            {
                DishName = "Nachos",
                DishDescription = "Sprøde tortillachips med ched ­dar og jalapeños. Serveres med guacamole, salsa og creme fraiche",
                Price = 69,
                Category = "Frokost",
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(nachos);

            Dish hakkebof = new Dish()
            {
                DishName = "Herregårds-hakkebøf",
                DishDescription = "Hakkebøf serveres med lune ærter, tykke fries og Jensens Bearnaisesauce",
                Price = 79,
                Category = "Frokost",
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(hakkebof);

            Dish rogn = new Dish()
            {
                DishName = "Stenbiderrogn",
                DishDescription = "Yummmm lidt æg til vinen",
                Price = 110,
                Category = "Fisk",
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(rogn);

            Dish deller = new Dish()
            {
                DishName = "Fiskefrikadeller",
                DishDescription = "Dejlig saftige fiskefrikedeller af den bedste torsk fra Gudenåen",
                Price = 150,
                Category = "Fisk",
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(deller);

            //************INSERT TABLES****************
            var table = db.TableRes;
            var bord1 = new TableRes()
            {
                TableNumber = 1,
                Chairs = 2,
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(bord1);

            var bord2 = new TableRes()
            {
                TableNumber = 2,
                Chairs = 4,
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(bord2);

            var bord3 = new TableRes()
            {
                TableNumber = 3,
                Chairs = 4,
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(bord3);

            var bord4 = new TableRes()
            {
                TableNumber = 4,
                Chairs = 4,
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(bord4);

            var bord5 = new TableRes()
            {
                TableNumber = 5,
                Chairs = 4,
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(bord5);

            var bord6 = new TableRes()
            {
                TableNumber = 6,
                Chairs = 6,
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(bord6);

            var bord7 = new TableRes()
            {
                TableNumber = 7,
                Chairs = 2,
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(bord7);

            var bord8 = new TableRes()
            {
                TableNumber = 8,
                Chairs = 4,
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(bord8);

            //************INSERT WAITERS**************
            var waiter = db.Waiter;
            var tjener1 = new Waiter()
            {
                Salary = 120000,
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(tjener1);

            var tjener2 = new Waiter()
            {
                Salary = 12000,
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(tjener2);

            var tjener3 = new Waiter()
            {
                Salary = 20000,
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(tjener3);

            //************INSERT GUESTS***************
            var guest = db.Guest;
            var gaest1 = new Guest()
            {
                NameBooker = "Carsten",
                TableNumber = 1,
                PartySize = 2,
                Time = new DateTime(2019, 11, 10, 18, 00, 00),
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(gaest1);

            var gaest2 = new Guest()
            {
                NameBooker = "Lillian",
                TableNumber = 2,
                PartySize = 4,
                Time = new DateTime(2019, 11, 10, 19, 30, 00),
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(gaest2);

            var gaest3 = new Guest()
            {
                NameBooker = "Suzanne",
                TableNumber = 4,
                PartySize = 3,
                Time = new DateTime(2019, 11, 11, 12, 30, 00),
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(gaest3);

            var gaest4 = new Guest()
            {
                NameBooker = "Allan",
                TableNumber = 5,
                PartySize = 4,
                Time = new DateTime(2019, 11, 14, 14, 15, 00),
                AddressRes = "Rosenkrantzgade 23, 8000 Aarhus"
            };
            db.Add(gaest4);

            var gaest5 = new Guest()
            {
                NameBooker = "Niklas",
                TableNumber = 7,
                PartySize = 1,
                Time = new DateTime(2019, 12, 24, 12, 00, 00),
                AddressRes = "Fiskehus Allé 42, 8200 Aarhus N"
            };
            db.Add(gaest5);

            //************INSERT REVIEWS**************
            var review = db.Review;

            var anmeldelse1 = new Review()
            {
                DishId = 1,
                ReviewerName = "Carsten",
                Stars = 5,
                ReviewText = "Super god bøf!",
                Time = new DateTime(2019, 11, 10, 18, 00, 00),
                AddressRes = "Lillegade 134, 8000 Aarhus C"
            };
            db.Add(anmeldelse1);

            db.SaveChanges();
        }
    }
}
