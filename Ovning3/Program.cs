using System;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            
            string fras = "...och sen då? ";
            Console.Write(fras);
            var ch = Console.ReadLine();
            Console.Write("Du tryckte på: ");
            Console.Write(ch + ".");
            Console.Write(" Tryck på Q eller q för att avsluta programmet. ");

            string Quit = "Q";
            string quit = "q";

            for ( ; ; )
            {
                if (!(ch == Quit || ch == quit))
                {
                    fras += fras;
                    Console.Write(fras);
                    ch = Console.ReadLine();
                    Console.Write("Du tryckte på: ");
                    Console.Write(ch + ".");
                    Console.Write(" Tryck på Q eller q för att avsluta programmet. ");
                }
                else if (ch == Quit || ch == quit)
                {
                Console.WriteLine("Du tryckte på Q eller q, programmet avslutas...");
                return;
                }
            
            }
        }
    }
}
