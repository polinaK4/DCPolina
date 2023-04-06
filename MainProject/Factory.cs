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
            new List<Employee>
            {
                new Employee ("John", "Doe", 23),
                new Employee ("Helena", "Bug", 20),
                new Employee ("Harry", "Potter", 19),
                new Employee ("Hanna", "Smith", 27, 5, "Middle"),
                new Employee ("Clark", "Kent", 30, 10, "Senior" ),
                new Employee ("Elon", "Musk", 22, 1, "Junior"),
                new Employee ( "Barak", "Obama", 35, 15, "Senior"),
            },
            new Manager[]
            { 
                new Manager
                (
                    "Team Manager Unit.PL1",
                    "Polina",
                    "Kaliuzhnaya",
                    29,
                    5,
                    "Senior",
                     new List<Employee>
                     {
                        new Employee ("Lewis", "Hamilton", 25),
                        new Employee ("Fernando", "Alonso", 24, 5, "Middle"),
                        new Employee ("Lando", "Norris", 27, 8, "Senior"),
                        new Employee ("Max", "Verstappen", 22, 1, "Junior"),
                     }
                    )
            }
        );

        Factory Tesla = new Factory
        (
            "Tesla",
            "Warsaw",
            3,
            new List<Employee>
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

        Console.WriteLine($"The number of employees: {iTechArt.GetEmployeesNumber()}");
        iTechArt.AddEmployee(new Employee("Drako", "Malfoy", 19));
        iTechArt.ListEmployees();
        iTechArt.ListEmployeesByPosition();
        iTechArt.RemoveEmployee(1);
        
    }
}

public class Factory
{
    private string _factoryName;
    private string _city;
    private int _officeNumber = 1;
    private List<Employee> _employees;
    private Manager[] _managers;
    
    public Factory(string factoryName, string city) //конструктор1
    {
        this._factoryName = factoryName;
        this._city = city;        
    }

    public Factory(string factoryName, string city, int officeNumber, List<Employee> employees) //конструктор2
    {
        this._factoryName = factoryName;
        this._city = city;
        this._officeNumber = officeNumber;
        this._employees = employees;
    }

    public Factory(string factoryName, string city, int officeNumber, List<Employee> employees, Manager[] managers) //конструктор3
    {
        this._factoryName = factoryName;
        this._city = city;
        this._officeNumber = officeNumber;
        this._employees = employees;
        this._managers = managers;
    }

    public int GetEmployeesNumber()
    {
        return _employees.Count;
    }

    public void AddEmployee(Employee newEmployee)
    {
        _employees.Add(newEmployee);
        Console.WriteLine($"New employee added: {newEmployee}");
    }

    public void RemoveEmployee(int indexToRemove)
    {
        _employees.RemoveAt(indexToRemove);
        Console.WriteLine($"Employee removed");
    }

    public void ListEmployees()
    {
     
        Console.WriteLine($"List of employees in {_factoryName}:");
        for (int i = 0; i < _employees.Count; i++)
        {

            Console.WriteLine($"{_employees[i]};");
        }
    }

    public void ListEmployeesByPosition()
    {
        Console.WriteLine($"Type position to get the list of employees (Intern, Junior, Middle, Senior):");
        string typePosition = Console.ReadLine();
        Console.WriteLine($"List of employees in {_factoryName} on position '{typePosition}':");
        for (int i = 0; i < _employees.Count; i++)
        {
            if (_employees[i].position == typePosition)
            {                
                Console.WriteLine($"{_employees[i]}");
                _employees[i].VacationDays();
                _employees[i].WorkCoefficient();
            }
        }
    }
}
