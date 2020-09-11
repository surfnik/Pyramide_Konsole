using System;
using System.Data;
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
                //Console.Clear();
                Console.WriteLine("Welche Pyramide soll ausgegeben werden?");
                Console.WriteLine("1: Sterne, 2: Ziffer '0' außen, 3: Ziffer '0' innen, 0: Ende");
                variante = Convert.ToInt32(Console.ReadLine());

                switch (variante)
                {
                    case 1:
                        Sterne();
                        break;
                    case 2:
                        NullAußen();
                        break;
                    case 3:
                        NullInnen();
                        break;
                    case 0:
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
        static void Sterne()
        {
            int numRows = 12;                        //Anzahl der Zeilen (evtl später als Argument übergeben)
            int blanks = numRows - 1;               //Leerzeichen 1. Zeile
            int stars = 1;                          //Sterne in 1. Zeile
            Console.WriteLine("Sterne\n");
            for(int row =1;row <= numRows; row++)   //row = Zäler der aktuellen Zeile
            {
                string strBlank = new string(' ', blanks);
                string strStars = new string('*', stars);
                Console.WriteLine(strBlank + strStars);
                blanks--;
                stars += 2;
            }
        }

        static void NullAußen()
        {
            Console.WriteLine("'0' außen\n");
        }

        static void NullInnen()
        {
            Console.WriteLine("'0' innen\n");
        }
    }
}
