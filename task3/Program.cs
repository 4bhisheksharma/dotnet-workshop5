namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task3: ");

            Printer printer = new Printer();
            printer.Print("Hello, World!");
            printer.Print(36);
            printer.Print("Hello k chha hau", 36);

            Console.WriteLine("=========================================\n");




        }
    }
}
