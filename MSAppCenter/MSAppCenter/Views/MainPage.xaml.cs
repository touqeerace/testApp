using Microsoft.AppCenter.Analytics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSAppCenter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Analytics.TrackEvent("Main Page");
        }
    }
}