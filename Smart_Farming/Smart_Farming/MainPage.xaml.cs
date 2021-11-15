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
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            BusinessLogic.Location loc = new BusinessLogic.Location();
            loc.GetLocation();

            BusinessLogic.CropSuggestion suggestion = new CropSuggestion();

            List<Crop> crops = new List<Crop>();

            var tempCrops = await suggestion.getCrops(loc);

            foreach (Crop item in crops)
            {
                crops.Add(item);
            }

            //To display the second page with results
            if (crops.Count > 0)
            {
                await Navigation.PushAsync(new Page1(crops));
            }
            else
            {
                await DisplayAlert("Alert", "The application could not suggest any crops for your location", "OK");
            }

}
    }
}
