/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 16/10/2023
 * 2. L’Isabel Preysler t’ha demanat fer una torre de Ferrero Rocher per a la recepció de l’ambaixador. La torre ha de ser en forma de piràmide quadrada. Això significa que el primer pis tindrà un Ferrero, el segon 4, el tercer 9, el quart 16, i així successivament (cada pis és un quadrat amb un més a cada cantó).
 *
 */


using System;

namespace MyApplication
{

    class Ferrero
    {
        static void Main()
        {

            const string MsgCases = "Introdueix el nombre de casos: ";
            const string MsgFloors = "Introdueix el nombre de pisos: ";
            const string MsgFerreros = "El nombre de ferreros de la piràmid és ";
            const string MsgEnd = "Prem una tecla per continuar.";

            int cases, floors, ferreros;

            Console.Write(MsgCases);
            cases = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < cases; i++)
            {

                ferreros = 0;

                Console.Write(MsgFloors);
                floors = Convert.ToInt32(Console.ReadLine());

                for (int j = 1; j <= floors; j++)
                {
                    ferreros += j * j;
                }

                Console.WriteLine(MsgFerreros + ferreros);
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
