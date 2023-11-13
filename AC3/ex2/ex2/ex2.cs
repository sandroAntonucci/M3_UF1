/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/11/2023
 * Exercici 2. Donada la següent llista:
    a = [10,20,30,20,10,50,60,40,80,50,40]
    implementa un programa que retorni una llista sense els elements duplicats.
 *
 */


using System;

namespace MyApplication
{

    class Duplicates
    {
        static void Main()
        {

            const string MsgArray = "Llista sense duplicats: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            bool numberInArray;

            int[] numbers = { 10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40 };
            int[] noDuplicateNumbers = new int[numbers.Length];

            
            //Primer for per recórrer tots els nombres a la llista original
            for(int i = 0; i < numbers.Length; i++)
            {

                int j = 0;
                numberInArray = false;

                //While per comprovar si aquest nombre està ja a la llista sense duplicats
                while ((j < noDuplicateNumbers.Length) && (!numberInArray))
                {
                    if (numbers[i] == noDuplicateNumbers[j])
                    {
                        numberInArray = true;
                    }
                    j++;
                }

                //Si el nombre no s'ha trobat a la llista de duplicats, s'afegeix
                if (!numberInArray) noDuplicateNumbers[i] = numbers[i];

            }

            Console.WriteLine(MsgArray);

            //Retorna la llista sense duplicats
            foreach (int i in noDuplicateNumbers)
            {
                if(i != 0) Console.Write(i + " ");
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
