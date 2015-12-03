using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestApp
{
    [Activity(Label = "TestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            var btnNews = FindViewById<Button>(Resource.Id.News);
            var btnSearch = FindViewById<Button>(Resource.Id.Search);
            var btnRate = FindViewById<Button>(Resource.Id.Rate);



            btnSearch.Click += delegate { StartActivity(typeof(Search)); };
            btnRate.Click += delegate { StartActivity(typeof(Rate)); };
            btnNews.Click += delegate { StartActivity(typeof(News)); };





        }


    };
};

