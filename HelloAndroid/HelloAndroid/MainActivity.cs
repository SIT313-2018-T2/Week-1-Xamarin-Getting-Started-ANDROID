using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            ImageView img = FindViewById<ImageView>(Resource.Id.imageView1);
            var imageSwitch = false;
            img.Click += delegate {
            
                if (imageSwitch)
                {
                    img.SetImageResource(Resource.Drawable.off);
                    imageSwitch = false;
                }
                else
                {
                    img.SetImageResource(Resource.Drawable.on);
                    imageSwitch = true;
                }
            };



            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

