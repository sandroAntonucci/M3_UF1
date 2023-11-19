/*
Autor: Sandro Antonucci Rejón
Data: 15/11/2023
5. Implementa un menú que demani per teclat introduir una de les següents opcions: A, B, C, D (éssent vàlida tant majúscula com minúscula), com el següent exemple:

*/

using System;

namespace SegonaProvaPractica
{
    class AntonucciSandroCodeEx5
    {
        static void Main()
        {

            const string MsgWelcome = "Benvingud@! Escull una opció:\nA: Buscar una cadena en un text\nB: Mostrar totes les lletres d'un text separades per espais\nC: Substituir un caràcter en un text per un altre caràcter\nD: Confirmar el nom d'un fitxer de codi font\nE: Sortir\n\nAcció: ";
            const string MsgTextInput = "Introdueix un text: ";
            const string MsgTextSearch = "Introdueix la cadena a cercar dins del text: ";
            const string MsgTextFound = "La cadena es troba a dins del text";
            const string MsgTextNotFound = "La cadena no es troba a dins del text";
            const string MsgLetterToReplace = "Introdueix la lletra a reemplaçar: ";
            const string MsgReplace = "Introdueix la lletra amb la que la vols reemplaçar: ";
            const string MsgFile = "Introdueix el nom del fitxer: ";
            const string MsgWithExtension = "Conté la extensió .cs";
            const string MsgWithoutExtension = "No conté la extensió .cs";
            const string MsgExit = "Adeu!";

            string option, text, textSearch;

            char letterToReplace, replace;

            //Do while per a comprovar que la opció és vàlida
            do
            {
                Console.Write(MsgWelcome);
                option = Console.ReadLine();
            }while(option.ToLower() != "a" && option.ToLower() != "b" && option.ToLower() != "c" && option.ToLower() != "d" && option.ToLower() != "e") ;


            //Switch per validar la opció escollida per l'usuari - fem servir toLower per ignorar majúscules
            switch (option.ToLower())
            {
                //A: l’usuari haurà d’introduir un text i la cadena a buscar dins d’aquest text. El programa haurà de retornar si la cadena és dins del text o no.
                case "a":

                    //Text
                    Console.Write(MsgTextInput);
                    text = Console.ReadLine();

                    //Cadena a cercar dins del text
                    Console.Write(MsgTextSearch);
                    textSearch = Console.ReadLine();

                    //Operador ternari per comprovar si es troba dins del text
                    Console.WriteLine(text.Contains(textSearch) ? MsgTextFound : MsgTextNotFound);

                    break;

                //B: l’usuari haurà d’introduir un text i el programa retornarà cada lletra del text separada per un espai.
                case "b":

                    //Text
                    Console.Write(MsgTextInput);
                    text = Console.ReadLine();

                    //Foreach per a imprimir cada caracter, comprova si es espai per a no fer un altre espai
                    foreach (char i in text) 
                    {
                        if(i != ' ') Console.Write($"{i} ");
                    }

                    break;

                //C: l’usuari haurà d’introduir un text, el valor que vol reemplaçar i el valor amb el que es vol reemplaçar.
                case "c":

                    //Text
                    Console.Write(MsgTextInput);
                    text = Console.ReadLine();

                    //Lletra a reemplaçar
                    Console.Write(MsgLetterToReplace);
                    letterToReplace = Convert.ToChar(Console.ReadLine());

                    //Lletra que reemplaça
                    Console.Write(MsgReplace);
                    replace = Convert.ToChar(Console.ReadLine());

                    text = text.Replace(letterToReplace, replace);

                    Console.Write(text);

                    break;

                //D:  l’usuari haurà d’introduir el nom d’un fitxer i el programa haurà d’indicar si el nom conté l’extensió de codi font de C# (“.cs”)

                case "d":

                    //Nom Arxiu
                    Console.Write(MsgFile);
                    text = Console.ReadLine();

                    //Operador ternari per comprovar si conté la extensió o no
                    Console.WriteLine(text.EndsWith(".cs") ? MsgWithExtension : MsgWithoutExtension);

                    break;

                //E: Sortir (només ha d’escriure un missatge de comiat)
                case "e":
                    Console.Write(MsgExit);
                    break;
            }


        }
    }
}