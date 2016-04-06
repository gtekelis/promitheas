using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromitheasDomain.Classes
{
    public class Gallery
    {
        public Gallery()
        {
            ListImages = new List<Image>();
        }

        public int GalleryId { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public List<Image> ListImages { get; set; }
        public bool IsActive { get; set; }
    }
}