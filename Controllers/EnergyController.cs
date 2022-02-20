using Energy_Sell_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace Energy_Sell_App1.Controllers
{
    public class EnergyController : ApiController
    {
        [HttpPost]
        public Userdata Submit(Userdata userdata)
        {

            userdata.DateFormat = userdata.Date.ToString("yyyy/MM/dd");
            if ((userdata.Date.DayOfWeek == DayOfWeek.Saturday) || (userdata.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                userdata.Offer_Msg = "10% discount";
            }
            else
                userdata.Offer_Msg = "";
            if (userdata.Display_Data == null)
                userdata.Display_Data = "";
            return userdata;
          
        }


    }
}
