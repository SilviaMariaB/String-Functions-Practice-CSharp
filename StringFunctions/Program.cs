using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 - Read string and print length

            Console.WriteLine("Please insert a message for character count: ");
            string message = Console.ReadLine();
            Console.WriteLine("The length of your message is " + message.Length);
            Console.WriteLine(message.Length >= 6 ? "Valid" : "Invalid");


            //Exercise 2 - Read & print in reverse

            Console.WriteLine("Please insert a message to reverse: ");
            string message2 = Console.ReadLine();

            for (int i = 0; i < message2.Length; i++)
            {
                Console.Write(message2[i]);
            }

            Console.WriteLine();

            for (int i = message2.Length - 1; i >= 0; i--)
            {
                Console.Write(message2[i]);
            }
            Console.WriteLine();
            //Exercise 3 - password checker

            Console.WriteLine("Please insert your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Please insert your password again: ");
            string password2 = Console.ReadLine();

            while (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please enter a password: ");
                password = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Please enter a password: ");
                password2 = Console.ReadLine();
            }
            if (password == password2)
            {
                Console.WriteLine("Passwords match");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }

            //Exercise 4 Read & print full name + use more than 1 method of concatenation
            Console.WriteLine("Please insert your first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Please insert your last name: ");
            string lName = Console.ReadLine();

            lName = lName.Trim();
            lName = lName.Replace(" ", "");
            lName = lName.ToLower();
            lName = char.ToUpper(lName[0]).ToString() + lName.Substring(1);

            fName = fName.Trim();
            fName = fName.Replace(" ", "");
            fName = fName.ToLower();
            fName = char.ToUpper(fName[0]).ToString() + fName.Substring(1);

            Console.WriteLine($"Your name is {fName} {lName}");
            Console.WriteLine("Your name is {0} {1}", fName, lName);
            Console.WriteLine("Your name is " + string.Concat(fName, " ", lName));
            Console.WriteLine("Your name is " + fName + " " + lName);

            //Exercise 5 Reverse string case
            Console.WriteLine("Please insert a word to reverse it's case:");
            string message3 = Console.ReadLine();
            Console.WriteLine(message3);

            foreach (char ch in message3)
            {
                //Console.WriteLine(char.IsLower(ch)? char.ToUpper(ch) : char.ToLower(ch));
                if (char.IsLower(ch))
                {
                    Console.Write(char.ToUpper(ch));
                }
                if (char.IsUpper(ch))
                {
                    Console.Write(char.ToLower(ch));
                }
            }
            Console.ReadLine();
        }
            
    }
}
