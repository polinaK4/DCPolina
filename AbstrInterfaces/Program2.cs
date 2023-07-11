using AbstractClasses;
class Program2 
{
    static void Main(string[] args)
    {
        Ship ship = new Ship("Tales Of The Sea", 70, 5, "Cruise");
        Car car = new Car("Tesla", 200, 50, "Electro");

        ship.PrintTheName();
        ship.Move();      
        ship.FastOrNot();

        car.PrintTheName();    
        car.Move();
        car.Move();
        car.Move();
        car.CheckDistance();

    }
}
