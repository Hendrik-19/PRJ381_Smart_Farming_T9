using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Smart_Farming.BusinessLogic;

namespace Smart_Farming
{
    public partial class MainPage : ContentPage
    {
        BusinessLogic.Location loc = new BusinessLogic.Location();
        
        List<Crop> crops = new List<Crop>();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await populateLocationObj();

            await PopulateCropList();

            await DisplayNewPage();
        }

        private async Task populateLocationObj()
        {
            await loc.GetLocation();
        }

        private async Task PopulateCropList()
        {
            CropSuggestion suggestion = new CropSuggestion();

            var tempCrops = await suggestion.getCrops(loc);

            foreach (Crop item in tempCrops)
            {
                crops.Add(item);
            }
        }

        private async Task DisplayNewPage()
        {
            //To display the second page with results
            if (crops.Count > 0 && loc.ClimateID != 0)//Opens second page with a list of crop suggestions
            {
                await Navigation.PushAsync(new Page1(crops));
            }
            else if (crops.Count == 0 && loc.ClimateID != 0)//Displays an error if a climate was assigned to a location, but no crops were assigned to the climate
            {
                await DisplayAlert("Alert", "The application could not suggest any crops for your location", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Unkown error occured", "OK");
            }
        }
    }
}
