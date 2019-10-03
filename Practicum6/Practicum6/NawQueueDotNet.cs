using System;
using System.Collections;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueDotNet
    {
        private Queue qr = new Queue();

        public void Enqueue(NAW naw)
        {
            qr.Enqueue(naw);
        }

        public NAW Dequeue()
        {
            if (qr.Count != 0)
            {
                return (NAW)qr.Dequeue();
            }
            return null;
        }

        public int Count()
        {
            return qr.Count;
        }

    }
}
