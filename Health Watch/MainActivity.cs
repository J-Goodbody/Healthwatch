using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Health_Watch
{
    [Activity(Label = "Health_Watch.Android", MainLauncher = true, Icon = "@drawable/StockBackGround")]
    public class MainActivity : Activity
    {
        private int count = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //Get our button fromt the layout resource,
            // And attach an event to it.
            Button button = FindViewById<Button>(Resource.Id.Search);
            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };
            button.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(DetailActivity));
                intent.PutExtra("userCount", count++);
                base.StartActivity(intent);
            };
        }
    }
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Search);
            var t = FindViewById<TextView>(Resource.Id.Search);
            t.Text = string.Format("{0}:{1}", "You clicked", Intent.GetIntExtra("userCount", 0));
        }
        }
        }
    






