/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 30/10/2023
 * Exercici 23. Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari si vol mostrar els valors ordenats de manera ascendent o descendent i mostrar-ho per pantalla.
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
            const string MsgAscendingDescending = "Introdueix si vols la llista en ordre ascendent(1) o descendent(2): ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            bool orderAscending;
            int grade;
            int[] grades = new int[Cases];

            for (int i = 0; i < Cases; i++)
            {
                do
                {
                    Console.Write(MsgGrade);
                    grade = Convert.ToInt32(Console.ReadLine());
                } while (i < 1 || i > 10);
                grades[i] = grade;
            }

            Console.Write(MsgAscendingDescending);
            orderAscending = Console.ReadLine() == "1" ? true : false;

            if(orderAscending)
            {
                for (int i = 0; i < Cases - 1; i++)
                {
                    for (int j = 0; j < Cases - i - 1; j++)
                    {
                        if (grades[j] > grades[j + 1])
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
            }
            else 
            {
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
            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }
}