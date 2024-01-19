using Newtonsoft.Json;
using Final;
using static System.Net.Mime.MediaTypeNames;
using System;

class Program
{
    static void Main(string[] args)
    {
        var videotapesFromJson = File.ReadAllText(Helper.pathVideotapesJson);
        var videotapes = JsonConvert.DeserializeObject<List<Videotape>>(videotapesFromJson);
        var tenantsFromJson = File.ReadAllText(Helper.pathTenantsJson);
        var tenants = JsonConvert.DeserializeObject<List<Tenant>>(tenantsFromJson);
        var companiesFromJson = File.ReadAllText(Helper.pathCompaniesJson);
        var companies = JsonConvert.DeserializeObject<List<Company>>(companiesFromJson);
        var audiotapesFromJson = File.ReadAllText(Helper.pathAudiotapesJson);
        var audiotapes = JsonConvert.DeserializeObject<List<Audiotape>>(audiotapesFromJson);
        var discsFromJson = File.ReadAllText(Helper.pathDiscsJson);
        var discs = JsonConvert.DeserializeObject<List<Disc>>(discsFromJson);
        //var customers = new List<Customer>();
        //customers.AddRange(companies);
        //customers.AddRange(tenants);        

        VideoSalon Tesla = new VideoSalon
            (
                "Tesla",
                videotapes,                
                audiotapes,
                discs,
                tenants,
                companies
                //customers
            );
        Tesla.LaunchVideoSalon();
    }
}
