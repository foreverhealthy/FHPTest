using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.FHP.Core;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Helper.Contracts;
using FRPI.FHP.Core.Common.Contracts;

namespace FRPI.FHP.Helper.Contracts
{
    public interface IInventoryHelper 
    {
       bool CheckIfIsExist(int branchid, int productId);

    }
}
