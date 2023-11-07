/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 05/11/2023
 * Exercici 28. Fent servir la interpolació i l’operador ternari, implementa un programa que indiqui pels 20 primers nombres (del 1 al 20 inclosos) si és parell o senar (només ha d’indicar per a cada valor “És parell”/”És senar)”.
 *
 */


using System;

namespace MyApplication
{

    class Hola
    {
        static void Main()
        {

            const string MsgEnd = "\nPrem una tecla per continuar.";

            for(int i = 1; i <= 20; i++)
            {

                Console.WriteLine(i % 2 == 0 ? $"{i} és parell" : $"{i} és senar");

            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
