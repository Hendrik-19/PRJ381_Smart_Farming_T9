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
            await populateLocation();

            await populateCropList();

            await displayNewPage();
        }

        private async Task populateLocation()
        {
            await loc.GetLocation();
        }

        private async Task populateCropList()
        {
            CropSuggestion suggestion = new CropSuggestion();

            var tempCrops = await suggestion.GetCrops(loc);

            foreach (Crop item in tempCrops)
            {
                crops.Add(item);
            }
        }

        private async Task displayNewPage()
        {
            if(crops.Count > 0 && loc.ClimateID != 1)
            {
                await Navigation.PushAsync(new Page1(crops));
            }
            else if (crops.Count == 0 && loc.ClimateID != 0)
            {
                await DisplayAlert("Alert", "The application could not suggest any crops for your location", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Something went wrong...", "OK");
            }
        }
    }
}
