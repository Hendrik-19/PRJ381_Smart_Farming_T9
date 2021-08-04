using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials; // api that allows location services
using Xamarin.Forms; // allows for xamarin form methods like a popup message

namespace Smart_Farming.BusinessLogic
{
    public class Location
    {
        // here the manilulation of the results from the api will be manipulated and sent to the database so that it can retrieve the apprpriate results
        // remeber to get the data from the form and send it here.

        #region Location
        int climateID;
        double latidue, longitude, avgMaxTemp, avgMinTemp, avgPercipitation;

        public Location()
        {
        }

        public Location(int climateID, double latidue, double longitude, double avgMaxTemp, double avgMinTemp, double avgPercipitation)
        {
            this.climateID = climateID;
            this.latidue = latidue;
            this.longitude = longitude;
            this.avgMaxTemp = avgMaxTemp;
            this.avgMinTemp = avgMinTemp;
            this.avgPercipitation = avgPercipitation;
        }

        public int ClimateID { get => climateID; set => climateID = value; }
        public double Latidue { get => latidue; set => latidue = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public double AvgMaxTemp { get => avgMaxTemp; set => avgMaxTemp = value; }
        public double AvgMinTemp { get => avgMinTemp; set => avgMinTemp = value; }
        public double AvgPercipitation { get => avgPercipitation; set => avgPercipitation = value; }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   climateID == location.climateID &&
                   latidue == location.latidue &&
                   longitude == location.longitude &&
                   avgMaxTemp == location.avgMaxTemp &&
                   avgMinTemp == location.avgMinTemp &&
                   avgPercipitation == location.avgPercipitation;
        }

        public override int GetHashCode()
        {
            int hashCode = -141653628;
            hashCode = hashCode * -1521134295 + climateID.GetHashCode();
            hashCode = hashCode * -1521134295 + latidue.GetHashCode();
            hashCode = hashCode * -1521134295 + longitude.GetHashCode();
            hashCode = hashCode * -1521134295 + avgMaxTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + avgMinTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + avgPercipitation.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Functionality
        public void getResults(int climateId)
        {
            // stuff to be done
        }

        public void GetLocation()
        {
            // once we have the locations services and the climate sorted out we can just move it from the front end to here.
        }

        #endregion
    }
}
