﻿/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 13/11/2023
 * Repte 8. L’algoritme de Luhn, també conegut com a algorisme de mòdul 10 o mod 10, és una fórmula simple de comprovació que s’utilitza per validar una varietat de números d’identificació, com ara números de targeta de crèdit, números IMEI, números d’assegurança social canadenc. La fórmula LUHN va ser creada a finals dels anys seixanta per un grup de matemàtics. Poc després, les empreses de targetes de crèdit el van adoptar. Com que l'algoritme es troba en un domini públic, pot utilitzar-lo tothom. La majoria de les targetes de crèdit i molts números d’identificació del govern utilitzen l’algoritme com a mètode senzill per distingir els números vàlids de xifres errònies o d’alguna manera incorrecta. Va ser dissenyat per protegir contra errors accidentals, no atacs maliciosos.
 *
 */


using System;

namespace MyApplication
{

    class Luhn
    {
        static void Main()
        {

            const string MsgNum = "Introdueix un nombre enter: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            int odd = 0;

            string num;

            Console.Write(MsgNum);
            num = Console.ReadLine();

            int[] nums = new int[num.Length];

            if (num.Length % 2 == 1) odd = 1;

            for (int i = num.Length-1; i > 0; i--)
            {
                if((i  + odd) % 2 == 0)
                {
                    nums[i] = Convert.ToInt32(num[i]);
                }
                else
                {
                    nums[i] = Convert.ToInt32(num[i]) * 2;
                }
            }

            foreach (int i in nums) Console.Write(i); 

            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
