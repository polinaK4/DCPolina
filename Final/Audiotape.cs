
namespace Final
{
    public class Audiotape : VideosalonItem
    {
        public string audioCodek;

        public Audiotape(int ID, string name, double rentPrice, bool isAvailable, string audioCodek, int? tenantID)
        {
            this.ID = ID;
            this.name = name;
            this.rentPrice = rentPrice;
            this.isAvailable = isAvailable;
            this.audioCodek = audioCodek;
            this.tenantID = tenantID;
        }

        public override string ToString()
        {
            return $"{name} | Price: {rentPrice} | AudioCodek: {audioCodek} | ID: {ID};";
        }
    }
}
