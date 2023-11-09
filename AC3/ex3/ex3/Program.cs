/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/11/2023
 * Exercici 3. Implementa un programa que, donada la següent llista, retorni l’element més gran i el més petit.
   llista= [5,10,15,2,25,30,35,40]
 *
 */


using System;

namespace MyApplication
{

    class GreaterLower
    {
        static void Main()
        {

            const string MsgGreater = "El número més gran és {0}";
            const string MsgLower = "El número més petit és {0}";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int greater, lower;

            int[] numbers = { 5, 10, 15, 2, 25, 30, 35, 40 };

            //Assignem valors de referència
            greater = numbers[0];
            lower = numbers[0];

            //Comparem els nombres i anem emmagatzemant el major i menor
            foreach (int i in numbers)
            {
                if(i > greater) greater = i;
                else if (i < lower) lower = i;
            }

            Console.WriteLine(MsgGreater, greater);
            Console.WriteLine(MsgLower, lower);


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
