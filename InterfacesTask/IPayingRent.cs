namespace InterfacesTask
{
    public interface IPayingRent
    {
        public int Price { get; set; }
        public int PeriodMonths { get; set; }

        public void Pay();
    }
}
