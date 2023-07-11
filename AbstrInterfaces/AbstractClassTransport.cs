namespace AbstractClasses
{
    abstract class Transport
    {
        public string name = "Transport";
        public abstract int Speed { get; set; }
        public abstract void Move();
        public void PrintTheName()
        {
            Console.WriteLine($"{name}");
        }
        public Transport(string name)
        {
            this.name = name;
        }
    }
}