using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum5
{
    public class Stack : IStack
    {
        protected StackLink First { get; set; }

        public void Push(string value)
        {
            if (value != null)
            {
                if (First != null)
                {
                    var temp = First;
                    First = new StackLink();
                    First.String = value;
                    First.Next = temp;
                }
                else
                {
                    First = new StackLink();
                    First.String = value;
                    First.Next = null;
                }
                
            }
        }

        public string Pop()
        {
            if (First != null)
            {
                var temp = First;
                First = temp.Next;
                return temp.String;
            }
            else
            {
                return null;
            }
        }

        public string Peek()
        {
            throw new System.NotImplementedException();
        }

        public bool IsEmpty()
        {
            if (First != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
