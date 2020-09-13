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
            int numRows = 10;                        //Anzahl der Zeilen (evtl später als Argument übergeben)


            do
            {
                //Console.Clear();
                Console.WriteLine("Welche Pyramide soll ausgegeben werden?");
                Console.WriteLine("1: Sterne, 2: Ziffer '0' außen, 3: Ziffer '0' innen, 4: Buchstaben, 0: Ende");
                variante = Convert.ToInt32(Console.ReadLine());

                switch (variante)
                {
                    case 1:
                        Sterne(numRows);
                        break;
                    case 2:
                        NullAußen(numRows);
                        break;
                    case 3:
                        NullInnen(numRows);
                        break;
                    case 4:
                        AInnen(numRows);
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
        static void Sterne(int numRows)
        {
            int blanks = numRows - 1;                //Leerzeichen 1. Zeile
            int stars = 1;                           //Anzahl Sterne (in 1. Zeile)
            
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

        static void NullAußen(int numRows)
        {
            int blanks = numRows - 1;                  //Leerzeichen 1. Zeile
            
            Console.WriteLine("'0' außen\n");
            for (int row = 1; row <= numRows; row++)   //row = Zäler der aktuellen Zeile
            {
                string strBlank = new string(' ', blanks);
                string strNums = ""; 
                for (int i = 0; i < row; i++)
                    strNums += Convert.ToString(i);
                for(int i=row-2;i>-1 ; i--)
                    strNums += Convert.ToString(i);

                Console.WriteLine(strBlank + strNums);
                blanks--;
                
            }
        }

        static void NullInnen(int numRows)
        {
            int blanks = numRows - 1;               

            Console.WriteLine("'0' innen\n");
            for (int row = 1; row <= numRows; row++)   
            {
                string strBlank = new string(' ', blanks);
                string strNums = "";
                for (int i = row-1; i >= 0; i--)
                    strNums += Convert.ToString(i);
                for (int i = 1; i < row; i++)
                    strNums += Convert.ToString(i);

                Console.WriteLine(strBlank + strNums);
                blanks--;
            }
        }

        static void AInnen(int numRows)
        {
            int blanks = numRows - 1;               

            Console.WriteLine("'0' innen\n");
            for (int row = 1; row <= numRows; row++)   
            {
                string strBlank = new string(' ', blanks);
                string strChar = ""; 
                for (int i = row - 1; i >= 0; i--)
                    strChar += Convert.ToString(Convert.ToChar(i+65));
                for (int i = 1; i < row; i++)
                    strChar += Convert.ToString(Convert.ToChar(i + 65));

                Console.WriteLine(strBlank + strChar);
                blanks--;
            }
        }
    }
}
