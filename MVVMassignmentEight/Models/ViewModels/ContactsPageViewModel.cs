using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMassignmentEight.Models;
using System.Collections.ObjectModel;

namespace MVVMassignmentEight.Models.ViewModels
{
    public partial class ContactsPageViewModel : ObservableObject
    {
        public ObservableCollection<Contact> Contacts { get; }
        public ContactsPageViewModel(ObservableCollection<Contact> contacts)
        {
            Contacts = contacts;
        }
        
    }
}
