using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum7
{
    public class LogFile : INawDictionary
    {
        protected LogFileLink Head { get; set; }

        public virtual void Insert(string key, NAW value)
        {
            if (key == null) { throw new ArgumentNullException(); }

            if (Head == null)
            {
                Head = new LogFileLink(key, value, null);
            }
            else
            {
                var temp = Head;
                Head = new LogFileLink(key, value, temp);

            }
        }

        public virtual NAW Find(string key)
        {
            if (key != null && Head != null)
            {
                bool isFound = false;
                var i = Head;
                

                while (!isFound)
                {

                    if (i.Key.Equals(key))
                    {
                        if (i.Value != null)
                        {
                            return i.Value;
                        }
                        return null;
                    }

                    if (i.Next == null)
                    {
                        return null;

                    }
                    i = i.Next;
                }
            }
            return null;
        }

        public virtual NAW Delete(string key)
        {
            if (key != null && Head != null)
            {
                bool isDeleted = false;
                var i = Head;
                var beforeKey = i;
                var temp = i;

                if (Head.Key.Equals(key))
                {
                    if (Head.Value != null)
                    {
                        Head = temp.Next;
                        return temp.Value;
                    }
                    return null;
                }

                while (!isDeleted)
                {
                    if (i.Key.Equals(key))
                    {
                        if (i.Value != null)
                        {
                            temp = i;
                            i = null;
                            beforeKey.Next = temp.Next;
                            return temp.Value;
                        }
                        return null;
                    }
                    beforeKey = i;
                    i = i.Next;
                }
                return temp.Value;
            }
            return null;
        }
    }

}
