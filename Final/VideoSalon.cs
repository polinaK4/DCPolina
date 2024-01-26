using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks.Dataflow;

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

        public void AllItemsByType()
        {
            var allItems = items.GroupBy(i => i.type);
            foreach (var type in allItems)
            {
                Console.WriteLine(type.Key);
                foreach (var item in type)
                {
                    Console.WriteLine(item.name);
                }
            }
        }

        public void ListAvailableItems()
        {
            items.Where(item => !rentedItems.Any(itemR => itemR.itemId == item.ID)).ToList().ForEach(item => Console.WriteLine(item));
        }

        public void ListRentedItems()
        {
            var rentedResults = from itemR in rentedItems
            join item in items
              on itemR.itemId equals item.ID
            join customer in customers
            on itemR.tenantId equals customer.ID
            select new { itemId = item.ID, Name = item.name, TenantId = customer.ID };
            foreach (var item in rentedResults)
            {
                Console.WriteLine($"{item.itemId} {item.Name} | Rented by customer with Id: {item.TenantId}");
            }
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

        public void AddRemoveItem()
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
                Console.Write("Select type: 1 - Videotape 2 - Audiotape 3 - Disc ");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    Console.Write("Enter VideoCodek type: ");
                    var videoCodek = Console.ReadLine();
                    Console.Write("Enter AudioCodek type: ");
                    var audioCodek = Console.ReadLine();
                    items.Add(new Videotape(ID, "Videotape" , name, rentPrice, videoCodek, audioCodek));
                }
                else if (type == 2)
                {
                    Console.Write("Enter AudioCodek type: ");
                    var audioCodek = Console.ReadLine();
                    items.Add(new Audiotape(ID, "Audiotape", name, rentPrice, audioCodek));
                }
                else if (type == 3)
                {
                    Console.Write("Enter File system type: ");
                    var fileSystem = Console.ReadLine();
                    items.Add(new Disc(ID, "Disc", name, rentPrice, fileSystem));
                }                
            }
            if (action == 2)
            {
                Console.Write("Enter ID of item that you want to remove: ");
                int removeId = Convert.ToInt32(Console.ReadLine());
                items.Where(item => item.ID == removeId).ToList().ForEach(item => items.Remove(item));
            }
            Helper.SaveItems(items);
        }

        public void AddRemoveCustomer()
        {
            Console.WriteLine($"Do you want to add or remove customer? \n 1 - Add \n 2 - Remove ");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                Console.Write("Enter ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Select type: 1 - Individual Tenant 2 - Company");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    Console.Write("Enter first name: ");
                    var firstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    var lastName = Console.ReadLine();
                    customers.Add(new Tenant(ID, "Individual Tenant", firstName, lastName));
                }
                else if (type == 2)
                {
                    Console.Write("Enter name: ");
                    var name = Console.ReadLine();
                    customers.Add(new Company(ID, "Company", name));
                }
            }
            if (action == 2)
            {
                Console.Write("Enter ID of customer that you want to remove: ");
                int removeId = Convert.ToInt32(Console.ReadLine());
                customers.Where(customer => customer.ID == removeId).ToList().ForEach(customer => customers.Remove(customer));
            }
            Helper.SaveCustomers(customers);
        }

        public void LaunchVideoSalon()
        {
            while (true)
            {
                Console.WriteLine($"Hello! What would you like to do? \n 1 - All Items \n 2 - Available Items \n 3 - Rented Items \n 4 - Tenants & Companies \n 5 - Rent \n 6 - Return \n 7 - Add/Remove Item \n 8 - Add/Remove Customer \n 0 - Exit");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    AllItemsByType();
                }
                else if (action == 2)
                {
                    ListAvailableItems();
                }
                else if (action == 3)
                {
                    ListRentedItems();

                }
                else if (action == 4)
                {
                    ListTenantsAndCompanies();
                }
                else if (action == 5)
                {
                    Rent();

                }
                else if (action == 6)
                {
                    Return();
                }
                else if (action == 7)
                {
                    AddRemoveItem();
                }
                else if (action == 8)
                {
                    AddRemoveCustomer();
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
