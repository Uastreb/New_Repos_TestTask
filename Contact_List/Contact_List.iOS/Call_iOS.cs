using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Contact_List.iOS.Call_iOS))]
namespace Contact_List.iOS
{
    class Call_iOS
    {
        public Task Call(string phoneNumber)
        {
            var nsurl = new NSUrl(new Uri($"tel:{phoneNumber}").AbsoluteUri);
            if (!string.IsNullOrWhiteSpace(phoneNumber) &&
                    UIApplication.SharedApplication.CanOpenUrl(nsurl))
            {
                UIApplication.SharedApplication.OpenUrl(nsurl);
            }
            return Task.FromResult(true);
        }
    }
}