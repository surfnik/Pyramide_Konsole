using System;
using System.Dynamic;

namespace Pyramide_Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int variante = 0;

            do
            {
                Console.WriteLine("Welche Pyramide soll ausgegeben werden?");
                Console.WriteLine("1: Sterne, 2: Ziffer '0' außen, 3: Ziffer '0' innen, 0: Ende");
                variante = Convert.ToInt32(Console.ReadLine());

                switch (variante)
                {
                    case 1:
                        Console.WriteLine("Sterne");
                        break;
                    case 2:
                        Console.WriteLine("'0' außen");
                        break;
                    case 3:
                        Console.WriteLine("'0' innen");
                        break;
                    default:
                        Console.WriteLine("Hä??");
                        break;
                }
            }
            while (variante !=0);
            Console.WriteLine("Ende");
            Console.ReadKey();

        }
    }
}
