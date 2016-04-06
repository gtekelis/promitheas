using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromitheasDomain.Classes;

namespace PromitheasDomain.DataModel
{
    public class PromitheasContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Gallery> ShopGalleries { get; set; }
        public DbSet<Image> GalleryImages { get; set; }
        public DbSet<SocialMedia> ShopSocialMedia { get; set; }
    }
}
