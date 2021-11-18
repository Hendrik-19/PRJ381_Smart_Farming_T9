﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials; // api that allows location services
using Xamarin.Forms; // allows for xamarin form methods like a popup message
using System.Threading.Tasks; // used in multithreading

namespace Smart_Farming.BusinessLogic
{
    public class Location
    {
        // here the results from the API will be manipulated and sent to the database so that it can retrieve the apprpriate results
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
        Climates climate = new Climates();

        public async Task GetLocation()
        {
            List<double> ave = new List<double>();

            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync(); // this gets the last location that is saved in the device cache
                if (location == null) // this checks of a location saved in the cache, if it is empty then it will request a location
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30) // if the app takes more than 30 seconds to get a location it will go to the catch 
                    });
                }

                if (location == null)
                {
                    await App.Current.MainPage.DisplayAlert("Alert","Could not detect user location","OK"); //Output an error if location can't be found
                }
                else
                {
                    this.Latidue = location.Latitude;
                    this.Longitude = location.Longitude;

                    //assigns max temp, min temp and average percipitiation to location from API
                    Climates climate = new Climates();
                    var temp = await climate.getWebResponse(this.Latidue, this.Longitude);

                    foreach(Double item in temp)
                    {
                        ave.Add(item);
                    }

                    this.avgMaxTemp = ave[0];
                    this.avgMinTemp = ave[1];
                    this.avgPercipitation = ave[2];

                    //assign climate to location
                    ClimateCalc cc = new ClimateCalc();
                    this.ClimateID = cc.assignClimate(this.avgMaxTemp, this.avgMinTemp, this.avgPercipitation);
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Unable to access location services.", "OK"); // This is an error message that will display when the app is having dificulties picking up location services
            }
        }
        #endregion
    }
}
