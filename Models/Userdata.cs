using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Energy_Sell_App1.Models
{
    public class Userdata
    {
        public string EnergyType { get; set; }
        public DateTime Date { get; set; }
        public string Price { get; set; }
        public string Display_Data { get; set; }

        public string DateFormat { get; set; }

        public string Offer_Msg { get; set; }
    }
}
