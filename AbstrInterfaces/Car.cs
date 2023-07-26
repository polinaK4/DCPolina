namespace AbstractClasses
{
    class Car : Transport
    {
        public override int Speed { get; set; }
        public int distance = 0;
        public string EngineType { get; set; } = "Gas";
        public override void Move()
        {
            distance += 200;
            Console.WriteLine($"The car is on the road! Distance is {distance}");
        }
        public void CheckDistance()
        {
            if (EngineType == "Electro" && distance >= 600)
            {
                Console.WriteLine("You need to charge!!!");
            }
            else
            {
                Console.WriteLine($"Everything is fine, just move");
            }
        }
        public Car(string name, int Speed, int distance, string EngineType) : base(name)
        {
            this.Speed = Speed;
            this.distance = distance;
            this.EngineType = EngineType;
        }
    }
}
