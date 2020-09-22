using System;

namespace ForLoopName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your name?");
            string userInput = Console.ReadLine().ToUpper();
            char searchCriteria = 'A';
            int counter = 0;

            for(int i = 0; i < userInput.Length; i++)
            {
                if(userInput[i] == searchCriteria)
                {
                    counter = counter + 1;
                }
            }

            if(counter > 0)
            {
                Console.WriteLine($"There are {counter} a's in your text.");
            }else
            {
                Console.WriteLine($"There are no {counter} a's in your text.");
            }
            
        }
    }
}
