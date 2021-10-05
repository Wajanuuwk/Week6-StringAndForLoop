using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema eesnimi
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine(firstName[0]);

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Teie nimi on {firstNameLength} sümbolit pikk");

            //viimase tähe indeks = firstNameLength - 1
            Console.WriteLine(firstName[firstNameLength-1]);
        }
    }
}
