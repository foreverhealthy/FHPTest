using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FRPI.FHP.ViewModel;
using FRPI.FHPInventory.Services.Service;
using System.Collections.Generic;

namespace FHP.Unit.Test
{
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void TestMethod1()
        {
            DeliveryLogService service = new DeliveryLogService();
            DeliveryLogVM delivery = new DeliveryLogVM();

            List<DeliveryLogDetailVM> detail = new List<DeliveryLogDetailVM>();

            detail.Add(new DeliveryLogDetailVM
            {
                ProductId = 2,
                Good = 10,
                Bad = 1

            });

            delivery.BatchNo = "dsads";
            delivery.BranchId = 2;
            delivery.ReceivedBy = "Luigie Cute";
            delivery.Remarks = "Edi WOw";
            delivery.DeliverylogDetails = detail;
            service.AddInventory(delivery);
        }
    }
}
