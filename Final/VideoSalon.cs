using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Final
{
    public class VideoSalon
    {
        public string name;
        public List<VideosalonItem> items;
        public List<Customer> customers;
        public List<RentedItems> rentedItems;

        public VideoSalon(string name,List<VideosalonItem> items, List<Customer> customers, List<RentedItems> rentedItems)
        {
            this.name = name;
            this.items = items;
            this.customers = customers;
            this.rentedItems = rentedItems; 
        }

        public void ListAvailableItems()
        {
            items.Where(item => !rentedItems.Any(itemR => itemR.itemId == item.ID)).ToList().ForEach(item => Console.WriteLine(item));
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
            items.Where(item => rentedItems.Any(itemR => itemR.itemId == item.ID) && item.ID == idRent).ToList().ForEach(item => { Console.WriteLine($"Item '{item.ID} | {item.name}' is not available"); matches++; });
            items.Where(item => !rentedItems.Any(itemR => itemR.itemId == item.ID) && item.ID == idRent).ToList().ForEach(item => { rentedItems.Add(new RentedItems(idRent, idTenant)); Helper.SaveRent(rentedItems); Console.WriteLine($"Item {item.name} ID:{item.ID} has been rented succesfully"); matches++; });
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
            rentedItems.Where(itemR => itemR.itemId == idReturn).ToList().ForEach(itemR => { rentedItems.Remove(itemR); Helper.SaveRent(rentedItems); matches++; });
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
