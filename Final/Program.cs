using Newtonsoft.Json;
using Final;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string pathVideotapesJson = ".\\Json\\videotapes.json";
        var videotapesFromJson = File.ReadAllText(pathVideotapesJson);
        var videotapes = JsonConvert.DeserializeObject<List<Videotape>>(videotapesFromJson);
        string pathTenantsJson = ".\\Json\\tenants.json";
        var tenantsFromJson = File.ReadAllText(pathTenantsJson);
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
