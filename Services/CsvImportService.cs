using CsvHelper;
using System.Globalization;
using StockCountMobile.Models;

namespace StockCountMobile.Services;

public class CsvImportService
{
    public List<ProductMaster> Import(string path)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        return csv.GetRecords<ProductMaster>().ToList();
    }
}
