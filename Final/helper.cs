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

        public static void SaveVideotapes(List<Videotape> videotapes)
        {
            string output = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
            File.WriteAllText(pathVideotapesJson, output);
        }

        public static void SaveTenants(List<Tenant> tenants)
        {
            string output = JsonConvert.SerializeObject(tenants, Formatting.Indented);
            File.WriteAllText(pathTenantsJson, output);
        }

        public static void SaveAudiotapes(List<Audiotape> audiotapes)
        {
            string output = JsonConvert.SerializeObject(audiotapes, Formatting.Indented);
            File.WriteAllText(pathAudiotapesJson, output);
        }

        public static void SaveDiscs(List<Disc> discs)
        {
            string output = JsonConvert.SerializeObject(discs, Formatting.Indented);
            File.WriteAllText(pathDiscsJson, output);
        }
    }
}
