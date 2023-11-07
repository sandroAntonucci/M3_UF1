using System;

namespace MyApplication
{
    class BetweenRange
    {
        static void Main()
        {

            const int FirstNumInRange = 2000, LastNumInRange = 3000, Divisor = 7, Multiple = 5, Zero = 0;

            for(int i = FirstNumInRange; i <= LastNumInRange; i++)
            {

                if (i % Divisor == Zero && i % Multiple != Zero)
                {
                    if(i + Divisor > LastNumInRange)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }

                }

            }
        }
    }
}