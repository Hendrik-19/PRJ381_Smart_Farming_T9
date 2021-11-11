using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Smart_Farming.DataAccess
{
    public class SmartFarmingBD
    {
        readonly SQLiteAsyncConnection database;

        public SmartFarmingBD(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<CropTable>().Wait();
            database.CreateTableAsync<ClimateAreaTable>().Wait();
            database.CreateTableAsync<ClimateAreaCropsTable>().Wait();
        }

        public SmartFarmingBD()
        {
        }

        public Task<List<CropTable>> GetCropsAsync()
        {
            //Get all crops.
            return database.Table<CropTable>().ToListAsync();
        }

        public Task<List<CropTable>> GetItemsNotDoneAsyncCrop(string Query)
        { 
            //Getting crops from query
            return database.QueryAsync<CropTable>(Query);
        }

        public Task<List<ClimateAreaTable>> GetClimateAsync()
        {
            //Get all climates.
            return database.Table<ClimateAreaTable>().ToListAsync();
        }

        public Task<List<ClimateAreaTable>> GetItemsNotDoneAsyncClimate(string Query)
        {
            //Getting climate from query
            return database.QueryAsync<ClimateAreaTable>(Query);
        }

        public Task<List<ClimateAreaCropsTable>> GetClimateCropsAsync()
        {
            //Get all climate crops.
            return database.Table<ClimateAreaCropsTable>().ToListAsync();
        }

        public Task<List<ClimateAreaCropsTable>> GetItemsNotDoneAsyncClimateCrops(string Query)
        {
            //Getting climateAreaCrops from query
            return database.QueryAsync<ClimateAreaCropsTable>(Query);
        }
    }
}
