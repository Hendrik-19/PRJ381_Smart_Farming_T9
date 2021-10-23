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

        List<Crop> crops = new List<Crop>();
        int counter = 0;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            BusinessLogic.Location loc = new BusinessLogic.Location();
            loc.GetLocation();

            BusinessLogic.CropSuggestion suggestion = new CropSuggestion();

            crops = suggestion.getCrops(loc);

            //To display the results
            if (crops.Count > 0)
            {
                //Img = croplist[counter].CropImage;//Seems to be causing an error
                lblCName.Text = "Crop name: " + crops[0].CropName.ToString();
                lblSTime.Text = "Sow time: " + crops[0].SowTime.ToString();
                lblHTime.Text = "Harvest time: " + crops[0].HarvestTime.ToString() + "";//add appropriate info
                lblIAmmount.Text = "Irrigation amount needed: " + crops[0].IrrigationAmount.ToString() + "";//add appropriate info
                lblPests.Text = "Common pests: " + crops[0].Pests.ToString();

            }
            else
            {
                await DisplayAlert("Alert", "The application could not suggest any crops for your location", "OK");
            }

        }

        private async void Button_Clicked_Next(object sender, EventArgs e)
        {
            if (crops.Count > 0) //if the crop list has multiple crop selections, allows the user to loop through the suggestions
            {
                counter++;
                if (counter > crops.Count)
                {
                    counter = 0;
                }

                //Img = croplist[counter].CropImage;//Seems to be causing an error
                lblCName.Text = "Crop name: " + crops[counter].CropName.ToString();
                lblSTime.Text = "Sow time: " + crops[counter].SowTime.ToString();
                lblHTime.Text = "Harvest time: " + crops[counter].HarvestTime.ToString() + "";//add appropriate info
                lblIAmmount.Text = "Irrigation amount needed: " + crops[counter].IrrigationAmount.ToString() + "";//add appropriate info
                lblPests.Text = "Common pests: " + crops[counter].Pests.ToString();
            }
            else//shows a message to user that only one crop suggestion could be found for their location
            {
                await DisplayAlert("Alert", "There are no additional crop suggestions", "OK");
            }

        }

        private async void Button_Clicked_Previous(object sender, EventArgs e)
        {
            if (crops.Count > 0) //if the crop list has multiple crop selections, allows the user to loop through the suggestions
            {
                counter--;
                if (counter < 0)
                {
                    counter = crops.Count - 1;
                }

                //Img = croplist[counter].CropImage;//Seems to be causing an error
                lblCName.Text = "Crop name: " + crops[counter].CropName.ToString();
                lblSTime.Text = "Sow time: " + crops[counter].SowTime.ToString();
                lblHTime.Text = "Harvest time: " + crops[counter].HarvestTime.ToString() + "";//add appropriate info
                lblIAmmount.Text = "Irrigation amount needed: " + crops[counter].IrrigationAmount.ToString() + "";//add appropriate info
                lblPests.Text = "Common pests: " + crops[counter].Pests.ToString();
            }
            else//shows a message to user that only one crop suggestion could be found for their location
            {
                await DisplayAlert("Alert", "There are no additional crop suggestions", "OK");
            }

        }

    }
}
