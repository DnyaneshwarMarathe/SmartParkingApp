using SmartParkingApp.ViewModel;

namespace SmartParkingApp.View;

public partial class MainPage : ContentPage
{
	public MainPage(ParkingViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}

