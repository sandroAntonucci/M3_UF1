using System;

namespace MyApplication
{

    class Fibonnacci
    {
        static void Main()
        {

            const string Msg = "Introdueix un nombre: ";

            int quantNum, firstNum = 0, secondNum = 0, result = 0;

            Console.Write(Msg); 
            quantNum = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= quantNum; i++)
            {
                if(i == 1)
                {
                    Console.WriteLine(0);
                }
                else if(i == 2)
                {
                    Console.WriteLine(1);
                    firstNum++;
                }
                else if(i % 2 == 1)
                {
                    firstNum = firstNum + secondNum;
                    result = firstNum + secondNum;
                    Console.WriteLine(result);
                }
                else
                {
                    secondNum = firstNum + secondNum;
                    result = firstNum + secondNum;
                    Console.WriteLine(result);
                }
            }
        }
    }

}