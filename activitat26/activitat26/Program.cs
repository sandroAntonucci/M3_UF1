/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 05/11/2023
 * Exercici 26. Implementa un programa que demani a l’usuari que introdueixi un text i retorni la seva longitud.
 *
 */


using System;

namespace MyApplication
{

    class TextLength
    {
        static void Main()
        {

            const string MsgText = "Introdueix un text: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string text;

            Console.Write(MsgText);
            text = Console.ReadLine();

            Console.WriteLine("La longitud del text és " + text.Length);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
