using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMassignmentEight.Models;
using System.Collections.ObjectModel;

namespace MVVMassignmentEight.Models.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly ObservableCollection<Contact> mcontacts;
        private readonly Action mContactSaved;

        public MainPageViewModel(ObservableCollection<Contact> contacts, Action contactSaved)
        {
            mcontacts = contacts;
            mContactSaved = contactSaved;
            
        }

        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string phoneNumber;
        [ObservableProperty] private string description;

        [RelayCommand]
        private void SaveContact()
        { 
            mcontacts.Add(new Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            });
            mContactSaved?.Invoke();

        }
    }
}
