using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_05.Recuperacio.MiquelManzano
{
    public class T1Exercises
    {
        const int Min = 0;
        const int Max = 100;

        public static void ShowPairs()
        {
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

        public static void ShowNumAvg()
        {
            const string AskN = "Cuants numeros vols introduir?";

            Console.Clear();
            Console.WriteLine("T1 - Activitats: Exercici 8");

            Console.WriteLine(AskN);
            int n = UserInteraction.AskUserIntNumber(Min, Max);
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdueix el número {i + 1}: ");
                sum += UserInteraction.AskUserIntNumber(Min, Max);
            }
            double avg = (double)sum / n;

            Console.WriteLine($"La mitjana es: {avg}");
        }

        public static void ExampleExpressions()
        {
            Console.Clear();
            Console.WriteLine("T1 - Activitats: Exercici 9");
            Console.WriteLine("Prova de finestra Watch");

            int x = 4;
            int y = 7;
            bool p = true;
            bool q = false;

            bool ex1 = !(x * y < 30) && p;
            bool ex2 = (x - y) <= 5 && !(p || q);

            Console.WriteLine($"Primera expressio: {ex1}\nSegona expressio: {ex2}");
        }
    }
}
