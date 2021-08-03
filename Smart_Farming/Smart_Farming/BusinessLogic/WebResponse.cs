using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class WebResponse
    {
        #region webResponse
        webData wData = new webData();

        public WebResponse(webData wData)
        {
            this.wData = wData;
        }

        public webData WData { get => wData; set => wData = value; }
        #endregion
    }
}
