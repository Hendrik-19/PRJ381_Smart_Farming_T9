using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using Xamarin.Forms; // used for the Image Datatype

namespace Smart_Farming.BusinessLogic
{
    public class Crop
    {
        #region Crop
        // private fields
        int cropID;
        string cropName, sowTime;
        double harvestTime, irrigationAmount;
        string pests;
        string cropImage;
        int climateID;

        // public properties 
        public int CropID { get => cropID; set => cropID = value; }
        public string CropName { get => cropName; set => cropName = value; }
        public string SowTime { get => sowTime; set => sowTime = value; }
        public double HarvestTime { get => harvestTime; set => harvestTime = value; }
        public double IrrigationAmount { get => irrigationAmount; set => irrigationAmount = value; }
        public string Pests { get => pests; set => pests = value; }
        public string CropImage { get => cropImage; set => cropImage = value; }
        public int ClimateID { get => climateID; set => climateID = value; }

        // public constructor
        public Crop(int cropID, string cropName, string sowTime, double harvestTime, double irrigationAmount, string pests, string cropImage, int climateID)
        {
            this.cropID = cropID;
            this.cropName = cropName;
            this.sowTime = sowTime;
            this.harvestTime = harvestTime;
            this.irrigationAmount = irrigationAmount;
            this.pests = pests;
            this.cropImage = cropImage;
            this.climateID = climateID;
        }

        // Equals override
        public override bool Equals(object obj)
        {
            return obj is Crop crop &&
                   CropID == crop.CropID &&
                   CropName == crop.CropName &&
                   SowTime == crop.SowTime &&
                   HarvestTime == crop.HarvestTime &&
                   IrrigationAmount == crop.IrrigationAmount &&
                   Pests == crop.Pests &&
                   CropImage == crop.CropImage &&
                   ClimateID == crop.ClimateID;
        }

        // HashCode override
        public override int GetHashCode()
        {
            int hashCode = 1318564473;
            hashCode = hashCode * -1521134295 + cropID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cropName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sowTime);
            hashCode = hashCode * -1521134295 + harvestTime.GetHashCode();
            hashCode = hashCode * -1521134295 + irrigationAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(pests);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cropImage);
            hashCode = hashCode * -1521134295 + climateID.GetHashCode();
            return hashCode;
        }

        // toString override
        public override string ToString()
        {
            return base.ToString();
        }

        
        #endregion
    }
}
