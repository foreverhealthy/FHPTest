using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRPI.Enterprise.FHPInventory.Model;
using FRPI.FHP.Core.Contracts;
namespace FRPI.FHP.Core.Business
{
   public class DeliveryLogsRepo : DataRepositoryBase<DeliveryLog> , IDeliveryLogs
    {


       public List<DeliveryLog> GetDeliveryLog(int id)
       {
           return this.GetData(x => x.Id == id).ToList();
       }


        protected override DeliveryLog AddEntity(fhpInventoryEntities entityContext, DeliveryLog entity)
        {
            return entityContext.DeliveryLogs.Add(entity);
        }

        protected override DeliveryLog UpdateEntity(fhpInventoryEntities entityContext, DeliveryLog entity)
        {
            return (from e in entityContext.DeliveryLogs
                    where e.Id == entity.Id
                    select e).FirstOrDefault();
        }

        protected override IEnumerable<DeliveryLog> GetEntities(fhpInventoryEntities entityContext)
        {
            return from e in entityContext.DeliveryLogs select e;
        }

        protected override DeliveryLog GetEntity(fhpInventoryEntities entityContext, int id)
        {
            var query = (from e in entityContext.DeliveryLogs where e.Id == id select e);

            var result = query.FirstOrDefault();

            return result;
        }

        protected override IEnumerable<DeliveryLog> GetDataEntity(fhpInventoryEntities entityContext, Func<DeliveryLog, bool> predicate)
        {
            return entityContext.DeliveryLogs.Where(predicate).ToList();
        }

      
    }
}
