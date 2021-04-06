using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MonthlyIncome;
using System.Data;
using CsvHelper; // https://joshclose.github.io/CsvHelper/examples/csvdatareader/
using System.Globalization;

namespace MonthlyIncome.Utilities
{
    class CsvManager
    {
        public static DataTable LoadCsv(string dir, string fileName)
        {
            DataTable dt = new DataTable();
            if (dir[dir.Length - 1] != '/') dir = dir + '/';

            using (var reader = new StreamReader($"{dir}{fileName}"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            // Do any configuration to `CsvReader` before creating CsvDataReader.
            using (var dr = new CsvDataReader(csv))
            {
                dt.Load(dr);
            }
            return dt;
        }
        public static int SaveDataTable_ToCsv(string dir, string fileName, DataTable table)
        {
            using (var textWriter = File.CreateText(@"D:\Temp\NewCsv.csv"))
            using (var csv = new CsvWriter(textWriter, CultureInfo.InvariantCulture))
            {
                //dt.Load(CHAIN); not sure how to do this

                // Write columns
                foreach (DataColumn column in table.Columns)       //copy datatable CHAIN to DT, or just use CHAIN
                {
                    csv.WriteField(column.ColumnName);
                }
                csv.NextRecord();

                // Write row values
                foreach (DataRow row in table.Rows)
                {
                    for (var i = 0; i < table.Columns.Count; i++)
                    {
                        csv.WriteField(row[i]);
                    }
                    csv.NextRecord();
                }
            }
            return 1;
        }
    }
}
