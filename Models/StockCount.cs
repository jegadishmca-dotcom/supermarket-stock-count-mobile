using SQLite;

namespace StockCountMobile.Models;

public class StockCount
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Barcode { get; set; }

    public string ItemName { get; set; }

    public string Batch { get; set; }

    public string ExpiryDate { get; set; }

    public int SystemStock { get; set; }

    public int ActualStock { get; set; }
}
