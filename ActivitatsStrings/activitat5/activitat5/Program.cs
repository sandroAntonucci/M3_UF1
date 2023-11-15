/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 14/11/2023
 * Exercici 5. Implementa un programa per comptar el nombre de vocals o consonants en una cadena introduïda per teclat.
 */


using System;

namespace MyApplication
{

    class Vocals
    {
        static void Main()
        {


            const string MsgText = "Introdueix un text: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int consCount = 0, vocalsCount = 0;

            string text, vocals = "aeiouáéíóúàèìòùAEIOUÁÉÍÓÚÀÈÌÒÙ";

            Console.Write(MsgText);
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (vocals.Contains(text[i])) vocalsCount++;
                else consCount++;
            }

            Console.WriteLine($"Hi han {vocalsCount} vocals i {consCount} consonants.");

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
