using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final
{
    public class VideoSalon
    {
        public string name;
        public List<VideosalonItem> items;
        public List<Customer> customers;

        public VideoSalon(string name,List<VideosalonItem> items, List<Customer> customers)
        {
            this.name = name;
            this.items = items;
            this.customers = customers;
        }

        public void ListAvailableItems()
        {
            items.Where(item => item.isAvailable == true).ToList().ForEach(item => Console.WriteLine(item)); 
        }

        public void ListTenantsAndCompanies()
        {
            customers.ToList().ForEach(customer => Console.WriteLine(customer));
        }

        public void Rent()
        {
            Console.WriteLine($"Write ID of the tenant:");
            int idTenant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write ID of item to rent:");
            int idRent = Convert.ToInt32(Console.ReadLine());
            int matches = 0;            
            items.Where(item => item.ID == idRent && item.isAvailable == false).ToList().ForEach(item => { Console.WriteLine($"Item '{item.ID} | {item.name}' is not available"); matches++; }) ;
            items.Where(item => item.ID == idRent && item.isAvailable == true).ToList().ForEach( item => {item.isAvailable = false; item.tenantId = idTenant; Console.WriteLine($"Item {item.name} ID:{item.ID} has been rented succesfully"); matches++; });
            if (matches == 0)
            {
                Console.WriteLine("No item or tenant with such ID");
            }
        }

        public void Return()
        {
            Console.WriteLine($"Write ID of item to return:");
            int idReturn = Convert.ToInt32(Console.ReadLine());
            int matches = 0;
            items.Where(item => item.ID == idReturn).ToList().ForEach(item => { item.isAvailable = true; item.tenantId = null; matches++; });
            if (matches == 0)
            {
                Console.WriteLine("No item found");
            }
        }

        public void LaunchVideoSalon()
        {
            while (true)
            {
                Console.WriteLine($"Hello! What would you like to do? \n 1 - Look at a list of available items \n 2 - Show all Tenants & Companies \n 3 - Rent \n 4 - Return \n 0 - Exit");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    ListAvailableItems();
                }
                else if (action == 2)
                {
                    ListTenantsAndCompanies();
                }
                else if (action == 3)
                {
                    Rent();
                }
                else if (action == 4)
                {
                    Return();
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
        }
    }
}
