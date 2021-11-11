using System;
using System.Collections.Generic;
using System.Text;
using Smart_Farming.BusinessLogic;
using Xamarin.Forms;

namespace Smart_Farming.DataAccess
{
    class Datahandler_2 //class for dumy values for testing until database works
    { 
        public List<Climates> getClimateList()
        {
            List<Climates> climates = new List<Climates>();

            climates.Add(new Climates(1,"ColdTemperate",-2,29,15,30));
            climates.Add(new Climates(2,"HotTemperate", 10, 80, 65, 70));
            climates.Add(new Climates(3,"SummerRainSubTropical", 7, 78, 60, 80));
            climates.Add(new Climates(4,"WinterRainSubtropical", 5, 68, 50, 65));
            climates.Add(new Climates(5, "AridDesert", 20, 90, 2, -3));

            return climates;
        }

        public List<Crop> getCropList()
        {
            List<Crop> crops = new List<Crop>();

            crops.Add(new Crop(1,"Sweetcorn", "August-March", 18, 20, "Bollworm", new Image { Source = "C:\\Users\\jppri\\Pictures\\SmartFarming\\sweetcorn.jpg" },1));
            crops.Add(new Crop(1, "Potato", "August-June", 18, 20, "Bollworm", new Image { Source = "C:\\Users\\jppri\\Pictures\\SmartFarming\\sweetcorn.jpg" },2));
            crops.Add(new Crop(1, "Butternut", "September-December", 18, 20, "Bollworm", new Image { Source = "C:\\Users\\jppri\\Pictures\\SmartFarming\\sweetcorn.jpg" },3));
            crops.Add(new Crop(1, "Cabbage", "March-September", 18, 20, "Bollworm", new Image { Source = "C:\\Users\\jppri\\Pictures\\SmartFarming\\sweetcorn.jpg" },4));
            crops.Add(new Crop(1, "Onion", "January-April", 18, 20, "Bollworm", new Image { Source = "C:\\Users\\jppri\\Pictures\\SmartFarming\\sweetcorn.jpg" },5));

            return crops;
        } 
    }
}
