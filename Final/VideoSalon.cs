using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final
{
    public class VideoSalon
    {
        public string name;
        public List<Videotape> videotapes;
        public List<Tenant> tenants;
        public List<Company> companies;
        public List<Customer> customers;
        public List<Audiotape> audiotapes;
        public List<Disc> discs;
        public VideoSalon(string name, List<Videotape> videotapes, List<Audiotape> audiotapes, List<Disc> discs, List<Tenant> tenants, List<Company> companies)
        {
            this.name = name;
            this.videotapes = videotapes;
            this.audiotapes = audiotapes;
            this.discs = discs;
            this.tenants = tenants;
            this.companies= companies;

        }
        public VideoSalon(string name, List<Videotape> videotapes, List<Audiotape> audiotapes, List<Disc> discs, List<Customer> customers)
        {
            this.name = name;
            this.videotapes = videotapes;
            this.audiotapes = audiotapes;
            this.discs = discs;
            this.customers = customers;
        }

        public void ListOfAvailableVideotapes()
        {
            Console.WriteLine($"Available videotapes: ");
            videotapes.Where(videotape => videotape.isAvailable == true).ToList().ForEach(videotape => Console.WriteLine(videotape)); 
        }

        public void VideotapesRented()
        {
            Console.WriteLine("Rented Videotapes:");
            videotapes.Where(videotape => videotape.isAvailable == false).ToList().ForEach(videotape => Console.WriteLine(videotape));
        }

        public void AddRemoveVideotape()
        {
            Console.WriteLine($"Do you want to add or remove videotape? \n 1 - Add \n 2 - Remove ");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Console.Write("Enter ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                Console.Write("Enter rent price: ");
                int rentPrice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter VideoCodek type: ");
                var videoCodek = Console.ReadLine();
                Console.Write("Enter AudioCodek type: ");
                var audioCodek = Console.ReadLine();                
                int? tenantId = null;
                videotapes.Add(new Videotape(ID, name, rentPrice, true, videoCodek, audioCodek, tenantId));
                Helper.SaveVideotapes(videotapes);
                Console.Write("Videotape is added");
            }
            if (action == 2)
            {
                Console.Write("Enter ID of videotape that you want to remove: ");
                int removeId = Convert.ToInt32(Console.ReadLine());             
                var selectedVideotape = videotapes.Where(videotape => videotape.ID == removeId);
                if (selectedVideotape != null)
                {
                    foreach (var videotape in selectedVideotape)
                    {
                        Console.WriteLine($"{videotape.ID} is removed");
                        videotapes.Remove(videotape);
                        Helper.SaveVideotapes(videotapes);
                    }
                }                
            }
        }

        public void AddRemoveTenant()
        {
            Console.WriteLine($"Do you want to add or remove tenant? \n 1 - Add Individual Tenant \n 2 - Remove Customer (Individual Tenant/Company)");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Console.Write("Enter ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter first name: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                var lastName = Console.ReadLine();
                tenants.Add(new Tenant(ID, firstName, lastName)); 
                Helper.SaveTenants(tenants);
            }
            if (action == 2)
            {
                Console.Write("Enter ID of Customer that you want to remove: ");
                int removeId = Convert.ToInt32(Console.ReadLine());
                var selectedTenant = tenants.Where(tenant => tenant.ID == removeId);
                if (selectedTenant != null)
                {
                    foreach (var tenant in selectedTenant)
                    {
                        Console.WriteLine($"{tenant.ID} is removed");
                        tenants.Remove(tenant);
                        Helper.SaveTenants(tenants);
                    }
                }
            }
        }

        public void Rent()
        {
            try
            {
                Console.WriteLine($"Write ID of the tenant:");
                int idTenant = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What will be rented? \n 1 - Videotape \n 2 - Audiotape \n 3 - Disc");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write ID of item to rent:");
                int idRent = Convert.ToInt32(Console.ReadLine());
                int matches = 0;
                if (action == 1)
                {
                    var videotapeNotAvailable = videotapes.Where(videotape => videotape.ID == idRent && videotape.isAvailable == false);
                    foreach (var videotape in videotapeNotAvailable)
                    {
                        matches++;
                        Console.WriteLine($"Videotape {videotape.ID} | {videotape.name} is not available");
                    }
                    var selectedVideotape = videotapes.Where(videotape => videotape.ID == idRent && videotape.isAvailable == true);
                    foreach (var videotape in selectedVideotape)
                    {
                        matches++;
                        videotape.isAvailable = false;
                        videotape.tenantID = idTenant;
                        Helper.SaveVideotapes(videotapes);
                        Console.WriteLine($"Videotape {videotape.name} ID:{videotape.ID} has been rented succesfully");
                    }
                }
                if (action == 2)
                {
                    var audiotapeNotAvailable = audiotapes.Where(audiotape => audiotape.ID == idRent && audiotape.isAvailable == false);
                    foreach (var audiotape in audiotapeNotAvailable)
                    {
                        matches++;
                        Console.WriteLine($"Audiotape {audiotape.ID} | {audiotape.name} is not available");
                    }
                    var selectedAudiotape = audiotapes.Where(audiotape => audiotape.ID == idRent && audiotape.isAvailable == true);
                    foreach (var audiotape in selectedAudiotape)
                    {
                        matches++;
                        audiotape.isAvailable = false;
                        audiotape.tenantID = idTenant;
                        Helper.SaveAudiotapes(audiotapes);
                        Console.WriteLine($"Audiotape {audiotape.name} ID:{audiotape.ID} has been rented succesfully");
                    }
                }
                if (action == 3)
                {
                    var discNotAvailable = discs.Where(disc => disc.ID == idRent && disc.isAvailable == false);
                    foreach (var disc in discNotAvailable)
                    {
                        matches++;
                        Console.WriteLine($"Disc {disc.ID} | {disc.name} is not available");
                    }
                    var selectedDisc = discs.Where(disc => disc.ID == idRent && disc.isAvailable == true);
                    foreach (var disc in selectedDisc)
                    {
                        matches++;
                        disc.isAvailable = false;
                        disc.tenantID = idTenant;
                        Helper.SaveDiscs(discs);
                        Console.WriteLine($"Disc {disc.name} ID:{disc.ID} has been rented succesfully");
                    }
                }
                if (matches == 0)
                {
                    Console.WriteLine("No item or tenant with such ID");
                }
            }
            catch
            {
                Console.WriteLine("Wrong data. Try again");
            }
        }

        public void Return()
        {
            try
            {
                Console.WriteLine($"What will be returned? \n 1 - Videotape \n 2 - Audiotape \n 3 - Disc");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write ID of item to return:");
                int idReturn = Convert.ToInt32(Console.ReadLine());
                int matches = 0;
                if (action == 1)
                {
                    var selectedVideotape = videotapes.Where(videotape => videotape.ID == idReturn);
                    foreach (var videotape in selectedVideotape)
                    {
                        matches++;
                        videotape.isAvailable = true;
                        videotape.tenantID = null;
                        Helper.SaveVideotapes(videotapes);
                    }
                }
                if (action == 2)
                {
                    var selectedAudiotape = audiotapes.Where(audiotape => audiotape.ID == idReturn);
                    foreach (var audiotape in selectedAudiotape)
                    {
                        matches++;
                        audiotape.isAvailable = true;
                        audiotape.tenantID = null;
                        Helper.SaveAudiotapes(audiotapes);
                    }
                }                
                if (action == 3)
                {
                    var selectedDisc = discs.Where(disc => disc.ID == idReturn);
                    foreach (var disc in selectedDisc)
                    {
                        matches++;
                        disc.isAvailable = true;
                        disc.tenantID = null;
                        Helper.SaveDiscs(discs);
                    }
                }
                if (matches == 0)
                {
                    Console.WriteLine("No item found");
                }
            }
            catch
            {
                Console.WriteLine("Wrong data. Try again");
            }
        }

        public void ShowTenantsAndCompanies()
        {
            Console.WriteLine($"List of all Tenants: ");
            tenants.ToList().ForEach(tenant => Console.WriteLine(tenant));
            Console.WriteLine($"List of all Companies: ");
            companies.ToList().ForEach(company => Console.WriteLine(company));
        }

        public void LaunchVideoSalon()
        {
            while (true)
            {
                Console.WriteLine($"Hello! What would you like to do? \n 1 - Look at a list of available videotapes \n 2 - Look at a list of rented videotapes \n 3 - Rent \n 4 - Return \n 5 - Add/Remove videotape \n 6 - Add/Remove Invividual tenant \n 7 - Show all Tenants & Companies \n 0 - Exit");
                try
                {
                    int action = Convert.ToInt32(Console.ReadLine());
                    if (action == 1)
                    {
                        ListOfAvailableVideotapes();
                    }
                    else if (action == 2)
                    {
                        VideotapesRented();
                    }
                    else if (action == 3)
                    {
                        Rent();
                    }
                    else if (action == 4)
                    {
                        Return();
                    }
                    else if (action == 5)
                    {
                        AddRemoveVideotape();
                    }
                    else if (action == 6)
                    {
                        AddRemoveTenant();
                    }
                    else if (action == 7)
                    {
                        ShowTenantsAndCompanies();
                    }
                    else if (action == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("There is no action with this number type. Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Exception catched");
                }
            }
        }
    }
}
