using MVVMassignmentEight.Models;
using MVVMassignmentEight.Models.ViewModels;    
using Microsoft.Maui.Controls;
using Contact = MVVMassignmentEight.Models.Contact;

namespace MVVMassignmentEight.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(Contact selectedContact)
        {
            InitializeComponent();
            BindingContext = new ContactDetailsPageViewModel(selectedContact);
        }
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
   
}
