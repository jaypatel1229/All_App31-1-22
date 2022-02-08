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
    [Activity(Label = "Popup_menu")]
    public class Popup_menu : Activity,PopupMenu.IOnMenuItemClickListener
    {
        Button btnShow;
        private PopupMenu menu1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Popup_menu);
         

            btnShow = FindViewById<Button>(Resource.Id.menu_btn);
            btnShow.Click += button1; 
           
        }

        private void button1(object sender, EventArgs e)
        {
            menu1 = new PopupMenu(this, btnShow);
            menu1.MenuInflater.Inflate(Resource.Menu.popup_menu, menu1.Menu);
            menu1.SetOnMenuItemClickListener(this);
            menu1.Show();
        }

       
      
        bool PopupMenu.IOnMenuItemClickListener.OnMenuItemClick(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.action_setting1:
                    Toast.MakeText(this ,Resource.String.Share,ToastLength.Long).Show();
                    return true;
                case Resource.Id.action_settings2:
                    Toast.MakeText(this, Resource.String.Bluetooh, ToastLength.Long).Show();
                    return true;
                case Resource.Id.action_settings3:
                    Toast.MakeText(this, Resource.String.Exit, ToastLength.Long).Show();
                    return true;
                default:
                    return false;



            }
        }
    }
}