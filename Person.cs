using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA_Programming_Prj
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public int addYears { get; set; }

        public Person() {
            firstName = "";
            lastName = "";
            age = 0;
            gender = "unknown";
        } 

        public int calculateFutureUserAge(int plusYears)
        {
            addYears = plusYears;
            return age + plusYears;
        }
        public void GetPersonData()
        {
            Console.Write("Enter your First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter your Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your Gender: ");
            gender = Console.ReadLine();

            Console.Write("Enter number of years in the future ");
            addYears = int.Parse(Console.ReadLine());
        }

        public void IsOld()
        {
            //switch (age)
            //{
            //    case >= 100:
            //        Console.WriteLine("You are ancient!");
            //        break;
            //    case int n when (n >= 50 && n < 100):
            //        Console.WriteLine("You are pretty old");
            //        break;
            //    case < 50: Console.WriteLine("You are stil young!! Yey");
            //        break;
            //}

            if (age < 50)
            {
                Console.WriteLine("You are stil young!! Yey");
            }
            else if (age >= 50 && age < 100)
            {
                Console.WriteLine("You are pretty old");
            }
            else
            {
                Console.WriteLine("You are ancient!");
            }
        }

        public void ShowGender()
        {
            switch (gender.ToLower())
            {
                case "male": Console.WriteLine("You are a male");
                    break;
                case "female": Console.WriteLine("You are a female");
                    break;
                default: Console.WriteLine("You haven't specified your gender!");
                    break;
            }
        }
        public override string ToString()
        {
            return ($"Your details are as follows:\n\t- First Name: {firstName}\n\t" +
                $"- Last Name: {lastName}\n\t- Gender: {gender}\n" +
                $"You will be {calculateFutureUserAge(addYears)} years old in {addYears} years!");
        }

    }
}
