using System;
using System.Collections.Generic;
using System.Text;

namespace Phonenest.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string[] ImageRef { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
    }
}
