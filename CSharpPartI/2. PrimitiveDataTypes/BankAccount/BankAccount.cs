using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Alexander";
        string middleName = "Georgiev";
        string lastName = "Stoimenov";
        float balance = 1345.57f;
        string bankName = "First Investment Bank";
        string IBAN = "BG29 NWBK 6016 1331 9268 19";
        string BIC = "2B912 ";
        string firstCreditCard = "American Express, 347836551942260, 12/12";
        string secondCreditCard = "Diners Club, 30227236593821, 01/15";
        string thirdCreditCard = "VISA, 4012888888881881, 06/13";
        Console.WriteLine(firstName);
        Console.WriteLine(middleName);
        Console.WriteLine(lastName);
        Console.WriteLine(balance);
        Console.WriteLine(bankName);
        Console.WriteLine(IBAN);
        Console.WriteLine(BIC);
        Console.WriteLine(firstCreditCard);
        Console.WriteLine(secondCreditCard);
        Console.WriteLine(thirdCreditCard);
    }
}
