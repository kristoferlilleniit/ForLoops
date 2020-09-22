using System;

namespace ForLoopString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i+1}. {name[i]}");
            }
        }
    }
}
