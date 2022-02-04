//-------Dependencies-----------//
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
//------Namespace----------//
namespace RegularExpression
{
    //--------Class-------//
    class RegularExpression
    {
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
    }
}
