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
    
    public partial class DomainType
    {
        public DomainType()
        {
            this.Adminpermissions = new HashSet<Adminpermission>();
        }
    
        public int Dmaintypeid { get; set; }
        public string Domaintypename { get; set; }
    
        public virtual ICollection<Adminpermission> Adminpermissions { get; set; }
    }
}
