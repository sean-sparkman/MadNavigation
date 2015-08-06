using System;
using UIKit;

namespace MadNavigation
{
	public class RootTabViewController
		: UITabBarController
	{
		public static UIStoryboard firstStoryboard = UIStoryboard.FromName ("First", null);
		public static UIStoryboard secondStoryboard = UIStoryboard.FromName ("Second", null);
		UIViewController first;
		UIViewController second;
		public RootTabViewController ()
		{
			first = firstStoryboard.InstantiateInitialViewController ();
			second = secondStoryboard.InstantiateInitialViewController ();
			ViewControllers = new UIViewController[] { 
				first, second
			};
			first.TabBarItem.Title = "AWESOME";
			second.TabBarItem.Title = "POSSUM";
			SelectedViewController = first;
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}
	}
}

