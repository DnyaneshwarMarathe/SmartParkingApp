using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SmartParkingApp.ViewModel
{
    public partial class ParkingSiteViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("///ParkingPage");
        }
    }
}
