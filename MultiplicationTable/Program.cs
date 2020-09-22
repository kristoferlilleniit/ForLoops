using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int userNumber = Int32.Parse(Console.ReadLine());
             
            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"{userNumber} X {i} = {userNumber*i}");
            }
        }
    }
}
