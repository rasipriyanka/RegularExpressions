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
            RegularExpression regularExpressions1 = new RegularExpression();
            regularExpressions1.ValidateLastName("Priyanka");
            RegularExpression regularExpressions2 = new RegularExpression();
            regularExpressions1.ValidateEmailAddress("rasi.priyanka@bridgelabz.com");
            RegularExpression regularExpressions3 = new RegularExpression();
            regularExpressions3.ValidateMobileNum("+91 9326547896");
            RegularExpression regularExpressions4 = new RegularExpression();
            regularExpressions4.ValidatePassWord("Rasi5678");
            RegularExpression regularExpressions5 = new RegularExpression();
            regularExpressions5.ValidateUpperCase("RasiPriyanka");
        }
    }
}
