using System;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> mq = new();
            mq.Push(1);
            mq.Push(2);
            mq.Push(3);
            mq.Push(4);
            mq.Push(5);
            Console.WriteLine("Fill the queue done. Begin take values:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Current size: {mq.Count()}");
                Console.WriteLine($"Pop element: {mq.Pop()}");
            }
            Console.WriteLine($"Current size: {mq.Count()}");
            Console.WriteLine("Trying to get Exception:");
            try
            {
                mq.Pop();
            }
            catch
            {
                Console.WriteLine("Got u!");
            }
            
        }
    }
}
