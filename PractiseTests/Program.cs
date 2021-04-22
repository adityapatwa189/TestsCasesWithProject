using System;
namespace PractiseTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number for sum of all digits : ");
            //long num = long.Parse(Console.ReadLine());
            //SumOfDigits s = new SumOfDigits();
            //Console.WriteLine("result is : {0}", s.DigitSum(num));

            string fname, lname;
            Console.Write("First Name: ");
            fname = Console.ReadLine();
            Console.Write("Last name: ");
            lname = Console.ReadLine();
            StringOperations str = new StringOperations();
            Console.WriteLine("result : " + str.Concat(fname, lname));


        }
    }
}
