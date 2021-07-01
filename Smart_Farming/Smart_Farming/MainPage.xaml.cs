using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials; // api that allows location services
using Smart_Farming.BusinessLogic;

namespace Smart_Farming
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            BusinessLogic.Location loc = new BusinessLogic.Location();

            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync(); // this gets the last location that is saved in the device cache
                if (location == null) // thios checks of a location saved in the cache, if it is empty then it will request a location
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30) // if the app takes more than 30 seconds to get a location it will go to the catch 
                    });
                }

                if (location == null)
                {
                    LabelLocation.Text = "No GPS"; // if the result is still empty it will give a message showing that there is no location
                }
                else
                {
                    LabelLocation.Text = "You have a location"; // need to display info but this will probably be where we load the next page
                    loc.getResults(location.Latitude, location.Longitude);
                }
            }
            catch (Exception)
            {
                //TODO: appropriate error message for something that went wrong
            }
        }
    }
}
