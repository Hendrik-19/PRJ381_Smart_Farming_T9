using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class WebResponse
    {
        int error;
        webData wData = new webData();

        public WebResponse(int error, webData wData)
        {
            this.error = error;
            this.wData = wData;
        }

        public int Error { get => error; set => error = value; }
        public webData WData { get => wData; set => wData = value; }
    }
}
