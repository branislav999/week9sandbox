public abstract class SmartDevice 
{

    protected string _name;
    protected bool _isOn;
    protected DateTime _setTime;


    public SmartDevice(string name) {

        _name = name;
        _isOn = false;
    }

    public void TurnOn() {
        _isOn = true;
        _setTime = DateTime.Now;
        Console.WriteLine($"{_name} is turned ON.");

    }

    public void TurnOff() {
        _isOn = false;
        Console.WriteLine($"{_name} is turned OFF.");

    }


    public void DisplayTimeDifference() {
        TimeSpan difference = _setTime - DateTime.Now;
        double minutesDifference = Math.Abs(difference.TotalMinutes);
        Console.WriteLine($"The time difference in minutes is: {minutesDifference}.");
    }

    
}