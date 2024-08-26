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
    
    public partial class Lup_BranchList
    {
        public Lup_BranchList()
        {
            this.Config_TeamList = new HashSet<Config_TeamList>();
            this.Dom_DomainBasic = new HashSet<Dom_DomainBasic>();
            this.Pre_BranchesPermissions = new HashSet<Pre_BranchesPermissions>();
            this.Sch_Schemas = new HashSet<Sch_Schemas>();
            this.DCR_Schema = new HashSet<DCR_Schema>();
        }
    
        public byte BranchID { get; set; }
        public string BranchTitle { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeletable { get; set; }
        public Nullable<System.DateTime> RCDate { get; set; }
        public Nullable<short> RCBy { get; set; }
        public Nullable<System.DateTime> LADate { get; set; }
        public Nullable<short> LABy { get; set; }
    
        public virtual ICollection<Config_TeamList> Config_TeamList { get; set; }
        public virtual ICollection<Dom_DomainBasic> Dom_DomainBasic { get; set; }
        public virtual ICollection<Pre_BranchesPermissions> Pre_BranchesPermissions { get; set; }
        public virtual ICollection<Sch_Schemas> Sch_Schemas { get; set; }
        public virtual ICollection<DCR_Schema> DCR_Schema { get; set; }
    }
}
