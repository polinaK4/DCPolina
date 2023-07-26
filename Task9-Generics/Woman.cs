namespace Task9_Generics
{
    public class Woman : Human
    {
        public Woman()
        {
            firstName = "Joanna";
            lastName = "Doe";
        }
        public Woman(string firstName, string lastName) : base(firstName, lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
