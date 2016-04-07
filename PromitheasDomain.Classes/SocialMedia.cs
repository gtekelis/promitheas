using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromitheasDomain.Classes
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public int ShopId { get; set; }
        //public Shop Shop { get; set; }
        public string SocialMediaUrl { get; set; }
        public bool IsActive { get; set; }
    }
}