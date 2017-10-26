using System;
using System.Drawing;
using ReadDataFromJson;
using ReadDataFromJson.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginCustomEntry), typeof(LoginCustomEntry_iOS))]
namespace ReadDataFromJson.iOS
{
    public class LoginCustomEntry_iOS:EntryRenderer
    {
        public LoginCustomEntry_iOS()
        {
        }
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				// perform initial setup
				// do whatever you want to the UITextField here!
				Control.BorderStyle = UITextBorderStyle.None;
				Control.AutosizesSubviews = true;

				Control.TextColor = UIColor.FromRGB(155, 155, 155);
				Control.BackgroundColor = UIColor.Clear;
				Control.Font = UIFont.FromName("Arial", 16);
				//Control.Font = UIFont.ItalicSystemFontOfSize(16);

			}

			//var toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, 44.0f, 44.0f));

			//toolbar.Items = new[]
			//{
			//  new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
			//  new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate { Control.ResignFirstResponder(); })
			//};

			//this.Control.InputAccessoryView = toolbar;

		}
    }
}
