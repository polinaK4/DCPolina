namespace ClassLibrary
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _age;
        private double _experienceYears;
        private string _position = "Intern";

        public string position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Employee()
        {
            _firstName = "New";
            _lastName = "Employee";
        }

        public Employee(string firstName, string lastName, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }

        public Employee(string firstName, string lastName, int age, int experienceYears, string position)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._experienceYears = experienceYears;
            this._position = position;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} | Age: {_age} | Experience Years: {_experienceYears} | Position: {_position}";
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