//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DCR_Schema
    {
        public DCR_Schema()
        {
            this.DCR_Domain_Data = new HashSet<DCR_Domain_Data>();
            this.DCR_Schema_Details = new HashSet<DCR_Schema_Details>();
            this.DCR_Column_Alias = new HashSet<DCR_Column_Alias>();
        }
    
        public int DCR_Schema_ID { get; set; }
        public string DCR_Schema_Name { get; set; }
        public Nullable<byte> BranchID { get; set; }
        public string BranchName { get; set; }
    
        public virtual ICollection<DCR_Domain_Data> DCR_Domain_Data { get; set; }
        public virtual Lup_BranchList Lup_BranchList { get; set; }
        public virtual ICollection<DCR_Schema_Details> DCR_Schema_Details { get; set; }
        public virtual ICollection<DCR_Column_Alias> DCR_Column_Alias { get; set; }
    }
}
