using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Model
{
    public class OrderItem
    {
        public long Id { get; set; }
        public long Quantity { get; set; }
        public long IdProduto { get; set; }      
    }
}
