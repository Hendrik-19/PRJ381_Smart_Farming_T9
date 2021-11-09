using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; // <--added a NuGet Package for this
using Xamarin.Forms;
using SQLite;
using System.Threading.Tasks;

namespace Smart_Farming.DataAccess
{
    public class Datahandler
    {
        #region DatabaseInitialization
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<Datahandler> Instance = new AsyncLazy<Datahandler>(async () =>
        {
            var instance = new Datahandler();
            CreateTableResult CropResult = await Database.CreateTableAsync<CropTable>(); // we think this line needs to be created for each table
            CreateTableResult ClimateResult = await Database.CreateTableAsync<ClimateAreaTable>();
            CreateTableResult LinkingResult = await Database.CreateTableAsync<ClimateAreaCropsTable>();
            return instance;
        });

        public Datahandler()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }
        #endregion

        #region DatabaseInteraction
        // For Crop table reading
        public Task<List<CropTable>> GetItemsAsyncCrop()
        {
            return Database.Table<CropTable>().ToListAsync();
        }
        public Task<List<CropTable>> GetItemsNotDoneAsyncCrop(string Query)
        {
            return Database.QueryAsync<CropTable>(Query);
        }
        public Task<CropTable> GetItemAsyncCrop(int id)
        {
            return Database.Table<CropTable>().Where(i => i.CropID == id).FirstOrDefaultAsync();
        }

        // For Climate table reading
        public Task<List<ClimateAreaTable>> GetItemsAsyncClimate()
        {
            return Database.Table<ClimateAreaTable>().ToListAsync();
        }
        public Task<List<ClimateAreaTable>> GetItemsNotDoneAsyncClimate(string Query)
        {
            return Database.QueryAsync<ClimateAreaTable>(Query);
        }
        public Task<ClimateAreaTable> GetItemAsyncClimate(int id)
        {
            return Database.Table<ClimateAreaTable>().Where(i => i.ClimateID == id).FirstOrDefaultAsync();
        }

        // For Climate Crop lining table reading
        public Task<List<ClimateAreaCropsTable>> GetItemsAsyncLinking()
        {
            return Database.Table<ClimateAreaCropsTable>().ToListAsync();
        }
        public Task<List<ClimateAreaCropsTable>> GetItemsNotDoneAsyncLinking(string Query)
        {
            return Database.QueryAsync<ClimateAreaCropsTable>(Query);
        }
        public Task<ClimateAreaCropsTable> GetItemAsyncLinking(int id)
        {
            return Database.Table<ClimateAreaCropsTable>().Where(i => i.ClimateID == id).FirstOrDefaultAsync();
        }
        #endregion
    }
}
