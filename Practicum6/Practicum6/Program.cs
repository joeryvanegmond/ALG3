using Alg1.Practica.Practicum6;
using System;

namespace Practicum6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NawPriorityQueue pq = new NawPriorityQueue();

            //pq.Enqueue(4, new Alg1.Practica.Utils.Models.NAW("2", "1", "1"));
            //pq.Enqueue(5, new Alg1.Practica.Utils.Models.NAW("1", "1", "1"));
            //pq.Enqueue(3, new Alg1.Practica.Utils.Models.NAW("9", "3", "3"));
            //pq.Enqueue(9, new Alg1.Practica.Utils.Models.NAW("8", "3", "3"));
            //pq.Enqueue(3, new Alg1.Practica.Utils.Models.NAW("7", "3", "3"));
            //pq.Enqueue(1, new Alg1.Practica.Utils.Models.NAW("6", "3", "3"));
            //pq.Enqueue(6, new Alg1.Practica.Utils.Models.NAW("5", "3", "3"));
            //pq.Enqueue(3, new Alg1.Practica.Utils.Models.NAW("4", "3", "3"));
            //pq.Enqueue(2, new Alg1.Practica.Utils.Models.NAW("3", "3", "3"));
            //pq.Enqueue(1, new Alg1.Practica.Utils.Models.NAW("4", "3", "3"));
            //pq.Enqueue(1, new Alg1.Practica.Utils.Models.NAW("3", "3", "3"));
            //pq.Enqueue(1, new Alg1.Practica.Utils.Models.NAW("2", "2", "2"));
            //pq.Enqueue(1, new Alg1.Practica.Utils.Models.NAW("1", "2", "2"));
            //pq.Enqueue(2, new Alg1.Practica.Utils.Models.NAW("2", "2", "2"));
            //pq.Enqueue(2, new Alg1.Practica.Utils.Models.NAW("6", "6", "6"));
            //pq.Enqueue(2, new Alg1.Practica.Utils.Models.NAW("2", "2", "2"));
            //Console.WriteLine(pq.Peek());

            Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            //Console.WriteLine(pq.Dequeue());
            pq.Show();
        }
    }
}
