using Foundation;
using System;
using UIKit;

namespace iOS.BlockChain
{
    public partial class MedCardViewController : UIViewController
    {
        public MedCardViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Send MedCard request.
            //string url = string.Format("");
            //var user = await FetchObject<UserMap>(url);

            // Handle MedCard response

        }
    }
}