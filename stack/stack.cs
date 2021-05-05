using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace stack
{
    class Stack
    {
        private exam[] stack;
        const int max = 100;
        int top;
        public Stack()
        {
            stack = new exam[max];
        }
        static int Size(int top)
        {
            int size = 0;
            for (int i = top; i >= 0; i--) size++;
            return size;
        }
        public exam Pop()
        {
            if (top > 0) return stack[--top];
            else
            {
                Console.WriteLine("Stack empty");
                return null;
            }
        }
        public void Push(exam data)
        {
            if (top < max) stack[top++] = data;
            else Console.WriteLine("Stack full");
        }

    }
}