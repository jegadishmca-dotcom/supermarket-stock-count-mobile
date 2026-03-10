using CsvHelper;
using System.Globalization;
using StockCountMobile.Models;

namespace StockCountMobile.Services;

public class CsvExportService
{
    public void Export(string path, List<StockCount> data)
    {
        using var writer = new StreamWriter(path);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

        csv.WriteRecords(data);
    }
}
