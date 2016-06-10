using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.Enterprise.FHPInventory.Model;
namespace FRPI.FHPInventory.Services.ServiceContracts
{
    public interface IDeliveryLogService 
    {
        List<DeliveryLog> GetDelivery(int id);
        List<DeliveryLog> GetDelivery(string sdate, string edate);

        
    }
}
