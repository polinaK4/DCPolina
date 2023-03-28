namespace ClassLibrary
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private int age;
        private int experienceYears;
        private string position = "Intern";

        public string getPosition
        {
            get { return position; }
            set { position = value; }
        }
        public Employee()
        {
            firstName = "New";
            lastName = "Employee";
        }
        public Employee(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Employee(string firstName, string lastName, int age, int experienceYears, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.experienceYears = experienceYears;
            this.position = position;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} | Age: {age} | Experience Years: {experienceYears} | Position: {position}";
        }

        public void VacationDays()
        {
            if (experienceYears >= 10)
            {
                Console.WriteLine("26 vacation days");
            }
            else
                Console.WriteLine($"20 vacation days. Years left before adding extra days: {10 - experienceYears}");
        }

    }

}