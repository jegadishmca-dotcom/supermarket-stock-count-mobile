using SQLite;
using StockCountMobile.Models;

namespace StockCountMobile.Services;

public class DatabaseService
{
    SQLiteAsyncConnection db;

    public async Task Init()
    {
        if (db != null) return;

        var path = Path.Combine(FileSystem.AppDataDirectory, "stockcount.db");

        db = new SQLiteAsyncConnection(path);

        await db.CreateTableAsync<ProductMaster>();
        await db.CreateTableAsync<StockCount>();
    }

    public Task<List<ProductMaster>> GetProducts(string barcode)
    {
        return db.Table<ProductMaster>()
            .Where(p => p.Barcode == barcode)
            .ToListAsync();
    }

    public Task<int> SaveCount(StockCount count)
    {
        return db.InsertAsync(count);
    }

    public Task<List<StockCount>> GetAllCounts()
    {
        return db.Table<StockCount>().ToListAsync();
    }
}
