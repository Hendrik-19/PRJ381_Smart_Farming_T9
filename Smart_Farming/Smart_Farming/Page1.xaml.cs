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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        List<Crop> croplist = new List<Crop>();
        int counter = 0;
        public Page1(List<Crop> crops)
        {
            croplist = crops;
            Img = croplist[counter].CropImage;
            lblCName.Text = "Crop name: " + croplist[counter].CropName.ToString();
            lblSTime.Text = "Sow time: " + croplist[counter].SowTime.ToString();
            lblHTime.Text = "Harvest time: " + croplist[counter].HarvestTime.ToString() + "";//add appropriate info
            lblIAmmount.Text = "Irrigation amount needed: " + croplist[counter].IrrigationAmount.ToString() + "";//add appropriate info
            lblPests.Text = "Common pests: " + croplist[counter].Pests.ToString();
        }

        private async void Button_Clicked_Next(object sender, EventArgs e)
        {
            counter++;
            if (counter > croplist.Count)
            {
                counter = 0;
            }

            Img = croplist[counter].CropImage;
            lblCName.Text = "Crop name: " + croplist[counter].CropName.ToString();
            lblSTime.Text = "Sow time: " + croplist[counter].SowTime.ToString();
            lblHTime.Text = "Harvest time: " + croplist[counter].HarvestTime.ToString() + "";//add appropriate info
            lblIAmmount.Text = "Irrigation amount needed: " + croplist[counter].IrrigationAmount.ToString() + "";//add appropriate info
            lblPests.Text = "Common pests: " + croplist[counter].Pests.ToString();
        }

        private async void Button_Clicked_Previous(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = croplist.Count - 1;
            }

            Img = croplist[counter].CropImage;
            lblCName.Text = "Crop name: " + croplist[counter].CropName.ToString();
            lblSTime.Text = "Sow time: " + croplist[counter].SowTime.ToString();
            lblHTime.Text = "Harvest time: " + croplist[counter].HarvestTime.ToString() + "";//add appropriate info
            lblIAmmount.Text = "Irrigation amount needed: " + croplist[counter].IrrigationAmount.ToString() + "";//add appropriate info
            lblPests.Text = "Common pests: " + croplist[counter].Pests.ToString();
        }
    }
}