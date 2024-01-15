namespace Final
{
    public class Tenant : Customer
    {
        public string firstName;
        public string lastName;

        public Tenant(int ID, string firstName, string lastName, List<Videotape> rentedVideotapes, List<Audiotape> rentedAudiotapes, List<Disc> rentedDiscs)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.rentedVideotapes = rentedVideotapes;
            this.rentedAudiotapes = rentedAudiotapes;
            this.rentedDiscs = rentedDiscs;
        }
    }
}
