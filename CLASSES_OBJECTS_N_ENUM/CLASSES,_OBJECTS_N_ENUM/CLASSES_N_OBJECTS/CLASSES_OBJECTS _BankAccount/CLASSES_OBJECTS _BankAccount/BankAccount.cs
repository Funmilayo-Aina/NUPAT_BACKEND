using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES_OBJECTS__BankAccount
{
    public enum AccountType
    {
        Savings,
        Checkings
    }
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }
        public AccountType AccountType { get; set; }

        //Create an enum AccountType with values: •	Savings
        // •Checking

        //class constructor
        public BankAccount(string accountNumber, string accountHolder, AccountType AccountType, decimal previousBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolder = accountHolder;
            this.Balance = previousBalance;
            AccountType = AccountType;

        }
        //*The BankAccount class should have methods:
        // •	Deposit (increase balance)
        // •	Withdraw (decrease balance)
        // */

        //Deposit (increase balance)
        public void Deposit(decimal valueAmount)
        {
            if (valueAmount <=0)
            {
                Console.WriteLine("This account is too low ");
                return;
            }

            Balance += valueAmount;
            Console.WriteLine($"You have deposited: {valueAmount} \n Your current balance is {Balance}");
        }
        //Withdraw (decrease balance)
        public void Withdraw(decimal valueAmount)
        {
            if (valueAmount<=0)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            Balance -= valueAmount;
            Console.WriteLine(
                $"{valueAmount} withdrawn have been withdrawn from your account \n The new balance is: {Balance}");
        }
    }
}
