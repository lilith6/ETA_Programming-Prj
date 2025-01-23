using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA_Programming_Prj.Loops
{
    internal class WhileStatements
    {
        public static void whileLoopMethod()
        {
            //int counter = 18;
            //while(counter <= 36)
            //{
            //    Console.WriteLine($"The current counter val is  {counter}");
            //    counter++;
            //}

            countWhile(18, 36);
            Console.WriteLine();
            skipWhileCount(1, 1, 10);
            Console.WriteLine();
            stopCountAt(4, 1, 10);
            Console.WriteLine();
            doCountWhile(10, 10);
        }

        public static void countWhile(int counterStart, int counterEnd)
        {
            while (counterStart <= counterEnd)
            {
                Console.WriteLine($"The current counter val is  {counterStart}");
                counterStart++;
            }

        }

        public static void skipWhileCount(int skipVal, int counterStart, int counterEnd)
        {
            while (counterStart <= counterEnd)
            {
                if (counterStart == skipVal)
                {
                    counterStart++;
                    continue;
                }
                Console.WriteLine($"The current counter val is  {counterStart}");
                counterStart++;
            }

        }

        public static void stopCountAt(int stopVal, int counterStart, int counterEnd)
        {
            while (counterStart <= counterEnd)
            {
                if (counterStart == stopVal)
                {
                    break;
                }
                Console.WriteLine($"The current counter val is  {counterStart}");
                counterStart++;
            }
        }

        public static void doCountWhile(int counterStart, int counterEnd)
        {

            do
            {
                Console.WriteLine($"The current counter val in do while is  {counterStart}");
                counterStart--;
            } while (counterStart >= counterEnd);

        }

    }
}
