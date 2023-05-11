using System;
using System.Collections.Generic;

namespace ООО_Товары_для_животных.Models
{
    public partial class Units
    {
        public Units()
        {
            Products = new HashSet<Products>();
        }

        public int UnitId { get; set; }
        public string ProductUnit { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
