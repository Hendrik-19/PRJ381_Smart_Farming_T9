using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Smart_Farming.DataAccess; // used to access the database class

namespace Smart_Farming
{
    public partial class App : Application
    {
        static SmartFarmingBD database; // create a static database variable

        //Creating database as singleton
        public static SmartFarmingBD Database // checks for the database in the Special Folder and if it does not exist it will create it and return that connection
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

            MainPage = new NavigationPage(new MainPage()); // enables the application to have multiple pages
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
