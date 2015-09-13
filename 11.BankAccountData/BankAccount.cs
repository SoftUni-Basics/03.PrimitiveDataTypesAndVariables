/*  A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Stanimir";
        string middleName = "Mirqnoff";
        string lastName = "Zlobarski";
        decimal balance = 1.23M;
        string bankName = "OBB";
        string personalIBAN = "BG80 BNBG 9661 1020 3456 78";
        ulong firstCreditCard = 378282246310005u;
        ulong secondCreditCard = 371449635398431u;
        ulong thirdCreditCard = 378734493671000u;

        Console.WriteLine(new string('\u2550', 60));
        Console.WriteLine("\t\tPersonal  Bank  Account");
        Console.WriteLine(new string('-', 60));
        Console.WriteLine(@"
          First Name:       {0}
          Midle Name:       {1}
           Last Name:       {2}
             Balance:       {3,8:C2}
           Bank Name:       {4}
       Personal IBAN:       {5}
                Visa:       {6:#### #### #### ####}
          MasterCard:       {7:#### #### #### ####}
    American Express:       {8:#### #### #### ####}"
        , firstName, middleName, lastName, balance, bankName, personalIBAN, firstCreditCard, secondCreditCard, thirdCreditCard);
        Console.WriteLine(new string('\u2550', 60) + "\r\n\r\n");
    }
}
