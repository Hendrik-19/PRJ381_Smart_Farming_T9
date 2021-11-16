using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Smart_Farming.DataAccess;

namespace Smart_Farming
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
