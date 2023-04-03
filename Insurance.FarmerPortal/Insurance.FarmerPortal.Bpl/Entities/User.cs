using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.FarmerPortal.Bpl.Entities
{
    public class User
    {
        public long ID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<ContactDetail> ContactDetails { get; set; }
        public Address PermanentAddress { get; set; }
        public Address CurrentAddress { get; set; }
    }
}
