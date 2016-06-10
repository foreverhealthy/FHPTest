using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FRPI.FHP.ViewModel;
using FRPI.FHPInventory.Services.Service;

namespace FRPI.Enterprise.FHPInventory.APIV2.Controllers
{
    public class AddInventoryController : ApiController
    {
        public bool Post(DeliveryLogVM data)
        {
            bool res = false;
            DeliveryLogService service = new DeliveryLogService();
            service.AddInventory(data);

            return res;
        }


    }
}
