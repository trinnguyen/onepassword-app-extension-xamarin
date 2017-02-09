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
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UIButton onePasswordButton { get; set; }

		[Outlet]
		UIKit.UITextField onetimePasswordTextField { get; set; }

		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UITextField usernameTextField { get; set; }

		[Action ("findLoginFromOnePassword:")]
		partial void findLoginFromOnePassword (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (usernameTextField != null) {
				usernameTextField.Dispose ();
				usernameTextField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (onetimePasswordTextField != null) {
				onetimePasswordTextField.Dispose ();
				onetimePasswordTextField = null;
			}

			if (onePasswordButton != null) {
				onePasswordButton.Dispose ();
				onePasswordButton = null;
			}
		}
	}
}
