namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much will you like to deposit?");
            var amountToDep = double.Parse(Console.ReadLine());
            account.Deposit(amountToDep);
            Console.WriteLine($"Thank you! Your balance is {account.GetBalance()}");
        }
    }
}
