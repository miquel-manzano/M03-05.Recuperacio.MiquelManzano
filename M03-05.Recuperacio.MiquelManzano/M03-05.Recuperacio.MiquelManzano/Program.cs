namespace M03_05.Recuperacio.MiquelManzano
{
    public class Program
    {
        private static void Main(string[] args)
        {
            const int Min = 0;
            const int Max = 3;
            const string MenuEx = "0. Exit\n1. T1 - Activitats: Exercici 7\n2. T1 - Activitats: Exercici 8\n3. T1 - Activitats: Exercici 9";

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
            }
        }
    }
}