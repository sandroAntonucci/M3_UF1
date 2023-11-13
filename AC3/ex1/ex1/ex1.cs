/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/11/2023
 * Exercici 1. Implementa un programa que demani a l’usuari quants valors vol introduir i el programa generi una llista, a partir de valors introduïts per teclat, retornant la suma de tots els elements d’aquesta.
 *
 */


using System;

namespace MyApplication
{

    class ArraySum
    {
        static void Main()
        {

            const string MsgArrayLength = "Quants valors vols introduir: ";
            const string MsgNum = "Introdueix un valor: ";
            const string MsgSum = "La suma de tots els valors és {0}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int num, sum = 0;

            Console.Write(MsgArrayLength);
            int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(MsgNum);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                numbers[i] = num;
            }

            Console.WriteLine(MsgSum, sum);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
