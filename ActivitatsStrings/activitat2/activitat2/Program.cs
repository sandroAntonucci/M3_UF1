/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 14/11/2023
 * Exercici 2. Implementa un programa que demani l’adreça d’email a l’usuari i comprovi si aquesta conté l’extensió “.com” o no.
 *
 */


using System;

namespace MyApplication
{

    class Adress
    {
        static void Main()
        {

            const string MsgText = "Introdueix el teu correu: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string text;

            Console.Write(MsgText);
            text = Console.ReadLine();

            Console.WriteLine(text.EndsWith(".com") ? "Acaba amb .com" : "No acaba amb .com");


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
