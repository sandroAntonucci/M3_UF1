/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 16/10/2023
 * Exercici 3. La vida d'un ascensor és dura: sempre amunt i avall portant pes, i mai ningú et dóna les gràcies. Per veure fins a quin punt n'és dura la seva vida, hem instal·lat un sistema que ens informarà cada cop que algú premi un botó de l'ascensor.
 *
 */


using System;

namespace MyApplication
{

    class Elevator
    {
        static void Main()
        {

            const string MsgMinFloors = "Introdueix el pis mínim: ";
            const string MsgMaxFloors = "Introdueix el pis máxim: ";
            const string MsgCurrentFloor = "Introdueix el pis actual: ";
            const string MsgFloorToMove = "Introdueix el pis al que vols anar (X per sortir): ";
            const string MsgEnd = "Prem una tecla per continuar.";

            int minFloors, maxFloors, currentFloor, timesMoved = 0, quantFloorsMoved = 0, floorToMoveNum;
            string floorToMove = "", wrongFloor = "";

            Console.Write(MsgMinFloors);
            minFloors = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgMaxFloors);
            maxFloors = Convert.ToInt32(Console.ReadLine());

            Console.Write(MsgCurrentFloor);
            currentFloor = Convert.ToInt32(Console.ReadLine());


            while(floorToMove != "X")
            {
                Console.Write(MsgFloorToMove);
                floorToMove = Console.ReadLine();

                if(floorToMove != "X")
                {
                    floorToMoveNum = Convert.ToInt32(floorToMove);

                    if(floorToMoveNum >= minFloors && floorToMoveNum <= maxFloors && floorToMoveNum != currentFloor)
                    {

                        timesMoved++;
                        
                        if(currentFloor > floorToMoveNum)
                        {
                            quantFloorsMoved += currentFloor - floorToMoveNum;
                        }
                        else
                        {
                            quantFloorsMoved += floorToMoveNum - currentFloor;
                        }

                        currentFloor = floorToMoveNum;
                    }
                    else if(floorToMoveNum <= minFloors || floorToMoveNum >= maxFloors)
                    {
                        wrongFloor = "E";
                    }
                }

            }

            Console.WriteLine(timesMoved + " " + quantFloorsMoved + " " + currentFloor + " " + wrongFloor);


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
