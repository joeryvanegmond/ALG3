using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class NawDoublyLinkedList
    {
        public DoubleLink First { get; set; }
        public DoubleLink Last { get; set; }

        public void InsertHead(NAW naw)
        {
            DoubleLink link = new DoubleLink();
            link.Naw = naw;

            if (First == null)
            {
                First = link;
                Last = link;
            }
            else
            {
                var temp = First;
                First = link;
                First.Next = temp;
                temp.Previous = First;
            }
        }

        public NAW ItemAtIndex(int index)
        {
            throw new System.NotImplementedException();
        }

        public DoubleLink SwapLinkWithNext(DoubleLink link)
        {

            if (link == First)
            {
                var temp = link.Next;
                First = temp;
                First.Next = link;
                link.Previous = First;
                link.Next = temp.Next;
            }
            else if (link.Next == Last)
            {
                var temp = Last;
                Last = link;
                Last.Previous = temp;
                Last.Next = null;
                temp.Next = Last;
            }
            else
            {
                var temp = link.Next;
                temp.Next = link;
                temp.Previous = First;
                link.Previous = temp;
                link.Next = Last;
                First.Next = temp;
                Last.Previous = link;


            }



            return link;
        }

        public void BubbleSort()
        {
            throw new System.NotImplementedException();
        }

        public BigO OrderOfBubbleSort()
        {
            throw new System.NotImplementedException();
        }
    }
}
