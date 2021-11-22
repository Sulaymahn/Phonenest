using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly: ResolutionGroupName("Unghostdude")]
[assembly: ExportEffect(typeof(Phonenest.Droid.Effects.DefaultEntryEffect), nameof(Phonenest.Droid.Effects.DefaultEntryEffect))]
namespace Phonenest.Droid.Effects
{
    public class DefaultEntryEffect : PlatformEffect
    {
        Color EntryBarColor = Color.Transparent;

        protected override void OnAttached()
        {
            Control.SetBackgroundColor(EntryBarColor);
        }

        protected override void OnDetached()
        {
            
        }
    }
}