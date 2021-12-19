using Phonenest.CustomInterfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phonenest.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppMainPage : TabbedPage
    {
        IFirebaseAuthenticator auth;
        ILocalStorage localStorage;

        public AppMainPage()
        {

            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();
            localStorage = DependencyService.Get<ILocalStorage>();

            if (localStorage.GetCredential() != null)
            {
                string[] credential = localStorage.GetCredential();
                if (credential.Length != 2)
                {
                    localStorage.DeleteCredential();
                    Navigation.PushModalAsync(new SignUpPage());
                }
                else auth.LoginWithEmailAndPass(credential[0], credential[1]);

            }
            else
            {
                Navigation.PushModalAsync(new SignUpPage());
            }
        }
    }
}