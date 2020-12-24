using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string Order_Date { get; set; }
        public string Delivery_Date { get; set; }
    }
}
