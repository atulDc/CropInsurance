using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.FarmerPortal.Dal.Entities
{
    public class ContactDetail
    {
        public long ID { get; set; }
        public ContactType Type { get; set; }
        public short AreaCode { get; set; }
        public short ContactNumber { get; set; }
    }
}
