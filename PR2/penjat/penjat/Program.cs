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
            const string MsgDifficulty = "\n\t\tPor favor, escoge el nivel de dificultad: \n\n";
            const string MsgDifficultiesList = "\t\tA. Fácil\n\t\tB. Normal\n\t\tC. Difícil\n\t\tD. Experto";
            const string MsgDifficultyChosen = "\n\t\t¡Has escogido el nivel de dificultad {0}! ";
            const string MsgText = "Introdueix un text per a escollir la paraula: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string difficulty = "", text = "";

            //Intro - Bienvenido al ahorcado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MsgWelcome);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MsgDifficulty);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(MsgDifficultiesList);
            Console.Write(MsgInput);
            difficulty = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Green;
            //Switch para la dificultad (escoge una palabra de mas o menos longitud)

            switch (difficulty.ToLower()){


                //Modo Fácil
                case "a":

                    //Introducció del text
                    Console.WriteLine(MsgDifficultyChosen, "fácil");
                    Console.ReadLine();
                    Console.WriteLine(MsgText);
                    Console.WriteLine(MsgInput);
                    text = Console.ReadLine();



                    break;

                //Modo Normal
                case "b":

                    //Introducció del text
                    Console.WriteLine(MsgDifficultyChosen, "normal");
                    Console.ReadLine();
                    Console.WriteLine(MsgText);
                    Console.WriteLine(MsgInput);
                    text = Console.ReadLine();



                    break;

                //Modo Difícil
                case "c":

                    //Introducció del text
                    Console.WriteLine(MsgDifficultyChosen, "difícil");
                    Console.ReadLine();
                    Console.WriteLine(MsgText);
                    Console.WriteLine(MsgInput);
                    text = Console.ReadLine();

                    break;


                //Modo Experto
                case "d":

                    //Introducció del text
                    Console.WriteLine(MsgDifficultyChosen, "experto");
                    Console.ReadLine();
                    Console.WriteLine(MsgText);
                    Console.WriteLine(MsgInput);
                    text = Console.ReadLine();

                    break;

            }




            Console.WriteLine(MsgEnd);
            Console.ReadKey();

        }
    }

}
