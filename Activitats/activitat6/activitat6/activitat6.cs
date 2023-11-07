using System;

namespace MyApplication
{

    class Grades
    {

        static void Main()
        {

            const string Msg = "Introdueix la teva nota: ";

            float grade;

            Console.Write(Msg);
            grade = Convert.ToSingle(Console.ReadLine());  


            if (grade < 5.0 && grade > 0.0)
            {
                Console.WriteLine("Suspès");
            }
            else if (grade < 6.0)
            {
                Console.WriteLine("Suficient");
            }
            else if (grade < 7.0)
            {
                Console.WriteLine("Bé");
            }
            else if (grade < 9.0)
            {
                Console.WriteLine("Notable");
            }
            else if (grade < 10.0)
            {
                Console.WriteLine("Excel·lent");
            }
            else
            {
                Console.WriteLine("Nota Invàlida");
            }
        }

    }


}