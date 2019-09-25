using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class BubbleSortableNawArrayUnordered : NawArrayUnordered, IBubbleSort
    {
        public BubbleSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void BubbleSort()
        {
            for (var a = 0; a < _used; a++) {

                for (var b = 0; b < _used - 1; b++) {

                    if (_nawArray[b].CompareTo(_nawArray[b + 1]) == 1) {
                        _nawArray.Swap(b, b + 1);
                    }

                }

            }
        }

        public void BubbleSortInverted()
        {
            for (var a = 0; a < _used; a++)
            {

                for (var b = _used; b < 0; b--)
                {

                    if (_nawArray[b].CompareTo(_nawArray[b - 1]) == -1)
                    {
                        _nawArray.Swap(b, b - 1);
                    }

                }

            }
       
        }
    }
}
