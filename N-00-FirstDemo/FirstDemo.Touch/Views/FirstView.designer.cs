// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace FirstDemo.Touch
{
	[Register ("FirstDemo_TouchViewController")]
	partial class FirstView
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UILabel labelFull { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField textEditFirst { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField textEditLast { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textEditFirst != null) {
				textEditFirst.Dispose ();
				textEditFirst = null;
			}

			if (textEditLast != null) {
				textEditLast.Dispose ();
				textEditLast = null;
			}

			if (labelFull != null) {
				labelFull.Dispose ();
				labelFull = null;
			}
		}
	}
}
