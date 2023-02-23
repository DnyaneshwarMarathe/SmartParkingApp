using SmartParkingApp.ViewModel;

namespace SmartParkingApp.View;

public partial class ParkingPage : ContentPage
{
	public ParkingPage(ParkingViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}