namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task5!");

            ElectronicStore store = new ElectronicStore();

            Laptop laptop = new Laptop("Mac", 15000);
            Smartphone smartphone = new Smartphone("Redmi", 1200);

            store.AddDevice(laptop);
            store.AddDevice(smartphone);

            store.ShowAllDeviceDetails();

        }
    }
}
