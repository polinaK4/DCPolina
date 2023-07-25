namespace Task9_Generics
{    
    public abstract class Human
    {
        public string firstName;
        public string lastName;

        public Human()
        {
            firstName = "Some";
            lastName = "Person";
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
