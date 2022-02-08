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
using Android.Webkit;

namespace App10
{
    [Activity(Label = "Web_View")]
    public class Web_View : Activity
    {

        WebView webView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Web_View);
            // Create your application here
            UIREferences();
            LoadPage();
        }

        private void LoadPage()
        {
            var url = "https://www.hackerrank.com/";
            webView.LoadUrl(url);
            //throw new NotImplementedException();
        }

        private void UIREferences()
        {
            webView = FindViewById<WebView>(Resource.Id.Web_view);

            //throw new NotImplementedException();
        }
    }
}