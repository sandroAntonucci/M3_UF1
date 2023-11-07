using System;

namespace MyApplication
{

    class Game
    {
        static void Main()
        {
            const int GuessNum = 45, Zero = 0, One = 1, Tries = 10;
            
            const string MsgGame = "Escull una opció: \nJugar (introdueix 1) \nSortir (introdueix 0)";
            const string MsgNum = "Adivina un nombre entre 1 i 100: ";
            const string MsgNumLower = "El nombre a endevinar és més petit";
            const string MsgNumGreater = "El nombre a endevinar és més gran";
            const string MsgNumGuessed = "¡Ho has endevinat! El nombre era ";
            const string MsgMaxTries = "T'has quedat sense intents :(";
            const string MsgEndGame = "Adeu";

            int option, num = 0;

            do
            {
                Console.WriteLine(MsgGame);
                option = Convert.ToInt32(Console.ReadLine());
            } while(option != 0 && option != 1);


            switch (option)
            {
                case 0:
                    Console.WriteLine(MsgEndGame);
                    break;

                case 1:
                    for (int i = Zero; i < Tries; i++)
                    {
                        Console.Write(MsgNum);
                        num = Convert.ToInt32(Console.ReadLine());

                        if (num > GuessNum)
                        {
                            Console.WriteLine(MsgNumLower);
                        }
                        else if (num < GuessNum)
                        {
                            Console.WriteLine(MsgNumGreater);
                        }
                        else
                        {
                            Console.WriteLine(MsgNumGuessed + num);
                            i = 10;
                        }
                    }

                    if (num != GuessNum)
                    {
                        Console.WriteLine(MsgMaxTries);
                    }

                    break;
            }         
        }
    }
}