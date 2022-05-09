using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //Mõlemad mängijad viskavad täringuid
            //programm kontrollib, kumb mängija viskas rohkem
            //see mängija, kes viskab rohkem, on võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);


                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja võitis.");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja võitis mängu. Palju õnne!");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti võitis mängu");
            }
            else
            {
                Console.WriteLine("Mängu tulemus oli viik.");
            }
        }
    }
}
