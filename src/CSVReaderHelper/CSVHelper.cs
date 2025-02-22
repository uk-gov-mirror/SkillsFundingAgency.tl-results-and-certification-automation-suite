﻿using CsvHelper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CSVReaderHelper
{
    public class CSVHelper
    {
        public IEnumerable<CsvErrors> Main(string folder, string filename)
        {
            using var reader = new StreamReader($"{folder}{filename}");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.HasHeaderRecord = true;
            var records = csv.GetRecords<CsvErrors>();
            return records.ToList();
        }

        public IEnumerable<CsvErrors> ExpectedData(string file)
        {
            using var reader1 = new StreamReader(file);
            using var csv1 = new CsvReader(reader1, CultureInfo.InvariantCulture);
            csv1.Configuration.HasHeaderRecord = true;
            var records = csv1.GetRecords<CsvErrors>();
            return records.ToList();
        }
    }
}
