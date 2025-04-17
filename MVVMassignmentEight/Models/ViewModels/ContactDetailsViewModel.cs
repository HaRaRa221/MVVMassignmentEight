using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMassignmentEight.Models;


namespace MVVMassignmentEight.Models.ViewModels
{
    public partial class ContactDetailsPageViewModel : ObservableObject
    {
        [ObservableProperty] private Contact contact;

        public ContactDetailsPageViewModel(Contact contact) 
        {
            Contact = contact;
        }

        [RelayCommand]
        private void Save()
        {
            // Optional: update logic here
        }
    }
}
