using System;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum2
{
    public class MainClass
    {
        public static void Main(String[] args)
        {
            // PerformanceTest.TestSortPerformance();
            BinarySearchableNawArrayOrdered fillArray = new BinarySearchableNawArrayOrdered(11);
            fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            fillArray.Add(new NAW("Piet", "straatnaam 117", "sbeverwijk"));
            fillArray.Add(new NAW("Ari", "Schoouwburgring 79-01", "tilburg"));
            fillArray.Add(new NAW("Johan", "Pieterburenstraat 1", "Den Bosch"));
            fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            fillArray.Add(new NAW("Joery", "straatnaam 1", "iamsterdam"));
            fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            fillArray.AddBinary(new NAW("Klaas", "straatnaam 1", "kmsterdam"));
            fillArray.AddBinary(new NAW("Klaas", "straatnaam 1", "aamsterdam"));

            //BubbleSortableNawArrayUnordered fillArray = new BubbleSortableNawArrayUnordered(10);
            //fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            //fillArray.Add(new NAW("Piet", "straatnaam 117", "beverwijk"));
            //fillArray.Add(new NAW("Ari", "Schoouwburgring 79-01", "tilburg"));
            //fillArray.Add(new NAW("Johan", "Pieterburenstraat 1", "Den Bosch"));
            //fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            //fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            //fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            //fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            //fillArray.Add(new NAW("Joery", "straatnaam 1", "amsterdam"));
            //fillArray.AddBinary(new NAW("Klaas", "straatnaam 1", "gmsterdam"));


            fillArray.Show();

            //fillArray.BubbleSortInverted();
            //fillArray.Show();




            //for (int i = 0; i < fillArray.Array.Size; i++)
            //{
            //    Console.WriteLine(fillArray.Array[i].Naam + " " + fillArray.Array[i].Adres + " " + fillArray.Array[i].Woonplaats);
            //}

            Console.Read();

        }


    }
}
