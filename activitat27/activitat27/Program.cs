/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 05/11/2023
 * Exercici 27. Implementa un programa que demani a l’usuari que introdueixi un text i el retorni tot en majúscules, tot en minúscules i la primera lletra de cada paraula en majúscules (per separat).
 *
 */


using System;

namespace MyApplication
{

    class UppercaseLowercase
    {
        static void Main()
        {

            const string MsgText = "Introdueix un text: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string text;

            Console.Write(MsgText);
            text = Console.ReadLine();

            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text);
            

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
