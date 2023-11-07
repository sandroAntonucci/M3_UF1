/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 30/10/2023
 * Exercici 22. Modifica el programa anterior de manera que mostri les notes introduïdes ordenades de manera ascendent i descendent (per separat).ama retornarà si aquest valor es troba entre els introduïts o no.
 *
 */


using System;

namespace MyApplication
{

    class Grades
    {
        static void Main()
        {
            const int Cases = 5;

            const string MsgGrade = "Introdueix la teva nota: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";


            int[] grades = new int[Cases];

            for (int i = 0; i < Cases; i++)
            {
                Console.Write(MsgGrade);
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Cases-1; i++)
            {
                for (int j = 0; j < Cases - i - 1; j++)
                {
                    if (grades[j] > grades[j + 1])
                    {
                        int aux = grades[j];
                        grades[j] = grades[j+1];
                        grades[j+1] = aux;
                    }
                }
            }

            for (int i = 0; i < Cases; i++)
            {
                Console.Write(grades[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < Cases - 1; i++)
            {
                for (int j = 0; j < Cases - i - 1; j++)
                {
                    if (grades[j] < grades[j + 1])
                    {
                        int aux = grades[j];
                        grades[j] = grades[j + 1];
                        grades[j + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < Cases; i++)
            {
                Console.Write(grades[i] + " ");
            }





            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }
}