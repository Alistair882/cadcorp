using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using loadToDatabase.Models;

namespace loadToDatabase.Helpers
{
    public class AddressDataMap : ClassMap<AddressData>
    {
        public AddressDataMap()
        {
            Map(m => m.Address).Name("Address");
            Map(m => m.Postcode).Name("Postcode");
        }
    }
}