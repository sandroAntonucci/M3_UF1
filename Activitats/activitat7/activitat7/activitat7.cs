using System;

namespace MyApplication
{
    class Week
    {

        static void Main()
        {

            const string Msg = "Introdueix el nombre del dia de la setmana: ";

            int day;

            Console.Write(Msg);
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.Write("Dilluns"); break;
                case 2:
                    Console.Write("Dimarts"); break;
                case 3:
                    Console.Write("Dimecres"); break;
                case 4:
                    Console.Write("Dijous"); break;
                case 5:
                    Console.Write("Divendres"); break;
                case 6:
                    Console.Write("Dissabte"); break;
                case 7:
                    Console.Write("Diumenge"); break;
            }

        }

    }

}