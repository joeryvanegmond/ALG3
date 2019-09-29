using System;

namespace Alg1.Practica.Practicum5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //[TEST ARRAYSTACK]
            //ArrayStack arrayStack = new ArrayStack(10);
            //arrayStack.Push("test0");
            //arrayStack.Push("test1");
            //arrayStack.Push("test2");
            //arrayStack.Push("test3");
            //arrayStack.Push("test4");
            //arrayStack.Push("test5");
            //arrayStack.Push("test6");
            //arrayStack.Push("test7");
            //arrayStack.Push("test8");
            //arrayStack.Push("test9");

            ////Console.WriteLine(arrayStack.Peek());
            //Console.WriteLine(arrayStack.IsEmpty());
            //Console.WriteLine(arrayStack.IsFull());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Pop());
            //Console.WriteLine(arrayStack.Peek());
            //Console.WriteLine(arrayStack.IsEmpty());
            //Console.WriteLine(arrayStack.IsFull());

            //Console.ReadLine();

            //[TEST XMLVALIDATOR]
            XmlValidator x = new XmlValidator();
            Console.WriteLine(x.Validate("<sarcasm> Het komt <em>vast</em> goed</sarcasm>"));
            Console.ReadLine();
        }
    }
}
