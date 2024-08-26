using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EIF.Helper
{
   public class BuckectResultLine
    {
        public int Count { get; set; }
        public string Bucket { get; set; }
        public string Balance { get; set; }
        public string PastDue { get; set; }
    }

   public class CycleResultLine
    {
        public int Count { get; set; }
        public string Cycle { get; set; }
        public string Balance { get; set; }
        public string PastDue { get; set; }
    }
   public class CollectorwithPayment
   {
       public string CollectorCode { get; set; }
       public string CollectorName { get; set; }
       public string Product { get; set; }
       public string Payment { get; set; }
       public int CountOfCustomers { get; set; }
       public int CountOfPayment { get; set; }
       public string DomainType { get; set; }
       public string Balance { get; set; }
       public string PastDue { get; set; }
   }
   public class DomainReoprtbyTeamLeader
   {
       public string TeamLeaderName { get; set; }
       public string Product { get; set; }
       public string Payment { get; set; }
       public int CountOfCustomers { get; set; }
       public int CountOfPayment { get; set; }
       public string DomainType { get; set; }
       public string Balance { get; set; }
       public string PastDue { get; set; }
   }
}