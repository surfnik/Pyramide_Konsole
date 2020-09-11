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
            int stars = 1;                          //Anzahl Sterne (in 1. Zeile)
            
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
            int numRows = 4;                        //Anzahl der Zeilen (evtl später als Argument übergeben)
            int blanks = numRows - 1;               //Leerzeichen 1. Zeile
            int nums = 1;                           //Anzahl Ziffern (in 1. Zeile)
            
            Console.WriteLine("'0' außen\n");
            for (int row = 1; row <= numRows; row++)   //row = Zäler der aktuellen Zeile
            {
                string strBlank = new string(' ', blanks);
                string strNums = ""; //new string('0',1);
                for (int i = 0; i < row; i++)
                    strNums += Convert.ToString(i);
                for(int i=row-2;i>-1 ; i--)
                    strNums += Convert.ToString(i);

                Console.WriteLine(strBlank + strNums);
                blanks--;
                
            }
        }

        static void NullInnen()
        {
            Console.WriteLine("'0' innen\n");
        }
    }
}
