using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_05.Recuperacio.MiquelManzano
{
    public static class UserInteraction
    {
        public static int AskUserIntNumber(int min, int max)
        {
            int userNum;
            bool flag;
            bool CorrectNum;
            string AskNum = $"\nEscriu un numero entre {min} i {max}";
            string ErrorNum = "Numero {0} incorrecte";

            do
            {
                Console.WriteLine(AskNum);

                CorrectNum = int.TryParse(Console.ReadLine(), out userNum);
                flag = userNum < min || userNum > max;
                if (!CorrectNum || flag)
                {
                    Console.WriteLine(ErrorNum, userNum);
                }
            } while (flag || !CorrectNum);
            return userNum;
        }
    }
}
