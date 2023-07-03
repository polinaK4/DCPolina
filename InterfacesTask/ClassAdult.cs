namespace InterfacesTask
{
    public class Adult : IWalk, IMessage, IPayingRent
    {
        public string name;
        public int Steps { get; set; }
        public int Price { get; set; }
        public int PeriodMonths { get; set; }
        public double rentPrice;
        public double availableMoney;
        public void Walk()
        {
            Steps++;
            Console.WriteLine($"Another step! {Steps} in total");
        }
        public void Pay()
        {
            rentPrice = Price * PeriodMonths;
            if (rentPrice <= availableMoney)
                {
                availableMoney =-rentPrice;
                Console.WriteLine($"Rent is paid");
                }
            else
                {
                Console.WriteLine($"You have no money:(");
                }
        }
        public void Message()
        {
            Console.WriteLine("It's time to pay rent");
        }

        public Adult(string name, int Price, int PeriodMonths, double availableMoney)
        {
            this.name = name;
            this.Price = Price;
            this.PeriodMonths = PeriodMonths;
            this.availableMoney = availableMoney;
        }
    }
}
