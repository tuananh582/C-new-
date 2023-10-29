using System;
using System.Collections.Generic;
namespace stackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peek() will return the element at the top of the stack without removing it
            //Define stack
            Stack<int> stack = new Stack<int>();
            //Add element to the stack using Push()
            stack.Push(1);
            Console.WriteLine($"Top value in the stack is : {stack.Peek()}");
            stack.Push(13378);
            Console.WriteLine($"Top value in the stack is : {stack.Peek()}");
            stack.Push(2);
            int mystack = stack.Pop();
            Console.WriteLine($"Top value in the stack is : {stack.Peek()},{mystack}");
            Console.WriteLine(stack.Count);
            Console.WriteLine("///");
            //
            int[] numbers = new int[] { 8, 2, 4, 3, 7, 6, 2 };
            Stack<int> myStack = new Stack<int>();
            foreach (int number in numbers)
            {
                Console.WriteLine(number+"");
                myStack.Push(number);
            }
            Console.WriteLine("");
            Console.WriteLine("The number in reverse");
            while (myStack.Count>0)
            {
                int number = myStack.Pop();
                Console.WriteLine(number+"");
            }
        }
    }
}



