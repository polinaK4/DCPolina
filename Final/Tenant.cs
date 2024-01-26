using System.Xml.Linq;

namespace Final
{
    public class Tenant : Customer
    {
        public string firstName;
        public string lastName;

        public Tenant(int ID, string type, string firstName, string lastName) : base(ID, type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {firstName} {lastName} | {type};";
        }
    }
}
