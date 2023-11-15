/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 14/11/2023
 * Exercici 6. Implementa un programa per trobar el nombre màxim de caràcters en una cadena introduïda per teclat. Per exemple:
 *
 */


using System;

namespace MyApplication
{

    class MaxChar
    {
        static void Main()
        {

            const string MsgText = "Introdueix un text: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int count = 0, maxCount = 0;

            char maxC = '\0'; 

            string text;

            Console.Write(MsgText);
            text = Console.ReadLine();

            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != ' ')
                {
                    for (int j = 0; j < text.Length; j++)
                    {

                        if (text[j] == text[i]) count++;
                    }
                }

                if(count > maxCount)
                {
                    maxCount = count;
                    maxC = text[i];
                }

                text = text.Replace(text[i], ' ');
                Console.WriteLine(text);
            }

            Console.WriteLine($"La freqüència més alta del caràcter <<{maxC}>> apareix per al nombre de vegades: {maxCount}");

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
