
using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        private int maxSize;
        private ArrayStack arrayStack;
        private int top;
        private bool result = false;
        private String tag = "";


        public bool Validate(string xml)
        {
            maxSize = xml.Length;
            arrayStack = new ArrayStack(maxSize);
            bool tagComplete = true;

            if (xml.Length != 0)
            {
                foreach (char oneChar in xml.ToCharArray())
                {
                    switch (oneChar)
                    {
                        case '<': // begint met het maken van een string (tag)
                            tagComplete = false;
                            break;

                        case '>': // voeg elk ander teken toe net zo lang tot dit symbool voorbij komt.
                            if (!tagComplete) // push als de tag nog niet compleet is.
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

                String[] tags = new string[top];

                //  add tags to array
                for (int i = 0; i < top; i++)
                {
                    tags[i] = arrayStack.Pop();
                    Console.WriteLine(tags[i]);
                }

                //  check tags
                for (int i = 0; i < top; i++)
                {
                    for (int j = top - 1; j > 0; j--)
                    {
                        if (tags[i][1].Equals('/'))
                        {
                            if (tags[i].Equals(tags[j]))
                            {
                                result = true;
                                Console.WriteLine("true " + tags[i] + tags[j]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("false " + tags[i] + tags[j]);
                        }
                    }
                }

            }
            else
            {
                result = true;
            }

            return result;
          
        }

        //[van steff]
        //public bool Validate(string xml)
        //{
        //    System.Console.WriteLine("==CALCULATING==");
        //    if (xml.Length == 0)
        //    {
        //        return true;
        //    }

        //    ArrayStack arrayStack = new ArrayStack(10);

        //    int i = 0;
        //    bool valid = false;

        //    while (i < xml.Length)
        //    {
        //        if (xml[i].Equals('<'))
        //        {
        //            string tag = "";
        //            i++;

        //            while (!xml[i].Equals('>'))
        //            {
        //                tag += xml[i];
        //                i++;
        //            }

        //            System.Console.WriteLine("-FOUND TAG: " + tag);
        //            System.Console.WriteLine("-FIRST CHR: " + tag[0]);

        //            if (!tag[0].Equals('/'))
        //            {
        //                System.Console.WriteLine("+PUSH: " + tag);
        //                arrayStack.Push(tag);
        //                System.Console.WriteLine("+PEEK: " + arrayStack.Peek());
        //            }
        //            else if (tag[0].Equals('/'))
        //            {
        //                System.Console.WriteLine("+PEEK: " + arrayStack.Peek());

        //                if (!string.IsNullOrEmpty(arrayStack.Peek()))
        //                {
        //                    string tempTag = tag.Remove(0, 1);
        //                    System.Console.WriteLine("+TODO: " + tempTag);

        //                    if (arrayStack.Peek().Equals(tempTag))
        //                    {
        //                        arrayStack.Pop();
        //                    }
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //            else
        //            {
        //                valid = false;
        //                break;
        //            }
        //        }
        //        i++;
        //    }


        //    if (arrayStack.IsEmpty())
        //    {
        //        valid = true;
        //    }
        //    return valid;
        //}


    }
}


