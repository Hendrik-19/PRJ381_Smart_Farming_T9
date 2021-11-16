using Smart_Farming.BusinessLogic; // to be able to use the crop class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Smart_Farming
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage //Todo: Fix object does not have an object reference error
    {
        public Page1()
        {
            InitializeComponent();
        }
        int counter = 0;
        List<Crop> croplist = new List<Crop>();
        
        public Page1(List<Crop> crops)
        {
            InitializeComponent();
            PopulatePage(crops);
        }

        public void PopulatePage(List<Crop> crops)
        {
            foreach (Crop item in crops)
            {
                croplist.Add(item);
            }

            Img.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile(croplist[0].CropImage) : ImageSource.FromFile(croplist[0].CropImage); //Todo: Fix image
            lblCName.Text = $"Crop name: {croplist[0].CropName.ToString()}";
            lblSTime.Text = "Sow time: " + croplist[0].SowTime.ToString();
            lblHTime.Text = "Harvest time: " + croplist[0].HarvestTime.ToString() + "";//add appropriate info
            lblIAmmount.Text = "Irrigation amount needed: " + croplist[0].IrrigationAmount.ToString() + "";//add appropriate info
            lblPests.Text = "Common pests: " + croplist[0].Pests.ToString();
        }

        private async void Button_Clicked_Next(object sender, EventArgs e)
        {
            if (croplist.Count > 0 && croplist.Count != 1) //if the crop list has multiple crop selections, allows the user to loop through the suggestions
            {
                counter++;
                if (counter > croplist.Count)
                {
                    counter = 0;
                }

                Img.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile(croplist[counter].CropImage) : ImageSource.FromFile(croplist[counter].CropImage);
                lblCName.Text = "Crop name: " + croplist[counter].CropName.ToString();
                lblSTime.Text = "Sow time: " + croplist[counter].SowTime.ToString();
                lblHTime.Text = "Harvest time: " + croplist[counter].HarvestTime.ToString() + "";//add appropriate info
                lblIAmmount.Text = "Irrigation amount needed: " + croplist[counter].IrrigationAmount.ToString() + "";//add appropriate info
                lblPests.Text = "Common pests: " + croplist[counter].Pests.ToString();
            }
            else//shows a message to user that only one crop suggestion could be found for their location
            {
                await DisplayAlert("Alert", "There are no additional crop suggestions", "OK");
            }

        }

        private async void Button_Clicked_Previous(object sender, EventArgs e)
        {
            if (croplist.Count > 0 && croplist.Count != 1) //if the crop list has multiple crop selections, allows the user to loop through the suggestions
            {
                counter--;
                if (counter < 0)
                {
                    counter = croplist.Count - 1;
                }

                Img.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile(croplist[counter].CropImage) : ImageSource.FromFile(croplist[counter].CropImage);
                lblCName.Text = "Crop name: " + croplist[counter].CropName.ToString();
                lblSTime.Text = "Sow time: " + croplist[counter].SowTime.ToString();
                lblHTime.Text = "Harvest time: " + croplist[counter].HarvestTime.ToString() + "";//add appropriate info
                lblIAmmount.Text = "Irrigation amount needed: " + croplist[counter].IrrigationAmount.ToString() + "";//add appropriate info
                lblPests.Text = "Common pests: " + croplist[counter].Pests.ToString();
            }
            else//shows a message to user that only one crop suggestion could be found for their location
            {
                await DisplayAlert("Alert", "There are no additional crop suggestions", "OK");
            }

        }
    }
}