using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FRPI.FHPInventory.Services.ServiceContracts;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Core.Contracts;
using FRPI.FHP.Core.Business;
using FRPI.FHP.ViewModel;
using FRPI.FHP.Helper.Business;
using FRPI.FHP.Helper.Contracts;

namespace FRPI.FHPInventory.Services.Service
{
    public class DeliveryLogService : IDeliveryLogService
    {
        private IDeliveryLogs _deliverylogrepo;
        private IInventoryHelper _InventoryhelperRepo;
        private IBranchInventorySummary _branchInventorySumRepo;

        private int productRemaining = 0;
        private int newProductStock = 0;
        public DeliveryLogService()
        {
            _deliverylogrepo = new DeliveryLogsRepo();
            _InventoryhelperRepo = new InventoryHelperRepo();
            _branchInventorySumRepo = new BranchInventorySummaryRepo();
        }

        public bool AddInventory(DeliveryLogVM obj)
        {
            bool result = false;
            DeliveryLog delivery = new DeliveryLog();
            List<DeliverylogDetail> details = new List<DeliverylogDetail>();
            List<RunningInventory> runinvee = new List<RunningInventory>();
            List<BranchInventorySummary> branchsummary = new List<BranchInventorySummary>();

            foreach (var a in obj.DeliverylogDetails)
            {
                if (!_InventoryhelperRepo.CheckIfIsExist(obj.BranchId, a.ProductId))
                {
                    details.Add(new DeliverylogDetail
                    {
                        Good = a.Good,
                        Bad = a.Bad,
                        DateExpiry = a.DateExpiry,
                        ProductId = a.ProductId
                    });

                    branchsummary.Add(new BranchInventorySummary
                    {
                        BranchId = obj.BranchId,
                        ProductId = a.ProductId,
                        TotalInventory = a.Good,
                        ProductReleased = 0,
                        TotalIn = a.Good,
                        TotalOut = 0
                    });

                    runinvee.Add(new RunningInventory
                    {
                        ProductId = a.ProductId,
                        Bottles = a.Good
                    });
                }
                else
                {
                    var currentdata = _branchInventorySumRepo.GetExistingBranchInveSum(obj.BranchId, a.ProductId).FirstOrDefault();

                    currentdata.TotalInventory += a.Good;
                    currentdata.TotalIn += a.Good;
                    productRemaining = currentdata.ProductOnHand.Value;
                    newProductStock = currentdata.ProductOnHand.Value + a.Good;

                    var updatebranch = this._branchInventorySumRepo.Update(currentdata);
                    //if(updatebranch.)

                    details.Add(new DeliverylogDetail
                    {
                        Good = a.Good,
                        Bad = a.Bad,
                        //DateExpiry = a.DateExpiry,
                        ProductId = a.ProductId

                    });

                    runinvee.Add(new RunningInventory
                    {

                        ProductId = a.ProductId,
                        Bottles = a.Good

                    });


                }
           
            }


            delivery.BranchId = obj.BranchId;
            delivery.ReceivedBy = obj.ReceivedBy;
            delivery.RunningInventories = runinvee;
            delivery.DeliverylogDetails = details;
            delivery.BatchNo = obj.BatchNo;


           
            var data = this._deliverylogrepo.Add(delivery);
            if (data != null)
                result = true;
            return result;
        }





        public List<Enterprise.FHPInventory.Model.DeliveryLog> GetDelivery(int id)
        {
            throw new NotImplementedException();
        }

        public List<Enterprise.FHPInventory.Model.DeliveryLog> GetDelivery(string sdate, string edate)
        {
            throw new NotImplementedException();
        }
    }
}
