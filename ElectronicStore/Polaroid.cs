namespace AutomationCources.Lecture_7.Homework
{
    public class Polaroid : Device, IPrint, ICamera
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }
        public double NumberOfPixelsInCamera { get; set; }
        public Polaroid(string? modelName, decimal price, int PaperWidth, int PaperHeight, double NumberOfPixelsInCamera) : base(modelName, price)
        {
            this.PaperWidth = PaperWidth;
            this.PaperHeight = PaperHeight;
            this.NumberOfPixelsInCamera = NumberOfPixelsInCamera;
        }
        public override string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}, number of pixels in camera: {NumberOfPixelsInCamera}";
            }
        }
        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }
        public override void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
