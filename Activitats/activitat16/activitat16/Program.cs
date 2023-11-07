/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 25/10/2023
 * Exercici 16. Implementa un programa que demani  a l’usuari 10 enters per teclat i els mostri en sentit contrari al que s’ha introduït.
 *
 */


using System;

namespace MyApplication
{

    class ReverseArray
    {
        static void Main()
        {
            const int Quant = 10;

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[] nums = new int[Quant];

            for(int i = 0; i < Quant; i++)
            {
                Console.Write(MsgNum);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = Quant-1; i >= 0; i--) 
            {

                Console.Write(nums[i] + " ");
            
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
