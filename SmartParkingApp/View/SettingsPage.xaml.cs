using Map = Microsoft.Maui.Controls.Maps.Map;
namespace SmartParkingApp.View;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
        Map map = new Map();
        Content = map;
    }
}