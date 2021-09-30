using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Model
{
    public class Order
    {
        public long Id { get; set; }
        public string PayMethod { get; set; }
        public double TotalValue { get; set; }
        public double Discount { get; set; }
        public double SubTotalValue { get; set; }
        public double ValuePaid { get; set; }
        public double Transshipmend { get; set; }
        List<OrderItem> ListOrdemItem { get; set; }
    }
}
