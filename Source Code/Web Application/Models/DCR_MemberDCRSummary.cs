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
    
    public partial class DCR_MemberDCRSummary
    {
        public long AccountID { get; set; }
        public int MemberID { get; set; }
        public long DomainID { get; set; }
        public string ActionMaker { get; set; }
        public Nullable<int> CountOfConnections { get; set; }
        public Nullable<int> CountOfAcounts { get; set; }
        public Nullable<int> CountOfPTP { get; set; }
        public Nullable<decimal> SumOFPTPAmount { get; set; }
        public Nullable<int> CountOfPromiseKept { get; set; }
        public Nullable<int> CountOfPromiseBrok { get; set; }
        public Nullable<decimal> SumOFKeptAmount { get; set; }
        public string DomainType { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public Nullable<int> AgencyID { get; set; }
        public Nullable<byte> BranchID { get; set; }
    }
}
