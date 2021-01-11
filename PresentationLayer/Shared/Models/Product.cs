using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }
        public int CategoryID { get; set; }

    }
}
