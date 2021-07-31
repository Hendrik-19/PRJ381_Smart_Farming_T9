using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class WebResponse
    {
        string error;
        List<Weather> monthly = new List<Weather>();

        public string Error { get => error; set => error = value; }
        public List<Weather> Monthly { get => monthly; set => monthly = value; }
    }
}
