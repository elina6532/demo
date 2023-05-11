using System;
using System.Collections.Generic;

namespace ООО_Товары_для_животных.Models
{
    public partial class Orderproducts
    {
        public int OrderId { get; set; }
        public string ProductArticleNumber { get; set; }
        public int OrderProductCount { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products ProductArticleNumberNavigation { get; set; }
    }
}
