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
    
    public partial class BottleType
    {
        public BottleType()
        {
            this.RunningInventories = new HashSet<RunningInventory>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<RunningInventory> RunningInventories { get; set; }
    }
}