using System;
using System.Collections.Generic;
using System.Text;

namespace Phonenest.Models
{
    public static class MockStore
    {
        public static List<Product> Products
        {
            get
            {
                return new List<Product>()
                {
                    new Product(){Name = "Apple IPhone 13 Pro", Price = "14,999", Manufacturer = "Apple", Description = "A dramatically more powerful camera system. A display so responsive, every interaction feels new again.", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-13-pro.jpg" },
                    new Product(){Name = "Apple IPhone 11 Pro", Price = "8,999", Manufacturer = "Apple", Description = "Super Retina XDR OLED, HDR10, Dolby Vision, 800 nits (HBM), 1200 nits (peak)", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-11-pro-max-.jpg" },
                    new Product(){Name = "Samsung Galaxy A03s", Price = "4,999", Manufacturer = "Samsung", Description = "Android 11, One UI 3.1 Core", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-a03s.jpg" },
                    new Product(){Name = "Samsung Galaxy A02s", Price = "3,999", Manufacturer = "Samsung", Description = "Android 11, One UI 3.1 Core", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-a02s-sm-a025-new.jpg" },
                    new Product(){Name = "Samsung Galaxy s20", Price = "9,999", Manufacturer = "Samsung", Description = "Released 2020, March 06163g, 7.9mm thicknessAndroid 10, up to Android 11, One UI 3.0128GB storage, microSDXC", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s20-.jpg" }
                };
            }
        }
        public static List<Advert> Adverts
        {
            get
            {
                return new List<Advert>()
                {
                    new Advert(){Source = "https://www.pcgamer.ma/258420-large_default/pc-i5-10400-geforce-rtx-3060-12g.jpg", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/316881/screenshots/6443811/vodafone_designathon_4x.png?compress=1&resize=1200x900", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/1147613/screenshots/3029860/media/86b7d61e8f14e9dfed7c360fa6ff2b3d.png?compress=1&resize=800x600", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/1147613/screenshots/16886861/media/2604ffd2bfc763de8ad8ad0c330b7b30.png?compress=1&resize=1200x900", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/914439/screenshots/14195422/media/35ed5e21f369eb47ccd84814efe2375e.png?compress=1&resize=1200x900", Destination = ""}
                };
            }
        }

        public static List<string> Categories {
            get
            {
                return new List<string>()
                {
                    "Phones",
                    "Laptops",
                    "Accessories",
                    "Consoles"
                };
            }
        }
    }
}
