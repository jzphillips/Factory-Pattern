namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you want on your vehicle? ('4', '2', '18')");
            
            string vehicleType = Console.ReadLine();
            var vehicle = VehicleFactory.VehicleBuilder(vehicleType);

            vehicle.Drive();
        }
    }
}
