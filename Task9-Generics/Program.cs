using Task9_Generics;

class Program
{
    static void Main(string[] args)
    {
        static T[] GenerateElements<T>(int count = 1) where T : Human, new()
        {
            T[] array1;
            array1 = new T[count];
            for (int i = 0; i < count; i++)
            {
                array1[i] = new T();
            }
            return array1;
        }

        var newmen = GenerateElements<Man>(5);
        var newwomen = GenerateElements<Woman>(2);
        Console.WriteLine(newmen[3].firstName);

        DataStore<Man> men = new DataStore<Man>(5);
        DataStore<Woman> women = new DataStore<Woman>(5);

        men.Add(1, new Man());
        men.Add(2, new Man("Test","QA"));
        men.Add(3, new Man("Man3", "B"));

        Console.WriteLine(men.GetItem(1));
        women.Add(1, new Woman());
        women.Add(2, new Woman("Woman2", "A"));

        Console.WriteLine(women);
        Console.WriteLine(men);

    }
}
