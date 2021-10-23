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
            //TODO: create component to handle multiple crops as output and possibly a second page to display output
            BusinessLogic.Location loc = new BusinessLogic.Location();
            loc.GetLocation();

            BusinessLogic.CropSuggestion suggestion = new CropSuggestion();
            
            List<Crop> crops = new List<Crop>();

            crops = suggestion.getCrops(loc); //TODO: do the output stuff

            //To display the second page with results
            await Navigation.PushAsync(new Page1(crops));
        }
    }
}
