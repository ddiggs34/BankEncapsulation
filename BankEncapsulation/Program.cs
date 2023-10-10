using BankEncapsulation;

namespace BankEncapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a test. Enter your name here.");

            var username = new BankAccount();
            username.name = Console.ReadLine();

            Console.Write($"Hello, {username.name}. ");

            while (true)

            {
                Console.WriteLine("Would you like to make a deposit? 'Yes' or 'No'?");
                string userInput = Console.ReadLine();

                if (string.Equals(userInput, "yes", StringComparison.OrdinalIgnoreCase))  // user types 'yes' (no matter if it upper or lower case"

                {
                    Console.WriteLine("How much would you like to deposit?");
                    break;
                }
                else if

                    (string.Equals(userInput, "no", StringComparison.OrdinalIgnoreCase)) // OR user types 'no (no matter if it is upper or lower case)

                {
                    Console.WriteLine("Have a nice day");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please type 'yes' or 'no'"); // OR user types something else, it is labeled INVALID
                }
            }

             double dollarAmount = double.Parse(Console.ReadLine());
            
            username.Deposit(dollarAmount); //put a user response in the parathesis!!!!!!

            Console.WriteLine($"Your new balance is ${username.GetBalance()}. Have a nice day");



        }
    }
}
