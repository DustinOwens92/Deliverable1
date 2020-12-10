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

            if (userPassword.Length >= 7 && userPassword.Length <= 12)
            {
                if (checkpassword(userPassword))
                {
                    Console.WriteLine("Password valid and accepted");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static Boolean checkpassword(string password)
        {

            if (password.Any(Char.IsUpper) && password.Any(Char.IsLower) && password.Contains("!"))
            {
                return true;
            }
            return false;

        }
    }
}