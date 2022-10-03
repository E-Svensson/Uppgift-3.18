using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            Console.WriteLine(" ");

            Console.Write("Skriv här: "); string namn1 = Console.ReadLine();
            Console.WriteLine(" ");

            string[] namn2 = namn1.Split(" ");

            if (namn2[0].CompareTo(namn2[1]) < 0)
            {
                Console.WriteLine($"Ditt förnamn ({namn2[0]}) kommer före ditt efternamn ({namn2[1]}) i bokstavsordning.");
            }

            else if (namn2[0].CompareTo(namn2[1]) == 0)
            {
                Console.WriteLine($"Ditt förnamn och efternamn är samma namn? ({namn2[0]})");
            }

            else
            {
                Console.WriteLine($"Ditt efternamn ({namn2[1]}) kommer före ditt förnamn ({namn2[0]}) i bokstavsordning.");
            }
        }
    }
}
