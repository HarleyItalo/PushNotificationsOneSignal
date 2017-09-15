using Com.OneSignal;
using Xamarin.Forms;
using Com.OneSignal.Abstractions;

namespace push
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pushPage();

            OneSignal.Current.StartInit("<YOUR APP ID ONESIGNAL>").EndInit();

        }

        protected override void OnStart()
        {
            OneSignal.Current.RegisterForPushNotifications();
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
