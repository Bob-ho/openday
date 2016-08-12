using Foundation;
using System;
using UIKit;
using MessageUI;

namespace assignment1
{
    public partial class FeedbackViewController : UIViewController
    {
		MFMailComposeViewController mailController;
        public FeedbackViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//Verify that the device is capable of sending mail - ensure you wrap all mail functionality inside the following CanSendMail check:
			if (MFMailComposeViewController.CanSendMail)
			{
				// do mail operations here
				mailController = new MFMailComposeViewController();
				mailController.SetToRecipients(new string[] { "sebe-clouddeakinsupport@deakin.edu.au" });
				mailController.SetSubject("Comment");
				mailController.SetMessageBody("Dear Deakin University", false);
				mailController.Finished += (object s, MFComposeResultEventArgs args) =>
				{
					Console.WriteLine(args.Result.ToString());
					args.Controller.DismissViewController(true, null);
				};
				this.PresentViewController(mailController, true, null);
			}


		}

    }
}