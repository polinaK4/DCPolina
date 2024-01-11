namespace Final
{
    public class Disc : VideosalonItem
    {
        public string fileSystem;

        public Disc(int ID, string name, double rentPrice, bool isAvailable, string fileSystem)
        {
            this.ID = ID;
            this.name = name;
            this.rentPrice = rentPrice;
            this.isAvailable = isAvailable;
            this.fileSystem = fileSystem;
        }
    }
}
