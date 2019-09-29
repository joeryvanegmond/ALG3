using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class ArrayStack : IStack
    {
        protected string[] values;
        protected int size;
        protected int count;

        public ArrayStack(int capacity)
        {
            if (capacity > 0)
            {
                values = new string[capacity];
                size = capacity;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Push(string value)
        {
            if (count != size)
            {
                if (size != 0)
                {
                    values[count] = value;
                    count++;
                }
                else
                {
                    values[count] = value;
                    count++;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public string Pop()
        {
            if (count != 0)
            {
                var temp = count - 1;
                count--;
                return values[temp];
            }
            else
            {
                return null;
            }
        }

        public string Peek()
        {
            if (count != 0)
            {
                return values[count - 1];
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (size == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}