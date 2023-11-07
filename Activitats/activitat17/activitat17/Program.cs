/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 25/10/2023
 * Exercici 17. Implementa un programa que demani a l’usuari quants valors vol emmagatzemar (en una llista). A continuació l’usuari els haurà d’introduir i el programa haurà de validar si és un nombre natural o no. En cas que no ho sigui, informarà a l’usuari i aquest disposarà de dos intents més per a introduir el nombre correctament. Aquesta restricció és per a tots els nombres que l’usuari introdueixi. En finalitzar, el programa haurà de retornar:
 *
 */


using System;

namespace MyApplication
{

    class ArrayNaturalNums
    {
        static void Main()
        {

            const int min = 15, max = 30;


            const string MsgArrayLength = "Introdueix la quantitat de nombres a introduir: ";
            const string MsgNum = "Introdueix un nombre natural: ";
            const string MsgMin = "\nNombres menors a 15: ";
            const string MsgMax = "\nNombres majors a 30: ";
            const string MsgError = "Aquest nombre no és natural. ";
            const string MsgOutOfTries = "S'han acabat els intents";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int arrayLength, num, tries = 3, lowerFifteen = 0, greaterThirty = 0, quantNumbers = 0;

            Console.Write(MsgArrayLength);
            arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[arrayLength];

            for(int i = 0; i < arrayLength; i++)
            {
                do
                {
                    Console.Write(MsgNum);
                    num = Convert.ToInt32(Console.ReadLine());

                    if(num < 1)
                    {
                        tries--;
                        Console.WriteLine(MsgError);
                    }
                    else
                    {
                        tries = 3;
                    }

                }while (num < 1 && tries > 0);

                if(tries > 0)
                {
                    nums[i] = num;
                    if (nums[i] < min)
                    {
                        lowerFifteen++;
                    }
                    else if (nums[i] > max)
                    {
                        greaterThirty++;
                    }

                    quantNumbers++;
                }
                else
                {
                    Console.WriteLine(MsgOutOfTries);
                }
            }

            Console.WriteLine("Nombres totals: " + quantNumbers);
            Console.WriteLine(MsgMin + lowerFifteen);
            Console.WriteLine(MsgMax + greaterThirty);


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
