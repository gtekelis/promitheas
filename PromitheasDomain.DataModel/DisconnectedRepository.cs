using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromitheasDomain.Classes;
using PromitheasDomain.DataModel;
using System.Data.Entity;

namespace PromitheasDomain.DataModel
{
    public class DisconnectedRepository
    {
        public List<Shop> GetShops()
        {
            using (var context = new PromitheasContext())
            {
                var shops = context.Shops.AsNoTracking().ToList();
                return shops;
            }            
        }

        public Shop GetShopWithSocialMedia(int id)
        {
            using (var context = new PromitheasContext())
            {
                var shop = context.Shops.AsNoTracking().Include(x => x.ShopSocialMedia).FirstOrDefault(x => x.ShopId == id);
                return shop;
            }
        }

        public Shop GetShopById(int id)
        {
            using (var context = new PromitheasContext())
            {
                var shop = context.Shops.Find(id);
                return shop;
            }
        }

        public void SaveUpdatedShop(Shop shop)
        {
            using (var context = new PromitheasContext())
            {
                context.Entry(shop).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void SaveNewShop(Shop shop)
        {
            using (var context = new PromitheasContext())
            {
                context.Shops.Add(shop);
                context.SaveChanges();
            }
        }

        public void SaveNewShopSocialMedia(SocialMedia socialMedia)
        {
            using (var context = new PromitheasContext())
            {
                context.ShopSocialMedia.Add(socialMedia);
                context.SaveChanges();
            }
        }
    }
}
