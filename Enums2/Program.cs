﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Noah", "Ellis", 31);
            //CustomIteratorProblem testCustomIterator = new CustomIteratorProblem();            
            //foreach (string flightData in testCustomIterator)
            //{
            //    Console.Write(flightData);
            //}
            //EnumProblem enumPromblem = new EnumProblem();
            //enumPromblem.PrintWeather();
            //EnumProblem2 enumtest2 = new EnumProblem2();
            //enumtest2.PrintAnimals();
            //UI testUI = new UI();
            //testUI.StartUI();
            SodaMachine testMachine = new SodaMachine();
            testMachine.PutInChange();
            Console.ReadKey();

        }
    }
}
