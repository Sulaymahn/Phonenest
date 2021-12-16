using Phonenest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phonenest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductSearchPage : ContentPage
    {
        public ProductSearchPage()
        {
            InitializeComponent();
        }

        private void OnSearch(object sender, EventArgs e)
        {
            products.ItemsSource = MockStore.GetInstance().Products.Where(x =>
            {
                string check = x.Name + x.Manufacturer;
                return check.ToLower().Contains(entry.Text.ToLower());
            });
        }

        private async void products_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() != null)
            {
                await Navigation.PushModalAsync(new ProductsDetailPage((Product)e.CurrentSelection.FirstOrDefault()));
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}