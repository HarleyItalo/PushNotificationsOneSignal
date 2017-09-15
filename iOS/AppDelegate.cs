using System;
using System.Collections.Generic;
using System.Linq;
using Com.OneSignal;
using Foundation;
using UIKit;

namespace push.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
            Xamarin.Calabash.Start();
#endif


            LoadApplication(new App());
            OneSignal.Current.StartInit("<YOUR APP ID ONESIGNAL>")
                 .EndInit();
            return base.FinishedLaunching(app, options);
        }

    }
}
