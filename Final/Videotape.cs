namespace Final
{
    public class Videotape
    {
        public int ID;
        public string name;
        public double rentPrice;
        public bool isAvailable;

        public Videotape(int ID, string name, double rentPrice, bool isAvailable)
        {
            this.ID = ID;
            this.name = name;
            this.rentPrice = rentPrice;
            this.isAvailable = isAvailable;
        }
    }
}
