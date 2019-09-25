using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
namespace Alg1.Practica.Practicum3
{
    public class SelectionSortableNawArrayUnordered : NawArrayUnordered, ISelectionSort
    {
        public SelectionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void SelectionSort()
        {
            int curMin = 0;
            if (_nawArray != null)
            {
                for (int a = 0; a < _used; a++)
                {
                    curMin = a;
                    for (int b = a + 1; b < _used; b++)
                    {
                        if (_nawArray[b].CompareTo(_nawArray[curMin]) == -1)
                        {
                            curMin = b;
                        }
                    }
                    if (a != curMin)
                    {
                        _nawArray.Swap(a, curMin);
                    }
                }
            }
        }

        public void SelectionSortInverted()
        {
            int temp = 0;
            if (_nawArray != null)
            {
                for (int a = _used - 1; a > 0; a--)
                {
                    temp = a;
                    for (int b = a - 1; b >= 0; b--)
                    {
                        if (_nawArray[b].CompareTo(_nawArray[temp]) == 1)
                        {
                            temp = b;
                        }
                    }
                    if (temp != a)
                    {
                        _nawArray.Swap(a, temp);
                    }

                }
            }
        }
    }
}
