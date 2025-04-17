using MVVMassignmentEight.Models.ViewModels;
using MVVMassignmentEight.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using MVVMassignmentEight.Models.ViewModels;
using MVVMassignmentEight.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Contact = MVVMassignmentEight.Models.Contact;

namespace MVVMassignmentEight.Views
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contact> mContacts;

        public MainPage(ObservableCollection<Contact> contacts)
        {
            InitializeComponent();
            mContacts = contacts;
            BindingContext = new MainPageViewModel(contacts, mContactSaved);
        }
        private async void mContactSaved()
        {
            Navigation.PushAsync(new ContactsPage(mContacts));
        }
        
    }

}
