using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromitheasDomain.Classes
{
    public class Shop
    {
        public Shop()
        {
            ShopGalleries = new List<Gallery>();
            ShopSocialMedia = new List<SocialMedia>();
        }

        public int ShopId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string SmallDescription { get; set; }
        public string FullDescription { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string LandLine1 { get; set; }
        public string LandLine2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public bool IsActive { get; set; }
        public ShopMembershipType ShopMembershipType { get; set; }
        public List<Gallery> ShopGalleries { get; set; }
        public List<SocialMedia> ShopSocialMedia { get; set; }
        //public Gallery Gallery { get; set; }
        //public SocialMedia SocialMedia { get; set; }
    }

}
