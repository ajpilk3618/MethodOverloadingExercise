using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this works just trust me okay!");

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            int sum = num1 + num2;
            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum <= 1)
            {
                return $"{sum} dollar";
            }
            else return $"{sum}";
        }
    }
}
