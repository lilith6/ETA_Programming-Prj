using System;

namespace ETA_Programming_Prj
{
    public class MethodOverload
    {
        public static void MetodaTest()
        {
            //SumNumbers();
            //SumNumbers(33, 77);
            //SumNumbers(61, 99, 643);

            int sum = GetSum(6, 9876, 345);
            Console.WriteLine(sum);
        }

        public static void SumNumbers()
        {
            int number1 = 10;
            int number2 = 700;
            int sum = number1 + number2;
            Console.WriteLine($"The result is {sum}");
        }

        public static void SumNumbers(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine($"The result is {sum}");
        }

        public static void SumNumbers(int number1, int number2, int number3)
        {
            int sum = number1 + number2 + number3;
            Console.WriteLine($"The result is {sum}");
        }

        public static int GetSum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

    }
}
