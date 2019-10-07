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
            nd.Insert("A", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("B", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("C", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("D", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("E", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("F", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("G", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("H", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("I", new Utils.Models.NAW("1", "1", "1"));
            nd.Insert("J", new Utils.Models.NAW("1", "1", "1"));

        }
    }
}
