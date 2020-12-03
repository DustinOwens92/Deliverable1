using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Password with 7 to 12 Characters including an Exclamation mark");

            string userPassword = Console.ReadLine();

            if (valpassword(userPassword) && checkpassword(userPassword))
            {
                Console.WriteLine("Password valid and accepted");


            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static Boolean valpassword(string password)
        {

            if (password.Length > 7 && password.Length < 12)
            {

                Console.WriteLine("Length Accepted");
                return true;
            }
            else
            {
                Console.WriteLine("Password is too short or too long");
            }
            return false;



        }
        public static Boolean checkpassword(string password)
        {
            Boolean hasNum = false; Boolean hasCap = false; Boolean hasLow = false; Boolean hasExclamation = false; string c;
            // for (int i = 0; i < password.Length; i++)
            // {
            // c = password[i];
            if (/*Char.IsNumber(c)*/password.Any(Char.IsNumber) && password.Any(Char.IsUpper) && password.Any(Char.IsLower) && password.Contains("!"))
            {
                hasNum = true;
                hasCap = true;
                hasLow = true;
                hasExclamation = true;

            }
            // else if (/*Char.IsUpper(c)*/password.Any(Char.IsUpper))
            // {
            //  hasCap = true;
            // }
            // else if (/*Char.IsLower(c)*/password.Any(Char.IsLower))
            // {
            //  hasLow = true;
            // }
            // else if (password.Contains("!"))
            // {
            //  hasExclamation = true;
            // }




            //  }
            if (hasNum && hasCap && hasLow && hasExclamation)
            {
                Console.WriteLine("Special Character Accepted");
                return true;
            }
            Console.WriteLine("Not acceptable");
            return false;

        }
    }
}