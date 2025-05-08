using System.Security.Principal;

namespace CLASSES_OBJECTS__BankAccount
{
    internal class Program
    {
        /*CLASSES, OBJECTS AND ENUM ASSIGNMENT
           Create a class called BankAccount with the following properties:
           •	AccountNumber (string)
           •	AccountHolder (string)
           •	AccountType (use an enum)
           •	Balance (decimal)
           Create an enum AccountType with values:
           •	Savings
           •	Checking
           The BankAccount class should have methods:
           •	Deposit (increase balance)
           •	Withdraw (decrease balance)
           
           In the Main method, create a bank account object, deposit some money, and withdraw an amount.
           INSTRUCTIONS:
           1.	Define the BankAccount class with the properties mentioned.
           2.	Create the AccountType enum with Savings and Checking.
           3.	Add methods for Deposit and Withdraw.
           4.	In the Main method, create a BankAccount object, perform a deposit and withdrawal, and display the final balance.
           */
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;
            var account1 = new BankAccount("01234567890","Testing Mule", AccountType.Savings,3000000m);
            Console.WriteLine($"Account Holder: {account1.AccountHolder}");
            Console.WriteLine($"Account Number: {account1.AccountNumber}");
            Console.WriteLine($"Account Type: {account1.AccountType}");
            Console.WriteLine($"Previous Balance: {account1.Balance}");


            // Testing the account
            account1.Deposit(100000m);
            account1.Withdraw(5000m);
        }
    }
}
