namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task4: ");

            Car car = new Car();
            Console.WriteLine("For Car: ");
            car.StartEngine();
            car.Display();
            car.StopEngine();

            Bike bike = new Bike();
            Console.WriteLine("For Bike: ");
            bike.StartEngine();
            bike.Display();
            bike.StopEngine();




        }
    }
}
