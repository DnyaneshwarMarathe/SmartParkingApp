using SmartParkingApp.Model;
using System.Net.Http.Json;
using System.Text.Json;

namespace SmartParkingApp.Services;

public class ParkingService
{
    HttpClient httpClient;
    public ParkingService()
    {
        this.httpClient = new HttpClient();
    }

    List<ParkingStatus> parkingList;
    public async Task<List<ParkingStatus>> GetParkingStatus()
    {
        // Online
        var response = await httpClient.GetAsync("http://192.168.0.104:1880/GetParkingData");
        if (response.IsSuccessStatusCode)
        {
            parkingList = await response.Content.ReadFromJsonAsync<List<ParkingStatus>>();
        }

        // Offline
        //using var stream = await FileSystem.OpenAppPackageFileAsync("parkingdata.json");
        //using var reader = new StreamReader(stream);
        //var contents = await reader.ReadToEndAsync();
        //parkingList = JsonSerializer.Deserialize<List<ParkingStatus>>(contents);

        return parkingList;
    }
}

