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
        public List<Videotape> rentedVideotapes;
        public List<Audiotape> rentedAudiotapes;
        public List<Disc> rentedDiscs;
    }
}
