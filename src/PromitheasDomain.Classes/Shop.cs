using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromitheasDomain.Classes
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Shop
    {
        public int ShopId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string SmallDescription { get; set; }
        public string FullDescription { get; set; }
        public string Logo { get; set; }
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
        public MembershipType MembershipType { get; set; }
        public List<Gallery> Galleries { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
    }
}
