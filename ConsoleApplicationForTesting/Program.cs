using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromitheasDomain.Classes;
using PromitheasDomain.DataModel;

namespace ConsoleApplicationForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertShop();
            GetAllShops();
        }

        private static void InsertShop()
        {
            var shop = new Shop
            {
                Title = "Tattoo & Art By George",
                Address = "Εσπερίδων 2",
                ZipCode = "18757",
                City = "Κερατσίνι",
                State = "Αττική"
            };

            using (var context = new PromitheasContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Shops.Add(shop);
                context.SaveChanges();
            }
        }

        private static List<Shop> GetAllShops()
        {
            using (var context = new PromitheasContext())
            {
                var shops = context.Shops.ToList();
                return shops;
            }
        }
    }
}
