namespace Final
{
    public class Tenant
    {
        public int ID;
        public string firstName;
        public string lastName;
        public List<Videotape> rentedVideotapes;
        public List<Audiotape> rentedAudiotapes;
        public List<Disc> rentedDiscs;

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
