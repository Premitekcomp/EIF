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
    
    public partial class DomainsWithPaymentPROC_Result
    {
        public long DomainID { get; set; }
        public string DomainTitle { get; set; }
        public string BranchTitle { get; set; }
        public string AgencyTitle { get; set; }
        public string MonthYear { get; set; }
        public Nullable<byte> SchemaID { get; set; }
        public string SchemaName { get; set; }
        public int AgencyID { get; set; }
        public byte BranchID { get; set; }
        public Nullable<bool> ISHIDEN { get; set; }
        public byte StatusID { get; set; }
        public string StatusName { get; set; }
        public Nullable<byte> VersionNumber { get; set; }
        public int MonthID { get; set; }
        public Nullable<decimal> DomainPayment { get; set; }
        public Nullable<int> PaymentCount { get; set; }
    }
}
