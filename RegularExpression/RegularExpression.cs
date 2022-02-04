//-------Dependencies-----------//
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
//------Namespace----------//
namespace RegularExpression
{
    //--------Class-------//
    internal class RegularExpression
    {
        //----------First Name-------------//
        public static string FirstName = "^[A-Z][A-Z a-z]{3,}$";
        //  method is used for validating first name
        //----------Method Starts------------//
        public void ValidateFirstName(string firstName)

        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("{0} is valid", firstName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
            }
            //----------Method Ends here-------------//
        }

        //-----------------Last Name---------------//
        public static string LastName = "^[A-Z][A-Z a-z]{3,}$";
        //  method is used for validating first name
        //----------Method Starts Here------------//
        public void ValidateLastName(string lastName)

        {
            if (Regex.IsMatch(lastName, LastName))
            {
                Console.WriteLine("{0} is valid", lastName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", lastName);
            }
        }
        //----------Method Ends here-------------//

        // Validating Email
        public static string EmailAddress = @"^([A-Za-z0-9]*\.[A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3})+)$";
        //----------Method Starts Here------------//
        public void ValidateEmailAddress(string email)//-Validating the EmailAddres
        {
            if (Regex.IsMatch(email, EmailAddress))
            {
                Console.WriteLine("{0} is valid", email);
                Console.WriteLine("Email :", email);

            }
            else
            {
                Console.WriteLine("{0} is not valid");
            }
            //----------Method Ends here-------------//
        }

        //-------------Mobile Number--------//
        public static string MobileNum = @"^([\+][0-9]{2}\s*[0-9]{10})$";
        //----------Method Starts Here------------//
        // this method used for the validating mobile number
        public void ValidateMobileNum(string mobile)
        {
            if (Regex.IsMatch(mobile, MobileNum))
            {
                Console.WriteLine("{0} is valid", mobile);
            }
            else
            {
                Console.WriteLine("{0} is not valid", mobile);
            }
            //----------Method Ends here-------------//
        }

        //----------Validating Password-------//
        public static string Password = @"^[A-Za-z0-9]{8,}$";
        //----------Method Starts Here------------//
        // this method used for the validating password
        public void ValidatePassWord(string password)
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("{0} is valid", password);
                Console.WriteLine("Password :", password);
            }
            else
            {
                Console.WriteLine("{0} is not valid", password);
            }
            //----------Method Ends here-------------//
        }
        //-----------Upper Case----------//
        public static string UpperCase = @"^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
        // this method used for the validating password atleast one upper case 
        //---------Method Starts-------------//
        public void ValidateUpperCase(string password)
        {
            if (Regex.IsMatch(password, UpperCase))
            {
                Console.WriteLine("{0} is valid", password);
                Console.WriteLine("Password :"+ password);
            }
            else
            {
                Console.WriteLine("{0} is not valid", password);

            }
            //-------Method Ends-------------//
        }
    }
}



           
       

