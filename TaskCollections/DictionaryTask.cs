namespace TaskCollections
{
    public class Dictnry
    {
        //DICTIONARY task2
        static public void SortLists(List<int> list1, List<string> list2)
        {
            list1.Sort();
            list2.Sort();
            list2.Reverse();
            var dictionary = new Dictionary<int, string>();
            for (int i = 0; i < list1.Count; i++)
            {
               dictionary.Add(list1[i], list2[i]);

            }
            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }
        }
    }
}
