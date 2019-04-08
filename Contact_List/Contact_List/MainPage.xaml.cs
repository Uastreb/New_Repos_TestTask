using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contact_List
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            contactsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Contact selectedContact = (Contact)e.SelectedItem;
            Contact_info contact_info = new Contact_info();
            contact_info.BindingContext = selectedContact;
            await Navigation.PushAsync(contact_info);
        }
       

        private async void CreateFriend(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            ContactPage contactPage = new ContactPage();
            contactPage.BindingContext = contact;
            await Navigation.PushAsync(contactPage);
        }
    }
}



        
