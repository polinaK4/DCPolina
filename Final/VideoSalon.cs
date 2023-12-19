using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final
{
    public class VideoSalon
    {
        public string name;
        public List<Videotape> videotapes;
        public List<Tenant> tenants;

        public VideoSalon(string name, List<Videotape> videotapes, List<Tenant> tenants)
        {
            this.name = name;
            this.videotapes = videotapes;
            this.tenants = tenants;
        }

        public void ListOfAvailableVideotapes()
        {
            Console.WriteLine($"Available videotapes: ");
            for (int i = 0; i < videotapes.Count; i++)
            {
                if (videotapes[i].isAvailable == true)
                {
                    Console.WriteLine($"{videotapes[i].ID} | {videotapes[i].name} | Price: {videotapes[i].rentPrice};");
                }
            }
        }

        public void VideotapesRented()
        {
            Console.WriteLine("Rented Videotapes");
            for (int i = 0; i < tenants.Count; i++)
            {
                foreach (var rentedVideotape in tenants[i].rentedVideotapes)
                {
                    Console.WriteLine($"{rentedVideotape.ID} | {rentedVideotape.name} | Price: {rentedVideotape.rentPrice} | Rented by: {tenants[i].firstName} {tenants[i].lastName}");
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
                videotapes.Add(new Videotape(ID, name, rentPrice, true));
                string output = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
                File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\videotapes.json", output);
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
                        string output = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
                        File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\videotapes.json", output);
                    }
                }
                for (int f = 0; f < tenants.Count; f++)
                {
                    for (int j = 0; j < tenants[f].rentedVideotapes.Count; j++)
                    {
                        if (tenants[f].rentedVideotapes[j].ID == removeId)
                        {
                            tenants[f].rentedVideotapes.Remove(tenants[f].rentedVideotapes[j]);
                            string outputT = JsonConvert.SerializeObject(tenants, Formatting.Indented);
                            File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\tenants.json", outputT);
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
                tenants.Add(new Tenant(ID, firstName, lastName, new List<Videotape>() { }));
                string outputT = JsonConvert.SerializeObject(tenants, Formatting.Indented);
                File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\tenants.json", outputT);
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
                        string outputT = JsonConvert.SerializeObject(tenants, Formatting.Indented);
                        File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\tenants.json", outputT);
                    }
                }
             }
        }

        public void RentAVideotape()
        {
            try
            {
                Console.WriteLine($"Write ID of the videotape to rent:");
                int idV = Convert.ToInt32(Console.ReadLine());                
                Console.WriteLine($"Write ID of the tenant:");
                int idT = Convert.ToInt32(Console.ReadLine());
                int matches = 0;
                for (int i = 0; i < videotapes.Count; i++)
                {
                    if (videotapes[i].ID == idV)
                    {
                        if (videotapes[i].isAvailable == true)
                        {                           
                            videotapes[i].isAvailable = false;
                            string output = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
                            File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\videotapes.json", output);
                            
                            for (int f = 0; f < tenants.Count; f++)
                            {
                                if (tenants[f].ID == idT)
                                {
                                    matches++;                                                                   
                                    tenants[f].rentedVideotapes.Add(videotapes[i]);
                                    string outputT = JsonConvert.SerializeObject(tenants, Formatting.Indented);
                                    File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\tenants.json", outputT);
                                    Console.WriteLine($"Videotape {videotapes[i].ID} | {videotapes[i].name} has been rented succesfully by {tenants[f].firstName} {tenants[f].lastName}");
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
                if (matches == 0)
                {
                    Console.WriteLine("No videotape or tenant with such ID");
                }
            }
            catch
            {
                Console.WriteLine("Wrong data. Try again");
            }
        }

        public void ReturnAVideotape()
        {
            try
            {
                Console.WriteLine($"Write ID of the videotape to return:");
                int idV = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write ID of the tenant:");
                int idT = Convert.ToInt32(Console.ReadLine());
                int matches = 0;
                for (int i = 0; i < tenants.Count; i++)
                {
                    if (tenants[i].ID == idT)
                    {
                        for (int j = 0; j < videotapes.Count; j++)
                        {
                            if (videotapes[j].ID == idV)
                            {
                                videotapes[j].isAvailable = true;
                                string output = JsonConvert.SerializeObject(videotapes, Formatting.Indented);
                                File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\videotapes.json", output);
                            }
                        }
                        for (int f = 0; f < tenants[i].rentedVideotapes.Count; f++)
                        {
                            if (tenants[i].rentedVideotapes[f].ID == idV)
                            {
                                matches++;
                                Console.WriteLine($"Returning {tenants[i].rentedVideotapes[f].ID} | {tenants[i].rentedVideotapes[f].name} by {tenants[i].firstName} {tenants[i].lastName}");
                                tenants[i].rentedVideotapes.Remove(tenants[i].rentedVideotapes[f]);
                                string outputT = JsonConvert.SerializeObject(tenants, Formatting.Indented);
                                File.WriteAllText(@"C:\Users\Polina\Source\Repos\DCPolina\Final\Json\tenants.json", outputT);
                            }
                        }
                    }
                }
                if (matches == 0)
                {
                    Console.WriteLine("No videotape or tenant with such ID");
                }
            }
            catch
            {
                Console.WriteLine("Wrong data. Try again");
            }
        }

        public void LaunchVideoSalon()
        {
            while (true)
            {
                Console.WriteLine($"Hello! What would you like to do? \n 1 - Look at a list of available videotapes \n 2 - Look at a list of rented videotapes \n 3 - Rent a videotape \n 4 - Return videotape \n 5 - Add/Remove videotape \n 6 - Add/Remove tenant \n 0 - Exit");
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
                        RentAVideotape();
                    }
                    else if (action == 4)
                    {
                        ReturnAVideotape();
                    }
                    else if (action == 5)
                    {
                        AddRemoveVideotape();
                    }
                    else if (action == 6)
                    {
                        AddRemoveTenant();
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
                Console.WriteLine("Do another? (y - for Yes, anything else for Exit)");
                if (Console.ReadLine() != "y")
                    break;
            }
        }
    }
}
