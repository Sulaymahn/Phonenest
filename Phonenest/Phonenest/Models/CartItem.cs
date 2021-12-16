using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Phonenest.Models
{
    public class CartItem : INotifyPropertyChanged
    {
        Product _item;
        public Product Item 
        {
            get => _item;
            set 
            {
                if (_item != value)
                {
                    _item = value;
                    OnPropertyChanged();
                }
            } 
        }

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        int _count;
        public int Count
        {
            get => _count;
            set
            {
                if(_count != value)
                {
                    _count = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
