using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using MSAppCenter.Views;
using Xamarin.Forms;

namespace MSAppCenter
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=49d7f80d-9500-4977-95f2-c9b3b93b92f8", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            Analytics.TrackEvent("App Sleep");
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            Analytics.TrackEvent("App Resume");
            // Handle when your app resumes
        }
    }
}
