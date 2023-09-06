
class Program
{
    static void Main(string[] args)
    {
        //#1. Write a program in C# Sharp to show how the three parts of a query operation execute.         
        int[] array1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var linkQuery =
            from num in array1
            where (num % 2) == 0
            select num;
        Console.Write("Task #1 : \n");
        foreach (int num in linkQuery)
        {
            Console.Write($"{num} ");
        }

        //#2. Create a list of numbers: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14.
        //Write a program in C# Sharp to find the positive numbers within the range of 1 to 11 from a list of numbers using
        //two WHERE conditions in LINQ Query.
        List<int> list1 = new List<int>() { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        var linkQuery2 =
            from num2 in list1
            where num2 > 0
            where num2 < 11
            select num2;
        Console.Write("\nTask #2 : \n");
        foreach (int num2 in linkQuery2)
        {
            Console.Write($"{num2} ");
        }

        //#3. Write a program in C# Sharp to find the number of an array and the square of each number.
        var linkQuery3 =
            from num in array1
            select num;
        Console.Write("\nTask #3 : \n");
        foreach (int num in linkQuery3)
        {
            Console.Write($"Number = {num}, SqrNo = {num*num} \n");
        }

        //#4. Write a program in C# Sharp to display the number and frequency of numbers from the given array.
        int[] array4 = new int[10] { 1, 1, 2, 3, 3, 1, 6, 7, 2, 9 };
        var linkQuery4 =
            from num4 in array4
            group num4 by num4 into x
            select x;
        Console.Write("\nTask #4 : \n");
        foreach (var num4 in linkQuery4)
        {
            Console.WriteLine($"Number: {num4.Key} appears {num4.Count()} times");
        }

        //#5. Write a program in C# Sharp to find the string which starts and ends with a specific character
        List<string> list5 = new List<string>() {"ROME", "LONDON", "NAIROBI", "KRAKOW", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};
        var linkQuery5 =
            from num5 in list5
            where num5.StartsWith("A") 
            where num5.EndsWith("M")
            select num5;
        Console.Write("\nTask #5 : \n");
        foreach (var num5 in linkQuery5)
        {
            Console.WriteLine($"Starts with A and ends with M - {num5}");
        }

        //#6. Write a program in C# Sharp to display the top n-th records
        List<int> list6 = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 7 };
        var linkQuery6 = list6.OrderByDescending(num6 => num6).Take(3);
        Console.Write("\nTask #6 : \n");
        foreach (var num6 in linkQuery6)
        {
            Console.WriteLine($"{num6}");
        }

        //#7. Write a program in C# Sharp to display the list of items in the array according to the length of the string
        //then by name in ascending order
        var linkQuery7 = list5.OrderBy(num7 => num7.Length);
        Console.Write("\nTask #7 : \n");
        foreach (var num7 in linkQuery7)
        {
            Console.WriteLine($"{num7}");
        }

        //8.Write a program in C# Sharp to arrange the distinct elements in the list in ascending order
        List<string> list8 = new List<string>() { "Honey", "Biscuit", "Butter", "Brade" };
        var linkQuery8 = list8.OrderBy(num8 => num8);
        Console.Write("\nTask #8 : \n");
        foreach (var num8 in linkQuery8)
        {
            Console.WriteLine($"{num8}");
        }
    }
}