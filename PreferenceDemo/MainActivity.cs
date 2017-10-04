using Android.App;
using Android.Widget;
using Android.OS;
using Android.Preferences;
using Android.Content;

namespace PreferenceDemo
{
    [Activity(Label = "PreferenceDemo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnGetPreference,btnSettings;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            PreferenceManager.SetDefaultValues(this, Resource.Xml.Preferences, false);
            btnGetPreference = FindViewById<Button>(Resource.Id.btnGetPreference);
            btnSettings = FindViewById<Button>(Resource.Id.btnSettings);
            btnSettings.Click += BtnSettings_Click;
            btnGetPreference.Click += BtnGetPreference_Click;
        }

        private void BtnSettings_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SettingsActivity));
            StartActivity(intent);
        }

        private void BtnGetPreference_Click(object sender, System.EventArgs e)
        {
            ISharedPreferences sharedPref = PreferenceManager.GetDefaultSharedPreferences(this);
            string syncConnPref = sharedPref.GetString("pref_url", "");
        }
        
    }
}

