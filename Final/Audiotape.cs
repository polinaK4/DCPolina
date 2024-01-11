
namespace Final
{
    public class Audiotape : VideosalonItem
    {
        public string audioCodek;

        public Audiotape(int ID, string name, double rentPrice, bool isAvailable, string audioCodek)
        {
            this.ID = ID;
            this.name = name;
            this.rentPrice = rentPrice;
            this.isAvailable = isAvailable;
            this.audioCodek = audioCodek;
        }
    }
}
