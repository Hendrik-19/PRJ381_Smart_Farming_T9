﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Smart_Farming.BusinessLogic;
using System.Linq;

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

        public async Task<List<ClimateAreaTable>> GetClimateAsync()
        {
            //Get all climates.
            var data = await database.Table<ClimateAreaTable>().ToListAsync();

            return data.ToList();
        }

        public Task<List<ClimateAreaCropsTable>> GetClimateCropsAsync()
        {
            //Get all climate crops.
            return database.Table<ClimateAreaCropsTable>().ToListAsync();
        }
        public Task<List<CropTable>> GetCropItemsNotDoneAsync(string Query)
        {
            return database.QueryAsync<CropTable>(Query);
        }
    }
}
