  
class Campus
{
    string Name {get; set;}
    List<Building> Buildings {get; set;}
    Campus(string name)
    {
        this.Name = name;
        this.Buildings = new List<Building>();
    }

}

class Building
{
    string Name { get; set; }
    public List<Zone> Zones { get; set; }

    Building(string name)
    {
        this.Name = name;
        this.Zones = new List<Zone>();
    }
}

class Zone
{
    public string Name;
    public List<Rule> Rules { get; set; }
    public List<Sensor> Sensors { get; set; }
    public List<Device> Devices { get; set; }

    Zone(string name)
    {
        this.Name = name;
        this.Rules = new List<Rule>();
        this.Sensors = new List<Sensor>();
        this.Devices = new List<Device>();
    }
}

class Rule
{
    public string Name { get; set; }
    private string messageOnOffense { get; set; }
    

    public void notifyOnOffence()
    {
        Console.WriteLine(this.messageOnOffense);
    }
}

class Sensor: HardwareComponent
{
    public string Name { get; set; }

    Sensor(string name)
    {
        this.Name = name;
        this.logEvent();
    }
    
}
class Device : HardwareComponent
{
    public string Name { get; set; }
    Device(string name)
    {
        this.Name = name;
        this.logEvent();
    }
    
}

class HardwareComponent
{
    public string Name { get; set; }

    public void logEvent()
    {
        Console.WriteLine("Log");
    }
}