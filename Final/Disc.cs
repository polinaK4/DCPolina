namespace Final
{
    public class Disc : VideosalonItem
    {
        public string fileSystem;

        public Disc(int id, string type, string name, double rentPrice, string fileSystem) : base(id, type, name, rentPrice)
        {
            this.fileSystem = fileSystem;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {type} | {name} | Price: {rentPrice} | AudioCodek: {fileSystem};";
        }
    }
}
