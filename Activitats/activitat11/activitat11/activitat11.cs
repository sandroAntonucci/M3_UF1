/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 16/10/2023
 * Activitat 11. Implementa un programa que retorni si un nombre introduït per teclat és palíndrom o no.
 *
 */


using System;

namespace MyApplication
{

    class Palindrome
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "Prem una tecla per continuar.";

            const int Decs = 10;

            int num, copyNum, reverseNum = 0, position = 1, digits=0;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            copyNum = num;

            while (num > 0)
            {
                digits++;
                num /= Decs;
            }

            num = copyNum;

            while(digits > 1)
            {
                digits--;
                position *= Decs;
            }
            
            while(num > 0)
            {
                reverseNum += (num % 10) * position;
                position /= 10;
                num /= 10;
            }

            num = copyNum;

            if(reverseNum == num)
            {
                Console.WriteLine("El nombre és palíndrom");
            }
            else
            {
                Console.WriteLine("El nombre no és palíndrom");
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
