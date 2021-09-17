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

        private async void Button_Clicked(object sender, EventArgs e)//TODO: move stuff
        {
            BusinessLogic.Location loc = new BusinessLogic.Location();
            //TODO: create component to handle multiple crops as output

            loc.GetLocation();
        }
    }
}
