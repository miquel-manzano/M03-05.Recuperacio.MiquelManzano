namespace M03_05.Recuperacio.MiquelManzano
{
    public class Program
    {
        private static void Main(string[] args)
        {
            const int Min = 0;
            const int Max = 99;
            const string MenuEx = "\n0. Exit\n\n1. T1 - Activitats: Exercici 7\n2. T1 - Activitats: Exercici 8\n3. T1 - Activitats: Exercici 9\n\n4. T2 - Activitats: Exercici 5\n5. T2 - Activitats: Exercici 6\n6. T2 - Activitats: Exercici 7\n7. T2 - Activitats: Exercici 8\n8. T2 - Activitats: Exercici 9\n9. T2 - Activitats: Exercici 10\n10. T2 - Activitats: Exercici 11\n11. T2 - Activitats: Exercici 12\n12. T2 - Activitats: Exercici 13";

            Console.WriteLine("M03-05.Recuperacio.MiquelManzano");
            Console.WriteLine(MenuEx);


            switch (UserInteraction.AskUserIntNumber(Min, Max))
            {
                case 0:
                    Console.WriteLine("Good night...");
                    break;
                case 1:
                    T1Exercises.ShowPairs();
                    break;
                case 2:
                    T1Exercises.ShowNumAvg();
                    break;
                case 3:
                    T1Exercises.ExampleExpressions();
                    break;
                case 4:
                    T2Exercises.FactorialPrimeNum();
                    break;
                case 5:
                    T2Exercises.Array10();
                    break;
                case 6:
                    T2Exercises.MathsMenu();
                    break;
                case 7:
                    T2Exercises.TwoNumDivision();
                    break;
                case 8:
                    T2Exercises.PasswordValidator();
                    break;
                case 9:
                    T2Exercises.StringValidator();
                    break;
                case 10:
                    T2Exercises.WeekDayDate();
                    break;
                case 11:
                    T2Exercises.NumType();
                    break;
                case 12:
                    T2Exercises.MultiplyTable();
                    break;
            }
        }
    }
}