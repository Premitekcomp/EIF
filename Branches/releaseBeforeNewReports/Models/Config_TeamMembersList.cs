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
    
    public partial class Config_TeamMembersList
    {
        public int TeamID { get; set; }
        public byte BranchID { get; set; }
        public int AgencyID { get; set; }
        public string TeamName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int MemberID { get; set; }
        public string MemberName { get; set; }
    }
}
