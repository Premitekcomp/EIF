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
    
    public partial class Design_MenuItems
    {
        public short MenuItemID { get; set; }
        public short MenuID { get; set; }
        public Nullable<byte> SectionID { get; set; }
        public string MenuItemName { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string IconClass { get; set; }
        public byte DisplayID { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeletable { get; set; }
        public System.DateTime RCDate { get; set; }
        public Nullable<int> RCBy { get; set; }
        public Nullable<System.DateTime> LADate { get; set; }
        public Nullable<int> LABy { get; set; }
    
        public virtual Design_MenuBasic Design_MenuBasic { get; set; }
    }
}
