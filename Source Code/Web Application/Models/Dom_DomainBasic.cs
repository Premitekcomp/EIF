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
    
    public partial class Dom_DomainBasic
    {
        public Dom_DomainBasic()
        {
            this.DCR_Column_Alias = new HashSet<DCR_Column_Alias>();
            this.DCR_Domain_Data = new HashSet<DCR_Domain_Data>();
            this.Dom_DomainColumnsAlias = new HashSet<Dom_DomainColumnsAlias>();
            this.Dom_DomainsDataExtra = new HashSet<Dom_DomainsDataExtra>();
            this.Domain_DomainType = new HashSet<Domain_DomainType>();
            this.Domain_Product = new HashSet<Domain_Product>();
            this.Domain_Region = new HashSet<Domain_Region>();
            this.PCR_PCRHistory = new HashSet<PCR_PCRHistory>();
        }
    
        public long DomainID { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public int AgencyID { get; set; }
        public int MonthID { get; set; }
        public byte BranchID { get; set; }
        public string DomainTitle { get; set; }
        public string DomainType { get; set; }
        public Nullable<bool> SuccessDomain { get; set; }
        public Nullable<bool> ISHIDEN { get; set; }
        public Nullable<int> SchemaId { get; set; }
        public string SchemaName { get; set; }
        public Nullable<int> VersionNumber { get; set; }
    
        public virtual Config_AgencyList Config_AgencyList { get; set; }
        public virtual ICollection<DCR_Column_Alias> DCR_Column_Alias { get; set; }
        public virtual ICollection<DCR_Domain_Data> DCR_Domain_Data { get; set; }
        public virtual Dom_DomainBasic Dom_DomainBasic1 { get; set; }
        public virtual Dom_DomainBasic Dom_DomainBasic2 { get; set; }
        public virtual Dom_DomainStatus Dom_DomainStatus { get; set; }
        public virtual Lup_BranchList Lup_BranchList { get; set; }
        public virtual Lup_MonthYear Lup_MonthYear { get; set; }
        public virtual ICollection<Dom_DomainColumnsAlias> Dom_DomainColumnsAlias { get; set; }
        public virtual ICollection<Dom_DomainsDataExtra> Dom_DomainsDataExtra { get; set; }
        public virtual ICollection<Domain_DomainType> Domain_DomainType { get; set; }
        public virtual ICollection<Domain_Product> Domain_Product { get; set; }
        public virtual ICollection<Domain_Region> Domain_Region { get; set; }
        public virtual ICollection<PCR_PCRHistory> PCR_PCRHistory { get; set; }
    }
}
