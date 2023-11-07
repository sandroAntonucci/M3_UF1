/*Author: Sandro Antonucci Rejón
 * M03. Programació UF2
 * v1. 24/10/2023
   13. Implementa un programa que demani 20 nombres enters per teclat i retorni els valors de les posicions senars. *
 */


using System;

namespace MyApplication
{

    class OddPosition
    {
        static void Main()
        {
            const int Cases = 20;

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgResult = "Valors de les posicions senars: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int[] nums = new int[Cases];


            for (int i = 0; i < Cases; i++)
            {
                Console.Write(MsgNum);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(MsgResult);

            for (int i = 0; i < Cases; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
