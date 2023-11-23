/*Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 13/11/2023
 * PR2. En aquesta pràctica, creareu la nostra versió de “El joc del Penjat”, on l’usuari haurà d’endevinar la paraula escollida pel programa, segons el nivell de dificultat.
 *
 */


using System;

namespace MyApplication
{
    class M3UF1PR2SandroAntonucci
    {
        static void Main()
        {

            const string MsgInput = "\n>> ";
            const string MsgNotValid = "Esta entrada no es válida";
            const string MsgOutOfTries = "Te has quedado sin intentos. !Adiós!";
            const string MsgWelcome = "\t\t\t******************************\n\t\t\t****Bienvenid@ al ahorcado****\n\t\t\t******************************";
            const string MsgDifficulty = "\n\t\tPor favor, escoge el nivel de dificultad: \n\n";
            const string MsgDifficultiesList = "\t\tA. Fácil\n\t\tB. Normal\n\t\tC. Difícil\n\t\tD. Experto";
            const string MsgDifficultyChosen = "\n\t\t¡Has escogido el nivel de dificultad {0}! ";
            const string MsgText = "\t\tIntroduce un texto para escoger una palabra: ";
            const string MsgGuess = "\tIntroduce una letra (vocal o consonante): ";
            const string MsgTries = "\tNúmero de intentos restantes: {0}\n";
            const string MsgLetterAlreadyGuessed = "\n\n\tYa has introducido esta letra. Pierdes un intento.";
            const string MsgLetterNotInWord = "\n\n\t{0} no se encuentra en la palabra. Pierdes un intento.";
            const string MsgLetterInWord = "\n\n\t¡{0} se encuentra en la palabra!";
            const string MsgContinue = "\n\t\tPulsa una tecla para continuar.";
            const string MsgWon = "\n¡Has ganado! - La palabra era {0}";
            const string MsgLost = "\nHas perdido :( - La palabra era {0}";


            //Frames del ahorcado

            const string HangmanZero = " +---+\n     |\n     |\n     |\n     |\n     |\n==========\n";
            const string HangmanOne = " +---+\n |   |\n     |\n     |\n     |\n     |\n==========\n";
            const string HangmanTwo = " +---+\n |   |\n O   |\n     |\n     |\n     |\n==========\n";
            const string HangmanThree = " +---+\n |   |\n O   |\n |   |\n     |\n     |\n==========\n";
            const string HangmanFour = " +---+\n |   |\n O   |\n/|   |\n     |\n     |\n==========\n";
            const string HangmanFive = " +---+\n |   |\n O   |\n/|\\  |\n     |\n     |\n==========\n";
            const string HangmanSix = " +---+\n |   |\n O   |\n/|\\  |\n/    |\n     |\n==========\n";
            const string HangmanSeven = " +---+\n |   |\n O   |\n/|\\  |\n/ \\  |\n     |\n==========\n";


            int difficultyTries = 3, textTries = 3, tries = 0;

            string difficulty = "", text = "", lettersGuessed = "", hangmanWord = "", alphabet = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            char letter = '\0';

            bool wordFound = false, letterFound = false;

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

                    //Informa al usuario en caso de error
                    if(textTries < 3)
                    {
                        Console.Write(MsgNotValid);
                    }

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

            //Se ordena el array de menor a mayor
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
                    hangmanWord = words[0].ToUpper();
                    break;

                //Modo Normal - Se escoge la última palabra del primer cuarto del texto ordenado por longitud (dividimos la longitud del array por 4)
                case "b":

                    tries = 5;
                    hangmanWord = words[words.Length / 4].ToUpper();
                    break;

                //Modo Difícil - Se escoge la primera palabra de la segunda mitad del texto ordenado por longitud (dividimos la longitud del array por 2)
                case "c":

                    tries = 4;
                    hangmanWord = words[words.Length / 2].ToUpper();
                    break;


                //Modo Experto - Se escoge la palabra más larga del texto
                case "d":

                    tries = 3;
                    hangmanWord = words[words.Length - 1].ToUpper();
                    break;

            }

            char[] hangmanGuessed = new char[hangmanWord.Length];

            //For para substituir por _ todos los carácteres a adivinar por el usuario en una array de carácteres
            for(int i = 0; i < hangmanWord.Length; i++) 
            {
                hangmanGuessed[i] = '_';
            }

            //While para indicar cada ronda que acaba si el usuario se queda sin intentos o adivina la palabra

            while (tries > 0 && !wordFound)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(MsgTries, tries);

                //For que imprime todas las letras, marca en rojo las incorrectas introducidas y en verde las correctas introducidas. También introduce un salto de línea en la letra I y Q

                foreach (char i in alphabet)
                {

                    //Si la letra está dentro de las que ha introducido el usuario, se comprueba si es correcta o incorrecta y cambia el color
                    if (lettersGuessed.Contains(i))
                    {
                        if (hangmanWord.Contains(i))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                    }
                    //Si el usuario no la ha introducido aún, la marca en blanco
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                    Console.Write(i + " ");
                    if (i == 'I' || i == 'Q') Console.WriteLine();

                }
                
                //Imprime la palabra con las letras adivinadas por el jugador
                Console.WriteLine("\n\n\t");

                foreach (char i in hangmanGuessed) Console.Write(i + " ");

                Console.WriteLine("\n\n");


                Console.ForegroundColor = ConsoleColor.Cyan;

                //Switch para dibujar diferentes frames del dibujo dependiendo de los intentos restantes (si escoge niveles difíciles empezará ya medio colgado)
                switch (tries)
                {
                    case 7:
                        Console.WriteLine(HangmanZero);
                        break;

                    case 6:
                        Console.WriteLine(HangmanOne);
                        break;

                    case 5:
                        Console.WriteLine(HangmanTwo);
                        break;

                    case 4:
                        Console.WriteLine(HangmanThree);
                        break;

                    case 3:
                        Console.WriteLine(HangmanFour);
                        break;

                    case 2:
                        Console.WriteLine(HangmanFive);
                        break;

                    case 1:
                        Console.WriteLine(HangmanSix);
                        break;
                }


                //Recoge una letra introducida por el usuario
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MsgGuess);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(MsgInput);
                
                letter = Convert.ToChar(Console.ReadLine());
                letter = char.ToUpper(letter);


                //Si la letra ya ha sido introducida antes, informa al usuario y resta un intento, si no, se comprueba que esté en la palabra a adivinar
                if (lettersGuessed.Contains(letter))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MsgLetterAlreadyGuessed);
                    tries--;
                }
                else 
                {
                    //Se recorre toda la palabra para comprobar si la letra coincide
                    for(int i = 0; i < hangmanWord.Length; i++)
                    {
                        if (hangmanWord[i] == letter)
                        {
                            hangmanGuessed[i] = letter;
                            letterFound = true;
                        }
                    }
                }

                //Si no se ha encontrado una letra, resta un intento y informa al usuario
                if (!letterFound && !(lettersGuessed.Contains(letter)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MsgLetterNotInWord, letter);
                    tries--;
                }
                else if(!(lettersGuessed.Contains(letter)))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(MsgLetterInWord, letter);
                }

                lettersGuessed += letter;
                letterFound = false;
                letter = '\0';

                //Si la palabra adivinada por el usuario no contiene _ significa que ya no hay letras a adivinar y ha ganado el juego
                if (!hangmanGuessed.Contains('_')) wordFound = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MsgContinue);
                Console.ReadKey();

            }

            Console.Clear();

            //Informa al usuario si ha ganado o ha perdido y si pierde dibuja el hangman entero
            if (wordFound)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MsgWon, hangmanWord);
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(HangmanSeven);
                Console.WriteLine(MsgLost, hangmanWord);
            }

            Console.WriteLine(MsgContinue);
            Console.ReadKey();

        }
    }
}
