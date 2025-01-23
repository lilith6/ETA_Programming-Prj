using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA_Programming_Prj.Loops
{
    public class ForStatements
    {
        public static void printArrayOfFirstXNumbers(int x)
        {

            int[] range = Enumerable.Range(1, x).ToArray();
            Console.WriteLine(String.Join(", ", range));
        }
        public static void printFirstXNumbers(int x)
        {
            Console.WriteLine($"First {x} numbers are : /n");
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void printMatesArray()
        {
            string[] mates = new string[3];
            mates[0] = "A";
            mates[1] = "B";
            mates[2] = "C";

            for (int i = 0; i < mates.Length; i++)
            {
                Console.WriteLine(mates[i]);
            }
        }

        public static void printMatesList()
        {
            List<string> mates = new List<string>();
            mates.Add("A");
            mates.Add("B");
            mates.Add("C");

            foreach (string s in mates)
            {
                Console.WriteLine(s);
            }
        }

        public static void PrintNumbers()
        {
            printFirstXNumbers(7);
            Console.WriteLine();
            printArrayOfFirstXNumbers(7);
            Console.WriteLine();
            printMatesArray();
            Console.WriteLine();
            printMatesList();
        }
    }
}
