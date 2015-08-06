using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MadNavigation
{
	partial class CyanViewController : UIViewController
	{
		public CyanViewController (IntPtr handle) : base (handle)
		{
		}

		partial void NavigationButton_TouchUpInside (UIButton sender)
		{
			var viewController = RootTabViewController.firstStoryboard.InstantiateViewController ("RedScreen") as RedViewController;
			viewController.Previous = this;
			ShowViewController (viewController, null);
		}
	}
}
