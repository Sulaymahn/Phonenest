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
    public partial class AppMainPage : TabbedPage
    {
        IFirebaseAuthenticator auth;

        public AppMainPage()
        {

            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();
            Console.WriteLine(Application.Current.Properties.ContainsKey("Token"));

            /*
            if (Application.Current.Properties.ContainsKey("Token"))
            {
                var token = Application.Current.Properties["Token"] as string;
                if ((auth.LogInWithToken(token)).Result)
                {
                    DisplayAlert("Welcome", "Nigga it cant work the first time, but it fucking did, yeeeehhaaaa!", "yiha!");
                }
                else
                {
                    DisplayAlert("Well how about that!", "Nigga it cant work the first time", "yeahhh");
                }
            }
            else
            {
                Navigation.PushModalAsync(new SignUpPage());
            }
            */
        }
    }
}