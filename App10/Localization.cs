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

namespace App10
{
    [Activity(Label = "Localization")]
    public class Localization : Activity
    {
        private Button button;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Localization);
            // Create your application here


            button = FindViewById<Button>(Resource.Id.Btn1);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //Toast.MakeText(this, "This Your Localization",ToastLength.Short).Show();
           // throw new NotImplementedException();
        }
    }
}