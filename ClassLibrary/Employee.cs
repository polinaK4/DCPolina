namespace ClassLibrary
{
    public class Employee
    {
        private const string City = "Minsk";
        private readonly string _firstName;
        private readonly string _lastName;        
        private double _age;
        private double _experienceYears;
        public static int retirementAge = 65;

        public string Position { get; private set; } = "Intern";

        public double WorkCoefficient2 => _age / _experienceYears;

        public Employee()
        {
            _firstName = "New";
            _lastName = "Employee";
        }

        public Employee(string firstName, string lastName, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age++;
        }

        public Employee(string firstName, string lastName, int age, int experienceYears, string position)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._experienceYears = experienceYears;
            this.Position = position;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} | Age: {_age} | Experience Years: {_experienceYears} | Position: {Position}";
        }

        public void VacationDays()
        {
            if (_experienceYears >= 10)
            {
                Console.WriteLine("26 vacation days");
            }
            else
            {
                Console.WriteLine($"20 vacation days. Years left before adding extra days: {10 - _experienceYears}");
            }
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("I am Employee!");
        }
        
        public void WorkCoefficient()
        {
            if (_experienceYears == 0)
            {
                Console.WriteLine("Work Coefficient: Not applicable");
            }
            else
            {
                double workCoeff = _age / _experienceYears;
                Console.WriteLine($"Work Coefficient: {workCoeff}");
            }
        }
    }
}