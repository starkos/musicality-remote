using System;

using Foundation;
using UIKit;

namespace Musicality.Remote.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new Musicality.Remote.Forms.App());
            return base.FinishedLaunching(app, options);
        }
    }
}
