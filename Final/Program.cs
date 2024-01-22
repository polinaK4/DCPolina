using Newtonsoft.Json;
using Final;
using static System.Net.Mime.MediaTypeNames;
using System;

class Program
{
    static void Main(string[] args)
    {
        var videotapes = Helper.LoadVideotapes();
        var audiotapes = Helper.LoadAudiotapes();
        var discs = Helper.LoadDiscs();
        var tenants = Helper.LoadTenants();
        var companies = Helper.LoadCompanies();

        var items = new List<VideosalonItem>();
        items.AddRange(videotapes);
        items.AddRange(audiotapes);
        items.AddRange(discs);

        var customers = new List<Customer>();
        customers.AddRange(companies);
        customers.AddRange(tenants);

        VideoSalon Tesla = new VideoSalon
            (
                "Tesla",
                items,
                customers
            );
        Tesla.LaunchVideoSalon();
    }
}
