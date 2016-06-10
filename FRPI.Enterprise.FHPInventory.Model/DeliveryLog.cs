//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FRPI.Enterprise.FHPInventory.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeliveryLog
    {
        public DeliveryLog()
        {
            this.DeliverylogDetails = new HashSet<DeliverylogDetail>();
            this.RunningInventories = new HashSet<RunningInventory>();
        }
    
        public int Id { get; set; }
        public Nullable<int> SupId { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public string ReceivedBy { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string InputBy { get; set; }
        public string BatchNo { get; set; }
        public Nullable<int> BranchId { get; set; }
        public string Remarks { get; set; }
    
        public virtual ICollection<DeliverylogDetail> DeliverylogDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<RunningInventory> RunningInventories { get; set; }
    }
}