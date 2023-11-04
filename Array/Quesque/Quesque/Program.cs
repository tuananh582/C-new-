using System;
using System.Collections.Generic;

namespace Quesque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a queue of integers
            Queue<int> myque = new Queue<int>();
            myque.Enqueue(1);
            myque.Enqueue(2);
            myque.Enqueue(3);
            myque.Enqueue(4);
            myque.Enqueue(5);
            foreach (var id in myque)
            {
                Console.WriteLine(id);
            }

        }
    }

}


