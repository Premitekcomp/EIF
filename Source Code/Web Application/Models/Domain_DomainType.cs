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
    
    public partial class Domain_DomainType
    {
        public int ID { get; set; }
        public long DomianID { get; set; }
        public int DomainTypeID { get; set; }
    
        public virtual Type Type { get; set; }
        public virtual Dom_DomainBasic Dom_DomainBasic { get; set; }
    }
}
