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


            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Teaching();
            nepaliTeacher.Name  = "Ram Bahadur";
            Console.WriteLine("Dai ko Name: " + nepaliTeacher.Name);
            nepaliTeacher.SalaryInfo();

            Console.WriteLine("=========================================\n");

            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Teaching();
            englishTeacher.Name = "Shyam Bahadur";
            Console.WriteLine("Dai ko Name: " + englishTeacher.Name);
            englishTeacher.SalaryInfo();


        }
    }
}
