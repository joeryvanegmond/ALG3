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
                var secondLink = link.Next;
                if (link == First)
                {
                    First = secondLink;
                    secondLink.Previous = null;
                }
                else
                {
                    link.Next = secondLink.Next;
                    link.Previous = secondLink;
                }

                if (secondLink == Last)
                {
                    Last = link;
                    link.Next = null;
                }
                else
                {
                    secondLink.Next = link;
                    secondLink.Previous = link.Previous;
                }
                return secondLink;
            }
            return null;
        }


        //public DoubleLink SwapLinkWithNext(DoubleLink link)
        //{
        //    if (link != Last)
        //    {
        //        DoubleLink secondLink = link.Next;

        //        if (First == link)
        //        {
        //            First.Next = link;
        //            First.Previous = null;
        //        }
        //        else
        //        {
        //            link.Previous = secondLink;
        //            secondLink.Next = link;
        //        }
        //        if (secondLink == Last)
        //        {

        //        }

        //        return link;
        //    }

        //    return null;

        //}

        //public DoubleLink SwapLinkWithNext(DoubleLink link)
        //{
        //    // swap first with second
        //    if (link == First)
        //    {
        //        var eerste = link.Next;
        //        var tweede = link;

        //        First = eerste;
        //        eerste.Next = tweede;
        //        tweede.Previous = eerste;
        //        tweede.Next = link.Next.Next;
        //        eerste.Previous = null;
        //    }
        //    // swap second-last with last
        //    else if (link.Next == Last)
        //    {
        //        var laatste = Last;
        //        var eenNaLaatste = link;

        //        Last.Previous = laatste;
        //        laatste.Next = eenNaLaatste;
        //        laatste.Previous = link.Previous;
        //        link.Previous.Next = laatste;
        //        Last = eenNaLaatste;
        //        eenNaLaatste.Previous = laatste;
        //        Last.Next = null;
        //    }
        //    // swap second with third
        //    else if (link == First.Next)
        //    {
        //        var derde = link.Next;
        //        var tweede = link;

        //        First.Next = derde;
        //        derde.Previous = First;
        //        derde.Next = tweede;
        //        tweede.Previous = derde;
        //        tweede.Next = Last;
        //        Last.Previous = tweede;
        //    }

        //    //var eersteSchakel = link.Next;
        //    //var tweedeSchakel = link;

        //    //tweedeSchakel.Previous = eersteSchakel;
        //    //tweedeSchakel.Next = link.Next.Next;
        //    //eersteSchakel.Next = tweedeSchakel;
        //    //eersteSchakel.Previous = link.Previous;

        //    return link;
        //}

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
