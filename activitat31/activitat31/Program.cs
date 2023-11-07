/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 07/11/2023
 * Exercici Implementa un programa perquè faci el següent:
a) Mostri tot el contingut de l'array, mostrant les mitjanes de cada mes de manera descendent. Un exemple de sortida seria aquest:
b) Compti quants mesos han tingut pluges entre 5 i 18 litres de mitjana (inclosos),  torni a mostrar el llistat de valors, la mitjana i el recompte calculat. Una possible sortida del programa seria aquesta:
c) Demani per teclat un valor i cerqui aquest dins l’array. Si el troba, ho ha d’indicar (aturant-se en trobar-lo, no s’ha de recórrer tot l’array). Si no l’ha trobat, informar que el valor no està dins l’array. Important! No cal validar el valor introduït per teclat.
 *
 */


using System;

namespace MyApplication
{

    class SortRain
    {
        static void Main()
        {

            const string MsgAverage = "La mitjana és {0}";
            const string MsgMonthSum = "Hi ha {0} mesos amb mitjanes de pluges entre 5 i 18 litres";
            const string MsgSearchValue = "Introdueix el valor a cercar: ";
            const string MsgValueFound = "Aquest valor està a la llista.";
            const string MsgValueNotFound = "Aquest valor no està a la llista.";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int monthSum = 0, search = 0;
            double average = 0, searchValue;
            bool valueFound = false;

            double[] arrayRain = new double[] {15.5,10,3.2,1.25, 1.75, 12, 5.15, 6.75, 15, 9.25, 10.75, 20.75};

            for (int i = 0; i < arrayRain.Length-1;i++)
            {
                for(int j = i + 1; j < arrayRain.Length;j++)
                {
                    if (arrayRain[i] < arrayRain[j])
                    {
                        double aux = arrayRain[i];
                        arrayRain[i] = arrayRain[j];
                        arrayRain[j] = aux;
                    }
                }
            }

            for(int i = 0; i < arrayRain.Length;i ++) 
            {

                if (arrayRain[i] >= 5 && arrayRain[i] <= 18) monthSum += 1;

                average += arrayRain[i];


                Console.WriteLine($"Mes {i}: {arrayRain[i]}");
            
            
            
            }

            Console.WriteLine(MsgAverage, average / arrayRain.Length);
            Console.WriteLine(MsgMonthSum, monthSum);

            Console.Write(MsgSearchValue);
            searchValue = Convert.ToDouble(Console.ReadLine());

            while(!valueFound && search < arrayRain.Length)
            {
                if (arrayRain[search] == searchValue)
                {
                    valueFound = true;
                }
                search++;
            }

            Console.WriteLine(valueFound ? MsgValueFound : MsgValueNotFound);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
