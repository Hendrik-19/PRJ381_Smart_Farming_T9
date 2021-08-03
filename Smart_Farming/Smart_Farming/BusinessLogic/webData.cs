using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class webData
    {
        #region webData
        List<Weather> monthly = new List<Weather>();

        public webData(List<Weather> monthly)
        {
            this.monthly = monthly;
        }

        public webData() { }

        public List<Weather> Monthly { get => monthly; set => monthly = value; }
    }
    #endregion
}
