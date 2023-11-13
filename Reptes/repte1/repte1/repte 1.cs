using System;

namespace MyApplication
{
    class Jungling
    {

        static void Main()
        {

            const string MsgCases = "Introdueix el nombre de casos a introduir: ";
            const string MsgHp = "Introdueix la vida del monstre: ";
            const string MsgRammus = "Introdueix el atac de Rammus: ";
            const string MsgTwitch = "Introdueix el verí de Twitch: ";
            const string MsgNoDmg = "Ni Rammus ni Twitch tenen atac, el monstre no pot morir.";

            int cases, hp, rammus, twitch;
            int rounds = 1;

            bool rammusTurn = true;


            Console.Write(MsgCases);
            cases = Convert.ToInt32(Console.ReadLine());

            while(cases > 0)
            {
                Console.Write(MsgHp);
                hp = Convert.ToInt32(Console.ReadLine());

                Console.Write(MsgRammus);
                rammus = Convert.ToInt32(Console.ReadLine());

                Console.Write(MsgTwitch);
                twitch = Convert.ToInt32(Console.ReadLine());

                if (rammus != 0 || twitch != 0){
                    while (hp > 0)
                    {

                        if (rammusTurn == true)
                        {
                            hp -= rammus;
                            rammusTurn = false;
                        }
                        else
                        {
                            hp -= twitch;
                            rammusTurn = true;
                            rounds++;
                        }
                    }
                    Console.WriteLine(rammusTurn == false ? "RAMMUS " + rounds : "TWITCH " + (rounds - 1));
                    rammusTurn = true;
                }
                else
                {
                    Console.WriteLine(MsgNoDmg);
                }

                rounds = 1;
                cases--;
            }
           
        }

    }
}