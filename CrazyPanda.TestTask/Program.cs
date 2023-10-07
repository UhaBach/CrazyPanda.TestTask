namespace CrazyPanda.TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<uint> list = new List<uint>();
            Random r = new Random();
            int length = r.Next(1, 10000000);
            ulong s = (ulong)r.NextInt64(0, 100000);
            Console.WriteLine("Array length: " + length);
            Console.WriteLine("Sum: " + s);
            for (int i = 0; i < length; i++)
            {
                list.Add((uint)r.Next(0, 10000));
            }
            FindElementsForSum(list, s, out int start, out int end);
            Console.WriteLine("Start: " + start);
            Console.WriteLine("End: " + end);
            FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out int start2, out int end2);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Start: " + start2);
            Console.WriteLine("End: " + end2);
            FindElementsForSum(new List<uint> { 4, 5, 6, 7, 8 }, 18, out int start3, out int end3);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Start: " + start3);
            Console.WriteLine("End: " + end3);
            FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out int start4, out int end4);
            Console.WriteLine("=====================================================");
            Console.WriteLine("Start: " + start4);
            Console.WriteLine("End: " + end4);
        }

        static public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0;
            end = 0;
            ulong s = 0;
            while (true)
            {
                if (s == sum) break;
                else if (end == (list.Count - 1) && (start == end || s < sum))
                {
                    start = 0; end = 0; break;
                }
                else if ((end == (list.Count - 1) && s > sum) || (s > sum))
                {
                    s -= list[start];
                    start++;
                }
                else if (end == start || s < sum)
                {
                    s += list[end];
                    end++;
                }
            }
            return;
        }
    }
}