using System;

namespace MyApplication
{

    class PrimeNumber
    {

        static void Main()
        {

            const string Msg = "Introdueix un nombre: ";

            int num;
            bool primeNum = false;

            Console.Write(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    primeNum = true;
                }
            }

            Console.WriteLine(primeNum ? "El nombre no es primer" : "El nombre es primer");

        }

    }

}