using System;
using System.Collections.Generic;
using System.Text;
using SQLite; // Used to access the SQLite database.
using System.Threading.Tasks; // used for multithreading
using Smart_Farming.BusinessLogic;
using System.Linq;

namespace Smart_Farming.DataAccess
{
    // This is the database class that handles all the database interaction
    #region Database
    public class SmartFarmingBD
    {
        readonly SQLiteAsyncConnection database;

        public SmartFarmingBD(string dbPath) // gets the databse path from the App and creates the folloing tables if they don't already exist
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<CropTable>().Wait();
            database.CreateTableAsync<ClimateAreaTable>().Wait();
            database.CreateTableAsync<ClimateAreaCropsTable>().Wait();
        }

        public SmartFarmingBD()
        {
        }

        public async Task<List<ClimateAreaTable>> GetClimateAsync() // used to get a list of data from the climate table
        {
            //Get all climates.
            var data = await database.Table<ClimateAreaTable>().ToListAsync();

            return data.ToList();
        }

        public Task<List<CropTable>> GetCropItemsNotDoneAsync(string Query) //  used to get data from the crop table
        {
            return database.QueryAsync<CropTable>(Query);
        }
    }
    #endregion
}
