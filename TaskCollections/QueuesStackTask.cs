namespace TaskCollections
{
    public class QueuesStackTask
    {
        static public int GetMaxValue(Queue<int> queue)
        {
            Console.WriteLine("Getting the max value but not removing:");
            int max = 0;
            foreach (int element in queue)
                if (element > max)
                {
                    max = element;
                }
            return max;
        }

        static public void DeleteMaxValue(Queue<int> queue)
        {
            Console.WriteLine("Getting the max value and removing:");
            Queue<int> reffQ = new Queue<int>();
            int s = queue.Count;
            int cnt = 0;

            int max = 0;
            foreach (int element in queue)
                if (element > max)
                {
                    max = element;
                }
            Console.WriteLine($"Max value removed: {max}");
            while (queue.Count != 0 && queue.Peek() != max)
            {
                reffQ.Enqueue(queue.Peek());
                queue.Dequeue();
                cnt++;
            }
            queue.Dequeue();
            while (reffQ.Count != 0)
            {
                queue.Enqueue(reffQ.Peek());
                reffQ.Dequeue();
            }
            int k = s - cnt - 1;
            while (k-- > 0)
            {
                int p = queue.Peek();
                queue.Dequeue();
                queue.Enqueue(p);
            }
            foreach (int element in queue)
            {
                Console.WriteLine(element);
            }
        }
        static public void Reverse(Stack<string> letters)
        {
            Console.WriteLine("Type a letter 3 times:");
            for (int i = 0; i < 3; i++)
            {
                letters.Push(Console.ReadLine());
            }
            Console.WriteLine("Basically this is reverse order if comparing the order of letters typing:");
            foreach (string element in letters)
            {
                Console.WriteLine(element);
            }            
        }

        static public void ReversePosition(Stack<string> letters)
        {
            Console.WriteLine("Type a letter 3 times again:");
            for (int i = 0; i < 3; i++)
            {
                letters.Push(Console.ReadLine());
            }
            Console.WriteLine("Reverse positions:");
            Stack<string> temp = new Stack<string>(letters.Count);
            while (letters.Count != 0)
            {
                temp.Push(letters.Pop());
            }
            foreach (string element in temp)
            {
                Console.WriteLine(element);
            }
        }
    }
}
