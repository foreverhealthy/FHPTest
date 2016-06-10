using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Core.Contracts;


namespace FRPI.FHP.Core.Business
{
    public class BranchInventorySummaryRepo : DataRepositoryBase<BranchInventorySummary> , IBranchInventorySummary
    {

      
        public IEnumerable<BranchInventorySummary> GetExistingBranchInveSum(int branchid, int productid)
        {
            return this.GetData(x => x.BranchId == branchid && x.ProductId == productid);           
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
