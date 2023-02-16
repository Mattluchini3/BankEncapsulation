namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var matthewsaccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            matthewsaccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you your balance is now {matthewsaccount.GetBalance()}");
        }
    }
}
