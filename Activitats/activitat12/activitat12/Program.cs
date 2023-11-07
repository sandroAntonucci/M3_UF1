/*Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 24/10/2023
 * 12. Implementa un programa que demani 20 nombres enters per teclat i retorni els valors separats en dues files: parell i senars.
 *
 */


using System;

namespace MyApplication
{

    class OddEven
    {
        static void Main()
        {
            const int Cases = 20;

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[] oddNums = new int[Cases], evenNums = new int[Cases];

            int num;


            for(int i = 0; i < Cases; i++)
            {
                Console.Write(MsgNum);
                num = Convert.ToInt32(Console.ReadLine());

                if(num % 2 == 0)
                {
                    evenNums[i] = num;
                }
                else
                {
                    oddNums[i] = num;
                }

            }

            Console.Write("Parells: ");
            for(int i = 0; i < Cases;i++)
            {
                if (evenNums[i] != 0)
                {
                    Console.Write(evenNums[i] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("Senars: ");
            for (int i = 0; i < Cases; i++)
            {
                if (oddNums[i] != 0)
                {
                    Console.Write(oddNums[i] + " ");
                }
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
