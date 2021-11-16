using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.BusinessLogic;
using Xamarin.Forms;

namespace Smart_Farming.DataAccess
{
    class Datahandler //class for dumy values for testing until database works
    { 
        public List<Climates> getClimateList()
        {
            List<Climates> climates = new List<Climates>();

            climates.Add(new Climates(1, "Alpine", 13.4, 1, 23.8, 48));
            climates.Add(new Climates(2, "HotDesert", 38.2, 9.3, 0, 5.8));
            climates.Add(new Climates(3, "ColdDesert", 22.3, -10, 5, 12.5));
            climates.Add(new Climates(4, "HumidContinental", 25.2, -3.6, 67.3, 88.5));
            climates.Add(new Climates(5, "HumidSubTropical", 27.3, 12.8, 53, 116.8));
            climates.Add(new Climates(6, "OceanicHighland",  24.6, 8.9, 5.1, 191.6));
            climates.Add(new Climates(7, "OceanicMarine", 18.4, 4.6, 60.9, 106.8));
            climates.Add(new Climates(8, "OceanicSubPolar", 11.6, 1.7, 76.8, 144.4));
            climates.Add(new Climates(9, "SemiArid", 35.1, 7.6, 0, 138));
            climates.Add(new Climates(10, "Temperate", 18, -3, 4.2, 109.6));
            climates.Add(new Climates(11, "TropicalMonsoon", 33.2, 19.7, 0, 736.5));
            climates.Add(new Climates(12, "TropicalRainforest", 31, 23, 565.8, 789.4));
            climates.Add(new Climates(13, "TropicalSavana", 33.4, 17.1, 0, 205.5));

            return climates;
        }

        public List<Crop> getCropList()
        {
            List<Crop> crops = new List<Crop>();

            crops.Add(new Crop(1,"Sweetcorn", "August-March", 18, 20, "Bollworm",  "C:\\Users\\jppri\\Pictures\\SmartFarming\\sweetcorn.jpg" ,1));
            crops.Add(new Crop(2, "Potato", "August-June", 18, 20, "Bollworm", "C:\\Users\\jppri\\Pictures\\SmartFarming\\potato.jpg", 2));
            crops.Add(new Crop(3, "Butternut", "September-December", 18, 20, "Bollworm", "C:\\Users\\jppri\\Pictures\\SmartFarming\\butternut.jpg", 3));
            crops.Add(new Crop(4, "Cabbage", "March-September", 18, 20, "Bollworm", "C:\\Users\\jppri\\Pictures\\SmartFarming\\cabbage.jpg", 4));
            crops.Add(new Crop(5, "Onion", "January-April", 18, 20, "Bollworm", "C:\\Users\\jppri\\Pictures\\SmartFarming\\onion.jpg", 5));
            crops.Add(new Crop(6, "Onion", "January-April", 18, 20, "Bollworm", "C:\\Users\\jppri\\Pictures\\SmartFarming\\onion.jpg", 9));

            return crops;
        } 
    }
}
