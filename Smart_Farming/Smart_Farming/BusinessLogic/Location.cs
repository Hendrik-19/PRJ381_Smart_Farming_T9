using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class Location
    {
        // here the manilulation of the results from the api will be manipulated and sent to the database so that it can retrieve the apprpriate results
        // remeber to get the data from the form and send it here.

        int climateID;
        double latidue, longitude, avgMaxTemp, avgMinTemp, avgPercipitation;

        public Location()
        {
        }

        public int ClimateID { get => climateID; set => climateID = value; }
        public double Latidue { get => latidue; set => latidue = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public double AvgMaxTemp { get => avgMaxTemp; set => avgMaxTemp = value; }
        public double AvgMinTemp { get => avgMinTemp; set => avgMinTemp = value; }
        public double AvgPercipitation { get => avgPercipitation; set => avgPercipitation = value; }

        public void getResults(int climateId)
        {
            // stuff to be done
        }
    }
}
