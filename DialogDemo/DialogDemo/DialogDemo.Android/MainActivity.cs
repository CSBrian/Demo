using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DialogDemo.Droid
{
    [Activity(Label = "DialogDemo", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
             global::Xamarin.Forms.Forms.Init(this, bundle);
            
            LoadApplication(new App());
            //---------------
            //string[] items = {"female","male" };
            string[] items = { "Hanoi", "Haihong","Nhatrang","Danang","HCM" };
            int position = 0;
            AlertDialog.Builder b = new AlertDialog.Builder(this);
            b.SetTitle("Confirm infor");
            
            b.SetItems(items, (s, a) => {//listener
                Toast.MakeText(this,items[a.Which],ToastLength.Short).Show();  //which 
            });
                     
                //**
                //b.SetSingleChoiceItems(items, 0, (s, a) => {
                //    position = a.Which;  
                //});
                //b.SetPositiveButton("select", (s, a) => {
                //    Toast.MakeText(this, items[position], ToastLength.Short).Show();//show success
                //});

                                
                //**
                b.Show();//show popup
            //**
            //b.SetMessage("Are you sure!");
            //b.SetPositiveButton("yes", (s, a) =>
            //{
            //    Finish();
            //});
            //b.SetNegativeButton("no", (s, a) =>
            //{
            //    b.Dispose();
            //});
            //AlertDialog ad = b.Create();
            //b.Show();
        }
    }

            
}

