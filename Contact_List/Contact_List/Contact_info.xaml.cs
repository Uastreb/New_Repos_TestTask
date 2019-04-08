using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact_List
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contact_info : ContentPage
    {
		public Contact_info ()
		{
			InitializeComponent ();
		}

        private void Call(object sender, EventArgs e)
        {
            DependencyService.Get<IPhone>()?.Call(PhoneNumber.Text);
        }
    }
}