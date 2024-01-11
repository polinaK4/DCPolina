namespace Final
{
    public class Videotape : VideosalonItem
    {
        public string videoCodek;
        public string audioCodek;

        public Videotape(int ID, string name, double rentPrice, bool isAvailable, string videoCodek, string audioCodek)
        {
            this.ID = ID;
            this.name = name;
            this.rentPrice = rentPrice;
            this.isAvailable = isAvailable;
            this.videoCodek = videoCodek;
            this.audioCodek = audioCodek;
        }
    }
}
