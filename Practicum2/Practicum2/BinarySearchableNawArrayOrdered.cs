using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using Alg1.Practica.Practicum1;
using System;

namespace Alg1.Practica.Practicum2
{
    public class BinarySearchableNawArrayOrdered : NawArrayOrdered, IBinarySearch
    {
        public BinarySearchableNawArrayOrdered(int initialSize) : base(initialSize)
        {
        }

        public int FindBinary(NAW item)
        {
            var minSize = 0;
            var maxSize = _nawArray.Size - 1;

            if (_used != 0)
            {
                while (minSize <= maxSize)
                {
                    int midNum = (minSize + maxSize) / 2;

                    if (item == _nawArray[midNum])
                    {
                        return midNum;
                    }
                    else if (item.CompareTo(_nawArray[midNum]) == -1)
                    {
                        maxSize = midNum - 1;
                    }
                    else
                    {
                        minSize = midNum + 1;
                    }
                }
            }
            return -1;
        }

        public void AddBinary(NAW item)
        {
            var minSize = 0;
            var maxSize = _used;
            int midNum = 0;

            if (_used == _size)
            {
                throw new Utils.Exceptions.NawArrayOrderedOutOfBoundsException();
            }
            else
            {
                while(minSize <= maxSize)
                {
                    midNum = (minSize + maxSize) / 2;

                    if (_nawArray[midNum] != null)
                    {
                        if (item.CompareTo(_nawArray[midNum]) == -1)
                        {
                            maxSize = midNum - 1;
                        }
                        else
                        {
                            minSize = midNum + 1;
                        }
                    }
                    else {
                        _nawArray[midNum] = item;
                        _used++;
                        return;
                    }
                    
                }
                    for (var i = _used; i > midNum; i--)
                    {
                        _nawArray[i] = _nawArray[i - 1];
                    }
                    _nawArray[midNum] = item;
                    _used++;
            }
        }
    }
}
