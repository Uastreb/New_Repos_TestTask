using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact_List
{
	public partial class ContactPage : ContentPage
    {

        public ContactPage()
		{
			InitializeComponent();
		}

        private void Call(object sender, EventArgs e)
        {
           DependencyService.Get<IPhone>()?.Call(PhoneNumber.Text);
        }

        private void SaveContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            if (!String.IsNullOrEmpty(contact.Name))
            {
                App.Database.SaveItem(contact);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            App.Database.DeleteItem(contact.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}