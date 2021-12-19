using Phonenest.CustomInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phonenest.Pages
{
    public partial class SignUpPage : ContentPage
    {
        IFirebaseAuthenticator auth;
        public SignUpPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();
        }

        private void CreateAccount(object sender, EventArgs e)
        {
            DisplayAlert("Account creation", "which account you wan create again boss", "sorry sir");
        }

        private void ForgotPassword(object sender, EventArgs e)
        {
            DisplayAlert("Forgotten Account", "Yahoo boy, toh we never even launch am", "i admit i'm a yahoo boy");
        }

        private async void SignInClicked(object sender, EventArgs e)
        {
            if (emailEntry.Text == null || passwordEntry.Text == null) return;
            string response = await auth.LoginWithEmailAndPass(emailEntry.Text, passwordEntry.Text);


            if (response != null)
            {
                DependencyService.Get<ILocalStorage>().SaveCredential(emailEntry.Text, passwordEntry.Text);
                await Navigation.PopModalAsync();
            }
            else
            {
                await DisplayAlert("Unsuccessful", "invalid Email", "ok");
            }
        }
    }
}
