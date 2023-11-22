*Author: Sandro Antonucci Rejón
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
            const string MsgText = "\t\tIntroduce un texto para escoger una palabra: ";
            const string MsgTries = "\tNúmero de intentos restantes: {0}";
            const string MsgContinue = "\n\t\tPulsa una tecla para continuar.";

            int difficultyTries = 3, textTries = 3, tries;

            string difficulty = "", text = "", hangmanWord;

            bool gameLost = false, wordFound = false;

            //Intro - Bienvenido al ahorcado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MsgWelcome);


            //Do while para mostrar un menú y comprovar que la entrada sea válida con un máximo de 3 intentos
            do
            {

                //Informa al usuario en caso de valor no válido
                if (difficultyTries < 3)
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
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(MsgInput);
                    text = Console.ReadLine();
                    textTries--;
                } while (text == "" && textTries > 0);
            }

            //Se quitan los acentos
            text = text.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U");

            //Separa cada palabra en un array
            string[] words = text.Split(' ');

            //S'ordena l'array de menor a major
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Length > words[j].Length)
                    {
                        string aux = words[i];
                        words[i] = words[j];
                        words[j] = aux;
                    }
                }
            }


            //Switch para la dificultad (escoge una palabra de mas o menos longitud)
            switch (difficulty)
            {


                //Modo Fácil - Se escoge la palabra más corta del texto
                case "a":

                    tries = 7;

                    hangmanWord = words[0];


                    break;

                //Modo Normal - Se escoge la última palabra del primer cuarto del texto ordenado por longitud (dividimos la longitud del array por 4)
                case "b":

                    tries = 5;

                    hangmanWord = words[words.Length / 4];

                    break;

                //Modo Difícil - Se escoge la primera palabra de la segunda mitad del texto ordenado por longitud (dividimos la longitud del array por 2)
                case "c":

                    tries = 4;

                    hangmanWord = words[words.Length / 2];

                    break;


                //Modo Experto - Se escoge la palabra más larga del texto
                case "d":

                    tries = 3;

                    hangmanWord = words[words.Length - 1];

                    break;

            }




            Console.WriteLine(MsgContinue);
            Console.ReadKey();

        }
    }

}
