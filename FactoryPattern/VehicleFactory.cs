namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle VehicleBuilder(string vehicleType)
    {
        switch (vehicleType)
        {
            case "4":
                return new Car();
            case "2":
                return new Motorcycle();
            case "18":
                return new BigRig();
            default:
                return new NoVehicle();
        }
    }
}