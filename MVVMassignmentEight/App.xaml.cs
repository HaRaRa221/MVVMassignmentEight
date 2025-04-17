using MVVMassignmentEight.Models;
using MVVMassignmentEight.Views;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Contact = MVVMassignmentEight.Models.Contact;


namespace MVVMassignmentEight
{
    public partial class App : Application
    {
        private ObservableCollection<Contact> mContacts = new();
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new MainPage(mContacts)));
        }
    }
}