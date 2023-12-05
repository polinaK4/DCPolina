namespace Final
{
    public class Tenant
    {
        public int ID;
        public string firstName;
        public string lastName;
        public List<Videotape> rentedVideotapes;

        public Tenant(int ID, string firstName, string lastName, List<Videotape> rentedVideotapes)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.rentedVideotapes = rentedVideotapes;
        }
    }
}
