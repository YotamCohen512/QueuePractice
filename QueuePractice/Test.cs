using System;
using System.Text;
using Unit4.CollectionsLib;

namespace QueuePractice
{
    static class Test
    {
        public static void RunTests()
        {
            Console.Write("SumTest: ");
            PrintPassOrFailed(SumTest());

            Console.Write("RemoveNumberTest: ");
            PrintPassOrFailed(RemoveNumberTest());

            Console.Write("IsInQueueTest: ");
            PrintPassOrFailed(IsInQueueTest());

            Console.Write("RemoveDoubleTest: ");
            PrintPassOrFailed(RemoveDoubleTest());

        }

        private static void PrintPassOrFailed(bool isPass)
        {
            if (isPass)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pass");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fail");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static bool SumTest()
        {
            // creates queue
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                queue.Insert(i);
            }

            // tests sum method
            return Program.Sum(queue) == 45;
        }

        private static bool RemoveNumberTest()
        {
            // creates queue
            Queue<int> queue = new Queue<int>();
            queue.Insert(3);
            queue.Insert(5);
            queue.Insert(5);
            queue.Insert(8);

            // tests remove number method
            return Program.RemoveNumber(queue, 5) == 2 && queue.Remove() == 3 && queue.Remove() == 8 && queue.IsEmpty();
        }

        private static bool IsInQueueTest()
        {
            // creates queue
            Queue<int> queue = new Queue<int>();
            queue.Insert(1);
            queue.Insert(4);
            queue.Insert(7);
            queue.Insert(8);

            // tests is in queue method
            return Program.IsInQueue(queue, 4) && !Program.IsInQueue(queue, 5);
        }

        private static bool RemoveDoubleTest()
        {
            // creates queue
            Queue<int> queue = new Queue<int>();
            queue.Insert(1);
            queue.Insert(1);
            queue.Insert(3);
            queue.Insert(3);

            // tests remove double method
            Program.RemoveDouble(queue);
            return queue.Remove() == 1 && queue.Remove() == 3 && queue.IsEmpty();
        }
    }
}
