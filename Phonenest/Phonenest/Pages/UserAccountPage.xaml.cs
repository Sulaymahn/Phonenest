using Phonenest.CustomInterfaces;
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
    public partial class UserAccountPage : ContentPage
    {
        public UserAccountPage()
        {
            InitializeComponent();
        }

        private void OnLogOut(object sender, EventArgs e)
        {
            DependencyService.Get<ILocalStorage>().DeleteCredential();
        }
    }
}