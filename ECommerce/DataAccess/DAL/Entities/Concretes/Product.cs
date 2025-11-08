using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Product : BaseClass
    {
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        //ilişki kurulacak
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Supplier ilişkisi
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }

}
