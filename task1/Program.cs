namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task1\n");

            BankAccount account = new BankAccount(123456, 2500000.0);

            Console.WriteLine($"Hello User, Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance}\n");

            account.Deposit(50000.0);
            Console.WriteLine($"Balance after deposit: {account.Balance}");

            account.Withdraw(4000.0);
            Console.WriteLine($"Balance after withdrawal: {account.Balance}");
        }
    }
}
