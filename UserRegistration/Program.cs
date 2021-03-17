using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public bool validateFirstName(string firstName)
        {
            string pattern = @"^[A-Z]\w{2,}$";
            bool result = Regex.IsMatch(firstName, pattern);
            if(!result)
            {
                throw new UserException("FirstName Validation Failed");
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("Welcome to unit testing of user registration");
            bool result = false;

            Program program = new Program();
            try
            {
                result = program.validateFirstName("Sanjana");
            }
            catch (UserException)
            {
                Console.WriteLine("Exception caught"); 
            }
            
            Console.WriteLine("First name validation result: " + result);
        }
    }
}
