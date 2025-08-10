namespace FactoryPattern;

public class BigRig : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("A new big rig is now being built...");
    }
}