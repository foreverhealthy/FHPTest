using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRPI.FHP.ViewModel
{
  public class DeliveryLogVM
    {
        public DateTime DateReceived { get; set; }
        public string ReceivedBy { get; set; }
        public int BranchId { get; set; }
        public DateTime InputDate { get; set; }
        public string InputBy { get; set; }
        public string BatchNo { get; set; }
        public string Remarks { get; set; }
        public List<DeliveryLogDetailVM> DeliverylogDetails { get; set; }
    }
}
