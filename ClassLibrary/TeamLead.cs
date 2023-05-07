namespace ClassLibrary
{
    public class TeamLead : Employee
    {
        const double pi = 3.14;

        private string _role;
        public TeamLead(string role, string firstName, string lastName, int age, int experienceYears, string position) : base(firstName, lastName, age, experienceYears, position)
        {
            this._role = role;
        }

        public new void ShowEmployeeInfo()
        {
            Console.WriteLine("I am Team Lead!");
        }

        public static double CirclePi(double radius)
        {
           return 2 * pi * radius;
        }

    }
}
