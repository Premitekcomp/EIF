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
    
    public partial class PCR_PCRHistory
    {
        public long PCRID { get; set; }
        public long DomainID { get; set; }
        public int MemberID { get; set; }
        public long AccountID { get; set; }
        public byte ConnectionTypeID { get; set; }
        public byte ConnectionResultID { get; set; }
        public byte PTPTypeID { get; set; }
        public Nullable<System.DateTime> ConnectionDate { get; set; }
        public Nullable<System.DateTime> PTPDate { get; set; }
        public Nullable<decimal> PTPAmount { get; set; }
        public Nullable<bool> IsPromiseKept { get; set; }
        public Nullable<decimal> KeptAmount { get; set; }
        public string EngComment { get; set; }
        public string ArabicComment { get; set; }
        public Nullable<byte> PTPTypeID2 { get; set; }
        public Nullable<System.DateTime> PTPDate2 { get; set; }
        public Nullable<decimal> PTPAmount2 { get; set; }
        public Nullable<byte> PTPTypeID3 { get; set; }
        public Nullable<System.DateTime> PTPDate3 { get; set; }
        public Nullable<decimal> PTPAmount3 { get; set; }
        public Nullable<System.DateTime> KeptDate { get; set; }
        public bool IsPromiseKept2 { get; set; }
        public Nullable<System.DateTime> KeptDate2 { get; set; }
        public Nullable<decimal> KeptAmount2 { get; set; }
        public bool IsPromiseKept3 { get; set; }
        public Nullable<System.DateTime> KeptDate3 { get; set; }
        public Nullable<decimal> KeptAmount3 { get; set; }
        public string CustomerPhone { get; set; }
        public Nullable<byte> Code2ID { get; set; }
        public Nullable<byte> ReachedID { get; set; }
        public Nullable<byte> ReachedCommentsID { get; set; }
        public Nullable<byte> UnReachedCommentsID { get; set; }
    
        public virtual Dom_DomainBasic Dom_DomainBasic { get; set; }
        public virtual Dom_DomainsDataExtra Dom_DomainsDataExtra { get; set; }
        public virtual PCR_ConnectionResult PCR_ConnectionResult { get; set; }
        public virtual PCR_ConnectionType PCR_ConnectionType { get; set; }
        public virtual PCR_PTPType PCR_PTPType { get; set; }
        public virtual Config_MembersList Config_MembersList { get; set; }
    }
}
