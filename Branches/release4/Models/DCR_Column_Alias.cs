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
    
    public partial class DCR_Column_Alias
    {
        public int AliasID { get; set; }
        public Nullable<long> DimainID { get; set; }
        public string ColumnName { get; set; }
        public string AliasName { get; set; }
        public Nullable<int> SchemaID { get; set; }
    
        public virtual DCR_Schema DCR_Schema { get; set; }
        public virtual Dom_DomainBasic Dom_DomainBasic { get; set; }
    }
}
