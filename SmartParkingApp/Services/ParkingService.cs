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
        if (parkingList?.Count > 0)
            return parkingList;

        // Online
        //var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
        //if (response.IsSuccessStatusCode)
        //{
        //    parkingList = await response.Content.ReadFromJsonAsync<List<ParkingStatus>>();
        //}

        // Offline
        using var stream = await FileSystem.OpenAppPackageFileAsync("parkingdata.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        parkingList = JsonSerializer.Deserialize<List<ParkingStatus>>(contents);

        return parkingList;
    }
}

