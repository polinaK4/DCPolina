using System;
using ClassLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{    static void Main(string[] args)
    {
        Factory iTechArt = new Factory
        {
            factoryName = "iTechArt",
            city = "Krakow",
            employees = new Employee[]
            {
                new Employee { firstName = "John", lastName = "Doe", age = 23 },
                new Employee { firstName = "Helena", lastName = "Bug", age = 20 },
                new Employee { firstName = "Harry", lastName = "Potter", age = 19 },
                new Employee { firstName = "Hanna", lastName = "Smith", age = 27, experienceYears = 5, position = "middle" },
                new Employee { firstName = "Clark", lastName = "Kent", age = 30, experienceYears = 10, position = "senior" },
                new Employee { firstName = "Elon", lastName = "Musk", age = 22, experienceYears = 1, position = "junior" },
                new Employee { firstName = "Barak", lastName = "Obama", age = 35, experienceYears = 15, position = "senior" },
            } 
        };

        Factory Tesla = new Factory
        {
            factoryName = "Tesla",
            city = "Warsaw",
            officeNumber = 3,
            employees = new Employee[]
            {
                new Employee { firstName = "Donald", lastName = "Tusk", age = 20 },
                new Employee { firstName = "Kate", lastName = "Smith", age = 18 },
                new Employee { firstName = "July", lastName = "Trump", age = 2, experienceYears = 5, position = "middle" },
                new Employee { firstName = "James", lastName = "Jobs", age = 30, experienceYears = 4, position = "middle" },
                new Employee { firstName = "Alex", lastName = "Taylor", age = 21, experienceYears = 1, position = "junior" },
            }
        };
               
        iTechArt.ReturnNumberEmployees();
        iTechArt.AddEmployee();
        iTechArt.ListEmployees();
        iTechArt.ListEmployeesByPosition();
    }
}
public class Factory
    {
        public string factoryName = "Undefined";
        public string city = "Undefined";
        public int officeNumber = 1;
        public Employee[] employees;
                 
        public Factory() //конструктор1
        {
            factoryName = "New Company";                       
        }
        public Factory(string factoryName, string city, int officeNumber) //конструктор2
    {
        this.factoryName = factoryName;
        this.city = city;
        this.officeNumber = officeNumber;
    }
    public void ReturnNumberEmployees()
    {
        Console.WriteLine($"The number of employees in {factoryName}: {employees.Length}");
    }
        public void AddEmployee()
    {
        Array.Resize(ref employees, employees.Length + 1);
        employees[employees.Length - 1] = new Employee { firstName = "Drako", lastName = "Malfoy", age = 19 };
        Console.WriteLine($"New employee added to {factoryName}: {employees[employees.Length - 1].firstName} {employees[employees.Length - 1].lastName} age: {employees[employees.Length - 1].age} experience years: {employees[employees.Length - 1].experienceYears} position: {employees[employees.Length - 1].position}");

    }
    public void ListEmployees()
    {
        Console.WriteLine($"List of employees in {factoryName}:");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{employees[i].firstName} {employees[i].lastName}");
        }
    }
    public void ListEmployeesByPosition()
    {
        Console.WriteLine($"Type position to get the list of employees (intern, junior, middle, senior):");
        string typePosition = Console.ReadLine();
        Console.WriteLine($"List of employees in {factoryName} on position '{typePosition}':");
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i].position == typePosition)
            {
                Console.WriteLine($"{employees[i].firstName} {employees[i].lastName}");
            }            
        }
    }


}
