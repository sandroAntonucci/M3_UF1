/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 30/10/2023
 * Exercici 20. Especifica un algorisme que demani a l’usuari que introdueixi els números d’una matriu de 7 files per 3 columnes (compresos entre 1 i 9 inclosos) per teclat. Una vegada la matriu estigui omplerta, cal que el vostre programa mostri la matriu trasposta (només els valors, sense els claudàtors).
 *
 */


using System;

namespace MyApplication
{

    class ReverseMatrix
    {
        static void Main()
        {

            const int Rows = 5, Cols = 3;

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num;
            int[,] nums = new int[Rows, Cols];

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    do
                    {
                        Console.Write(MsgNum);
                        num = Convert.ToInt32(Console.ReadLine());
                        nums[i, j] = num;
                    } while (num < 1 || num > 9);
                    nums[i, j] = num;
                }
            }

            for(int i = 0; i < Cols; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < Rows; j++)
                {
                    Console.Write(nums[j, i] + " ");
                }
            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
