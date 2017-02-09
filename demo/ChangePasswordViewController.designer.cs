// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DemoOnePasswordExtension
{
	[Register ("ChangePasswordViewController")]
	partial class ChangePasswordViewController
	{
		[Outlet]
		UIKit.UITextField confirmPasswordTextField { get; set; }

		[Outlet]
		UIKit.UITextField freshPasswordTextField { get; set; }

		[Outlet]
		UIKit.UITextField oldPasswordTextField { get; set; }

		[Outlet]
		UIKit.UIButton onePasswordButton { get; set; }

		[Action ("changePasswordInOnePassword:")]
		partial void changePasswordInOnePassword (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (oldPasswordTextField != null) {
				oldPasswordTextField.Dispose ();
				oldPasswordTextField = null;
			}

			if (freshPasswordTextField != null) {
				freshPasswordTextField.Dispose ();
				freshPasswordTextField = null;
			}

			if (confirmPasswordTextField != null) {
				confirmPasswordTextField.Dispose ();
				confirmPasswordTextField = null;
			}

			if (onePasswordButton != null) {
				onePasswordButton.Dispose ();
				onePasswordButton = null;
			}
		}
	}
}
