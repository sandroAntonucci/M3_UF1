/*
 * Author: Sandro Antonucci Rejón
 * M03. Programació UF1
 * v1. 05/11/2023
 * Exercici 24. Fent servir la interpolació, implementa un programa en el que es demani a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu, com a l’exemple:
 */


using System;

namespace MyApplication
{

    class UserInfo
    {
        static void Main()
        {
            const int Info = 3;

            const string MsgName = "Introdueix el teu nom: ";
            const string MsgSurname = "Introdueix el teu cognom: ";
            const string MsgAge = "Introdueix la teva edat: ";
            const string MsgEnd = "\nPrem una tecla per continuar.";

            string[] userInfo = new string[Info];


            for(int i = 0; i < Info; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write(MsgName);
                        userInfo[i] = Console.ReadLine();
                        break;

                    case 1:
                        Console.Write(MsgSurname);
                        userInfo[i] = Console.ReadLine();
                        break;

                    case 2:
                        Console.Write(MsgAge);
                        userInfo[i] = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine($"L'{userInfo[0]} {userInfo[1]} té {userInfo[2]} anys.");


            Console.WriteLine(MsgEnd);
            Console.ReadKey();
        }
    }

}
