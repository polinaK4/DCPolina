using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        //Task5();
        var employees = new List<Employee>
            {
                new Employee ("John", "Doe", 20),
                new Employee ("Helena", "Bug", 20),
            };
        
        Employee employee1 = new Employee("Harry", "Potter", 19);
        Manager manager1 = new Manager("Team Manager Unit.PL1", "Polina","Kaliuzhnaya", 29, 5,"Senior", employees);
        TeamLead teamlead1 = new TeamLead("Team Lead DC", "Kate", "Belskaya", 29, 5, "Senior");

        Task6(employee1);
        Task6(manager1);
        Task6(teamlead1);
        Console.WriteLine(manager1.WorkCoefficient2);
        Console.WriteLine(Employee.retirementAge);
        Employee.retirementAge = 68;
        Console.WriteLine(Employee.retirementAge);

        Console.WriteLine(TeamLead.CirclePi(7));
    }
    public static void Task6(Employee item)
    {
        item.ShowEmployeeInfo();
    }

    public static void Task5()
    {
        var harryPotter = new Employee("Harry", "Potter", 19);

        var employees = new List<Employee>
                {
                    new Employee ("John", "Doe", 20),
                    new Employee ("Helena", "Bug", 20),
                    new Employee ("Harry", "Potter", 19),
                    new Employee ("Hanna", "Smith", 27, 5, "Middle"),
                    new Employee ("Clark", "Kent", 30, 10, "Senior" ),
                    new Employee ("Elon", "Musk", 22, 1, "Junior"),
                    new Employee ( "Barak", "Obama", 35, 15, "Senior"),
                };

        var managers = new Manager[]
             {
                    new Manager
                    (
                        "Team Manager Unit.PL1",
                        "Polina",
                        "Kaliuzhnaya",
                        29,
                        5,
                        "Senior",
                        employees
                        )
             };

        Factory iTechArt = new Factory
        (
            "iTechArt",
            "Krakow",
            1,
            employees,
            managers
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
        iTechArt.RemoveEmployee(employees[3]);
        iTechArt.RemoveEmployee(1);
        var result = iTechArt.RemoveEmployee(employees[2]);
        Console.WriteLine(result);

        iTechArt.ListEmployees();
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

    public void RemoveEmployee(int index)
    {
        _employees.RemoveAt(index);
        Console.WriteLine($"Employee removed");

    }

    public string RemoveEmployee(Employee item2, bool isHarryHasToBeDeleted = false)
    {
        if (isHarryHasToBeDeleted)
        {
            _employees.Remove(item2);
            return $"Harry removed";
        }
        else
        {
            return $"Harry not removed";
        }
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
            if (_employees[i].Position == typePosition)
            {
                Console.WriteLine($"{_employees[i]}");
                _employees[i].VacationDays();
                _employees[i].WorkCoefficient();
            }
        }
    }
}
