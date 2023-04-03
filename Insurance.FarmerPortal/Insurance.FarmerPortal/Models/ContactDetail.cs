using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.FarmerPortal.Models
{
    public class ContactDetail
    {
        public long ID { get; set; }
        public ContactType Type { get; set; }
        public short AreaCode { get; set; }
        public short ContactNumber { get; set; }
    }
}
