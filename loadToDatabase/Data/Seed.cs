using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using loadToDatabase.Helpers;
using loadToDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace loadToDatabase.Data
{
    public class Seed
    {
        public static async Task SeedAddresses(AppDbContext context)
        {
            if (await context.AddressData.AnyAsync()) return;

            using var reader = new StreamReader("Data/data.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<AddressDataMap>();
            var records = csv.GetRecords<AddressData>().ToList();

            context.AddressData.AddRange(records);
            await context.SaveChangesAsync();
        }
    }
}