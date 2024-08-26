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
    public class CollectorName
    {
        public string Name { get; set; }
    }

    public class BankName
    {
        public string Name { get; set; }
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
        public string AgencyTitle { get; set; }
        public string MonthYear { get; set; }
        public string DomainTitle { get; set; }
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
        public string MonthYear { get; set; }
        public string AgencyTitle { get; set; }
        public byte? GroupId { get; set; }

    }

    public class PaymentReport
    {
        public string Payment { get; set; }
        public string DomainType { get; set; }
        public string Balance { get; set; }
        public string PastDue { get; set; }
        public string MonthYear { get; set; }
        public string AgencyTitle { get; set; }
        public string BranchTitle { get; set; }
        public string DomainTitle { get; set; }
    }

    public class BankReoprtbyTeamLeader
    {
        public string TeamLeaderName { get; set; }
        public string AgencyTitle { get; set; }
        public string MonthYear { get; set; }
        public string BranchName { get; set; }
        public string DomainType { get; set; }
        public int ActiveAccountsNum { get; set; }
        public int WOAcountsNum { get; set; }
        public string WOOs { get; set; }
        public string WOPayment { get; set; }
        public string WOPD { get; set; }
        public string ActiveOs { get; set; }
        public string ActivePayment { get; set; }
        public string ActivePD { get; set; }      
    }

    public class PaymentPerBank
    {
        public string MonthYear { get; set; }
        public string TeamLeaderName { get; set; }
        public string CollectorName { get; set; }
        public string AgencyTitle { get; set; }
        public int ActiveNumberOfAccounts { get; set; }
        public int WONumberOfAccounts { get; set; }
        public string WOOs { get; set; }
        public string WOPayment { get; set; }
        public string WOPD { get; set; }

        public string ActiveOs { get; set; }
        public string ActivePayment { get; set; }
        public string ActivePD { get; set; }
        public string DomainType { get; set; }
    }


    public class LegalPayment
    {
        public string AgencyTitle { get; set; }
        public string BranchName { get; set; }
        public string TeamLeaderName { get; set; }
        public string PaymentAmount { get; set; }
        public string LegalPaymentAmount{ get; set; }
        public string MonthYear { get; set; }
        public string UnLegalPayment { get; set; }
    }


    public class DailyBankReportPerBranch
    {
        public string TeamLeaderName { get; set; }
        public string AgencyTitle { get; set; }
        public string MonthYear { get; set; }
        public string BranchName { get; set; }
        public string DomainType { get; set; }
        public int ActiveAccountsNum { get; set; }
        public int WOAcountsNum { get; set; }
        public string WOOs { get; set; }
        public string WOPayment { get; set; }
        public string WOPD { get; set; }
        public string ActiveOs { get; set; }
        public string ActivePayment { get; set; }
        public string ActivePD { get; set; }
    }

}