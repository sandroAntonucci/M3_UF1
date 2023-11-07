/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 25/10/2023
 * Exercici 19. Implementa un programa que reculli les següents dades per 10 persones:
 *
 */


using System;

namespace MyApplication
{

    class InfoPerson
    {
        static void Main()
        {
            const int Rows = 10, Cols = 4;

            const string MsgAge = "Introdueix la teva edat: ";
            const string MsgSex = "Introdueix el teu sexe (H/D): ";
            const string MsgPay = "Introdueix el teu salari: ";
            const string MsgIntern = "Introdueix si ets becari (0 fals, 1 cert): ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[,] data = new int[Rows, Cols];

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    switch (j){
                        case 0:
                            Console.Write(MsgAge);
                            data[i, j] = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 1:
                            Console.Write(MsgSex);
                            data[i, j] = Console.ReadLine() == "H" ? 0:1;
                            break;

                        case 2:
                            Console.Write(MsgPay);
                            data[i, j] = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
                            break;

                        case 3:
                            Console.Write(MsgIntern);
                            data[i, j] = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write(data[i, j]);
                            break;

                        case 1:
                            Console.Write(data[i, j] == 0 ? "H" : "M");
                            break;

                        case 2:
                            Console.Write(data[i, j]);
                            break;

                        case 3:
                            Console.Write(Convert.ToBoolean(data[i, j]) ? "Ets becari" : "No ets becari");
                            break;

                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
