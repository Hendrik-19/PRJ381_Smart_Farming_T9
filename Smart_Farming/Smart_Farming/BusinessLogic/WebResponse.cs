using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class WebResponse
    {
        #region webResponse
        Nullable<int> error;
        webData data = new webData();

        public WebResponse(int? error, webData wData)
        {
            this.error = error;
            this.data = wData;
        }

        public int? Error { get => error; set => error = value; }
        public webData Data { get => data; set => data = value; }
        #endregion
    }
}
