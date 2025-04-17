using MVVMassignmentEight.Models;
using MVVMassignmentEight.Models.ViewModels;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Contact = MVVMassignmentEight.Models.Contact;

namespace MVVMassignmentEight.Views
{
    public partial class ContactsPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public ContactsPage(ObservableCollection<Contact> contacts)
        {
            InitializeComponent();
            _contacts = contacts;
            BindingContext = new ContactsPageViewModel(contacts);
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Contact selectedContact)
            {
                await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
            }
        }

        private async void OnAddMoreContacts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(_contacts));
        }
    }
    
}
