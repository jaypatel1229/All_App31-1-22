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
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace App10
{
    [Activity(Label = "Toolbar")]
    public class Tool_bar : Activity
    {
        Toolbar toolbar;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Tool_bar);
            // Create your application here
            toolbar = FindViewById<Toolbar>(Resource.Id.tb1);
            
            
        }

     

        
    }
}