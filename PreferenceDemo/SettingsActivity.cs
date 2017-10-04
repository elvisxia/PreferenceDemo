using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Preferences;

namespace PreferenceDemo
{
    [Activity(Label = "PreferenceDemo")]
    public class SettingsActivity:Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Settings);
            FragmentManager.BeginTransaction().Replace(Resource.Id.container, new SettingsFragment()).Commit();
            
        }
    }
}