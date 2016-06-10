using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.FHP.Core;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Helper.Contracts;

namespace FRPI.FHP.Helper.Business
{
    public class InventoryHelperRepo : DataRepositoryBase<BranchInventorySummary>, IInventoryHelper
    {
        public bool CheckIfIsExist(int branchid, int productId)
        {
            bool IsExist = false;

         var a = this.GetData(x => x.BranchId == branchid && x.ProductId == productId);

         if (a.Count() > 0)
             IsExist = true;
            return IsExist;
        }




        protected override BranchInventorySummary AddEntity(fhpInventoryEntities entityContext, BranchInventorySummary entity)
        {
            return entityContext.BranchInventorySummaries.Add(entity);
        }

        protected override BranchInventorySummary UpdateEntity(fhpInventoryEntities entityContext, BranchInventorySummary entity)
        {
            return (from e in entityContext.BranchInventorySummaries
                    where e.Id == entity.Id
                    select e).FirstOrDefault();
        }

        protected override IEnumerable<BranchInventorySummary> GetEntities(fhpInventoryEntities entityContext)
        {
            return from e in entityContext.BranchInventorySummaries select e;
        }

        protected override BranchInventorySummary GetEntity(fhpInventoryEntities entityContext, int id)
        {
            var query = (from e in entityContext.BranchInventorySummaries where e.Id == id select e);
            var result = query.FirstOrDefault();
            return result;
        }

        protected override IEnumerable<BranchInventorySummary> GetDataEntity(fhpInventoryEntities entityContext, Func<BranchInventorySummary, bool> predicate)
        {
            return entityContext.BranchInventorySummaries.Where(predicate).ToList();
        }
    }
}
