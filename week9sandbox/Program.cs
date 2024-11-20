using System;

class Program
{

    static void Main(string[] args)
    {
        SmartLight bedroomLight = new SmartLight("Bedroom Light");
        bedroomLight.TurnOn();
        System.Threading.Thread.Sleep(2000);
        bedroomLight.DisplayTimeDifference();
        bedroomLight.TurnOff();
        



    }

}