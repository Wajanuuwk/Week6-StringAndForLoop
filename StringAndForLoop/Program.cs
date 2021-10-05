using System;

namespace StringAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for(int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine(firstName[i]);
            }
        }
    }
} 
