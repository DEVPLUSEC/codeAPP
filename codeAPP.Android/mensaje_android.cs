using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using codeAPP.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(mensaje_android))]

namespace codeAPP.Droid
{
    public class mensaje_android : mensaje
    {

        public void LongAlert(string mensa) { 
        
            Toast.MakeText(Application.Context, mensa, ToastLength.Long).Show();
        }

        public void ShortAlert(string mensa)
        {

            Toast.MakeText(Application.Context, mensa, ToastLength.Short).Show();
        }

    }
}