/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/11/2023
 * Exercici 4. Implementa un programa que generi un array, indicant la seva mida per teclat. L’usuari haurà d’indicar un número per teclat, de manera que els valors de cada posició seran nombres múltiples consecutius del valor introduït per teclat. Per exemple, si es defineix un array de grandària 5 i s’indica un 3 com a valor, l’array contindrà els valors 3, 6, 9, 12, 15.
 *
 */


using System;

namespace MyApplication
{

    class Sequence
    {
        static void Main()
        {

            const string MsgArrayLength = "Introdueix la mida de la llista: ";
            const string MsgNum = "Introdueix el primer nombre: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int baseNum;
            int currentNum;

            Console.Write(MsgArrayLength);
            int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];

            //Assignem valor base i el valor que s'haura d'assignar
            Console.Write(MsgNum);
            baseNum = Convert.ToInt32(Console.ReadLine());
            currentNum = baseNum;

            //Per cada iteració sumarem el valor base al valor a assignar
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = currentNum;
                currentNum += baseNum;
            }

            foreach(int i in numbers) Console.Write(i + " ");

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
