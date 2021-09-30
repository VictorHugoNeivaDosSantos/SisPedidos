using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Model
{
    public class Address
    {
        public long Id { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        

    }
}
