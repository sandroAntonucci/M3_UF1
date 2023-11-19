/*
    Autor: Sandro Antonucci Rejón
    Data: 15/11/2023
    3. Implementa un programa que demani a l’usuari quants valors vol introduir, de manera que el programa generi una llista a partir de valors introduïts per teclat i retorni el producte de tots els elements d’aquesta. Els valors que l’usuari pot introduir són entre (15, 100) i l’usuari disposa de 5 intents en total.
*/

using System;

namespace SegonaProvaPractica
{
    class AntonucciSandroCodeEx3
    {
        static void Main()
        {
            const int Max = 100, Min = 15;

            const string MsgArrayLength = "Introdueix la mida de la llista: ";
            const string MsgNum = "Introdueix un nombre enter entre 15 i 100: ";
            const string MsgOutOfTries = "T'has quedat sense intents.";
            const string MsgResult = "La multiplicació de tots els elements de la llista és ";

            int numsLength = 0, num = 0, tries = 5, multiplication = 1;

            //Bucle per a comprovar que la llargada de la llista sigui major que 0
            do
            {

                Console.Write(MsgArrayLength);
                numsLength = Convert.ToInt32(Console.ReadLine());

            } while (numsLength < 1);

            int[] nums = new int[numsLength];


            //For que va assignant els valors a l'array si están dins del rang
            for(int i = 0; i < numsLength; i++)
            {

                //Comprovem que l'usuari no s'hagi quedat sense intents
                if(tries > 0)
                {
                    //Do-While per a comprovar que el nombre està dins del rang, si no, resta un intent
                    do
                    {
                        Console.WriteLine(MsgNum);
                        num = Convert.ToInt32(Console.ReadLine());

                        if (num > Max || num < Min) tries--;

                    } while ((num > Max || num < Min) && tries > 0);
                }
                
                //Si l'usuari no s'ha quedat sense intents a l'anterior do-while, assigna el nombre a la posició corresponent
                if(tries > 0)
                {
                    nums[i] = num;
                }
            }

            //Multiplica cada nombre de l'array
            foreach (int i in nums)
            {
                multiplication *= i;
            }

            //Operador ternari per mostrar si l'usuari s'ha quedat sense intents o el resultat de la multiplicació
            Console.WriteLine(tries > 0 ? MsgResult + multiplication: MsgOutOfTries);

        }
    }
}