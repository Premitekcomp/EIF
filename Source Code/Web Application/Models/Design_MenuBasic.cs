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
    
    public partial class Design_MenuBasic
    {
        public Design_MenuBasic()
        {
            this.Design_MenuItems = new HashSet<Design_MenuItems>();
        }
    
        public short MenuID { get; set; }
        public byte SectionID { get; set; }
        public string DepartKey { get; set; }
        public string MenuTitle { get; set; }
        public string IconClass { get; set; }
        public string DirectURL { get; set; }
        public byte DisplayID { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeletable { get; set; }
        public System.DateTime RCDate { get; set; }
        public Nullable<int> RCBy { get; set; }
        public Nullable<System.DateTime> LADate { get; set; }
        public Nullable<int> LABy { get; set; }
    
        public virtual ICollection<Design_MenuItems> Design_MenuItems { get; set; }
    }
}
