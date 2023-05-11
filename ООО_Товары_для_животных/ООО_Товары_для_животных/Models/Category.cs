using System;
using System.Collections.Generic;

namespace ООО_Товары_для_животных.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        public string ProductCategory { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
