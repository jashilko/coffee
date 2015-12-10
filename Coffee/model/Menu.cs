using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.model
{
    class Menu
    {
        public int Id { get; set; }
        
        public int EnumId { get; set; }
        public Enum Enum { get; set; }

        public short Vol { get; set; }
        public decimal Price { get; set; }

        public bool IsEnabled { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateFinished { get; set; }

    }
}
