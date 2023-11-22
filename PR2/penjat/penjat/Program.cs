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
            const string MsgNotValid = "Aquesta entrada no es válida";
            const string MsgOutOfTries = "Te has quedado sin intentos. !Adiós!";
            const string MsgWelcome = "\t\t\t******************************\n\t\t\t****Bienvenid@ al ahorcado****\n\t\t\t******************************";
            const string MsgDifficulty = "\n\t\tPor favor, escoge el nivel de dificultad: \n\n";
            const string MsgDifficultiesList = "\t\tA. Fácil\n\t\tB. Normal\n\t\tC. Difícil\n\t\tD. Experto";
            const string MsgDifficultyChosen = "\n\t\t¡Has escogido el nivel de dificultad {0}! ";
            const string MsgText = "Introduce un texto para escoger una palabra: ";
            const string MsgContinue = "\nPulsa una tecla para continuar.";

            int difficultyTries = 3, textTries = 3, tries;

            string difficulty = "", text = "", hangmanWord;

            //Intro - Bienvenido al ahorcado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MsgWelcome);


            //Do while para comprovar que el valor sea válido con un máximo de 3 intentos
            do
            {

                //Informa al usuario en caso de valor no válido
                if(difficultyTries < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MsgNotValid);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(MsgDifficulty);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(MsgDifficultiesList);

                Console.Write(MsgInput);
                difficulty = Console.ReadLine();
                difficulty = difficulty.ToLower();

                difficultyTries--;

            } while (difficulty != "a" && difficulty != "b" && difficulty != "c" && difficulty != "d" && difficultyTries > 0);


            //Comprueba si el usuario se ha quedado sin intentos
            
            if (difficultyTries == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(MsgOutOfTries);
            }

            else
            {

                Console.ForegroundColor = ConsoleColor.Green;

                //Indica al jugador la dificultad escogida
                switch (difficulty)
                {
                    case "a":
                        Console.WriteLine(MsgDifficultyChosen, "fácil");
                        Console.WriteLine(MsgContinue);
                        Console.ReadLine();
                        break;

                    case "b":
                        Console.WriteLine(MsgDifficultyChosen, "normal");
                        Console.WriteLine(MsgContinue);
                        Console.ReadLine();
                        break;

                    case "c":
                        Console.WriteLine(MsgDifficultyChosen, "difícil");
                        Console.WriteLine(MsgContinue);
                        Console.ReadLine();
                        break;

                    case "d":
                        Console.WriteLine(MsgDifficultyChosen, "experto");
                        Console.WriteLine(MsgContinue);
                        Console.ReadLine();
                        break;
                }

                Console.Clear();


                //Introducción del texto (necesita mínimo una letra)

                do
                {
                    Console.WriteLine(MsgText);
                    Console.Write(MsgInput);
                    text = Console.ReadLine();
                    textTries--;
                } while (text == "" && textTries > 0);
            }

            //Separa cada palabra en un array
            string[] words = text.Split(' ');


            //S'ordena l'array de menor a major
            for(int i = 0; i < words.Length - 1; i++)
            {
                for(int j = i+1; j < words.Length; j++)
                {
                    if (words[i].Length > words[j].Length)
                    {
                        string aux = words[i];
                        words[i] = words[j];
                        words[j] = aux;
                    }
                }
            }

            foreach(string s in words)
            {
                Console.WriteLine(s);
            }


            //Switch para la dificultad (escoge una palabra de mas o menos longitud)
            switch (difficulty){


                //Modo Fácil
                case "a":

                    tries = 7;
                    


                    break;

                //Modo Normal
                case "b":

                    tries = 5;



                    break;

                //Modo Difícil
                case "c":

                    tries = 4;


                    break;


                //Modo Experto
                case "d":

                    tries = 3;


                    break;

            }




            Console.WriteLine(MsgContinue);
            Console.ReadKey();

        }
    }

}
