using Phonenest.Models;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phonenest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        
        public CartPage()
        {
            InitializeComponent();
            cartCol.ItemsSource = MockStore.GetInstance().Cart;
            UpdateTotal();
        }

        private void AddCount(object sender, System.EventArgs e)
        {
            CartItem item = (sender as Image).BindingContext as CartItem;
            MockStore.GetInstance().AddtoCart(item.Item);
            UpdateTotal();
        }

        private void RemoveCount(object sender, System.EventArgs e)
        {
            CartItem item = (sender as Image).BindingContext as CartItem;
            MockStore.GetInstance().RemoveFromCart(item.Item);
            UpdateTotal();
        }

        void UpdateTotal()
        {
            total.Text = MockStore.GetInstance().CartTotal.ToString("C0");
        }

        private async void cartCol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() != null)
            {
                await Navigation.PushModalAsync(new ProductsDetailPage((Product)e.CurrentSelection.FirstOrDefault()));
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}