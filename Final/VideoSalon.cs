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
                            for (int f = 0; f < tenants.Count; f++)
                            {
                                if (tenants[f].ID == idT)
                                {
                                    matches++;
                                    tenants[f].rentedVideotapes.Add(videotapes[i]);
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
                        for (int f = 0; f < tenants[i].rentedVideotapes.Count; f++)
                        {
                            if (tenants[i].rentedVideotapes[f].ID == idV)
                            {
                                matches++;
                                Console.WriteLine($"Returning {tenants[i].rentedVideotapes[f].ID} | {tenants[i].rentedVideotapes[f].name} by {tenants[i].firstName} {tenants[i].lastName}");
                                tenants[i].rentedVideotapes.Remove(tenants[i].rentedVideotapes[f]);
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
            Console.WriteLine($"Hello! What would you like to do? \n 1 - Look at a list of available videotapes \n 2 - Look at a list of rented videotapes \n 3 - Rent a videotape \n 4 - Return videotape");
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
                    VideotapesRented();
                }
                else if (action == 4)
                {
                    ReturnAVideotape();
                    ListOfAvailableVideotapes();
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
