using System;
using AgileBits;
using Foundation;
using UIKit;
//using AgileBits;

namespace DemoOnePasswordExtension
{
	[Register("LoginViewController")]
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.onePasswordButton.Hidden = !OnePasswordExtension.SharedExtension.IsAppExtensionAvailable;
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			if (!OnePasswordExtension.SharedExtension.IsAppExtensionAvailable)
			{
				UIAlertController alertController = UIAlertController.Create("1Password is not installed", null, UIAlertControllerStyle.Alert);
				alertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, (alertAction) => { }));
				PresentViewController(alertController, true, null);
			}
		}

		partial void findLoginFromOnePassword(NSObject sender)
		{
			if (OnePasswordExtension.SharedExtension.IsAppExtensionAvailable)
			{
				OnePasswordExtension.SharedExtension.FindLoginForURLString("https://www.acme.com", this, sender, (NSDictionary loginDictionary, NSError error) => 
				{
					if (loginDictionary == null || loginDictionary.Count == 0)
					{
						if (error.Code != AppExtensionErrorCodes.CancelledByUser)
						{
							System.Diagnostics.Debug.WriteLine(@"Error invoking 1Password App Extension for find login: {0}", error);
						}
						return;
					}

					this.usernameTextField.Text = (NSString)loginDictionary[AppExtensionLoginDictionarykeys.UsernameKey];
					this.passwordTextField.Text = (NSString)loginDictionary[AppExtensionLoginDictionarykeys.PasswordKey];
				});	
			}
		}

		/// <summary>
		/// This method for demo filling 1Password login to WebView
		/// You must add an WebView, and should add an Touch event for a button inside to call this
		/// </summary>
		/// <param name="sender">Sender.</param>
		private void DemoWebViewFill(NSObject sender)
		{
			UIWebView webView = new UIWebView();
			OnePasswordExtension.SharedExtension.FillItemIntoWebView(webView, this, sender, false, (bool success, NSError error) => 
			{
				if (!success)
				{
					System.Diagnostics.Debug.WriteLine("Failed to fill into webview: {0}", error);
				}	
			});
		}
	}
}
