using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace MadNavigation
{
	partial class RedViewController : UIViewController
	{
		public RedViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			NavigationItem.LeftBarButtonItem = GenerateBarButton ("Back_arrow.png", 1, (sender, args) => {
				// Doesn't work either flow
				// NavigationController.DismissViewController (true, null);
				// Doesn't work other flow
				NavigationController.PopViewController (true);
				// COME ON! Doesn't work on either flow!
				// DismissViewController (true, null);
				// 
				//NavigationController.PopToViewController (Previous, true);

			});
		}

		protected UIBarButtonItem GenerateBarButton (string imageName, int resize, EventHandler eventHandler)
		{			
			var image = UIImage.FromFile (imageName);
			image.ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal);

			var frame = new CGRect (0, 0, image.Size.Width / resize, image.Size.Height / resize);

			var settingButton = new UIButton (frame);
			settingButton.SetBackgroundImage (image, UIControlState.Normal);
			settingButton.TouchUpInside += (sender, args) => {
				if (eventHandler != null)
					eventHandler(sender, args);
			};

			var barButtonItem = new UIBarButtonItem (settingButton);

			return barButtonItem;
		}

		public UIViewController Previous { get; set; }
	}
}
