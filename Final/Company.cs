namespace Final
{
    public class Company : Customer
    {
        public string name;

        public Company(int ID, string name, List<Videotape> rentedVideotapes, List<Audiotape> rentedAudiotapes, List<Disc> rentedDiscs)
        {
            this.ID = ID;
            this.name = name;
            this.rentedVideotapes = rentedVideotapes;
            this.rentedAudiotapes = rentedAudiotapes;
            this.rentedDiscs = rentedDiscs;
        }
    }
}
