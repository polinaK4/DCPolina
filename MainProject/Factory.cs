using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Factory iTechArt = new Factory
        (
            "iTechArt",
            "Krakow",
            1,
            new Employee[]
            {
                new Employee ("John", "Doe", 23),
                new Employee ("Helena", "Bug", 20),
                new Employee ("Harry", "Potter", 19),
                new Employee ("Hanna", "Smith", 27, 5, "Middle"),
                new Employee ("Clark", "Kent", 30, 10, "Senior" ),
                new Employee ("Elon", "Musk", 22, 1, "Junior"),
                new Employee ( "Barak", "Obama", 35, 15, "Senior"),
            }
        );

        Factory Tesla = new Factory
        (
            "Tesla",
            "Warsaw",
            3,
            new Employee[]
            {
                new Employee ("Donald", "Tusk", 20),
                new Employee ("Kate", "Smith", 18),
                new Employee ("July", "Trump", 2, 5, "Middle"),
                new Employee ("James", "Jobs", 30, 4, "Middle"),
                new Employee ("Alex", "Taylor", 21, 1, "Junior"),
            }
        );

        Factory Microsoft = new Factory
        (
            "Microsoft",
            "Gdansk"
        );

        Console.WriteLine($"The number of employees: {iTechArt.ReturnNumberEmployees()}");
        iTechArt.AddEmployee(new Employee("Drako", "Malfoy", 19));
        iTechArt.ListEmployees();
        iTechArt.ListEmployeesByPosition();
    }
}
public class Factory
{
    private string factoryName;
    private string city;
    private int officeNumber = 1;
    private Employee[] employees;

    public Factory(string factoryName, string city) //конструктор1
    {
        this.factoryName = factoryName;
        this.city = city;
    }
    public Factory(string factoryName, string city, int officeNumber, Employee[] employees) //конструктор2
    {
        this.factoryName = factoryName;
        this.city = city;
        this.officeNumber = officeNumber;
        this.employees = employees;
    }
    public int ReturnNumberEmployees()
    {
        return employees.Length;
    }
    public void AddEmployee(Employee newEmployee)
    {
        Array.Resize(ref employees, employees.Length + 1);
        employees[employees.Length - 1] = newEmployee;
        Console.WriteLine($"New employee added: {newEmployee}");
    }
    public void ListEmployees()
    {
        Console.WriteLine($"List of employees in {factoryName}:");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{employees[i]}");
        }
    }
    public void ListEmployeesByPosition()
    {
        Console.WriteLine($"Type position to get the list of employees (Intern, Junior, Middle, Senior):");
        string typePosition = Console.ReadLine();
        Console.WriteLine($"List of employees in {factoryName} on position '{typePosition}':");
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i].getPosition == typePosition)
            {
                Console.WriteLine($"{employees[i]}");
            }
        }
    }
}
