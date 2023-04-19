using SmartParkingApp.ViewModel;

namespace SmartParkingApp.View;

public partial class ParkingSiteMapViewPage : ContentPage
{
	public ParkingSiteMapViewPage(ParkingSiteViewModel parkingSiteViewModel)
	{
		InitializeComponent();
        BindingContext = parkingSiteViewModel;
    }
}