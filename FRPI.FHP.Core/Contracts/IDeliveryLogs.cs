using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Core.Common.Contracts;


namespace FRPI.FHP.Core.Contracts
{
    public interface IDeliveryLogs : IDataRepository<DeliveryLog>
    {
        List<DeliveryLog> GetDeliveryLog(int id);

    }
}
