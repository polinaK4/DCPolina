namespace AutomationCources.Lecture_7.Homework
{
    public class MobilePhone : Device, ICamera
    {
        public double NumberOfPixelsInCamera { get; set; }

        public MobilePhone(double NumberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
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
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press left side button");
        }

        public override void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
