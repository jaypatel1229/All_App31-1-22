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
    [Activity(Label = "Broadcast_Receiver")]
    public class Broadcast_Receiver : Activity
    {
        Button mybutton;
        MybootReceiver receiver;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Broadcast_Receiver);
            // Create your application here

            mybutton = FindViewById<Button>(Resource.Id.btn);
            receiver = new MybootReceiver();
            mybutton.Click += mybutton_Click;
        }

        private void mybutton_Click(object sender, EventArgs e)
        {
            Intent message = new Intent("com.xamarin.example.Test");
            message.PutExtra("key", "Testing Broadcast");
            SendBroadcast(message);
            //throw new NotImplementedException();
        }

        protected override void OnResume()
        {
            base.OnResume();
            RegisterReceiver(receiver, new IntentFilter("com.xamarin.example.Test"));

        }

        protected override void OnPause()
        {
            UnregisterReceiver(receiver);
            base.OnPause();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}