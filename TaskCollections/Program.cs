using TaskCollections;

class Program
{    
    static void Main(string[] args)
    {
        //LIST tasks
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(ListsTask.SumEvens(numbers));
        List<string> words = new List<string>() { "Hello", "Hi", "Privet", "Slovo" };
        Console.WriteLine(ListsTask.WordsByLength(words));

        //LINKEDLIST task1
        var linkedNumbers = new List<int>() { 2, 4, 3, 2, 8, 2, 5, 1, 2 };
        LinkedList<int> anotherNumbers = new LinkedList<int>(linkedNumbers);
        LinkedListsTask.AddAfter(anotherNumbers);

        //LINKEDLIST task2
        List<int> numbersToMerge1 = new List<int>() { 1, 3, 4, 7, 12 };
        List<int> numbersToMerge2 = new List<int>() { 1, 5, 7, 9 };
        List<int> merged = new List<int>();
        if (numbersToMerge1.Count > numbersToMerge2.Count)
        {
            for (int i = 0; i < numbersToMerge1.Count; i++)
            {
                for (int j = 0; j < numbersToMerge2.Count; j++)
                {
                    if (numbersToMerge1[i] == numbersToMerge2[j])
                    {
                        merged.Add(numbersToMerge1[i]);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < numbersToMerge2.Count; i++)
            {
                for (int j = 0; j < numbersToMerge1.Count; j++)
                {
                    if (numbersToMerge1[i] == numbersToMerge2[j])
                    {
                        merged.Add(numbersToMerge2[i]);
                    }
                }
            }
        }
        foreach (int element in merged)
        {
            Console.WriteLine(element);
        }

        //QUEUE & STACK task1
        var queueElements = new Queue<int>();
        Console.WriteLine("Input 5 int numbers:");
        for (int i = 0; i < 5; i++)
        {
            queueElements.Enqueue(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine(QueuesStackTask.GetMaxValue(queueElements));
        QueuesStackTask.DeleteMaxValue(queueElements);
        Stack<string> letters = new Stack<string>();
        QueuesStackTask.Reverse(letters);
        letters.Clear();
        QueuesStackTask.ReversePosition(letters);

        //DICTIONARY task1
        Dictionary<string, int> people = new Dictionary<string, int>();
        people.Add("Polina", 30);
        people["John"] = 55;
        Console.WriteLine(people["Polina"]);

        //DICTIONARY task2
        List<int> numbersInt = new List<int>() { 8, 2, 13, 43, 25, 62, 27, 18, 9, 1 };
        List<string> wordsString = new List<string>() { "Blue", "Red", "White", "Green", "Black", "Yellow", "Pink", "Brown", "Magenta", "Grey" };
        Dictnry.SortLists(numbersInt, wordsString);

        //DICTIONARY task3
        Dictionary<string, City> cities = new Dictionary<string, City>();
        cities.Add("Krakow", new City(800000, 40.2));
        cities.Add("Warsaw", new City(2000000, 80.5));
        cities.Add("Gdansk", new City(450000, 30.5));
        cities.Add("Lodz", new City(700000, 55.4));
        cities.Add("Wroclaw", new City(500000, 38.5));
        foreach (var element in cities.OrderBy(x => x.Value.area).ToList())
        {
            Console.WriteLine($"{element.Key}, {element.Value.population}, {element.Value.area}");
        }
        foreach (var element in cities.OrderByDescending(x => x.Value.population).ToList())
        {
            Console.WriteLine($"{element.Key}, {element.Value.population}, {element.Value.area}");
        }
        int result = 0;
        foreach (var element in cities)
        {
            result += element.Value.population;
        }
        Console.WriteLine($"Sum of population: {result}");
    }
}
