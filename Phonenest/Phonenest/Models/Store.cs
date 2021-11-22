using System;
using System.Collections.Generic;
using System.Text;

namespace Phonenest.Models
{
    public class Store
    {
        public List<Product> Products { get; set; }
        public List<Advert> Adverts { get; set; }
        public List<string> Categories { get; set; }
    }
}
