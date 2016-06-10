using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Core.Common.Contracts;

namespace FRPI.FHP.Core.Contracts
{
    public interface IBranchInventorySummary : IDataRepository<BranchInventorySummary>
    {
     
        IEnumerable<BranchInventorySummary> GetExistingBranchInveSum(int branchid, int productid);
    }
}
