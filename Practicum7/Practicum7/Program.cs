using System;

namespace Alg1.Practica.Practicum7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NawDictionary nd = new NawDictionary(10);
            nd.Insert("A", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("A", new Utils.Models.NAW("3", "3", "3"));
            nd.Insert("B", new Utils.Models.NAW("B", "B", "B"));
            nd.Insert("C", new Utils.Models.NAW("C", "C", "C"));
            nd.Insert("D", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("E", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("F", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("G", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("H", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("I", new Utils.Models.NAW("1", "1", "1"));

           
            //Console.WriteLine(nd.Find("B"));
            //nd.Delete("C");
            //Console.WriteLine(nd.Find("C"));
            //Console.WriteLine(nd.Count);
            Console.WriteLine(nd.LoadFactor);
            Console.ReadLine();
            //Console.WriteLine(nd.Count);

        }
    }
}
