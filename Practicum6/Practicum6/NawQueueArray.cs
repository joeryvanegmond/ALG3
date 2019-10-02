using System;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueArray
    {
        public int Front { get; set; }

        public int Rear { get; set; }

        protected Alg1NawArray _array; // interne array
        protected int _count; // aantal gebruikte index in interne array
        protected int _size; // maximale omvang van interne array

        public NawQueueArray(int initialSize)
        {
            // aanmaken intern array
            if ((initialSize > 0) && (initialSize <= 1000))
            {
                _size = initialSize;
            }
            else
            {
                throw new NawQueueArrayInvalidSizeException();
            }

            _array = new Alg1NawArray(_size);

            // verdere initialisatie

            Front = 0;
            Rear = -1;
        }

        public void Enqueue(NAW naw)
        {
            if (Rear == _size - 1)
            {
                Rear = -1;
                _array[++Rear] = naw;
            }

        }

        public NAW Dequeue()
        {
            var temp = _array[Front++];
            if (Front == _size)
                Front = 0;
            return temp;
        }

        public int Count()
        {
            if (Rear >= Front) 
            {
                return Rear - Front + 1;
            }
            else
            {
                return (_size - Front) + (Rear + 1);
            }
                
        
        }
    }

}
