namespace AbstractClasses
{
    class Ship : Transport
    {
        public override int Speed { get; set; }
        public int numberOfTurbines;
        public string Type { get; set; } = "Cruise";
        public override void Move()
        {
            Console.WriteLine("Sheep is in the sea!");
        }
        public void FastOrNot()
        {
            if (Speed >= 80)
            {
                Console.WriteLine("The sheep is fast");
            }
            else
            {
                Console.WriteLine($"Not so fast");
            }
        }
        public Ship(string name, int Speed, int numberOfTurbines, string Type) : base(name) {
            this.Speed = Speed;
            this.numberOfTurbines = numberOfTurbines;
            this.Type = Type;
        }
    }
}
