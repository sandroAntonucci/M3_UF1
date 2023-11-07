/*
*Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 05/11/2023
 * Exercici 25. Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable textOne. Demana un altre text i emmagatzema’l en la variable textTwo. Afegeix textTwo a textOne i mostra-la per pantalla. És correcte? Què pots observar a les variables textOne i textTwo?
 *
 *//*asdfjhaspijodjfpaisujeofjawso*/


using System;

namespace MyApplication
{

    class Texts
    {
        static void Main()
        {

            const string MsgTextOne = "Introdueix una frase: ";
            const string MsgTextTwo = "Introdueix una altra frase: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string textOne;
            string textTwo;
            string text;

            Console.Write(MsgTextOne);
            textOne = Console.ReadLine();

            Console.Write(MsgTextTwo);
            textTwo = Console.ReadLine();

            text = textOne + textTwo;

            Console.WriteLine(text);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
