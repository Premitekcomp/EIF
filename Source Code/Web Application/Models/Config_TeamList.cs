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
    
    public partial class Config_TeamList
    {
        public Config_TeamList()
        {
            this.Dom_AssignDomainToMembers = new HashSet<Dom_AssignDomainToMembers>();
        }
    
        public int TeamID { get; set; }
        public byte BranchID { get; set; }
        public int AgencyID { get; set; }
        public string TeamName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Config_AgencyList Config_AgencyList { get; set; }
        public virtual Lup_BranchList Lup_BranchList { get; set; }
        public virtual ICollection<Dom_AssignDomainToMembers> Dom_AssignDomainToMembers { get; set; }
    }
}
