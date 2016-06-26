// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace macOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField labelTextField { get; set; }

		[Outlet]
		AppKit.NSTextField textField { get; set; }

		[Action ("clickButton:")]
		partial void clickButton (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}

			if (labelTextField != null) {
				labelTextField.Dispose ();
				labelTextField = null;
			}
		}
	}
}
