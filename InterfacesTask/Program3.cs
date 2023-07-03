using InterfacesTask;

class Program3
{
    static void Main(string[] args)
    {
        Adult adult1 = new Adult("John Snow", 3000, 12, 100000);
        Adult adult2 = new Adult("Donald Trump", 3500, 6, 50000);
        Duck duck1 = new Duck("Park Duck", 5, 10);
        Duck duck2 = new Duck("Wild Duck", 10, 20);
        Plane plane1 = new Plane("RYR0123", 12800, 13000);
        Plane plane2 = new Plane("WZ0123", 5800, 7000);

        adult1.Walk();
        adult1.Message();
        adult1.Pay();
        adult1.Walk();
        adult1.Message();
        adult1.Pay();

        duck1.Walk();
        duck1.Fly();

        plane1.Message();
        plane1.Fly();
        plane1.Message();
        plane1.Fly();
        plane1.Message();

    }
}