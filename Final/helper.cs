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
        public static string pathRentedItemsJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "rent.json");

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

        public static List<RentedItems> LoadRents()
        {
            var rentsFromJson = File.ReadAllText(pathRentedItemsJson);
            return JsonConvert.DeserializeObject<List<RentedItems>>(rentsFromJson);
        }

        public static void SaveRent(List<RentedItems> rentedItems)
        {
            string output = JsonConvert.SerializeObject(rentedItems, Formatting.Indented);
            File.WriteAllText(pathRentedItemsJson, output);
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
                    videotapes.Add(new Videotape(vid.ID, vid.type, vid.name, vid.rentPrice, vid.audioCodek, vid.videoCodek));
                }
                else if (item is Audiotape aud)
                {
                    audiotapes.Add(new Audiotape(aud.ID, aud.type, aud.name, aud.rentPrice, aud.audioCodek));
                }
                else if (item is Disc dis)
                {
                    discs.Add(new Disc(dis.ID, dis.type, dis.name, dis.rentPrice, dis.fileSystem));
                }
            }
            string outputV = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
            File.WriteAllText(pathVideotapesJson, outputV);
            string outputA = JsonConvert.SerializeObject(audiotapes, Formatting.Indented);
            File.WriteAllText(pathAudiotapesJson, outputA);
            string outputD = JsonConvert.SerializeObject(discs, Formatting.Indented);
            File.WriteAllText(pathDiscsJson, outputD);
        }
        public static void SaveCustomers(List<Customer> customers)
        {
            var tenants = new List<Tenant>() { };
            var companies = new List<Company>() { };
            foreach (var customer in customers)
            {
                if (customer is Tenant ten)
                {
                    tenants.Add(new Tenant(ten.ID, ten.type, ten.firstName, ten.lastName));
                }
                else if (customer is Company com)
                {
                    companies.Add(new Company(com.ID, com.type, com.name));
                }
            }
            string outputT = JsonConvert.SerializeObject(tenants, Formatting.Indented);
            File.WriteAllText(pathTenantsJson, outputT);
            string outputC = JsonConvert.SerializeObject(companies, Formatting.Indented);
            File.WriteAllText(pathCompaniesJson, outputC);
        }
    }
}
