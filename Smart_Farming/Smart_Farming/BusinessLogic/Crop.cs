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
        Image cropImage;

        // public properties 
        public int CropID { get => cropID; set => cropID = value; }
        public string CropName { get => cropName; set => cropName = value; }
        public string SowTime { get => sowTime; set => sowTime = value; }
        public double HarvestTime { get => harvestTime; set => harvestTime = value; }
        public double IrrigationAmount { get => irrigationAmount; set => irrigationAmount = value; }
        public string Pests { get => pests; set => pests = value; }
        public Image CropImage { get => cropImage; set => cropImage = value; }

        // public constructor
        public Crop(int cropID, string cropName, string sowTime, double harvestTime, double irrigationAmount, string pests, Image cropImage)
        {
            this.cropID = cropID;
            this.cropName = cropName;
            this.sowTime = sowTime;
            this.harvestTime = harvestTime;
            this.irrigationAmount = irrigationAmount;
            this.pests = pests;
            this.cropImage = cropImage;
        }

        // Constructopr for no image
        public Crop(int cropID, string cropName, string sowTime, double harvestTime, double irrigationAmount, string pests)
        {
            this.cropID = cropID;
            this.cropName = cropName;
            this.sowTime = sowTime;
            this.harvestTime = harvestTime;
            this.irrigationAmount = irrigationAmount;
            this.pests = pests;
        }

        // Equals override
        public override bool Equals(object obj)
        {
            return obj is Crop crop &&
                   cropID == crop.cropID &&
                   cropName == crop.cropName &&
                   sowTime == crop.sowTime &&
                   harvestTime == crop.harvestTime &&
                   irrigationAmount == crop.irrigationAmount &&
                   pests == crop.pests &&
                   EqualityComparer<Image>.Default.Equals(cropImage, crop.cropImage);
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
            hashCode = hashCode * -1521134295 + EqualityComparer<Image>.Default.GetHashCode(cropImage);
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
