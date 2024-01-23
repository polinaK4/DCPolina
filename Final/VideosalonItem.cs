namespace Final
{
    public abstract class VideosalonItem
    {
        public int ID;
        public string type;
        public string name;        
        public double rentPrice;
        //public bool isAvailable;
        //public int? tenantId;

        public VideosalonItem(int id, string type, string name, double rentPrice)
        {
            this.ID = id;
            this.type = type;
            this.name = name;
            this.rentPrice = rentPrice;
            //this.isAvailable = isAvailable;
            //this.tenantId = tenantId;
        }
    }
}
