﻿using ETA_Programming_Prj;
using static ETA_Programming_Prj.MethodOverload;
using System;

namespace ETA_Programmimg_Prj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Session 5 
            ///
            //Session5.MetodaTest();
            ///Practice 1 && 5
            ///
            Person person1 = new Person();
            person1.GetPersonData();
            Console.WriteLine(person1.ToString());

            ///Practice 6
            ///
            person1.IsOld();
            person1.ShowGender();

        }
    }
}
