using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    class Testing
    {
        Climates climates = new Climates();
        ClimateCalc climateCalc = new ClimateCalc();
        List<double> testAve = new List<double>();
        double testAveMaxTemp, testAveMinTemp, testAvePercipitaion;
        int testId;

        public void testAlpine() // testing 28.5983, 83.9311
        {
            testAve = climates.getWeatherStats(28.5983, 83.9311); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 1)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testDesert() // testing 23.4162, 25.6628
        {
            testAve = climates.getWeatherStats(23.4162, 25.6628); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 2)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testContinental() // testing 60.0, 105.0
        {
            testAve = climates.getWeatherStats(60.0, 105.0); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 3)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testSubtropical() // testing 28.5306, 30.8958
        {
            testAve = climates.getWeatherStats(28.5306, 30.8958); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 4)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testIceCap() // testing 71.7069, 42.6043
        {
            testAve = climates.getWeatherStats(71.7069, 42.6043); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 5)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testPolar() // testing 90, 135
        {
            testAve = climates.getWeatherStats(90.0, 135.0); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 6)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testSemiArid() // testing 40.6667, 117.6667
        {
            testAve = climates.getWeatherStats(40.6667, 117.6667); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 7)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testTemperate() // testing 36.2048, 138.2529
        {
            testAve = climates.getWeatherStats(36.2048, 138.2529); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 8)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testTropicalMonsoon() // testing 2.3185, 19.5687
        {
            testAve = climates.getWeatherStats(2.3185, 19.5687); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 9)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testTropicalRainforest() // testing 3.4653, 62.2159
        {
            testAve = climates.getWeatherStats(3.4653, 62.2159); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 10)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testTropicalSavanna() // testing 1.8936, 34.6857
        {
            testAve = climates.getWeatherStats(1.8936, 34.6857); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 11)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }

        public void testTundra() // testing 64.9631, 19.0208
        {
            testAve = climates.getWeatherStats(64.9631, 19.0208); // hard coded values to test

            testAveMaxTemp = testAve[0];
            testAveMinTemp = testAve[1];
            testAvePercipitaion = testAve[2];

            testId = climateCalc.assignClimate(testAveMaxTemp, testAveMinTemp, testAvePercipitaion);

            if (testId == 12)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Passed!", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert", "Test Failed!", "OK");
            }
        }
    }
}
