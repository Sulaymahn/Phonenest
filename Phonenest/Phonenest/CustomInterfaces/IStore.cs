using Phonenest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Phonenest.CustomInterfaces
{
    public interface IStore
    {
        ObservableCollection<Product> Products { get; }
        ObservableCollection<Advert> Adverts { get; }
        ObservableCollection<string> ProductCategories { get; }
        ObservableCollection<CartItem> Cart { get; }

        void AddToCart(Product product);
        void ReduceFromCart(Product product);
        void RemoveFromCart(Product product);
    }
}
