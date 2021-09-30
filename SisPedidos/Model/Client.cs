using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Model
{
    public class Client
    {
        public long Id { get; set; }
        public string Document { get; set; }
        public string CompanyName { get; set; }
        public string StateRegistration { get; set; }
    }
}
