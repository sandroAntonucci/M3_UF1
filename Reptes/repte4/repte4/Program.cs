/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 16/10/2023
 * Exercici 4.  Partint d’una velocitat standard de 300 kms/hora, aquesta es pot veure afectada segons es situin els passatgers al llarg del tren. Si la càrrega que hi ha costat dret i esquerre no són iguals la velocitat disminueix un 2 Kms/h per casa 50 Kgs complerts També és important que la càrrega estigui ben distribuïda al llarg de tots els vagons del tren. Si la càrrega no és simètrica la velocitat disminueix un 5 Kms/h per cada 100 kgs. de diferència entre la primera meitat i la segona meitat del tren. Això que el Ferran vol dissenyar un algorisme per donar indicacions al maquinista a quina velocitat pot anar, en funció del passatgers que porti.
 *
 */


using System;

namespace MyApplication
{

    class Train
    {
        static void Main()
        {

            const string MsgCases = "Introdueix el nombre de casos: ";
            const string MsgWagons = "Introdueix el nombre de vagons: ";
            const string MsgLeftSeats = "Introdueix els kg a la part esquerra: ";
            const string MsgRightSeats = "Introdueix els kg a la part dreta: ";
            const string MsgEnd = "Prem una tecla per continuar.";

            int cases, wagons, rightSeats, leftSeats, firstHalf, secondHalf, lateralDiff = 0, speed = 300;

            Console.Write(MsgCases);
            cases = Convert.ToInt32(Console.ReadLine());


            for(int i = 0; i < cases; i++)
            {
                Console.Write(MsgWagons);
                wagons = Convert.ToInt32(Console.ReadLine());

                firstHalf = 0; secondHalf = 0; lateralDiff = 0; speed = 300;

                for(int j = 1; j <= wagons; j++)
                {
                    Console.Write(MsgLeftSeats);
                    leftSeats = Convert.ToInt32(Console.ReadLine());
                    Console.Write(MsgRightSeats);
                    rightSeats = Convert.ToInt32(Console.ReadLine());

                    lateralDiff += leftSeats - rightSeats;

                    if(j <= wagons/2)
                    {
                        firstHalf += leftSeats + rightSeats;
                    }
                    else if(j > wagons/2 && wagons % 2 == 0)
                    {
                        secondHalf += leftSeats + rightSeats;
                    }
                    else if(j > (wagons / 2)+1 && wagons % 2 != 0)
                    {
                        secondHalf += leftSeats + rightSeats;
                    }
                }

                if(lateralDiff < 0)
                {
                    lateralDiff *= -1;
                }

                while(lateralDiff > 50)
                {
                    speed -= 2;
                    lateralDiff -= 50;
                }

                if(firstHalf > secondHalf)
                {
                    while(firstHalf - 100 > secondHalf)
                    {
                        speed -= 5;
                        firstHalf -= 100;
                    }
                }
                else
                {
                    while(secondHalf - 100 > firstHalf)
                    {
                        speed -= 5;
                        secondHalf -= 100;
                    }
                }

                Console.WriteLine(speed);

            }





            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
