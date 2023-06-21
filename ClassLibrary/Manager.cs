namespace ClassLibrary
{

    public class Manager : Employee
    {
        private string _role;
        private List<Employee> _employees;

        public Manager(string role, string firstName, string lastName, int age, int experienceYears, string position, List<Employee> employee) : base(firstName, lastName, age, experienceYears, position)
        {
            this._role = role;
            this._employees = employee;
        }

        public void AddEmployeeToManager(Employee newEmployee)
        {
            _employees.Add(newEmployee);
            Console.WriteLine($"New employee added: {newEmployee}");
        }

        public void ListManagerEmployees()
        {
            Console.WriteLine($"List of employees in:");
            for (int i = 0; i < _employees.Count; i++)
            {
                Console.WriteLine($"{_employees[i]};");
            }
        }

    }

}
