using CommunityToolkit.Mvvm.Input;
using SmartParkingApp.ViewModel;
using SmartParkingApp.Model;
using SmartParkingApp.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace SmartParkingApp.ViewModel;

public partial class ParkingViewModel : BaseViewModel
{
    public ObservableCollection<ParkingStatus> Parkings { get; } = new();
    ParkingService parkingService;
    public ParkingViewModel(ParkingService parkingService)
    {
        Title = "Parking App";
        this.parkingService = parkingService;
    }

    [RelayCommand]
    async Task GetParkingStatusAsync()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var parkings = await parkingService.GetParkingStatus();

            if (Parkings.Count != 0)
                Parkings.Clear();

            foreach (var parking in parkings)
                Parkings.Add(parking);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get Parkings: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }

    }
}

