using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_05.Recuperacio.MiquelManzano
{
    public class T1Exercises
    {
        public static void ShowPairs()
        {
            const int Min = 0;
            const int Max = 100;

            Console.Clear();
            Console.WriteLine("T1 - Activitats: Exercici 7");

            int userNum = UserInteraction.AskUserIntNumber(Min, Max);

            Console.WriteLine("Divisors parells de {0}", userNum);

            for (int i = 1; userNum >= i; i++ )
            {
                if (userNum % i == 0 && i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
