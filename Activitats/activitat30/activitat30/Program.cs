/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 06/11/2023
 * Exercici 30.Cada cas conté la llista de membres d'un grup musical. Un grup musical té un mínim de dos membres i un màxim de quinze (si fossin més no tocarien a res a l'hora de repartir-se els guanys...) La llista es compon pel nom de cadascú dels membres separats per comes a excepció de l'últim membre, que en comptes d'una coma té la conjunció "i".
 *
 */


using System;

namespace MyApplication
{

    class Activitat30
    {
        static void Main()
        {

            const string MsgNames = "Introdueix els noms dels membres: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string names, splitNames;
            string initials = "";
       
            Console.Write(MsgNames);
            names = Console.ReadLine();

            splitNames = names.Replace(", ", " ");
            splitNames = splitNames.Replace(" i ", " ");

            string[] separatedNames = splitNames.Split(' ');

            for(int i = 0;  i < separatedNames.Length; i++)
            {
                initials += separatedNames[i][0];
            }


            Console.WriteLine(initials);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
