using System;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex!");
            //--------------Obj Creation-------------//
            RegularExpression regularExpressions = new RegularExpression();
            regularExpressions.ValidateFirstName("Rasi");
             regularExpressions.ValidateLastName("Priyanka");
            regularExpressions.ValidateEmailAddress("rasi.priyanka@bridgelabz.com");
            regularExpressions.ValidateMobileNum("+91 9326547896");
            regularExpressions.ValidatePassWord("Rasi5678");
            regularExpressions.ValidateUpperCase("RasiPriyanka");
            regularExpressions.ValidateAtleastOneNumber("RasiPriyanka123");
            regularExpressions.ValidateSpecialChar("Rasipendela@43");
        }
    }
}
