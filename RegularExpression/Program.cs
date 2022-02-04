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
            regularExpressions1.ValidateFirstName("Priyanka");
        }
    }
}
