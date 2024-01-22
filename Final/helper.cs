using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Final
{
    public static class Helper
    {
        public static string pathVideotapesJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "videotapes.json");
        public static string pathTenantsJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "tenants.json");
        public static string pathAudiotapesJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "audiotapes.json");
        public static string pathDiscsJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "discs.json");
        public static string pathCompaniesJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "companies.json");

        public static List<Videotape> LoadVideotapes()
        {
            var videotapesFromJson = File.ReadAllText(pathVideotapesJson);
            return JsonConvert.DeserializeObject<List<Videotape>>(videotapesFromJson);
        }
        public static List<Audiotape> LoadAudiotapes()
        {
            var audiotapesFromJson = File.ReadAllText(pathAudiotapesJson);
            return JsonConvert.DeserializeObject<List<Audiotape>>(audiotapesFromJson);
        }
        public static List<Disc> LoadDiscs()
        {
            var discsFromJson = File.ReadAllText(pathDiscsJson);
            return JsonConvert.DeserializeObject<List<Disc>>(discsFromJson);
        }

        public static List<Tenant> LoadTenants()
        {
            var tenantsFromJson = File.ReadAllText(Helper.pathTenantsJson);
            return JsonConvert.DeserializeObject<List<Tenant>>(tenantsFromJson);
        }

        public static List<Company> LoadCompanies()
        {
            var companiesFromJson = File.ReadAllText(pathCompaniesJson);
            return JsonConvert.DeserializeObject<List<Company>>(companiesFromJson);
        }

        public static void SaveItems(List<VideosalonItem> items)
        {
            var videotapes = new List<Videotape>() { };
            var audiotapes = new List<Audiotape>() { };
            var discs = new List<Disc>() { };
            foreach (var item in items)
            {
                if (item is Videotape vid)
                {
                    videotapes.Add(new Videotape(vid.ID, vid.type, vid.name, vid.rentPrice, vid.isAvailable, vid.audioCodek, vid.videoCodek, vid.tenantId));
                }
                else if (item is Audiotape aud)
                {
                    audiotapes.Add(new Audiotape(aud.ID, aud.type, aud.name, aud.rentPrice, aud.isAvailable, aud.audioCodek, aud.tenantId));
                }
                else if (item is Disc dis)
                {
                    discs.Add(new Disc(dis.ID, dis.type, dis.name, dis.rentPrice, dis.isAvailable, dis.fileSystem, dis.tenantId));
                }
            }
            string outputV = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
            File.WriteAllText(pathVideotapesJson, outputV);
            string outputA = JsonConvert.SerializeObject(audiotapes, Formatting.Indented);
            File.WriteAllText(pathAudiotapesJson, outputA);
            string outputD = JsonConvert.SerializeObject(discs, Formatting.Indented);
            File.WriteAllText(pathDiscsJson, outputD);
        }
    }
}
