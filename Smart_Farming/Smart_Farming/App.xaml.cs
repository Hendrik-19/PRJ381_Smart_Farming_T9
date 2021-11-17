using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Smart_Farming.DataAccess;

namespace Smart_Farming
{
    public partial class App : Application
    {
        static SmartFarmingBD database;

        //Creating database as singleton
        public static SmartFarmingBD Database
        {
            get
            {
                if (database == null)
                {
                    database = new SmartFarmingBD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SmartFarmingDB.db3"));
                }
                return database;
            }
        }

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
