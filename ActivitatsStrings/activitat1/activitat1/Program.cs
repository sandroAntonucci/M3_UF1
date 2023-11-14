/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 14/11/2023
 * Exercici 1. Implementa un programa que demani una cadena a l’usuari i retorni si aquesta és palíndroma o no. 
 */


using System;

namespace MyApplication
{

    class Palindrome
    {
        static void Main()
        {

            const string MsgText = "Introdueix una cadena: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string text, reverseText = "";

            Console.Write(MsgText);
            text = Console.ReadLine();

            for(int i = text.Length; i > 0; i--)
            {
                reverseText += text[i-1];
            }

            Console.WriteLine(text.Equals(reverseText) ? "És palíndrom" : "No és palíndrom");
            
            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
