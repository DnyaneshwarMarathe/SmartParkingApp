namespace SmartParkingApp.Model;

public class ParkingStatus
{
    public string DeviceId { get; set; }

    public string DeviceName { get; set; }

    public string ParkingName { get; set; }

    public int OnOffFlag { get; set; }

    public Color CellColor
    {
        get { return this.OnOffFlag == 0 ? Colors.LightGreen : Colors.LightPink; }
    }

    public bool IsOccupied 
    { 
        get { return this.OnOffFlag == 0 ? false : true; }
    }
}

