namespace TaskCollections
{
    public class ListsTask
    {
       public static int SumEvens(List<int> list)
        {
            int result = 0;
            foreach (int number in list)
                if (number % 2 == 0)
                {
                    result += number;
                }
            return result;
        }

        public static string WordsByLength(List<string> list)
        {
            Console.WriteLine("Type value (try 5):");
            int value = Convert.ToInt32(Console.ReadLine());
            foreach (string word in list)
                if (word.Length == value)
                {
                    Console.WriteLine(word);
                }
            return "Words with 5 letters";
        }
    }
}
