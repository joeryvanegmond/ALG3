using System;
using Alg1.Practica.Practicum2;
namespace Alg1.Practica.Practicum3
{
    public class AlternativeBubbleSortableNawArrayUnordered : BubbleSortableNawArrayUnordered
    {
        public AlternativeBubbleSortableNawArrayUnordered(int size) : base(size)
        {
        }

        public void BubbleSortAlternative()
        {
            int outer, inner;
            //int temp;
            for (outer = _used - 1; outer > 0; outer--)
            {
                for (inner = 0; inner < outer; inner++)
                {
                    if (_nawArray[inner].CompareTo(_nawArray[inner + 1]) == 1)
                    {
                        _nawArray.Swap(inner, inner + 1);

                        //temp = inner;
                        //_nawArray[inner] = _nawArray[inner + 1];
                        //_nawArray[inner + 1] = _nawArray[temp];
                    } // if
                } // for
            } // for
        }
    }
}
