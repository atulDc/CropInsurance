using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.FarmerPortal.Bpl.Entities
{
    public class Address
    {
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String AddressLine3 { get; set; }
        public String City { get; set; }
        public String Zip { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
    }
}
