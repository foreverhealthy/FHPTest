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
    
    public partial class TransferRemark
    {
        public int Id { get; set; }
        public string RemarksBy { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> ProdRequestId { get; set; }
        public Nullable<int> PRStatusId { get; set; }
    
        public virtual ProdRequest ProdRequest { get; set; }
        public virtual PRStatu PRStatu { get; set; }
    }
}