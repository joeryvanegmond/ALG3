using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum3
{
    public class InsertionSortableNawArrayUnordered : NawArrayUnordered, IInsertionSort
    {
        public InsertionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        private int counter;

        public int Counter { get { return counter; } set { counter = value; } }

        public void InsertionSort()
        {
            int inner, outer;
            if (_nawArray != null)
            {
                for (outer = 1; outer < _used; outer++)
                {
                    NAW temp = _nawArray[outer];
                    inner = outer;
                    while (inner > 0 && _nawArray[inner - 1].CompareTo(temp) == 1)
                    {
                        _nawArray[inner] = _nawArray[inner - 1];
                        inner--;
                    }
                    if (inner != outer)
                    {
                        _nawArray[inner] = temp;
                        Counter += 1;
                    }
                }
            }
        }

        public void InsertionSortInverted()
        {
            int inner, outer;
            if (_nawArray != null)
            {
                for (outer = _used - 1; outer >= 0; outer--)
                {
                    NAW temp = _nawArray[outer];
                    inner = outer + 1;

                    while (inner <= _used - 1 && _nawArray[inner].CompareTo(temp) == -1)
                    {
                        _nawArray[inner - 1] = _nawArray[inner];
                        inner++;
                    }
                    if (inner != outer && _nawArray[inner - 1].CompareTo(temp) != 0)
                    {
                        _nawArray[inner - 1] = temp;
                        Counter += 1;
                    }
                }
            }
        }
    }
}
