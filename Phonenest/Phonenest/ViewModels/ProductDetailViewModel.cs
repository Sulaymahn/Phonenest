using Phonenest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Phonenest.ViewModels
{
    public class ProductDetailViewModel : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }

        }

        string description;
        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }

        }

        string _thumbnail;
        public string Thumbnail
        {
            get => _thumbnail;
            set
            {
                if (_thumbnail != value)
                {
                    _thumbnail = value;
                    OnPropertyChanged();
                }
            }

        }

        string _manufacturer;
        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                if (_manufacturer != value)
                {
                    _manufacturer = value;
                    OnPropertyChanged();
                }
            }

        }

        int _price;
        public int Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged();
                }
            }

        }

        string[] _imageRef;
        public string[] ImageRef
        {
            get => _imageRef;
            set
            {
                if (_imageRef != value)
                {
                    _imageRef = value;
                    OnPropertyChanged();
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ProductDetailViewModel(Product product)
        {
            Name = product.Name;
            Description = product.Description;
            ImageRef = product.ImageRef;
            Manufacturer = product.Manufacturer;
            Price = product.Price;
            Thumbnail = product.Thumbnail;
        }
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
