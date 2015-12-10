using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.model
{
    class Order
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        // Телефон клиента. 
        public String clientPhone { get; set; }

        // Список покупок. 
        public ICollection<OrderItem> Orders { get; set; }
        public Order()
        {
            Orders = new List<OrderItem>();
        }
                
    }

    class OrderItem
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu FromMenu { get; set; }
        public decimal salePrice { get; set; }

        public int? OrderId { get; set; }
        public Order Order { get; set; }


    }
}
