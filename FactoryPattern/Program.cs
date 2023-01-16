namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to make a car or motorcycle?");
            var userInput = Console.ReadLine();

            IVehicle factory= VehicleFactory.CreateVehicle(userInput);
            factory.Drive();
            //factory.CreateVehicle(userInput);

            //Console.WriteLine("Lets make another vehicle ");
            //userInput= Console.ReadLine();

        }
    }
}
