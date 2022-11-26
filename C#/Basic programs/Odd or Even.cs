using System;
 
namespace oddeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.Write("Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Number is an Odd Number");
                Console.Read();
            }
        }
    }
}