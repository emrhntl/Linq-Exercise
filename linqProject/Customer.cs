using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProject
{
    internal class Customer
    {
        public string customerId { get; set; }
        public string contactName { get; set; }
        public List<Order> orders { get; set; }
        public int orderCount { 
            get 
            {
                return orders.Count;        
            }
        }
    }
}
