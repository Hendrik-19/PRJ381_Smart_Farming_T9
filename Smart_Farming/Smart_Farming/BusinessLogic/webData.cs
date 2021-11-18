using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class webData
    {
        // The Weather, webData and WebResponse classes are used to map the API JSON response to C# variables
        #region webData
        List<Weather> monthly = new List<Weather>();

        public webData(List<Weather> monthly)
        {
            this.monthly = monthly;
        }

        public webData() { }

        public List<Weather> Monthly { get => monthly; set => monthly = value; }
        #endregion
    }
}
