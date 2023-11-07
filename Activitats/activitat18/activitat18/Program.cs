/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 25/10/2023
 * Exercici X. Enunciat de l’exercici que es resol
 *
 */


using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication
{

    class Stats
    {
        static void Main()
        {

            const int minHP = 1, maxHP = 1000, minPower = 100, maxPower = 500, minStrength = 20, maxStrength = 50, Rows = 1, Cols = 3;


            const string MsgHP = "Introdueix la vida del personatge (1 - 1000): ";
            const string MsgPower = "Introdueix el poder del personatge (100 - 500): ";
            const string MsgStrength = "Introdueix la força del personatge (20 - 50): ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[,] stats = new int[Rows, Cols];

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    if(j == 0)
                    {
                        do
                        {
                            Console.Write(MsgHP);
                            stats[i, j] = Convert.ToInt32(Console.ReadLine());
                        } while (stats[i, j] > maxHP || stats[i, j] < minHP);
                        
                    }
                    else if(j == 1)
                    {
                        do
                        {
                            Console.Write(MsgPower);
                            stats[i, j] = Convert.ToInt32(Console.ReadLine());
                        } while (stats[i, j] > maxPower || stats[i, j] < minPower);
                    }
                    else
                    {
                        do
                        {
                            Console.Write(MsgStrength);
                            stats[i, j] = Convert.ToInt32(Console.ReadLine());
                        } while (stats[i, j] > maxStrength || stats[i, j] < minStrength);
                    }
                }
            }

            Console.WriteLine("\t\t" + "Vida\t" + "Poder\t" + "Força\t");

            for(int i = 0; i < Rows; i++)
            {
                Console.Write("Personatge " + i + " -\t");
                for(int j = 0; j < Cols; j++)
                {
                    Console.Write(stats[i, j] + "\t");
                }
                Console.WriteLine();
            }
            


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
