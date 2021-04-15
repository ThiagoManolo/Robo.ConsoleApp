using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sudokuLinha1 = "1 3 2 5 7 9 4 6 8";
            string sudokuLinha2 = "4 9 8 2 6 1 3 7 5";
            string sudokuLinha3 = "7 5 6 3 8 4 2 1 9";
            string sudokuLinha4 = "6 4 3 1 5 8 7 9 2";
            string sudokuLinha5 = "5 2 1 7 9 3 8 4 6";
            string sudokuLinha6 = "9 8 7 4 2 6 5 3 1";
            string sudokuLinha7 = "2 1 4 9 3 5 6 8 7";
            string sudokuLinha8 = "3 6 5 8 1 7 9 2 4";
            string sudokuLinha9 = "8 7 9 6 4 2 1 5 3";

            string[] caracteresLinha1 = sudokuLinha1.Split(' ');

            char[] linha1Caracteres = sudokuLinha1.ToCharArray();
            char[] linha2Caracteres = sudokuLinha2.ToCharArray();
            char[] linha3Caracteres = sudokuLinha3.ToCharArray();
            char[] linha4Caracteres = sudokuLinha4.ToCharArray();
            char[] linha5Caracteres = sudokuLinha5.ToCharArray();
            char[] linha6Caracteres = sudokuLinha6.ToCharArray();
            char[] linha7Caracteres = sudokuLinha7.ToCharArray();
            char[] linha8Caracteres = sudokuLinha8.ToCharArray();
            char[] linha9Caracteres = sudokuLinha9.ToCharArray();

            double[] numerosLinha1 = Array.ConvertAll(caracteresLinha1, double.Parse);

            double contador = 0;

            for (int i = 1; i < 8; i++)
            {
                
                for (int j = 2; j < 7; j++)
                {
                    
                    for (int k = 3; k < 0; k++)
                    {
                        
                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha1)
                            {
                                Console.WriteLine("Não");
                            }
                        
                        }

                    }
                
                }

                //contador = numerosLinha1[i]++;
                //Console.WriteLine("Soma total: " + contador);

                //Console.ReadLine();
            }
           
        }
    
    }

}
