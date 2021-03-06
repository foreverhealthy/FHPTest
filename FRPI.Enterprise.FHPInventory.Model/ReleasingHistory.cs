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
    
    public partial class ReleasingHistory
    {
        public ReleasingHistory()
        {
            this.RunningInventories = new HashSet<RunningInventory>();
        }
    
        public int Id { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> ReleasingActionTypeId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string PromoNo { get; set; }
        public string OrderNo { get; set; }
        public string UserName { get; set; }
    
        public virtual ReleasingActionType ReleasingActionType { get; set; }
        public virtual ICollection<RunningInventory> RunningInventories { get; set; }
    }
}
