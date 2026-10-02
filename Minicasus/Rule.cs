namespace Minicasus;

public class Rule
{
    public string Name { get; set; }
    private string messageOnOffense { get; set; }

    public void notifyOnOffence()
    {
        Console.WriteLine(messageOnOffense);
    }
}