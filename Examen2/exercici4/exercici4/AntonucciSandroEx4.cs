/*
Autor: Sandro Antonucci Rejón
Data: 15/11/2023
4. El següent tipus de dades emmagatzema les notes mitjanes d’un grup de cicles formatius. Cada nota correspon a la nota mitjana de cada alumne:

*/

using System;

namespace SegonaProvaPractica
{
    class AntonucciSandroCodeEx4
    {
        static void Main()
        {
            const int Min = 4, Max = 9;

            const string MsgGrade = "Nota {0}: {1}";
            const string MsgAverage = "La nota mitjana de la classe és: {0}";
            const string MsgStudentsBetween = "Hi ha {0} alumnes que han obtingut notes entre {1} i {2} de mitjana (inclosos)";
            const string MsgSearch = "Introdueix el valor a cercar: ";
            const string MsgNumFound = "El nombre està dins l'array";
            const string MsgNumNotFound = "El nombre no està dins l'array";


            int studentsBetween = 0, searchPosition = 0;

            double search = 0;

            float average = 0;

            bool numFound = false;


            float[] marks = { 5.5f, 10f, 3.5f, 1.25f, 1.75f, 6.2f, 5.15f, 6.75f, 4.15f, 9.25f, 8.75f, 2.75f, 0.0f, 1.35f, 6.55f };

            //Apartado A 

            //Recorre el array, imprime el valor y lo suma a average
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(MsgGrade, i+1, marks[i]);
                average += marks[i];
            }

            //Divide average para encontrar la media real
            average /= marks.Length;
            Console.WriteLine(MsgAverage, average);

            //Apartado B
            
            //Ordena el array de forma descendente utilizando bubble sort
            for (int i = 0; i < marks.Length-1; i++)
            {
                for(int j = i+1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        float aux = marks[i];
                        marks[i] = marks[j];
                        marks[j] = aux;
                    }
                }
            }

            //Imprime los valores del array (no uso foreach ya que necesito la posicion para imprimir nota 1, nota 2...)
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(MsgGrade, i + 1, marks[i]);
            }

            Console.WriteLine(MsgAverage, average);

            //Apartado C
            //Recorre el array y suma uno a la variable studentsBetween si la nota está entre 4 y 9 incluidos
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] >= Min && marks[i] <= 9) studentsBetween++;
                Console.WriteLine(MsgGrade, i + 1, marks[i]);
            }

            Console.WriteLine(MsgAverage, average);
            Console.WriteLine(MsgStudentsBetween, studentsBetween, Min, Max);

            //Apartado D
            Console.Write(MsgSearch);
            search = Convert.ToDouble(Console.ReadLine());

            //Busca la variable search en la array, si la encuentra se deja de ejecutar el while
            while ((searchPosition < marks.Length) && numFound == false)
            {
                if (Convert.ToDouble(marks[searchPosition]) == search) numFound = true;
                searchPosition++;
            }

            //Operador ternario para imprimir el resultado
            Console.WriteLine(numFound ? MsgNumFound : MsgNumNotFound);
            

        }
    }
}