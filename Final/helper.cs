using Newtonsoft.Json;
using System.Net.NetworkInformation;

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
    }
}
