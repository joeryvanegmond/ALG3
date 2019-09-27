using Alg1.Practica.Utils.Models;
using System;

namespace Alg1.Practica.Practicum4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NawDoublyLinkedList lijst = new NawDoublyLinkedList();

            NAW n1 = new NAW("1", "1", "1");
            NAW n2 = new NAW("2", "2", "2");
            NAW n3 = new NAW("3", "3", "3");
            NAW n4 = new NAW("4", "4", "4");
            NAW n5 = new NAW("5", "5", "5");

            //DoubleLink first = new DoubleLink();
            lijst.First = new DoubleLink() { Naw = n5 };
            lijst.First.Next = new DoubleLink() { Naw = n4 };
            lijst.First.Next.Next = new DoubleLink() { Naw = n3 };
            lijst.First.Next.Next.Next = new DoubleLink() { Naw = n2 };
            lijst.First.Next.Next.Next.Next = new DoubleLink() { Naw = n1 };
            lijst.Last = lijst.First.Next.Next.Next.Next;
            lijst.Last.Previous = lijst.First.Next.Next.Next;
            lijst.Last.Previous.Previous = lijst.First.Next.Next;
            lijst.Last.Previous.Previous.Previous = lijst.First.Next;
            lijst.Last.Previous.Previous.Previous.Previous = lijst.First;
            //lijst.Last.Previous.Previous.Previous.Previous.Previous = lijst.First;


            //Utils.Models.DoubleLink second = new DoubleLink();
            //Utils.Models.DoubleLink third = new DoubleLink();
            //Utils.Models.DoubleLink fourth = new DoubleLink();
            //Utils.Models.DoubleLink fifth = new DoubleLink();
            //first.Naw = new NAW("1", "1", "1");
            //second.Naw = new NAW("2", "2", "2");
            //third.Naw = new NAW("3", "3", "3");
            //fourth.Naw = new NAW("4", "4", "4");
            //fifth.Naw = new NAW("5", "5", "5");

            //first = lijst.First;
            //second = first.Next;
            //third = second.Next;
            //fourth = third.Next;
            //fifth = fourth.Next;


            Console.WriteLine(lijst.First.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Next.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Next.Next.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Next.Next.Next.Naw.Naam);

            lijst.BubbleSort();

            Console.WriteLine(lijst.First.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Next.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Next.Next.Naw.Naam);
            Console.WriteLine(lijst.First.Next.Next.Next.Next.Naw.Naam);
            Console.ReadLine();
        }
    }
}
