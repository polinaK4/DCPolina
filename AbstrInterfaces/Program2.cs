using AbstractClasses;
class Program2
{
    static void Main(string[] args)
    {
        XXXX.Sum(1);
    }
    public class XXXX
    {
        public static void Sum(params int[] numbers)
        {
            int result = 0;
            foreach (var n in numbers)
            {
                result += n;
            }
            Console.WriteLine(result);
        }

        public static void Sum(int x)
        {
            Console.WriteLine("hello");
        }
    }
}




