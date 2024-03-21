using System.Collections.Generic;
using System.Text.Json;


namespace LINQtest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ Test Products!");

            List<Product> inventory = CreateProducts();

            int count = inventory.Count;

            Console.WriteLine($"There are {count} products");

            foreach (Product product in inventory)
            {
                Console.WriteLine($"\t{Console.ForegroundColor = product.Color}ID: {product.Id}, " +
                   $"Name: {product.Name}, Category: {product.Category},\n Description: {product.Description}, " +
                    $"Price: {product.Price}\n\n");
            }



            var items = inventory.Where(i => i.Description == "Cyan")
                .Select(i => new { i.Name, i.Price, i.QtyInStock, TotalValue = i.Price * i.QtyInStock });

            Console.WriteLine("JSON follows:");

            ShowAsJson(items);


            var totalvalue = inventory.Where(i => i.Description == "Cyan").Sum(i => i.Price);

            Console.WriteLine($"The Sum price of Cyan products is {totalvalue}");


            var averagevalue = inventory.Where(i => i.Description == "Blue").Average(i => i.Price);

            Console.WriteLine($"The average price of Blue products is {averagevalue}");

            var totalAllItems = inventory.Sum(i => i.Price * i.QtyInStock);

            Console.WriteLine($"The Total of all items is {totalAllItems}");

            //SQL Server Syntax
            var yitems = from p in inventory
                         where p.Description == "Yellow"
                         select p;
            foreach (var p in yitems)
            {
                Console.WriteLine($"{Console.ForegroundColor = p.Color}Product {p.Name} is {p.Description}");
            }


            var priceitems = from p in inventory
                             where p.Price > 200
                             select p;

            foreach (var p in priceitems)
            {
                Console.WriteLine($"{Console.ForegroundColor = p.Color}Product{p.Name} costs ${p.Price}");
            }



            var priceditems = from p in inventory
                              where p.Price > 200 && p.Description != "Red"
                              select p;

            foreach (var p in priceditems)
            {
                Console.WriteLine($"{Console.ForegroundColor = p.Color}, Product{p.Name} costs ${p.Price}");
            }


            var pricenotreditems = from p in inventory
                                   where !(p.Price > 200 && p.Description != "Red")
                                   select p;

            foreach (var p in pricenotreditems)
            {
                Console.WriteLine($"{Console.ForegroundColor = p.Color}, Product{p.Name} costs ${p.Price}");
            }

            Console.WriteLine("List of Products: ");

            var items2 = from p in inventory
                         where p.Description == "Cyan"
                         group p by 1 into theTotal = Sum{ p.Price}
            select new { p.theTotal };

            var value = _context.Lineitems.Where(li => li.RequestId = requestId).Sum(li => li.Quanity * li.Price)
;

        }

        internal static List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();
            
            Product a = new Product(ConsoleColor.Yellow, 1, "Golden Delicious", "Food", "Yellow", 2.50m, 20);
            Product b = new Product(ConsoleColor.Cyan, 2, "Snow Boots", "Apparel", "Cyan", 150.50m, 4);
            Product c = new Product(ConsoleColor.Blue, 3, "Sweatshirt", "Apparel", "Blue", 25.99m, 15);
            Product d = new Product(ConsoleColor.Green, 4, "Cucumbers", "Food", "Green", 1.99m, 20);
            Product e = new Product(ConsoleColor.White, 5, "Bugatti", "Automotive", "White", 299999999.99m, 1);
            Product f = new Product(ConsoleColor.Cyan, 6, "Snorkel", "Sporting Goods", "Cyan", 10.50m, 3);
            Product g = new Product(ConsoleColor.DarkYellow, 7, "Sports Bike", "Automotive", "Gold", 30000.10m, 3);
            Product h = new Product(ConsoleColor.Magenta, 8, "Soccer Ball", "Sporting Goods", "Pink", 30.99m, 8);
            Product i = new Product(ConsoleColor.Blue, 9, "Tomatoes", "Food", "Blue", 1.50m, 10);
            Product j = new Product(ConsoleColor.Gray, 10, "Tesla", "Automotive", "Silver", 60000m, 2);

            products.Add(a);
            products.Add(b);
            products.Add(c);
            products.Add(d);
            products.Add(e);
            products.Add(f);
            products.Add(g);
            products.Add(h);
            products.Add(i);
            products.Add(j);


            return products;


        }
        static void ShowAsJson(object obj)
        {
            Console.WriteLine($"JSON for {obj.GetType()}");
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = System.Text.Json.JsonSerializer.Serialize(obj, options);
            Console.WriteLine(json);
        }

    }
}