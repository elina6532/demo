using System;
using System.Collections.Generic;

namespace ООО_Товары_для_животных.Models
{
    public partial class Pickuppoints
    {
        public Pickuppoints()
        {
            Orders = new HashSet<Orders>();
        }

        public int PickupPointId { get; set; }
        public int PickupPointIndex { get; set; }
        public string PickupPointAddress { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
