// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MadNavigation
{
	[Register ("CyanViewController")]
	partial class CyanViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NavigationButton { get; set; }

		[Action ("NavigationButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void NavigationButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (NavigationButton != null) {
				NavigationButton.Dispose ();
				NavigationButton = null;
			}
		}
	}
}
