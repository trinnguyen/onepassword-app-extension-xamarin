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
	[Register ("RegisterViewController")]
	partial class RegisterViewController
	{
		[Outlet]
		UIKit.UITextField firstnameTextField { get; set; }

		[Outlet]
		UIKit.UITextField lastnameTextField { get; set; }

		[Outlet]
		UIKit.UIButton onePasswordButton { get; set; }

		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UITextField usernameTextField { get; set; }

		[Action ("saveLoginToOnePassword:")]
		partial void saveLoginToOnePassword (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (firstnameTextField != null) {
				firstnameTextField.Dispose ();
				firstnameTextField = null;
			}

			if (lastnameTextField != null) {
				lastnameTextField.Dispose ();
				lastnameTextField = null;
			}

			if (usernameTextField != null) {
				usernameTextField.Dispose ();
				usernameTextField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (onePasswordButton != null) {
				onePasswordButton.Dispose ();
				onePasswordButton = null;
			}
		}
	}
}
