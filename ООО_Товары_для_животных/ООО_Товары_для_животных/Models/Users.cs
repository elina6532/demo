using System;
using System.Collections.Generic;

namespace ООО_Товары_для_животных.Models
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public int UserId { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int UserRole { get; set; }

        public virtual Roles UserRoleNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
