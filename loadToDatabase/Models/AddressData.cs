using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loadToDatabase.Models
{
    public class AddressData
    {
        public int Id { get; set; }
        public required string Address { get; set; }
        public required string Postcode { get; set; }
    }
}