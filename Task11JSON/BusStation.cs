namespace Task12JSON
{
    public class BusStation
    {
        public string color;
        public int number;
        public bool active;
        public DateTime datetimeOfCheck;
        public List<Bus> buses;
        public BusStation(string color, int number, bool active, DateTime datetimeOfCheck, List<Bus> buses)
        {
            this.color = color;
            this.number = number;
            this.active = active;
            this.datetimeOfCheck = datetimeOfCheck;
            this.buses = buses;
        }
    }
}
