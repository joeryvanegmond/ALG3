
using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        private int maxSize;
        private ArrayStack arrayStack;
        private int top;

        public bool Validate(string xml)
        {
            maxSize = xml.Length;
            arrayStack = new ArrayStack(maxSize);
            bool tagComplete = true;
            String tag = "";

            foreach (char oneChar in xml.ToCharArray())
            {
                switch (oneChar)
                {
                    case '<': // begint met het maken van een string (tag)
                        tagComplete = false;
                        break;

                    case '>': // voeg elk ander teken toe net zo lang tot dit symbool voorbij komt.
                        if (!tagComplete) // push als de tag compleet is.
                        {
                            tag += oneChar;
                            tagComplete = true;
                            arrayStack.Push(tag);
                            top++;
                            tag = "";
                        }
                        break;

                    default:
                        break;
                }

                if (!tagComplete) { tag += oneChar; }
            }

            for (int i = 0; i < top; i++)
            {
                String[] tags = new string[top];

                tags[i] = arrayStack.Pop();
                Console.WriteLine(tags[i]);
            }

        return false;
            //  TO DO: vergelijk de gepushede tags met elkaar uit de stack en return uiteindelijk true of false;
        }
    }
}


