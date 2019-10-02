
using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        private int maxSize;
        private ArrayStack arrayStack;
        private bool result;

        public bool Validate(string xml)
        {
            if (xml.Length != 0)
            {
                maxSize = xml.Length;
                arrayStack = new ArrayStack(maxSize);
                bool tagComplete = true;
                string tag = "";

                foreach (char oneChar in xml.ToCharArray())
                {
                    switch (oneChar)
                    {
                        case '<': 
                            tag = "";
                            tagComplete = false;
                            break;

                        case '>': 
                            if (!tagComplete)
                            {
                                tag += oneChar;
                                tagComplete = true;
                                

                                if (tag[1].Equals('/'))
                                {
                                    if (!string.IsNullOrEmpty(arrayStack.Peek()))
                                    {
                                        string temp = tag.Remove(1, 1);
                                        if (arrayStack.Peek().Equals(temp))
                                        {
                                            arrayStack.Pop();
                                        }
                                    }
                                    else
                                    {
                                        result = false;
                                        return result;
                                    }
                                }
                                else if (!tag[1].Equals('/'))
                                {
                                    arrayStack.Push(tag);
                                }
                                else
                                {
                                    result = false;
                                    break;
                                }
                            }
                            break;

                        default:
                            break;
                    }
                    if (!tagComplete) { tag += oneChar; }
                }
                if (arrayStack.IsEmpty())
                {
                    result = true;
                }
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}


