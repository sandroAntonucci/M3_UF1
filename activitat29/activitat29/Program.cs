/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. dd/mm/yyyy
 * Exercici X. Enunciat de l’exercici que es resol
 *
 */


using System;

namespace MyApplication
{

    class Interpolation
    {
        static void Main()
        {

            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[] { 1, 2, 3, 4 };
            jaggedArr[1] = new int[] { 11, 34, 67 };
            jaggedArr[2] = new int[] { 89, 23 };
            jaggedArr[3] = new int[] { 0, 45, 78, 53, 99 };

            for(int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write($"Fila {i}: ");
                for(int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
