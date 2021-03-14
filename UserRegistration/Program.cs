using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public bool validateName(string name)
        {
            string pattern = @"^[A-Z]\w{2,}$";
            bool result = Regex.IsMatch(name, pattern);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("Welcome to unit testing of user registration");
            bool result;

            Program program = new Program();
            result = program.validateName("Sanjana");
            Console.WriteLine("First name validation result: " + result);
        }
    }
}
