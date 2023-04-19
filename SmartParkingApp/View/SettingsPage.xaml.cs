using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;
namespace SmartParkingApp.View;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
        Location location = new Location(18.551599745712434, 73.95112670582294);
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
        Map map = new Map(mapSpan);

        Pin pin = new Pin
        {
            Label = "Eon IT Park - Parking",
            Address = "Kharadi, Pune",
            Type = PinType.Place,
            Location = new Location(18.551599745712434, 73.95112670582294)
        };
        map.Pins.Add(pin);

        Content = map;

        pin.InfoWindowClicked += async (s, args) =>
        {
            await Shell.Current.GoToAsync("///ParkingPage");
        };
    }
}