using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Phonenest.CustomInterfaces;
using Phonenest.Droid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Phonenest.Droid.Implementations.FirebaseDB))]
namespace Phonenest.Droid.Implementations
{
    public class FirebaseDB : IFirebaseDatabase
    {
        public IStore GetStore()
        {
            return null;
        }
    }
}