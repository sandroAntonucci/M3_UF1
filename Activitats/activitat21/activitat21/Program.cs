/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 30/10/2023
 * Exercici 21. Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari quin valor vol cercar i el programa retornarà si aquest valor es troba entre els introduïts o no.
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
            const string MsgSearchGrade = "Introdueix la nota a cercar: ";
            const string MsgGradeInArray = "Aquesta nota és a la llista";
            const string MsgGradeNotInArray = "Aquesta nota no és a la llista";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int searchGrade, searchPosition = 0;
            bool gradeInArray = false;
            int[] grades = new int[Cases];

            for(int i = 0; i < Cases; i++)
            {
                Console.Write(MsgGrade);
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(MsgSearchGrade);
            searchGrade = Convert.ToInt32(Console.ReadLine());


            while(!gradeInArray && searchPosition < Cases)
            {
                if (grades[searchPosition] == searchGrade)
                {
                    gradeInArray = true;
                }

                searchPosition++;
            }

            Console.WriteLine(gradeInArray ? MsgGradeInArray : MsgGradeNotInArray);

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
