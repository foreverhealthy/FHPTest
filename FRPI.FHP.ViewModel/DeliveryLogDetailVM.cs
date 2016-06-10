using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRPI.FHP.ViewModel
{
    public class DeliveryLogDetailVM
    {
        public int ProductId { get; set; }
        public int Good { get; set; }
        public int Bad { get; set; }
        public int Lost { get; set; }
        public DateTime DateExpiry { get; set; }

    }
}
