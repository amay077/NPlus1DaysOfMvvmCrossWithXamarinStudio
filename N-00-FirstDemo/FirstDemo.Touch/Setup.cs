using System;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace FirstDemo.Touch
{
    public class Setup : MvxTouchSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
            : base(appDelegate, presenter) { }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}

