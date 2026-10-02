namespace Minicasus;

public class Sensor: HardwareComponent
{

    public Sensor(string name) :base(name)
    {
        
        logEvent();
    }
    
}
public class Device : HardwareComponent
{
    public Device(string name) : base(name)
    {
        logEvent();
    }
    
    
}

class TemperatureSensor : Sensor
{
    private int Temperature = 0;

    public TemperatureSensor(string name, int temperature) : base(name)
    {
        Temperature = temperature;
    }

    public int Temperature1
    {
        get => Temperature;
        set
        {
            if (Temperature < -20 || Temperature > 60)
            {
                Console.WriteLine("Temperature has to be between -20 and 60 degrees celsius.");
            }
        }
    }
}
class MotionSensor : Sensor
{

    public MotionSensor(string name) : base(name)
    {
    }

    
}
class EnergySensor : Sensor
{

    public EnergySensor(string name) : base(name)
    {
    }

    
}
class DimmableLight : Device
{
    private int Brightness = 0;

    public DimmableLight(string name, int brightness) : base(name)
    {
        this.Brightness = brightness;
    }

    public int Brightness1
    {
        get => Brightness;
        set
        {
            if (Brightness < 0 || Brightness > 100)
            {
                Console.WriteLine("Brightness has to be between 0 and 100.");
            }
        }
        
    }
}
class Thermostat : Device
{

    public Thermostat(string name) : base(name)
    {
    }

    
}
class Ventilator : Device
{

    public Ventilator(string name) : base(name)
    {
    }

    
}

public abstract class HardwareComponent
{
    public static string Name { get; set; }

    public HardwareComponent(string name)
    {
        Name = name;
    }

    public void logEvent()
    {
        Console.WriteLine("Log");
    }
}