using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DialogDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DialogDemo.MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Start");           
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("Sleep");
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            Debug.WriteLine("Resume");
            // Handle when your app resumes
        }
    }
}
