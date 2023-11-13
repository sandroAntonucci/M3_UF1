/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 17/10/2023
 * Exercici X. Enunciat de l’exercici que es resol
 *
 */


using System;

namespace MyApplication
{

    class Hola
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "Prem una tecla per continuar.";

            int num;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
