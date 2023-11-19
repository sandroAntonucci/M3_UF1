/*
 Autor: Sandro Antonucci Rejón
 Data: 15/11/2023
 1. Implementa en C# el següent disseny de solució en pseudocodi. Escriu els literals que falten:
 
 */

using System;

namespace SegonaProvaPractica
{
    class AntonucciSandroCodeEx1
    {
        static void Main() 
        {

            const string FIRSTMSG = "Introdueix un enter: ";
            const string SECONDMSG = "Els dígits d'aquest enter són ";

            int num, digit = 0;

            Console.Write(FIRSTMSG);
            num = Convert.ToInt32(Console.ReadLine());

            //Comprova si el num és major que 0 i retorna 1 digit, sinó, entra en un while que va comptant tots els dígits
            if (num > 0)
            {
                while(num > 0)
                {
                    num = num / 10;
                    digit++;
                }
            }
            else
            {
                digit = 1;
            }

            Console.Write(SECONDMSG);
            Console.Write(digit);
        }
    }
}