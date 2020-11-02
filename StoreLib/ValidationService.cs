using System;
using System.Text.RegularExpressions;

namespace StoreLib
{
    public class ValidationService
    {
        public static void InvalidInput()
        {
            Console.WriteLine("Invalid selection! Please choose a valid option.");
        }

        public static void InvalidUsername() {
            Console.WriteLine("You have entered an incorrect username.");
            Console.WriteLine("Please verify your credentials and try again.");
        }

        public static void InvalidPassword() {
            Console.WriteLine("You have entered an incorrect password.");
            Console.WriteLine("Please verify your credentials and try again.");
        }

        public static Boolean ValidName(string name) {
            if(Regex.IsMatch(name, "[\\d]", RegexOptions.IgnoreCase)) {
                Console.WriteLine("This is not a valid name.");
                Console.WriteLine("Your name should not have numbers.");
                return false;
            } else {
                return true;
            }
        }

        public static Boolean ValidEmail(string email) {
            if(Regex.IsMatch(email, @"^[a-z0-9.]+@[a-z0-9]+[\.][a-z]", RegexOptions.IgnoreCase)) {
                return true;
            } else {
                Console.WriteLine("This is not a valid email address.");
                return false;
            }
        }

        // public static Boolean ValidPassword(string password) {
        //     if(Regex.IsMatch(password, "")) { //TODO edit this to check for letters numbers and spc char w/ at least 8 characters total
        //         Console.WriteLine("Password must include upper and lowercase letters, numbers and a special character.");
        //         Console.WriteLine("Password must also be at least 8 characters long.");
        //         return false;
        //     } else {
        //         return true;
        //     }
        // }



    }
}




