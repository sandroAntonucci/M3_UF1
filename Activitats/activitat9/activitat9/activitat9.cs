using System;
using System.ComponentModel;

namespace MyApplication
{

    class Factorial
    {

        static void Main()
        {

            const string Msg = "Introdueix un número: ";
            const string MsgZero = "El factorial és 0";
            const string MsgResult = "El factorial és ";
            const string MsgEnd = "Prem una tecla per sortir";

            int num;
            int factorial = 1;

            Console.Write(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine(MsgZero);
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine(MsgResult + factorial);
            }

            Console.WriteLine(MsgEnd);
            Console.ReadKey();

        }


    }

}