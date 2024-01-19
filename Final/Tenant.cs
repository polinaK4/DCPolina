using System.Xml.Linq;

namespace Final
{
    public class Tenant : Customer
    {
        public string firstName;
        public string lastName;

        public Tenant(int ID, string firstName, string lastName)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} | ID: {ID};";
        }
    }
}
