namespace Task9_Generics
{
    public class Man : Human
    {
        public Man()
        {
            firstName = "John";
            lastName = "Doe";
        }
        public Man(string firstName, string lastName) : base(firstName, lastName) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
