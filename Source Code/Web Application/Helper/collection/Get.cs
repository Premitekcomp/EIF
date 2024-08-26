using EIF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EIF.Helper.collection
{
    public class Get
    {
        CollectionEntities _enty = new CollectionEntities();
        public SelectList AllBrunchList(int? id, int? Choosen, string myinfo ="" , bool showmyinfoonly = false)
        {
            var list = new List<Lup_BranchList>();
            if(showmyinfoonly == false)
                list = _enty.Lup_BranchList.Select(q => q).ToList();
            else
            {
                if (myinfo != "")
                {
                    var branchids = myinfo.Split(',').ToList().ConvertAll(Convert.ToByte);
                    list = _enty.Lup_BranchList.Where(a=> branchids.Contains(a.BranchID)).Select(q => q).ToList();
                }
            }
            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }

        }
        public SelectList SchemaList(int? id, int? Choosen)
        {
            var list = new List<Sch_Schemas>();
            list = _enty.Sch_Schemas.Select(q => q).ToList();


            if (id!=null)
            {
                if (Choosen != null)
                {
                    return new SelectList((list.Where(q=>q.BranchID==id).Select(q => q)).ToList(), "SchemaID", "SchemaName", Choosen);
                }
                else
                {
                    return new SelectList((list.Where(q => q.BranchID == id).Select(q => q)).ToList(), "SchemaID", "SchemaName");
                }
            }
            else
            {
                if (Choosen != null)
                {
                    return new SelectList((list.Select(q => q)).ToList(), "SchemaID", "SchemaName", Choosen);
                }
                else
                {
                    return new SelectList((list.Select(q => q)).ToList(), "SchemaID", "SchemaName");
                }
            }

        }
        public SelectList AgencyList(int? id, int? Choosen , string myinfo ="" , bool showmyinfoonly = false)
        {
            var list = new List<Config_AgencyList>();
            if(showmyinfoonly == false)
                list = _enty.Config_AgencyList.Select(q => q).ToList();
            else
            {
                if(myinfo != "")
                {
                    var BankIds = myinfo.Split(',').ToList().ConvertAll(int.Parse);
                    list = _enty.Config_AgencyList.Where(a=> BankIds.Contains(a.AgencyID)).Select(q => q).ToList();
                }
            }


            if (Choosen != null)
            {
                return new SelectList((list.Where(q => q.IsActive == true).Select(q => q)).ToList(), "AgencyID", "AgencyTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Where(q=>q.IsActive==true).Select(q => q)).ToList(), "AgencyID", "AgencyTitle");
            }

        }
        public SelectList MonthList(int? id, int? Choosen)
        {
            var list = new List<Lup_MonthYear>();
            list = _enty.Lup_MonthYear.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "MonthID", "MonthYear", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "MonthID", "MonthYear");
            }

        }
        public SelectList DomainType(string Choosen)
        {
            var list = new List<Lup_TeamRole>();
            list = _enty.Lup_TeamRole.Select(q => q).ToList();

            if (Choosen != null)
            {
                return new SelectList(new Dictionary<string, string> { { "Active Domain", "Active Domain"}, { "W/O Domain", "W/O Domain" }, 
            }, "Key", "Value", Choosen);
            }
            else
            {
                return new SelectList(new Dictionary<string, string> { { "Active Domain", "Active Domain"}, { "W/O Domain", "W/O Domain" }, 
            }, "Key", "Value");
            }

        }

        public SelectList DomainType2(string Choosen)
        {
            if (Choosen != null)
            {
                return new SelectList(new Dictionary<string, string> { { "Active Domain", "Active Domain"}, { "W/O Domain", "W/O Domain" }, { "Both", "Both" },
            }, "Key", "Value", Choosen);
            }
            else
            {
                return new SelectList(new Dictionary<string, string> { { "Active Domain", "Active Domain"}, { "W/O Domain", "W/O Domain" }, { "Both", "Both" },
            }, "Key", "Value");
            }

        }
        public SelectList DomainTypeFromDataBase(int? Choosen , string myinfo="" , bool showmyinfoonly = false)
        {
            var list = new List<EIF.Models.Type>();
            if(showmyinfoonly == false)
                list = _enty.Types.Select(q => q).ToList();
            else
            {
                if (myinfo != "")
                {
                    var DomianLst = myinfo.Split(',').ToList().ConvertAll(int.Parse);
                    list = _enty.Types.Where(a=> DomianLst.Contains(a.DomainId)).Select(q => q).ToList();
                }
            }
            list.Insert(0, new Models.Type { DomainId = 0, DomainName = "All" });
            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "DomainName", "DomainName", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "DomainName", "DomainName");
            }

        }
        public MultiSelectList DomainTypes(int BankId)
        {
            var list = new List<EIF.Models.Type>();
            var TypeIds = _enty.UserDataScopes.Where(a => a.BankID == BankId).Select(s => s.TypeID).ToList();
            if (TypeIds.Contains(-1))
            {
                // user has scope to see all Domain Types 
                list = _enty.Types.Select(q => q).ToList();
            }
            else
            {
                list = _enty.Types.Where(a=>TypeIds.Contains(a.DomainId)).Select(q => q).ToList();
            }
            if (list.Count() > 0)
                list.Insert(0, new EIF.Models.Type { DomainId = -1, DomainName = "All Domains" });
            return new MultiSelectList((list.Select(q => q)).ToList(), "DomainId", "DomainName");

        }
        public MultiSelectList Region(int BankId,int? userid = null)
        {
            var list = new List<Region>();
            var RegionIds = _enty.UserDataScopes.Where(a => a.BankID == BankId && userid !=null? a.UserId == userid:true).Select(s => s.RegionID).ToList();         
            List<int> RegIds = new List<int>();
            foreach (var item in RegionIds)
            {
                var RID = item.Split(',').ToList().ConvertAll(int.Parse);
                if (RID.Contains(0))
                {
                    // this section for all regions 
                    list = _enty.Regions.Select(q => q).ToList();
                    break;
                }
                else
                {
                    RegIds.AddRange(RID);
                }  
            }
            if (RegIds.Count() > 0)
            {
                list = _enty.Regions.Where(a=>RegIds.Contains(a.RegionId)).Select(q => q).ToList();
            }
            //list.Insert(0, new Region { RegionId = 0, RegionName = "All Regions" });

            return new MultiSelectList((list.Select(q => q)).ToList(), "RegionId", "RegionName");
        }
        public MultiSelectList ProductLst(int BankId)
        {
            var list = new List<Product>();
            var productIds = _enty.UserDataScopes.Where(a => a.BankID == BankId).Select(s => s.ProductID).ToList();
            if(productIds.Contains(-1))
            {
                // user has scope to see all products 
                list = _enty.Products.Select(q => q).ToList();
            }
            else
            {
                list = _enty.Products.Where(a=>productIds.Contains(a.ProductId)).Select(q => q).ToList();
            }
            if (list.Count() > 0)
                list.Insert(0, new Product { ProductId = -1, ProductName = "All Products" });
            return new MultiSelectList((list.Select(q => q)).ToList(), "ProductId", "ProductName");

        }
        public SelectList MasterDomainFilter()
        {
            return new SelectList(new Dictionary<string, string> {{ "Col1", "Account Number" }
                , { "Col2", "Account ID" }, { "Col3", "Name"},            
            }, "Key", "Value");
        }
        public SelectList AliasList(long id)
        {
            var list = new List<Dom_DomainColumnsAlias>();
            list = _enty.Dom_DomainColumnsAlias.Select(q => q).ToList();
            return new SelectList((list.Where(q => q.DomainID == id).Select(q => q)).ToList()
                                    , "ColumnName", "AliasName");
        }


        public SelectList DomianList(int? Choosen , string userid , bool myinfo = false)
        {
            var list = new List<DomainsPerUserScope>();
            //list = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
            EIF.Controllers.collectionController colle = new Controllers.collectionController();
            list = colle.CheckSheetDataScope(myinfo, userid);
            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "DomainID", "DomainTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "DomainID", "DomainTitle");
            }

        }
        public SelectList ConnectionResultList(int? Choosen)
        {
            var list = new List<PCR_ConnectionResult>();
            list = _enty.PCR_ConnectionResult.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ConnectionResultID", "ConnectionResultTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ConnectionResultID", "ConnectionResultTitle");
            }

        }
        public SelectList Code2List(int? Choosen)
        {
            var list = new List<PCR_Code2>();
            list = _enty.PCR_Code2.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "Code2ID", "Code2Title", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "Code2ID", "Code2Title");
            }

        }
        public SelectList ConnectionTypeList(int? Choosen)
        {
            var list = new List<PCR_ConnectionType>();
            list = _enty.PCR_ConnectionType.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ConnectionTypeID", "ConnectionTypeTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ConnectionTypeID", "ConnectionTypeTitle");
            }

        }
        public SelectList PTPTypeList(int? Choosen)
        {
            var list = new List<PCR_PTPType>();
            list = _enty.PCR_PTPType.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "PTPTypeID", "PTPTypeTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "PTPTypeID", "PTPTypeTitle");
            }

        }
        public SelectList CommentsList(int? Choosen)
        {
            var list = new List<Lup_Comments>();
            list = _enty.Lup_Comments.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "CommentID", "Comment", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "CommentID", "Comment");
            }

        }
        public SelectList MembersList(int? Choosen, Int64 AccountID)
        {
            //var list = new List<Config_MembersList>();
            //list = _enty.Config_MembersList.Select(q => q).ToList();

            Dom_DomainDetailsList accountDetails = _enty.Dom_DomainDetailsList.Where(q => q.RecordSerial == AccountID).FirstOrDefault();

            var AssignedMembers = _enty.Config_TeamMembersList.Where(q => q.BranchID == accountDetails.BranchID && q.AgencyID == accountDetails.AgencyID && q.IsActive != null && (bool)q.IsActive).Select(x => new { x.MemberID, x.MemberName }).Distinct().ToList();


            if (Choosen != null)
            {
                return new SelectList((AssignedMembers.Select(q => q)).ToList(), "MemberID", "MemberName", Choosen);
            }
            else
            {
                return new SelectList((AssignedMembers.Select(q => q)).ToList(), "MemberID", "MemberName");
            }

        }
        public SelectList AssignMembersList()
        {
            var list = new List<Config_TeamMembersRoleList>();
            list = _enty.Config_TeamMembersRoleList.Select(q => q).OrderBy(q=>q.RoleID).ToList();
            return new SelectList((list.Select(q => q)).ToList(), "MemberID", "MemberRole");
        }
        public SelectList EliasColList(IEnumerable<Dom_DomainColumnsAlias> elias)
            {
                return new SelectList((elias.Select(q => q)).ToList(), "ColumnName", "AliasName");
            }

        public SelectList ReachedList(int? Choosen)
        {
            var list = new List<PCR_Reached>();
            list = _enty.PCR_Reached.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ID", "Description", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ID", "Description");
            }

        }

        public SelectList ReachedCommentsList(int? Choosen)
        {
            var list = new List<PCR_ReachedComments>();
            list = _enty.PCR_ReachedComments.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ID", "Description", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ID", "Description");
            }

        }

        public SelectList UnReachedCommentsList(int? Choosen)
        {
            var list = new List<PCR_UnReachedComments>();
            list = _enty.PCR_UnReachedComments.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ID", "Description", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ID", "Description");
            }

        }


        #region Schema
        public SelectList SchemaBranchesList(int? id , string myinfo ="" , bool showmyinfoonly = false )
        {
            var list = new List<Lup_BranchList>();
            if( showmyinfoonly == false)
                list = _enty.Lup_BranchList.Where(q => q.IsDeleted == false).Select(q => q).ToList();
            else
            {
                if (myinfo != "")
                {
                    var BranshLst = myinfo.Split(',').ToList().ConvertAll(Convert.ToByte);
                    list = _enty.Lup_BranchList.Where(q => BranshLst.Contains(q.BranchID) && q.IsDeleted == false).Select(q => q).ToList();
                }
            }
           


            if (id != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle", id);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }

        }
        public SelectList ColumnsList(int? id)
        {
            var list = new List<Sch_Columns>();
            list = _enty.Sch_Columns.Select(q => q).ToList();


            if (id != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "CoID", "ColumnName", id);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "CoID", "ColumnName");
            }

        }        
        public SelectList ColumnIndex(int? Choosen)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();

            for (int i = 1; i < 100; i++)
            {
                list.Add(i.ToString(), i.ToString());
            }

            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "Key", "Value", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "Key", "Value");
            }

        }
        #endregion
        public SelectList DCRSchemalist(int? id, int? Choosen)
        {
            var list = new List<DCR_Schema>();
            list = _enty.DCR_Schema.Select(q => q).ToList();


            if (id != null)
            {
                if (Choosen != null)
                {
                    return new SelectList((list.Where(q => q.BranchID == id).Select(q => q)).ToList(), "DCR_Schema_ID", "DCR_Schema_Name", Choosen);
                }
                else
                {
                    return new SelectList((list.Where(q => q.BranchID == id).Select(q => q)).ToList(), "DCR_Schema_ID", "DCR_Schema_Name");
                }
            }
            else
            {
                if (Choosen != null)
                {
                    return new SelectList((list.Select(q => q)).ToList(), "DCR_Schema_ID", "DCR_Schema_Name", Choosen);
                }
                else
                {
                    return new SelectList((list.Select(q => q)).ToList(), "DCR_Schema_ID", "DCR_Schema_Name");
                }
            }

        }
        public SelectList DCRColumnsList(int? id)
        {
            var list = new List<DCR_Schema_ColumnsList>();
            list = _enty.DCR_Schema_ColumnsList.OrderBy(o=>o.ColumnName).Select(q => q).ToList();


            if (id != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ColumnID", "ColumnName", id);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ColumnID", "ColumnName");
            }

        }    

    }
}