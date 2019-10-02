using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueLinkedList
    {
        public Link First { get; set; }

        protected Link Last { get; set; }

        protected int _count;

        public void Enqueue(NAW naw)
        {
            if (_count != 0)
            {

                Last.Next = new Link();
                Last = Last.Next;
                Last.Naw = naw;
                _count++;
            }
            else
            {
                First = new Link();
                First.Naw = naw;
                Last = First;
                _count++;
            }
        }

        public NAW Dequeue()
        {
            if (_count != 0)
            {
                var temp = First;
                First = First.Next;
                _count--;
                return temp.Naw;
            }
            else
            {
                return null;
            }
        }

        public int Count()
        {
            return _count;
        }
    }

}
