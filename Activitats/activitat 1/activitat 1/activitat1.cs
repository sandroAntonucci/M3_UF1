using System;

namespace MyApplication
{
    class Range
    {
        static void Main()
        {

            const string MsgMin = "Introdueix el primer nombre del rang: ";
            const string MsgMax = "Introdueix el últim nombre del rang: ";
            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "El número no està dins del rang.";

            int min, max, num;

            Console.Write(MsgMin);
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgMax);
            max = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());

            if (!(min < num && num < max))
            {
                Console.WriteLine(MsgEnd);
            }
        }
    }
}