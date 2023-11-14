/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 14/11/2023
 * Exercici 4. Implementa un programa que demani una cadena i compti el nombre de caràcters, dígits i caràcters especials en aquesta cadena.
 *
 */


using System;

namespace MyApplication
{

    class Special
    {
        static void Main()
        {

            const string MsgText = "Introdueix un text: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int charact = 0, specialCount = 0, digitsCount = 0;

            string text, special="$%&/()=?¿*", digits="0123456789";

            Console.Write(MsgText);
            text = Console.ReadLine();

            for(int i = 0; i < text.Length; i++)
            {
                if (special.Contains(text[i])) specialCount++;

                else if (digits.Contains(text[i])) digitsCount++;

                else charact++;
            }

            Console.WriteLine("Caràcters: " + charact);
            Console.WriteLine("Dígits: " + digitsCount);
            Console.WriteLine("Special: " + specialCount);


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
