using System;
using System.Collections;
using System.Collections.Generic;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawPriorityQueue
    {
        private int _count;
        private SortedList<int, Queue> pq = new SortedList<int, Queue>();
        private int First { get; set; }

        public void Enqueue(int priority, NAW naw)
        {
            Queue temp;

            if (_count != 0)
            {
                if (pq.ContainsKey(priority))
                {
                    pq[priority].Enqueue(naw);
                    
                    _count++;
                }
                else 
                {
                    temp = new Queue();
                    temp.Enqueue(naw);
                    pq.Add(priority, temp);
                    _count++;
                }
                First = pq.Keys[0];
                return;
            }

            temp = new Queue();
            temp.Enqueue(naw);
            pq.Add(priority, temp);
            First = pq.Keys[0];
            _count++;
        }

        public NAW Dequeue()
        {
            if (Count() != 0)
            {
                var temp = (NAW) pq[First].Dequeue();

                if (pq[First].Count == 0)
                {
                    pq.RemoveAt(0);
                }

                _count--;

                if (Count() != 0)
                {
                    First = pq.Keys[0];
                }
                
                return temp;
            }
            return null;
        }

        public int Count()
        {
            return _count;
        }

        public void Show()
        {
            // Deze methode is handig bij het debuggen maar wordt niet nagekeken
        }
    }
}
