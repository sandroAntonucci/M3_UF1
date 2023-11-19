/*
Autor: Sandro Antonucci Rejón
Data: 15/11/2023
2. Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable stmntOne. Després ha de demanar un altre text i emmagatzema’l en la variable stmntTwo, afegir stmntOne al final de stmntTwo i mostrar-la per pantalla. Explica el procés a nivell informàtic i demostra-ho mitjançant les instruccions en C# que consideris.
*/

using System;

namespace SegonaProvaPractica
{
    class AntonucciSandroCodeEx2
    {
        static void Main()
        {
            //Declarem les constants
            const string MsgTextOne = "Introdueix una frase: ";
            const string MsgTextTwo = "Introdueix una altra frase: ";
            const string MsgFirstHash = "Aquest és el hash de la primera frase: {0}";
            const string MsgSecondHash = "Ja que hem creat una nova String amb valor diferent pero mateix nom, el hash ha canviat a {0}";
            const string MsgConcat = "Les frases concatenades són: ";

            string stmntOne, stmntTwo;


            /*Assignem les frases a les variables
             *Degut a que les variables de tipus String son inmutables, si canviem el seu valor
             *el que passarà realment és que l'ordinador crearà una nova variable amb el mateix nom
             *i diferent valor. Al fer aixó, canvia el hash de la variable (ja que realment és una nova). 
             *Ho podem comprovar utilitzant GetHashCode() per comprovar el valor hash inicial.
            */
            Console.Write(MsgTextOne);
            stmntOne = Console.ReadLine();

            Console.Write(MsgTextTwo);
            stmntTwo = Console.ReadLine();

            //Imprimim el hash de la string
            Console.WriteLine(MsgFirstHash, stmntTwo.GetHashCode());


            //Afegim stmntOne al final de stmntTwo
            stmntTwo += stmntOne;



            Console.WriteLine(stmntTwo);

            //Mostrem que el hash ha canviat ja que el programa ha creat una nova variable al sumar stmntOne.
            Console.WriteLine(MsgSecondHash, stmntTwo.GetHashCode());


        }
    }
}