using System;
using System.Collections.Generic;

namespace ООО_Товары_для_животных.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Products>();
        }

        public int ManufacturerId { get; set; }
        public string ProductManufacturer { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
