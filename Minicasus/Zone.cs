namespace Minicasus;

public class Zone
{
    public string Name;
    public List<Rule> Rules { get; set; }
    public List<Sensor> Sensors { get; set; }
    public List<Device> Devices { get; set; }

    Zone(string name)
    {
        Name = name;
        Rules = new List<Rule>();
        Sensors = new List<Sensor>();
        Devices = new List<Device>();
    }
}