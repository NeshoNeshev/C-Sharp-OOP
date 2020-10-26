namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new CrossMotorcycle(140,100);
            car.Drive(40);
            
            System.Console.WriteLine(car.Fuel);
        }
    }
}
