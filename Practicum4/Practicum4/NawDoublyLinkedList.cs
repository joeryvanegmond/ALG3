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
            if (link != Last)
            {
                DoubleLink secondLink = link.Next;
                DoubleLink thirdLink = secondLink.Next;
                DoubleLink pastLink = link.Previous;

                if (link == First)
                {
                    First = secondLink;
                    link.Next = thirdLink;
                    link.Previous = secondLink;
                    secondLink.Next = link;
                    secondLink.Previous = null;
                    thirdLink.Previous = link;
                }
                else if (secondLink == Last)
                {
                    Last = link;
                    link.Next = null;
                    link.Previous = secondLink;
                    secondLink.Next = link;
                    secondLink.Previous = pastLink;
                    pastLink.Next = secondLink;
                }
                else
                {
                    thirdLink.Previous = link;
                    link.Next = thirdLink;
                    link.Previous = secondLink;
                    secondLink.Next = link;
                    secondLink.Previous = pastLink;
                    pastLink.Next = secondLink;
                }
                return secondLink;
            }
            return null;
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
