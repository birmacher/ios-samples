// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace HomeKitIntro
{
	[Register ("CharacteristicCellSwitch")]
	partial class CharacteristicCellSwitch
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel SubTitle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch Switch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Title { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (SubTitle != null) {
				SubTitle.Dispose ();
				SubTitle = null;
			}
			if (Switch != null) {
				Switch.Dispose ();
				Switch = null;
			}
			if (Title != null) {
				Title.Dispose ();
				Title = null;
			}
		}
	}
}
