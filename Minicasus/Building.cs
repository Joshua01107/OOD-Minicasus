namespace Minicasus;

public class Building
{
    public string Name { get; set; }
    public List<Zone> Zones { get; set; }

    Building(string name)
    {
        Name = name;
        Zones = new List<Zone>();
    }
}