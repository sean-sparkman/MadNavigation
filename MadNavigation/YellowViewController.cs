using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MadNavigation
{
	partial class YellowViewController : UIViewController
	{
		public YellowViewController (IntPtr handle) : base (handle)
		{
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			var destination = segue.DestinationViewController as RedViewController;

			if (destination != null) {
				destination.Previous = this;
			}
		}
	}
}
