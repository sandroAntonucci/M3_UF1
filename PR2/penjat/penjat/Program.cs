/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 13/11/2023
 * PR2. En aquesta pràctica, creareu la nostra versió de “El joc del Penjat”, on l’usuari haurà d’endevinar la paraula escollida pel programa, segons el nivell de dificultat.
 *
 */


using System;

namespace MyApplication
{
    class Hangman
    {
        static void Main()
        {

            const string MsgInput = "\n>> ";
            const string MsgWelcome = "\t\t\t******************************\n\t\t\t****Bienvenid@ al ahorcado****\n\t\t\t******************************";
            const string MsgDifficulty = "\t\tPor favor, escoge el nivel de dificultad: \n\n";
            const string MsgDifficultiesList = "\t\tA. Fácil\n\t\tB. Normal\n\t\tC. Difícil\n\t\tD. Experto";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int difficulty;

            //Intro - Bienvenido al ahorcado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MsgWelcome);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MsgDifficulty);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(MsgDifficultiesList);
            Console.Write(MsgInput);
            Console.ReadLine();


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
