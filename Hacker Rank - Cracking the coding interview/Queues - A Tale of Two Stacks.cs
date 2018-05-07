using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    private class MyQueue<T>
    {
        Stack<T> s1 = new Stack<T>();
        Stack<T> s2 = new Stack<T>();

        public void Enqueue(T data)
        {
            s1.Push(data);
        }
        public void Dequeue()
        {
            RefactorStacks();
            s2.Pop();

        }
        public void Print()
        {
            RefactorStacks();
            Console.WriteLine(s2.Peek());
        }
        private void RefactorStacks()
        {
            if (s2.Count <= 0)
                while (s1.Count > 0)
                    s2.Push(s1.Pop());
        }
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int q = Int32.Parse(Console.ReadLine());
        MyQueue<Int32> queue = new MyQueue<Int32>();
        for (int i = 0; i < q; i++)
        {
            string[] arr = Console.ReadLine().Split(' ');
            if (arr[0].Equals("1"))
                queue.Enqueue(Int32.Parse(arr[1]));
            if (arr[0].Equals("2"))
                queue.Dequeue();
            if (arr[0].Equals("3"))
                queue.Print();
        }
    }
}