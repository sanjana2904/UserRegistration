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

        public bool validateEmail(string name)
        {
            string pattern = @"^[\w]+@[a-zA-Z0-9]+.[a-zA-Z0-9]+";
            bool result = Regex.IsMatch(name, pattern);
            return result;
        }
        public bool validatePhoneNumber(string number)
        {
            string pattern = @"^\d{2}\s\d{10}$";
            bool result = Regex.IsMatch(number, pattern);
            return result;
        }

        public bool validatePassword(string password)
        {
           string pattern = @"^.{8,}$";
            bool result = Regex.IsMatch(password, pattern);
            return result;
        }

        public bool validateUppercase(string uppercase)
        {
            string pattern = @"^(?=.*[A-Z]).{8,}$";
            bool result = Regex.IsMatch(uppercase, pattern);
            return result;
        }

        public bool validateNumericcase(string name)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
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
            result = program.validateEmail("sanju@gmail.com");
            Console.WriteLine("Email name validation result: " + result);
            result = program.validatePhoneNumber("91 7708796223");
            Console.WriteLine("Phone Number validation result: " + result);
            result = program.validatePassword("sanjanaks");
            Console.WriteLine("Password validation result: " + result);
            result = program.validateUppercase("saNjanaks");
            Console.WriteLine("Uppercase validation result: " + result);
            result = program.validateNumericcase("sanjana5ks");
            Console.WriteLine("Numeric case validation result: " + result);
        }
    }
}
