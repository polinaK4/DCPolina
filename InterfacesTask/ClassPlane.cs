namespace InterfacesTask
{
    public class Plane : IFly, IMessage
    {
        public string planeId;
        public int maxHeight;
        public int Height { get; set; }
        public void Fly()
        {
            Height = Height + 150;
            Console.WriteLine($"The height is now {Height}");
        }
        public void Message()
        {
            if (Height >= maxHeight)
            {
                Console.WriteLine($"Urgent! Reduce the height {Height}");
            }
            else
            if (Height < 200)
            {
                Console.WriteLine($"The height is {Height} !!");
            }
            else
            {
                Console.WriteLine("Everything is fine");
            }
        }
        public Plane(string planeId, int Height, int maxHeight)
        {
            this.planeId = planeId;
            this.Height = Height;
            this.maxHeight = maxHeight;
        }
    }
}
