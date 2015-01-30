/*A bank account has a holder name (first name, middle name and last name), 
available amount of money (balance), bank name, IBAN, 
3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account 
using the appropriate data types and descriptive names.*/
using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Petar";
        string secondName = "Petrov";
        string lastName = "Vasilev";
        object holderName = firstName + " " + secondName + " " + lastName;
        decimal balance = 3000.20m;
        string bankName = "DSK";
        string iban = "BH56AAAA00000123456789";
        long firstCreditCard = 0978984662075435;
        long secondCreditCard = 8561961479184018;
        long thirdCreditCard = 5782273590399031;

        Console.WriteLine("Account holder: " + holderName
            + "\nBalance: " + balance
            + " BGN\nBank: " + bankName
            + "\nIBAN: " + iban
            + "\nCredit card 1: " + firstCreditCard
            + "\nCredit card 2: " + secondCreditCard
            + "\nCredit card 3: " + thirdCreditCard);
    }
}

