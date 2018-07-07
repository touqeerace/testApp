using Microsoft.AppCenter.Analytics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSAppCenter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Analytics.TrackEvent("About Page");
            Crash.Clicked += (s, e) =>
            {
                Analytics.TrackEvent("Crash button clicked");
                throw new System.TimeZoneNotFoundException("Crash o gya e oye");
            };

        }
    }
}