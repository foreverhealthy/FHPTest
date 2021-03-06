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
    
    public partial class RunningInventory
    {
        public RunningInventory()
        {
            this.BatchNoes = new HashSet<BatchNo>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Bottles { get; set; }
        public Nullable<int> PreviousQty { get; set; }
        public int NewQty { get; set; }
        public Nullable<int> ActionType { get; set; }
        public Nullable<int> BottleTypeId { get; set; }
        public Nullable<int> ReleasingHistoryId { get; set; }
        public Nullable<int> DeliveryReceiptId { get; set; }
        public Nullable<int> ProdReqId { get; set; }
        public Nullable<int> InitialAdditionalId { get; set; }
        public Nullable<int> BranchSummaryId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<int> ReplenishmentId { get; set; }
        public Nullable<int> TransferHistoryId { get; set; }
        public Nullable<int> DeliveryLogsId { get; set; }
        public Nullable<int> BranchId { get; set; }
    
        public virtual ICollection<BatchNo> BatchNoes { get; set; }
        public virtual BottleType BottleType { get; set; }
        public virtual BranchInventorySummary BranchInventorySummary { get; set; }
        public virtual DeliveryLog DeliveryLog { get; set; }
        public virtual DeliveryReceipt DeliveryReceipt { get; set; }
        public virtual InitialAdditionalHistory InitialAdditionalHistory { get; set; }
        public virtual ProdRequest ProdRequest { get; set; }
        public virtual ReleasingHistory ReleasingHistory { get; set; }
        public virtual ReplenishmentHistory ReplenishmentHistory { get; set; }
        public virtual TransferHistory TransferHistory { get; set; }
    }
}
