namespace Final
{
    public class Company : Customer
    {
        public string name;

        public Company(int ID, string name)
        {
            this.ID = ID;  
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} | ID: {ID};";
        }
    }
}
