using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromitheasDomain.Classes;
using PromitheasDomain.DataModel;
using System.Data.Entity;

namespace ConsoleApplicationForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertShop();
            //GetAllShops();            
            GetShopGraph();
            //InsertShopWithSocialMedia();
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

        private static Shop GetShopGraph()
        {
            using (var context = new PromitheasContext())
            {
                var shop = context.Shops.Include(o => o.ShopSocialMedia).Where(o => o.Title == "Best Tattoos Ever").FirstOrDefault();
                //context.Entry(shop).Collection(s => s.ShopSocialMedia).Load();
                return shop;
            }
        }

        private static void InsertShopWithSocialMedia()
        {
            using (var context = new PromitheasContext())
            {
                var shop = new Shop
                {
                    Title = "Best Tattoos Ever",
                    Address = "Αριστοφάνους 74",
                    City = "Κερατσίνι",
                    ZipCode = "18757",
                    State = "Αττική",
                    IsActive = true,
                    ShopMembershipType = ShopMembershipType.Free
                };

                var socialMedia1 = new SocialMedia
                {
                    IsActive = true,
                    SocialMediaUrl = "http://www.facebook.com/test1"
                };

                var socialMedia2 = new SocialMedia
                {
                    IsActive = true,
                    SocialMediaUrl = "http://www.facebook.com/test2"
                };

                context.Shops.Add(shop);
                shop.ShopSocialMedia.AddRange(new List<SocialMedia> { socialMedia1, socialMedia2 });
                context.SaveChanges();
            }


        }
    }
}
