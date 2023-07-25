using Task9_Generics;

class Program
{
    static void Main(string[] args)
    {
        static T GenerateElements<T>() where T : Human, new()
        {
            return new T(); 
        }

        var newmen = GenerateElements<Man>();
        var newwomen = GenerateElements<Woman>();

        DataStore<Man> men = new DataStore<Man>(5);
        DataStore<Woman> women = new DataStore<Woman>(5);

        men.Add(1, new Man());
        Console.WriteLine($"{men.GetItem(1)}");
        women.Add(1, new Woman());
        women.Add(2, new Woman());

        Console.WriteLine(women.ToString());
        Console.WriteLine(men.ToString());

    }
}
