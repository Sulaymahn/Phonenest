using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Phonenest.CustomInterfaces;

namespace Phonenest.Models
{
    public class MockStore : IStore, INotifyPropertyChanged
    {
        private static MockStore _instance;

        //Events
        public event PropertyChangedEventHandler PropertyChanged;

        //Fields
        ObservableCollection<Product> _products;
        ObservableCollection<Advert> _adverts;
        ObservableCollection<string> _productCategories;
        ObservableCollection<CartItem> _cart;
        int _currentCartTotal;


        //Property
        public ObservableCollection<Product> Products
        {
            get => _products;
        }
        public ObservableCollection<Advert> Adverts
        {
            get => _adverts;
        }
        public ObservableCollection<string> ProductCategories
        {
            get => _productCategories;
        }
        public ObservableCollection<CartItem> Cart
        {
            get => _cart;
        }
        public int CartTotal
        {
            get => _currentCartTotal;
            set
            {
                if (value == _currentCartTotal) return;

                _currentCartTotal = value;
                OnPropertyChanged();
            }
        }

        //Constructor
        private MockStore()
        {
            _products = new ObservableCollection<Product>()
                {
                    new Product() { Name = "IPhone 13 Pro", Price = 525000, Manufacturer = "Apple", Description = "A dramatically more powerful camera system. A display so responsive, every interaction feels new again.", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-13-pro.jpg", ImageRef = new string[] { @"https://t-mobile.scene7.com/is/image/Tmusprod/Apple-iPhone-13-Pro-Max-Sierra-Blue-rightimage-1", @"https://t-mobile.scene7.com/is/image/Tmusprod/Apple-iPhone-13-Pro-Max-Sierra-Blue-frontimage-1", "https://t-mobile.scene7.com/is/image/Tmusprod/Apple-iPhone-13-Pro-Max-Sierra-Blue-leftimage-1" } },
                    new Product(){Name = "IPhone 11 Pro", Price = 490000, Manufacturer = "Apple", Description = "Super Retina XDR OLED, HDR10, Dolby Vision, 800 nits (HBM), 1200 nits (peak)", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-11-pro-max-.jpg" },
                    new Product(){Name = "Galaxy A03s", Price = 67500, Manufacturer = "Samsung", Description = "Android 11, One UI 3.1 Core", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-a03s.jpg" },
                    new Product(){Name = "Galaxy A02s", Price = 52000, Manufacturer = "Samsung", Description = "Android 11, One UI 3.1 Core", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-a02s-sm-a025-new.jpg" },
                    new Product(){Name = "M15 R3", Price = 1520000, Manufacturer = "Alienware", Description = "Alienware’s most thin and powerful 15\" laptop ever. Now with the option for up to 10th gen Intel® Core™ i9k processors with up to 12 - phase HyperEfficient Voltage regulation.", Thumbnail = @"https://i.dell.com/is/image/DellContent//content/dam/global-asset-library/Products/Notebooks/Alienware/m15_r3_non-touch_non-tobii/awm15r3nt_cnb_05000ff090_wh.psd?fmt=pjpg&amp;pscan=auto&amp;scl=1&amp;hei=402&amp;wid=528&amp;qlt=100,0&amp;resMode=sharp2&amp;size=528,402" },
                    new Product(){Name = "Galaxy s20", Price = 200000, Manufacturer = "Samsung", Description = "Released 2020, March 06163g, 7.9mm thicknessAndroid 10, up to Android 11, One UI 3.0128GB storage, microSDXC", Thumbnail = @"https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s20-.jpg" }
                };
            _adverts = new ObservableCollection<Advert>()
                {
                    new Advert(){Source = "https://cdn.dribbble.com/users/5941313/screenshots/16251892/media/4fa9b7e86f8bf36be03f7f9570d2ff83.jpg?compress=1&resize=1200x900", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/316881/screenshots/6443811/vodafone_designathon_4x.png?compress=1&resize=1200x900", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/1147613/screenshots/3029860/media/86b7d61e8f14e9dfed7c360fa6ff2b3d.png?compress=1&resize=800x600", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/1147613/screenshots/16886861/media/2604ffd2bfc763de8ad8ad0c330b7b30.png?compress=1&resize=1200x900", Destination = ""},
                    new Advert(){Source = "https://cdn.dribbble.com/users/914439/screenshots/14195422/media/35ed5e21f369eb47ccd84814efe2375e.png?compress=1&resize=1200x900", Destination = ""}
                };
            _productCategories = new ObservableCollection<string>()
                {
                    "Phones",
                    "Laptops",
                    "Accessories",
                    "Consoles"
                };

            _cart = new ObservableCollection<CartItem>();
            FillCart();
        }


        //Methods
        public static MockStore GetInstance()
        {
            if (_instance == null) _instance = new MockStore();
            return _instance;
        }

        void GetCartTotal()
        {
            int total = 0;
            foreach (CartItem cartItem in Cart)
            {
                total += cartItem.Item.Price;
            }
        }

        void FillCart()
        {
            AddToCart(_products[0]);
            AddToCart(_products[1]);
            AddToCart(_products[2]);
            GetCartTotal();
        }
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void AddToCart(Product product)
        {
            foreach (CartItem cartItem in _cart)
            {
                if (cartItem.Item == product)
                {
                    cartItem.Count++;
                    CartTotal += product.Price;
                    return;
                }
            }

            _cart.Add(new CartItem() { Item = product, Count = 1 });
            CartTotal += product.Price;
        }
        public void ReduceFromCart(Product product)
        {
            foreach (CartItem cartItem in _cart)
            {
                if (cartItem.Item == product)
                {
                    if (cartItem.Count == 1)
                    {
                        _cart.Remove(cartItem);
                    }
                    cartItem.Count--;

                    CartTotal -= product.Price;
                    return;
                }
            }
        }
        public void RemoveFromCart(Product product)
        {
            foreach (CartItem cartItem in _cart)
            {
                if (cartItem.Item == product)
                {
                    _cart.Remove(cartItem);
                    return;
                }
            }
        }

    }
}
