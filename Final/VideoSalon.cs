using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final
{
    public class VideoSalon
    {
        public string name;
        public List<Videotape> videotapes;
        public List<Tenant> tenants;
        public List<Audiotape> audiotapes;
        public List<Disc> discs;
        public List<Company> companies;
        
        public VideoSalon(string name, List<Videotape> videotapes, List<Tenant> tenants, List<Audiotape> audiotapes, List<Disc> discs, List<Company> companies)
        {
            this.name = name;
            this.videotapes = videotapes;
            this.tenants = tenants;
            this.audiotapes = audiotapes;
            this.discs = discs;
            this.companies = companies;
        }

        public void ListOfAvailableVideotapes()
        {
            Console.WriteLine($"Available videotapes: ");
            for (int i = 0; i < videotapes.Count; i++)
            {
                if (videotapes[i].isAvailable == true)
                {
                    Console.WriteLine($"{videotapes[i].name} | Price: {videotapes[i].rentPrice} | VideoCodek: {videotapes[i].videoCodek} | AudioCodek: {videotapes[i].audioCodek} | ID: {videotapes[i].ID};");
                }
            }
        }

        public void VideotapesRented()
        {
            Console.WriteLine("Rented Videotapes:");
            for (int i = 0; i < tenants.Count; i++)
            {
                foreach (var rentedVideotape in tenants[i].rentedVideotapes)
                {
                    Console.WriteLine($"{rentedVideotape.name} | Price: {rentedVideotape.rentPrice} | ID: {rentedVideotape.ID} | Rented by: {tenants[i].firstName} {tenants[i].lastName}");
                }
            }
            for (int i = 0; i < companies.Count; i++)
            {
                foreach (var rentedVideotape in companies[i].rentedVideotapes)
                {
                    Console.WriteLine($"{rentedVideotape.name} | Price: {rentedVideotape.rentPrice} | ID: {rentedVideotape.ID} | Rented by: {companies[i].name}");
                }
            }
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
                videotapes.Add(new Videotape(ID, name, rentPrice, true, videoCodek, audioCodek));
                Helper.SaveVideotapes(videotapes);
            }
            if (action == 2)
            {
                Console.Write("Enter ID of videotape that you want to remove: ");
                int removeId = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < videotapes.Count; i++)
                {
                    if (videotapes[i].ID == removeId)
                    {
                        videotapes.Remove(videotapes[i]);
                        Helper.SaveVideotapes(videotapes);
                    }
                }
                for (int f = 0; f < tenants.Count; f++)
                {
                    for (int j = 0; j < tenants[f].rentedVideotapes.Count; j++)
                    {
                        if (tenants[f].rentedVideotapes[j].ID == removeId)
                        {
                            tenants[f].rentedVideotapes.Remove(tenants[f].rentedVideotapes[j]);
                            Helper.SaveTenants(tenants);
                        }
                    }
                }
                for (int f = 0; f < companies.Count; f++)
                {
                    for (int j = 0; j < companies[f].rentedVideotapes.Count; j++)
                    {
                        if (companies[f].rentedVideotapes[j].ID == removeId)
                        {
                            companies[f].rentedVideotapes.Remove(companies[f].rentedVideotapes[j]);
                            Helper.SaveCompanies(companies);
                        }
                    }
                }
            }
        }

        public void AddRemoveTenant()
        {
            Console.WriteLine($"Do you want to add or remove tenant? \n 1 - Add \n 2 - Remove ");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Console.Write("Enter ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter first name: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                var lastName = Console.ReadLine();
                tenants.Add(new Tenant(ID, firstName, lastName, new List<Videotape>() { }, new List<Audiotape>() { }, new List<Disc>() { }));
                Helper.SaveTenants(tenants);
            }
            if (action == 2)
            {
                Console.Write("Enter ID of tenant that you want to remove: ");
                int removeId = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < tenants.Count; i++)
                {
                    if (tenants[i].ID == removeId)
                    {
                        tenants.Remove(tenants[i]);
                        Helper.SaveTenants(tenants);
                    }
                }
             }
        }

        public void Rent()
        {
            try
            {
                Console.WriteLine($"Is there Individual tenant ot Company? \n 1 - Individual tenant \n 2 - Company");
                int type = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write ID of the tenant:");
                int idTenant = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What will be rented? \n 1 - Videotape \n 2 - Audiotape \n 3 - Disc");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write ID of item to rent:");
                int idRent = Convert.ToInt32(Console.ReadLine());
                int matches = 0;
                if (action == 1)
                {                                   
                    for (int i = 0; i < videotapes.Count; i++)
                    {
                        if (videotapes[i].ID == idRent)
                        {
                            if (videotapes[i].isAvailable == true)
                            {
                                videotapes[i].isAvailable = false;
                                Helper.SaveVideotapes(videotapes);
                                if (type == 1)
                                {
                                    for (int f = 0; f < tenants.Count; f++)
                                    {
                                        if (tenants[f].ID == idTenant)
                                        {
                                            matches++;
                                            tenants[f].rentedVideotapes.Add(videotapes[i]);
                                            Helper.SaveTenants(tenants);
                                            Console.WriteLine($"Videotape {videotapes[i].name} ID:{videotapes[i].ID} has been rented succesfully by {tenants[f].firstName} {tenants[f].lastName}");
                                        }
                                    }
                                }
                                if (type == 2)
                                {
                                    for (int f = 0; f < companies.Count; f++)
                                    {
                                        if (companies[f].ID == idTenant)
                                        {
                                            matches++;
                                            companies[f].rentedVideotapes.Add(videotapes[i]);
                                            Helper.SaveCompanies(companies);
                                            Console.WriteLine($"Videotape {videotapes[i].name} ID:{videotapes[i].ID} has been rented succesfully by {companies[f].name}");
                                        }
                                    }
                                }
                            }
                            else if (videotapes[i].isAvailable == false)
                            {
                                matches++;
                                Console.WriteLine($"Videotape {videotapes[i].ID} | {videotapes[i].name} is not available");
                            }
                        }
                    }                    
                }
                if (action == 2)
                {
                    for (int i = 0; i < audiotapes.Count; i++)
                    {
                        if (audiotapes[i].ID == idRent)
                        {
                            if (audiotapes[i].isAvailable == true)
                            {
                                audiotapes[i].isAvailable = false;
                                Helper.SaveAudiotapes(audiotapes);
                                if (type == 1)
                                {
                                    for (int f = 0; f < tenants.Count; f++)
                                    {
                                        if (tenants[f].ID == idTenant)
                                        {
                                            matches++;
                                            tenants[f].rentedAudiotapes.Add(audiotapes[i]);
                                            Helper.SaveTenants(tenants);
                                            Console.WriteLine($"Audiotape {audiotapes[i].name} ID:{audiotapes[i].ID} has been rented succesfully by {tenants[f].firstName} {tenants[f].lastName}");
                                        }
                                    }
                                }
                                if (type == 2)
                                {
                                    for (int f = 0; f < companies.Count; f++)
                                    {
                                        if (companies[f].ID == idTenant)
                                        {
                                            matches++;
                                            companies[f].rentedAudiotapes.Add(audiotapes[i]);
                                            Helper.SaveCompanies(companies);
                                            Console.WriteLine($"Audiotape {audiotapes[i].name} ID:{audiotapes[i].ID} has been rented succesfully by {companies[f].name}");
                                        }
                                    }
                                }
                            }
                            else if (audiotapes[i].isAvailable == false)
                            {
                                matches++;
                                Console.WriteLine($"Audiotape {audiotapes[i].ID} | {audiotapes[i].name} is not available");
                            }
                        }
                    }
                }
                if (action == 3)
                {
                    for (int i = 0; i < discs.Count; i++)
                    {
                        if (discs[i].ID == idRent)
                        {
                            if (discs[i].isAvailable == true)
                            {
                                discs[i].isAvailable = false;
                                Helper.SaveDiscs(discs);
                                if (type == 1)
                                {
                                    for (int f = 0; f < tenants.Count; f++)
                                    {
                                        if (tenants[f].ID == idTenant)
                                        {
                                            matches++;
                                            tenants[f].rentedDiscs.Add(discs[i]);
                                            Helper.SaveTenants(tenants);
                                            Console.WriteLine($"Disc {discs[i].name} ID:{discs[i].ID} has been rented succesfully by {tenants[f].firstName} {tenants[f].lastName}");
                                        }
                                    }
                                }
                                if (type == 2)
                                {
                                    for (int f = 0; f < companies.Count; f++)
                                    {
                                        if (companies[f].ID == idTenant)
                                        {
                                            matches++;
                                            companies[f].rentedDiscs.Add(discs[i]);
                                            Helper.SaveCompanies(companies);
                                            Console.WriteLine($"Disc {discs[i].name} ID:{discs[i].ID} has been rented succesfully by {companies[f].name}");
                                        }
                                    }
                                }
                            }
                            else if (discs[i].isAvailable == false)
                            {
                                matches++;
                                Console.WriteLine($"Disc {discs[i].ID} | {discs[i].name} is not available");
                            }
                        }
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
                    for (int i = 0; i < tenants.Count; i++)
                    {
                        for (int f = 0; f < tenants[i].rentedVideotapes.Count; f++)
                        {
                            if (tenants[i].rentedVideotapes[f].ID == idReturn)
                            {
                                matches++;
                                Console.WriteLine($"Returning {tenants[i].rentedAudiotapes[f].name} ID:{tenants[i].rentedAudiotapes[f].ID} by {tenants[i].firstName} {tenants[i].lastName}");
                                tenants[i].rentedVideotapes.Remove(tenants[i].rentedVideotapes[f]);
                                Helper.SaveTenants(tenants);
                            }
                        }
                    }
                    for (int i = 0; i < companies.Count; i++)
                    {
                        for (int f = 0; f < companies[i].rentedVideotapes.Count; f++)
                        {
                            if (companies[i].rentedVideotapes[f].ID == idReturn)
                            {
                                matches++;
                                Console.WriteLine($"Returning {companies[i].rentedVideotapes[f].name} ID:{companies[i].rentedVideotapes[f].ID} by {companies[i].name}");
                                companies[i].rentedVideotapes.Remove(companies[i].rentedVideotapes[f]);
                                Helper.SaveCompanies(companies);
                            }
                        }
                    }
                    for (int i = 0; i < videotapes.Count; i++)
                    {
                        if (videotapes[i].ID == idReturn)
                        {
                            videotapes[i].isAvailable = true;
                            Helper.SaveVideotapes(videotapes);
                        }
                    }
                }
                if (action == 2)
                {
                    for (int i = 0; i < tenants.Count; i++)
                    {
                        for (int f = 0; f < tenants[i].rentedAudiotapes.Count; f++)
                        {
                            if (tenants[i].rentedAudiotapes[f].ID == idReturn)
                            {
                                matches++;
                                Console.WriteLine($"Returning {tenants[i].rentedAudiotapes[f].name} ID:{tenants[i].rentedAudiotapes[f].ID} by {tenants[i].firstName} {tenants[i].lastName}");
                                tenants[i].rentedAudiotapes.Remove(tenants[i].rentedAudiotapes[f]);
                                Helper.SaveTenants(tenants);
                            }
                        }
                    }
                    for (int i = 0; i < companies.Count; i++)
                    {
                        for (int f = 0; f < companies[i].rentedAudiotapes.Count; f++)
                        {
                            if (companies[i].rentedAudiotapes[f].ID == idReturn)
                            {
                                matches++;
                                Console.WriteLine($"Returning {companies[i].rentedAudiotapes[f].name} ID:{companies[i].rentedAudiotapes[f].ID} by {companies[i].name}");
                                companies[i].rentedAudiotapes.Remove(companies[i].rentedAudiotapes[f]);
                                Helper.SaveCompanies(companies);
                            }
                        }
                    }
                    for (int i = 0; i < audiotapes.Count; i++)
                    {
                        if (audiotapes[i].ID == idReturn)
                        {
                            audiotapes[i].isAvailable = true;
                            Helper.SaveAudiotapes(audiotapes);
                        }
                    }
                }                
                if (action == 3)
                {
                    for (int i = 0; i < tenants.Count; i++)
                    {
                        for (int f = 0; f < tenants[i].rentedDiscs.Count; f++)
                        {
                            if (tenants[i].rentedDiscs[f].ID == idReturn)
                            {
                                matches++;
                                Console.WriteLine($"Returning {tenants[i].rentedDiscs[f].name} ID:{tenants[i].rentedDiscs[f].ID} by {tenants[i].firstName} {tenants[i].lastName}");
                                tenants[i].rentedDiscs.Remove(tenants[i].rentedDiscs[f]);
                                Helper.SaveTenants(tenants);
                            }
                        }
                    }
                    for (int i = 0; i < companies.Count; i++)
                    {
                        for (int f = 0; f < companies[i].rentedDiscs.Count; f++)
                        {
                            if (companies[i].rentedDiscs[f].ID == idReturn)
                            {
                                matches++;
                                Console.WriteLine($"Returning {companies[i].rentedDiscs[f].name} ID:{companies[i].rentedDiscs[f].ID} by {companies[i].name}");
                                companies[i].rentedDiscs.Remove(companies[i].rentedDiscs[f]);
                                Helper.SaveCompanies(companies);
                            }
                        }
                    }
                    for (int i = 0; i < discs.Count; i++)
                    {
                        if (discs[i].ID == idReturn)
                        {
                            discs[i].isAvailable = true;
                            Helper.SaveDiscs(discs);
                        }
                    }
                }
                if (matches == 0)
                {
                    Console.WriteLine("No rented items found");
                }
            }
            catch
            {
                Console.WriteLine("Wrong data. Try again");
            }
        }

        public void ShowTenantsAndCompanies()
        {
            Console.WriteLine($"List of Individual tenants: ");
            for (int i = 0; i < tenants.Count; i++)
            {
              Console.WriteLine($"{tenants[i].firstName} {tenants[i].lastName} | ID:{tenants[i].ID};");
            }
            Console.WriteLine($"List of Companies: ");
            for (int i = 0; i < companies.Count; i++)
            {
                Console.WriteLine($"{companies[i].name} | ID:{companies[i].ID};");
            }
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
                    Console.WriteLine("Command is not recognized. Try again");
                }
            }
        }
    }
}
