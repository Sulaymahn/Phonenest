using Phonenest.Models;
using Phonenest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phonenest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsDetailPage : ContentPage
    {
        Product _product;
        const string CARTITEMINFO = "Already in cart";
        bool inCart;

        public ProductsDetailPage(Product product)
        {
            InitializeComponent();
            foreach (var cartItem in MockStore.GetInstance().Cart) if (product == cartItem.Item) SwitchToCount();
            _product = product;
            BindingContext = new ProductDetailViewModel(product);
        }

        void SwitchToCount()
        {
            inCart = true;
            cartAddBtn.Text = CARTITEMINFO;
            cartAddBtn.IsEnabled = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (inCart)
            {
                return;
            }
            else
            {
                MockStore.GetInstance().AddtoCart(_product);
                SwitchToCount();
            }
        }
    }
}