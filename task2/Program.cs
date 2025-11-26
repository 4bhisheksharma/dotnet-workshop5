namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task2: ");

            Bike bike = new Bike
            {
                Brand = "BhatBhate",
                Speed = 20.5,
                Seats = 8
            };
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();


            Console.WriteLine("==========================================\n");

            Car car = new Car
            {
                Brand = "Maruti 800",
                Speed = 80.0,
                Doors = 4
            };
            car.Start();
            car.DisplayInfo();
            car.Stop();

        }
    }
}
