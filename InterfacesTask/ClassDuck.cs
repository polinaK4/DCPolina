namespace InterfacesTask
{
    public class Duck : IWalk, IFly
    {
        public string description;
        public int Steps { get; set; }
        public int Height { get; set; }
        public void Fly()
        {
            if (Height <= 20)
            {
                Console.WriteLine($"This duck is flying");
            }
            else
            {
                Console.WriteLine($"Duck don't want to fly on this height");
            }
        }
        public void Walk()
        {
            for (int i = 0; i < Steps; i++)
            {
                Console.WriteLine($"Step...");
            }
        }
        public Duck(string description, int Steps, int Height)
        {
            this.description = description;
            this.Steps = Steps;
            this.Height = Height;
        }

    }
}
