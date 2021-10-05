using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            //programm kuvab konsoolis sõna esimest tähte ja viimast tähte

            Console.WriteLine(helloWorld[0]);

            int helloworldLength = helloWorld.Length;
            Console.WriteLine(helloWorld[helloworldLength - 1]);


        }
    }
}
