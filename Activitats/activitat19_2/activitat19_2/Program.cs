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
            const int Rows = 3, Cols = 4;

            const string MsgAge = "Introdueix la teva edat: ";
            const string MsgSex = "Introdueix el teu sexe (H/D): ";
            const string MsgPay = "Introdueix el teu salari: ";
            const string MsgIntern = "Introdueix si ets becari (0 fals, 1 cert): ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[] age = new int[Rows];
            char[] sex = new char[Rows];
            double[] salary = new double[Rows];
            bool[] intern = new bool[Rows];


            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write(MsgAge);
                            age[i] = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 1:
                            Console.Write(MsgSex);
                            sex[i] = Convert.ToChar(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write(MsgPay);
                            salary[i] = Convert.ToDouble(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write(MsgIntern);
                            intern[i] = Convert.ToInt32(Console.ReadLine()) == 0 ? false : true;
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
                            Console.Write(age[i] + " ");
                            break;

                        case 1:
                            Console.Write(sex[i] == 'H' ? "Home " : "Dona ");
                            break;

                        case 2:
                            Console.Write(salary[i] + " ");
                            break;

                        case 3:
                            Console.Write(Convert.ToBoolean(intern[i]) ? "Ets becari" : "No ets becari" + " ");
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
