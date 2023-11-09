/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 09/11/2023
 * Exercici 5. Implementa un programa que generi una matriu de 4x4 i mostri la diagonal principal (pots inicialitzar-la amb els valors enters que consideris).
 *
 */


using System;

namespace MyApplication
{

    class Diagonal
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[,] numbers = { {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16} };

            //Recorre la matriu i utilitza el mateix nombre per a la fila i la columna (primera columna - primer valor, segona columna - segon valor...)
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine(numbers[i, i]);
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
