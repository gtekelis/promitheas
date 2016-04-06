using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromitheasDomain.Classes
{
    public class Image
    {
        public int ImageId { get; set; }
        public int GalleryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TattooCategory TattooCategory { get; set; }
        public string ImageUrl { get; set; }
        public Gallery Gallery { get; set; }
        public bool IsActive { get; set; }
    }
}