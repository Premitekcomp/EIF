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
    
    public partial class Pre_UserStatus
    {
        public int RecordSerial { get; set; }
        public short UserID { get; set; }
        public bool IsOnline { get; set; }
    
        public virtual Pre_Users Pre_Users { get; set; }
    }
}
