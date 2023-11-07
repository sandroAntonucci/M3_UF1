/*Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 24/10/2023
   14. Implementa un programa que demani 20 nombres enters per teclat i retorni els valors de les posicions senars. *
 */


using System;

namespace MyApplication
{

    class Reverse
    {
        static void Main()
        {
            const int Cases = 20;

            const string MsgNum = "Introdueix un nombre enter de l'1 a 9 inclosos): ";
            const string MsgError = "Aquest nombre no està entre 1 i 9.";
            const string MsgNums = "Llista de nombres: ";
            const string MsgReverseNums = "\nLlista de nombres a l'inrevés: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[] nums = new int[Cases];

            int num = 0;


            for (int i = 0; i < Cases; i++)
            {
                do
                {
                    Console.Write(MsgNum);
                    num = Convert.ToInt32(Console.ReadLine());

                    if(num < 1 || num > 9)
                    {
                        Console.WriteLine(MsgError);
                    }
                }while(num < 1 || num > 9);

                nums[i] = num;

            }

            Console.Write(MsgNums);

            for (int i = 0; i < Cases; i++)
            {

                Console.Write(nums[i] + " ");
                
            }

            Console.Write(MsgReverseNums);

            for (int i = Cases-1; i >= 0; i--)
            {

                Console.Write(nums[i] + " ");

            }


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
