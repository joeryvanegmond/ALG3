using Alg1.Practica.Utils.Models;
using System;

namespace Alg1.Practica.Practicum3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PerformanceTest.TestSortPerformance();

            InsertionSortableNawArrayUnordered testCase = new InsertionSortableNawArrayUnordered(10);
            //testCase.Add(new NAW("8", "8", "8"));
            //testCase.Add(new NAW("3", "3", "3"));
            //testCase.Add(new NAW("5", "5", "5"));
            //testCase.Add(new NAW("7", "7", "7"));
            //testCase.Add(new NAW("9", "9", "9"));
            //testCase.Add(new NAW("1", "1", "1"));
            //testCase.Add(new NAW("0", "0", "0"));
            //testCase.Add(new NAW("6", "6", "6"));
            //testCase.Add(new NAW("4", "4", "4"));
            //testCase.Add(new NAW("2", "2", "2"));

            testCase.Add(new NAW("0", "0", "0"));
            testCase.Add(new NAW("1", "1", "1"));
            testCase.Add(new NAW("2", "2", "2"));
            testCase.Add(new NAW("3", "3", "3"));
            testCase.Add(new NAW("8", "8", "8"));
            testCase.Add(new NAW("5", "5", "5"));
            testCase.Add(new NAW("6", "6", "6"));
            testCase.Add(new NAW("7", "7", "7"));
            testCase.Add(new NAW("4", "4", "4"));
            testCase.Add(new NAW("9", "9", "9"));

            testCase.Show();
            //testCase.InsertionSort();
            //testCase.Show();
            testCase.InsertionSortInverted();
            testCase.Show();
            Console.WriteLine(testCase.Counter);
            Console.ReadKey();


        }
    }
}
