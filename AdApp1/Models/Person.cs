using System.Collections.Generic;

namespace AdApp1.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Email> EmailAddresses { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}