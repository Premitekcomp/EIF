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
    
    public partial class Pre_OfficesMembers
    {
        public short RecordSerial { get; set; }
        public short UserID { get; set; }
        public byte OfficeID { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeletable { get; set; }
        public Nullable<System.DateTime> RCDate { get; set; }
        public Nullable<short> RCBy { get; set; }
        public Nullable<System.DateTime> LADate { get; set; }
        public Nullable<short> LABy { get; set; }
    
        public virtual Pre_Offices Pre_Offices { get; set; }
        public virtual Pre_Users Pre_Users { get; set; }
    }
}
