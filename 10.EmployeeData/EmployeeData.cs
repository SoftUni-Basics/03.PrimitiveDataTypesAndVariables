/*  A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        First name, Last name, Age (0...100), Gender (m or f), 
        Personal ID number (e.g. 8306112507)
        Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
 */

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Amanda";
        string lastName = "Jonson";
        int age = 27;
        string gender = "F";
        string personID = "8306112507";
        ulong minNumb = 27560000;
        ulong maxNumb = 27569999;

        while (minNumb <= maxNumb)
        {
            Console.WriteLine(new string('\u2550', 48));
            Console.WriteLine("            Person Number  :" + minNumb);
            Console.WriteLine(new string('-', 48));
            Console.WriteLine(@"
            First Name:           {0}
             Last Name:           {1}
                   Age:           {2} 
                Gender:           {3}
      Person ID number:           {4}
Unique Employee number:           {5}"
            , firstName, lastName, age, gender, personID, minNumb);
            Console.WriteLine(new string('\u2550', 48) + "\r\n\r\n");

            Console.WriteLine("\"9\" to continue.\r\n\"0\" to Exit ");
            string nextEmployee = Console.ReadLine();
            if (nextEmployee == "9")
            {
                minNumb++;
                Console.Clear();
                firstName = AddingFirstName();
                lastName = AddingLastName();
                age = AddingAge();
                gender = AddingGender();
                personID = AddingID(age);
            }
            else if (nextEmployee == "0")
            {
                break;
            }
            Console.Clear();
        }
    }

    static string AddingFirstName()
    {
        Console.Clear();
        Console.Write("Enther first name: ");
        string newFirstName = Console.ReadLine();
        return newFirstName;
    }

    static string AddingLastName()
    {
        Console.Clear();
        Console.Write("Enther last name: ");
        string newLastName = Console.ReadLine();
        return newLastName;
    }

    static int AddingAge()
    {
        Console.Clear();
        Console.Write("Enther Age: ");
        string newAge = Console.ReadLine();
        int age;
        bool res = int.TryParse(newAge, out age);
        if (age >= 1 && age <= 99)
        {
            return age;
        }
        Console.WriteLine("Please enter correct Age.");
        System.Threading.Thread.Sleep(2000);
        return AddingAge();
    }

    static string AddingGender()
    {
        Console.Clear();
        Console.Write("Enther Gender (M/F): ");
        string newGender = Console.ReadLine();
        if (newGender == "F" || newGender == "f" || newGender == "M" || newGender == "m")
        {
            return newGender.ToUpper();
        }
        Console.WriteLine("Please enter correct Gender.");
        System.Threading.Thread.Sleep(2000);
        return AddingGender();
    }

    private static string AddingID(int age)
    {
        Random rnd = new Random();
        int days = rnd.Next(1, 30);
        int months = rnd.Next(1, 13);
        int unique = rnd.Next(1212, 9898);
        string employeeID = age.ToString().PadLeft(2, '0') + days.ToString().PadLeft(2, '0') 
            + months.ToString().PadLeft(2, '0') + unique.ToString().PadLeft(4, '0');
        return employeeID;
    }
}