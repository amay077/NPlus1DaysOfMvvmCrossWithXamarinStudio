using MonoTouch.Foundation;
using Cirrious.MvvmCross.Touch.Platform;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace FirstDemo.Touch
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override void FinishedLaunching(UIApplication application)
        {
            var setup = new Setup(this, new MvxTouchViewPresenter(this, Window));
            setup.Initialize();
        }
    }
}

