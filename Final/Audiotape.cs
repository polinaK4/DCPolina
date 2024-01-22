namespace Final
{
    public class Audiotape : VideosalonItem
    {
        public string audioCodek;

        public Audiotape(int id, string type, string name, double rentPrice, bool isAvailable, string audioCodek, int? tenantId) : base(id, type, name, rentPrice, isAvailable, tenantId)
        {
            this.audioCodek = audioCodek;
        }

        public override string ToString()
        {
            return $"ID: {ID} | {type} | {name} | Price: {rentPrice} | AudioCodek: {audioCodek};";
        }
    }
}
