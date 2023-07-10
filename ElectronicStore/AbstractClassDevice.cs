namespace AutomationCources.Lecture_7.Homework
{
    public abstract class Device
    {
        public string? modelName;  
        public decimal price; 
        public abstract string Description { get; }

        public abstract void TurnOn(); 

        public abstract void TunrnOff();

        public Device(string modelName, decimal price)
        {
            this.modelName = modelName;
            this.price = price;            
        }
    }
}
