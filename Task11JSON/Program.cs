using Newtonsoft.Json;
using Task12JSON;

class Program
{
    static void Main(string[] args)
    {
            var busStation1 = new BusStation
            ("Red",
            4, 
            true,
            new DateTime(2023, 05, 09, 9, 15, 0),
            new List<Bus>
                {
                    new Bus ("Scania", 5),
                    new Bus ("Scania", 1),
                    new Bus ("MAZ", 25),
                    new Bus ("Volvo", 9)
                }
            );
        var busStationJson = JsonConvert.SerializeObject(busStation1);
        File.WriteAllText(@"C:/Users/Polina/Source/Repos/DCPolina/Task11JSON/Json/json.json", busStationJson);

        var busStationFromJson = File.ReadAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Task11JSON\Json\json-My.json");
        var newBusStation = JsonConvert.DeserializeObject<BusStation>(busStationFromJson);
        Console.WriteLine($"Check new object is created, its color: {newBusStation.color}");
    }
}

