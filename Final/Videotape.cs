namespace Final
{
    public class Videotape : VideosalonItem
    {
        public string videoCodek;
        public string audioCodek;

        public Videotape(int id, string type, string name, double rentPrice, string videoCodek, string audioCodek) : base(id, type, name, rentPrice)
        {
            this.videoCodek = videoCodek;
            this.audioCodek = audioCodek;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {type} | {name} | Price: {rentPrice} | VideoCodek: {videoCodek} | AudioCodek: {audioCodek};";
        }
    }
}
