using Minicasus;
Console.WriteLine("Hele mooie vraag");

public class LogBook<T>
{
    public List<T> LogList { get; private set; }

    public LogBook()
    {
        LogList = new List<T>();
    }
    
    public void logEvent(T loggable){
        LogList.Add(loggable);
    }

    public void ShowAllLogs()
    {
        foreach (var T in LogList)
        {
            Console.WriteLine();
        }
    }
}