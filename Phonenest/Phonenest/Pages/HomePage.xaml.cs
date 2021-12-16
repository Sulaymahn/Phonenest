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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            productsCol.ItemsSource = MockStore.GetInstance().Products;
            AdsCarouselView.ItemsSource = MockStore.GetInstance().Adverts;
            StartAdsTime();
        }

        void StartAdsTime()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                AdsCarouselView.Position = (AdsCarouselView.Position + 1) % MockStore.GetInstance().Adverts.Count;

                return true;
            });
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() != null)
            {
                await Navigation.PushModalAsync(new ProductsDetailPage((Product)e.CurrentSelection.FirstOrDefault()));
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}