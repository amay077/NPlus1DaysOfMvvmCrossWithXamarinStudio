using System;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using FirstDemo.Core.ViewModels;

namespace FirstDemo.Touch
{
    public partial class FirstView : MvxViewController
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            this.Request = new MvxViewModelRequest<FirstViewModel>(
                null, null, new MvxRequestedBy());
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(textEditFirst).To(vm => vm.FirstName);
            set.Bind(textEditLast).To(vm => vm.LastName);
            set.Bind(labelFull).To(vm => vm.FullName);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}

