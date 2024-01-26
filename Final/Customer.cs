using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public abstract class Customer
    {
        public int ID;
        public string type; 

        public Customer(int id, string type)
        {
            this.ID = id;
            this.type = type;
        }
    }
}
