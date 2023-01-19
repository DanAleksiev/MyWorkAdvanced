using System;
using System.Collections.Generic;

namespace _04.ProductShop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input;
            SortedDictionary<string ,Dictionary<string,double>> shops = new SortedDictionary<string ,Dictionary<string,double>>();
            while((input = Console.ReadLine()) != "Revision")
                {
                string[] split = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string shop = split[0];
                string product = split[1];
                double price = double.Parse(split[2]);

                if(!shops.ContainsKey(shop))
                    {
                    shops.Add(shop, new Dictionary<string,double>());
                    }
                shops[shop].Add(product, price);
                }
            foreach (var shop in shops)
                {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                    {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                    }
                }
            }
        }
    }
