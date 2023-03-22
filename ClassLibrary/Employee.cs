using System.Xml.Linq;

namespace ClassLibrary
{
   
    public class Employee
    {
        public string firstName = "Undefined";
        public string lastName = "Undefined";
        public int age;
        public int experienceYears;
        public string position = "Intern";
               
        public Employee()  // 1 конструктор
        {
            firstName = "New";
            lastName = "Employee"; 

        }
        public Employee(string firstName, string lastName, int age) // 2 конструктор
        { 
            this.firstName = firstName; 
            this.lastName = lastName;
            this.age = age;

        } 
        public Employee(string firstName, string lastName, int age, int experienceYears, string position) // 3 конструктор
        { 
            this.firstName = firstName; 
            this.lastName = lastName; 
            this.age = age; 
            this.experienceYears = experienceYears; 
            this.position = position; 
        } 

        public void Print()
        {
            Console.WriteLine($"First Name: {firstName} | Last Name: {lastName} | Age: {age} | Experience Years: {experienceYears} | Position: {position}");
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