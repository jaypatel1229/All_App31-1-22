using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace App10
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button1 = FindViewById<Button>(Resource.Id.And_Srv);
            button1.Click += ButtonA_Click;
            button2 = FindViewById<Button>(Resource.Id.Bro_Rec);
            button2.Click += ButtonB_Click;
            button3 = FindViewById<Button>(Resource.Id.Tl_br);
            button3.Click += ButtonC_Click;
            button4 = FindViewById<Button>(Resource.Id.Loc);
            button4.Click += ButtonD_Click;
            button5 = FindViewById<Button>(Resource.Id.Popup_menu);
            button5.Click += ButtonE_Click;
            button6 = FindViewById<Button>(Resource.Id.Web_view);
            button6.Click += ButtonF_Click;

        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Android_Service));
            StartActivity(intent);
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Broadcast_Receiver));
            StartActivity(intent);
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Tool_bar));
            StartActivity(intent);
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Localization));
            StartActivity(intent);
        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Popup_menu));
            StartActivity(intent);
        }

        private void ButtonF_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Web_View));
            StartActivity(intent);
        }



    }
}