namespace FactoryPattern;

public class NoVehicle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("No vehicle can be built with this many tires at this facility.");
    }
}