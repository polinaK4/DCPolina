namespace Final
{
    public class Disc : VideosalonItem
    {
        public string fileSystem;

        public Disc(int ID, string name, double rentPrice, bool isAvailable, string fileSystem, int? tenantId)
        {
            this.ID = ID;
            this.name = name;
            this.rentPrice = rentPrice;
            this.isAvailable = isAvailable;
            this.fileSystem = fileSystem;
            this.tenantID= tenantId;
        }

        public override string ToString()
        {
            return $"{name} | Price: {rentPrice} | AudioCodek: {fileSystem} | ID: {ID};";
        }
    }
}
