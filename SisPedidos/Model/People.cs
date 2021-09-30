using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Model
{
    public class People
    {
        public long Id { get; set; }
        public string CompletedName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Cpf { get; set; }
        
    }
}
