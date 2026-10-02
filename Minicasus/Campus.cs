namespace Minicasus;
using Minicasus; 

public class Campus
{
    public string Name {get; set;}
    public List<Building> Buildings {get; set;}
    Campus(string name)
    {
        Name = name;
        Buildings = new List<Minicasus.Building>();
    }

}