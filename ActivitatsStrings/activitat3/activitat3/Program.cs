/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 14/11/2023
 * Exercici 3. Implementa un programa que demani un text a l’usuari i retorni el nombre de paraules que conté aquest text.
 *
 */


using System;

namespace MyApplication
{

    class Words
    {
        static void Main()
        {

            const string MsgText = "Introdueix un text: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string text;

            Console.Write(MsgText);
            text = Console.ReadLine();

            string[] words = text.Split();

            Console.WriteLine(words.Length);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
