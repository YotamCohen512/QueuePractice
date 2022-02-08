using System;
using Unit4.CollectionsLib;

namespace QueuePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test.RunTests();
        }
        

        #region homework methods
        public static int Sum(Queue<int> queue)
        {
            // returns the sum of the numbers in a queue
            // Time Complexity: O(n)
            // n - number of values in queue

            int sum = 0;

            while (!queue.IsEmpty())
            {
                sum += queue.Remove();
            }

            return sum;
        }

        public static int RemoveNumber(Queue<int> queue, int number)
        {
            // removes a given number from a given queue
            // Time Complexity: O(2n)
            // n - number of values in queue

            Queue<int> dummy = new Queue<int>();
            int counter = 0;

            while (!queue.IsEmpty())
            {
                if (queue.Head() == number)
                {
                    queue.Remove();
                    counter++;
                }

                else
                {
                    dummy.Insert(queue.Remove());
                }
            }

            Copy(queue, dummy);
            return counter;
        }

        public static bool IsInQueue(Queue<int> queue, int number)
        {
            // checks if number is in queue
            // Time Complexity: O(2n)
            // n - number of values in queue

            Queue<int> dummy = new Queue<int>();

            while (!queue.IsEmpty())
            {
                if (queue.Head() == number)
                {
                    return true;
                }
                dummy.Insert(queue.Remove());
            }

            Copy(queue, dummy);
            return false;
        }

        public static void RemoveDouble(Queue<int> queue)
        {
            // removes numbers that already appeared in queue
            // Time Complexity: O(n^2 + n)
            // n - number of values in queue

            Queue<int> dummy = new Queue<int>();

            while (!queue.IsEmpty())
            {
                dummy.Insert(queue.Head());
                RemoveNumber(queue, queue.Remove());
            }

            Copy(queue, dummy);
        }

        #endregion

        #region support methods
        public static int Count(Queue<int> queue)
        {
            // counts the number of values in a queue
            // Time Complexity: O(2n)
            // n - number of values in queue

            Queue<int> dummy = new Queue<int>();
            int counter = 0;

            while (!queue.IsEmpty())
            {
                counter++;
                dummy.Insert(queue.Remove());
            }

            Copy(queue, dummy);
            return counter;
        }

        public static void Copy(Queue<int> q1, Queue<int> q2)
        {
            // copies q2 onto q1 while ruining q2
            // Time Complexity: O(n)
            // n - number of values in queue

            while (!q2.IsEmpty())
            {
                q1.Insert(q2.Remove());
            }
        }

        #endregion
    }
}
