using Newtonsoft.Json;
using Final;

class Program
{
    static void Main(string[] args)
    {
        var videotapesFromJson = File.ReadAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\videotapes.json");
        var videotapes = JsonConvert.DeserializeObject<List<Videotape>>(videotapesFromJson);
        var tenantsFromJson = File.ReadAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\tenants.json");
        var tenants = JsonConvert.DeserializeObject<List<Tenant>>(tenantsFromJson);

        VideoSalon Tesla = new VideoSalon
            (
                "Tesla",
                videotapes,
                tenants
            );
        Tesla.LaunchVideoSalon();
    }
}
