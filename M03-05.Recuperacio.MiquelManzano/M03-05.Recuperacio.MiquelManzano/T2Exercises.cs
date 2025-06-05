using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace M03_05.Recuperacio.MiquelManzano
{
    public class T2Exercises
    {
        const int Min = 0;
        const int Max = 100;

        // Exercici 5
        public static void FactorialPrimeNum()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 5");

            int number = UserInteraction.AskUserIntNumber(Min, Max);

            // Calculate factorial
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Check if the number is prime
            bool isPrime = true;
            if (number < 2)
            { 
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            Console.WriteLine($"El factorial de {number} és {factorial}");
            Console.WriteLine(isPrime ? "És un número primer" : "No és un número primer");
        }

        // Exercici 6
        public static void Array10()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 6");

            int[] nums = new int[10];
            int pair = 0;
            int odd = 0;
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Numero {i + 1} de {nums.Length}");

                nums[i] = UserInteraction.AskUserIntNumber(Min, Max);
                total += nums[i];
                if (nums[i] % 2 == 0)
                {
                    ++pair;
                }
                else
                {
                    ++odd;
                }
            }
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 6");
            Console.WriteLine($"\nResultatls:\nLa mitjana es: {total/nums.Length}\nNumero de parells: {pair}\nNumero de senars: {odd}");
        }

        // Exercici 7
        public static void MathsMenu()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 7");

            Console.WriteLine("\n--------------------\nMaths Menu:\n0. Exit\n1. Calcular àrea d’un rectangle\n2. Mostrar si un any és de traspàs\n--------------------");

            switch (UserInteraction.AskUserIntNumber(Min, Max))
            {
                case 0:
                    Console.WriteLine("Sortint...");
                    break;
                case 1:
                    Console.WriteLine($"Àrea rectangle: {CalculateRectangle(UserInteraction.AskUserIntNumber(Min, Max), UserInteraction.AskUserIntNumber(Min, Max))}");
                    break;
                case 2:
                    Console.WriteLine(PassYear(UserInteraction.AskUserIntNumber(0, 9999)) ? "És un any de traspàs" : "No és un any de traspàs");
                    break;
            }
        }

        public static int CalculateRectangle(int x, int y)
        {
            return x * y;
        }
        public static bool PassYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Exercici 8
        public static void TwoNumDivision()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 8");

            try
            {
                Console.Write("Introdueix el dividend: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Introdueix el divisor: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultat: {a / b}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: valor no vàlid.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: no es pot dividir entre 0.");
            }
        }

        // Exercici 9
        public static void PasswordValidator()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 9");


            Console.WriteLine("\nEscriu una password que ha de: \n- Tindre entre 8 i 12 caràcters\n- Incloure almenys una majúscula, una minúscula i un número\n- No contingui espais\n");
            string pwd = " ";
            bool validPwd;

            do
            {
                pwd = Console.ReadLine();
                validPwd = ValidPassword(pwd);
                if (!validPwd)
                {
                    Console.WriteLine("Password no valida!");
                }
                else
                {
                    Console.WriteLine("Password valida!");
                }
            } while (!validPwd);
        }

        public static bool ValidPassword(string pwd)
        {
            return pwd.Length >= 8 && pwd.Length <= 12 &&
                       pwd.Any(char.IsUpper) &&
                       pwd.Any(char.IsLower) &&
                       pwd.Any(char.IsDigit) &&
                       !pwd.Contains(" ");

        }

        // Exercici 10
        public static void StringValidator()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 10");

            Console.WriteLine("\nEscriu una cadena tingui 8 dígits seguits d’una lletra\n");
            string str = " ";
            bool validStr;

            do
            {
                str = Console.ReadLine();
                validStr = ValidString(str);
                if (!validStr)
                {
                    Console.WriteLine("Cadena no valida!");
                }
                else
                {
                    Console.WriteLine("Cadena valida!");
                }
            } while (!validStr);
        }

        public static bool ValidString(string input)
        {
            return Regex.IsMatch(input, @"^\d{8}[A-Za-z]$");
        }

        // Exercici 11
        public static void WeekDayDate()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 11");

            Console.WriteLine("\n\nEscriu una data en format: (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine($"Data valida. Dia de la semana: {date.DayOfWeek}.");
            }
            else
            {
                Console.WriteLine("Data invalida.");
            }
        }

        // Exercici 12
        public static void NumType()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 12");

            int userNum = UserInteraction.AskUserIntNumber(Min, Max);

            if (userNum > 0)
            {
                Console.WriteLine("El numero es positiu");
            }
            else if (userNum < 0)
            {
                Console.WriteLine("El numero es negatiu");
            }
            else{
                Console.WriteLine("El numero es 0");
            }

            Console.WriteLine(userNum % 2 == 0 ? "Es parell" : "Es senar");
        }

        // Exercici 13
        public static void MultiplyTable()
        {
            Console.Clear();
            Console.WriteLine("T2 - Activitats: Exercici 13");

            int userNum = UserInteraction.AskUserIntNumber(Min, Max);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{userNum} * {i} = {userNum*i}");
            }
        }
    }
}
