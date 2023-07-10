namespace AutomationCources.Lecture_7.Homework
{
    public class Printer : Device, IPrint
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public Printer(string? modelName, decimal price, int PaperWidth, int PaperHeight) : base(modelName, price)
        {
            this.PaperWidth = PaperWidth;
            this.PaperHeight = PaperHeight;        
        }
        public override string Description 
        {
            get
            {
                return $"Price: {price}, model:{modelName}";
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }

        public override void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
