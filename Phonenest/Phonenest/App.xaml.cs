using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Phonenest.Pages;

namespace Phonenest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
