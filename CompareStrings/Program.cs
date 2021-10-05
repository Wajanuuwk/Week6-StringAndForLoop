using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem -eesnimi või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userLastName = Console.ReadLine();


            if (userFirstName.Length < userLastName.Length)
            {
                Console.WriteLine($"Sinu perekonnanimel on {userLastName.Length - userFirstName.Length} sümbolit rohkem kui eesnimel");
            }
            else if (userLastName.Length < userFirstName.Length)
            {
                Console.WriteLine($"Sinu eesnimel on {userFirstName.Length - userLastName.Length} sümbolit rohkem kui perekonnanimel");

            }
            else
            {
                Console.WriteLine("Sama pikad");
            }
        }
    }

}