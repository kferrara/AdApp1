using System.Collections.Generic;

namespace AdApp1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<RoleType> Roles { get; set; }
        public virtual StatusType Status { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}