using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Core.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRPI.FHP.Core
{
   public abstract class DataRepositoryBase<T> : DataRepositoryBase<T,fhpInventoryEntities>
       where T : class, new()
    {

    }
}
