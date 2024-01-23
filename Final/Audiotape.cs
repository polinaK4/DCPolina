namespace Final
{
    public class Audiotape : VideosalonItem
    {
        public string audioCodek;

        public Audiotape(int id, string type, string name, double rentPrice, string audioCodek) : base(id, type, name, rentPrice)
        {
            this.audioCodek = audioCodek;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {type} | {name} | Price: {rentPrice} | AudioCodek: {audioCodek};";
        }
    }
}
