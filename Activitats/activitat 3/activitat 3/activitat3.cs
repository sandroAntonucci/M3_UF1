using Microsoft.VisualBasic;
using System;

namespace MyApplication
{
    class CountDigits
    {

        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgDigits = "La quantitat de digits d'aquest nombre és ";
            const string MsgOddDigits = "Sumant els digits senars dona ";
            const string MsgEvenDigits = "Sumant els digits parells dona ";

            const int Zero = 0, Decimals = 10, Two = 2;

            int num, digits = 0, oddDigits = 0, evenDigits = 0;

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine()); 

            if (num == Zero)
            {
                digits = 1;
            }
            else
            {
                while (num > Zero)
                {
                    if (num % Two == Zero)
                    {
                        evenDigits += num % Decimals;
                    }
                    else
                    {
                        oddDigits += num % Decimals;
                    }
                    num /= Decimals;
                    digits++;
                }

            }

            Console.WriteLine(MsgDigits + digits);
            Console.WriteLine(MsgOddDigits + oddDigits);
            Console.WriteLine(MsgEvenDigits + evenDigits);  

        }

    }
}