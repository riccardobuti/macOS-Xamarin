using System;

using AppKit;
using Foundation;
using pclLibrary;

namespace macOS
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		partial void clickButton(NSButton sender)
		{
			labelTextField.StringValue = pclLibrary.MyClass.Generate(labelTextField.StringValue, textField.StringValue);
		}
	}
}
