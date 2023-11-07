/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 25/10/2023
 * 15. Implementa un programa que demani a l’usuari quants valors vol introduir i generi una llista a partir d’aquest valors introduïts per teclat, retornant la suma de tots els elements d’aquesta.
 */


using System;

namespace MyApplication
{

    class Hola
    {
        static void Main()
        {

            const string MsgArrayLength = "Introdueix la quantitat de nombres que contindra la llista: ";
            const string MsgNum = "Introdueix un nombre: ";
            const string MsgResult = "La suma d'aquests nombres és: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int arrayLength, sum = 0;

            Console.Write(MsgArrayLength);
            arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[arrayLength];

            for(int i = 0; i < arrayLength; i++) 
            {
                Console.Write(MsgNum);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < arrayLength; i++)
            {
                sum += nums[i];
            }
            
            Console.WriteLine(MsgResult + sum);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
