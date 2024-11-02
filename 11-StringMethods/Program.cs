using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Case conversion methods

            String fullName = "Ean Dela Cruz";

            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            fullName = fullName.ToLower();
            Console.WriteLine(fullName);

            // Replace method

            String phoneNumber = "123-456-7890";

            phoneNumber.Replace("-", "/"); // Replace the "-" with "/" in the phone number
            Console.WriteLine(phoneNumber);

            // Insert Method

            String userName = fullName.Insert(0, "@"); // Insert "@" at the beginning of the string
            Console.WriteLine(userName);

            // Length Property

            Console.WriteLine(fullName.Length);

            // Substring Method

            String firstName = fullName.Substring(0, 3); // Get the first 3 characters of the string, in this case "Ean"
            Console.WriteLine(firstName);

            String lastName = fullName.Substring(4, 9); // Get the characters starting from the 5th character, in this case "Dela Cruz"
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}