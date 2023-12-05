using Final;

class Program
{
    static void Main(string[] args)
    {
        var videotapes = new List<Videotape>
            {
                new Videotape (1001, "Eternal sunshine of spotless mind", 20, true),
                new Videotape (1002, "The Shawshank Redemption", 19, true),
                new Videotape (1003, "The Green Mile", 20, true),
                new Videotape (1004, "Forrest Gump", 20, false),
                new Videotape (1005, "Interstellar", 21, false),
                new Videotape (1006, "Pulp Fiction", 18, false),
                new Videotape (1006, "Fight Club", 15, false),
            };

        var tenants = new List<Tenant>
            {
                new Tenant (2001, "Tom", "Jonson", new List<Videotape>() {videotapes[3], videotapes[4] }),
                new Tenant (2002, "Hanna", "Smith", new List<Videotape>() {videotapes[5], videotapes[6]}),
                new Tenant (2003, "John", "Trump", new List<Videotape>() {}),
            };

        VideoSalon Tesla = new VideoSalon
            (
                "Tesla",
                videotapes,                
                tenants
            );

        Tesla.LaunchVideoSalon();









    }
}
