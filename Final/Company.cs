namespace Final
{
    public class Company : Customer
    {
        public string name;

        public Company(int ID, string type, string name) : base(ID, type)
        { 
            this.name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {name} | {type};";
        }
    }
}
