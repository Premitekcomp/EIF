using EIF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EIF.Helper.admin
{
    public class Get
    {
        AdminEntities _enty = new AdminEntities();

        public MultiSelectList BranchesList(int? id)
        {
            var list = new List<Lup_BranchList>();
            list = _enty.Lup_BranchList.Where(q=>q.IsDeleted==false).Select(q => q).ToList();


            if (id != null)
            {
                byte[] Choosen = _enty.Config_AgencyBranches.Where(q => q.AgencyID==id).Select(q => q.BranchID).ToArray();
                return new MultiSelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle", Choosen);
            }
            else
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }

        }

        public SelectList TeamBranchesList(int? id)
        {
            var list = new List<Lup_BranchList>();
            list = _enty.Lup_BranchList.Where(q => q.IsDeleted == false).Select(q => q).ToList();


            if (id != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle", id);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }
            
        }
        public SelectList TeamAgencyList(int? id,int? BrID)
        {
            var list = new List<Config_AgencyList>();
            list = _enty.Config_AgencyList.Where(q=>q.IsActive==true).Select(q => q).ToList();


            if (id != null)
            {
                if (id == 0)
                {
                    return new SelectList((list.Where(q => q.AgencyID == id).Select(q => q)).ToList(), "AgencyID", "AgencyTitle");
                }
                else
                {
                    List<int> Ag = _enty.Config_AgencyBranchList.Where(q => q.BranchID == BrID).Select(q => q.AgencyID).ToList();
                    return new SelectList((list.Where(q=>Ag.Contains(q.AgencyID)).Select(q => q)).ToList(), "AgencyID", "AgencyTitle", id);

                }
            }
             
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "AgencyID", "AgencyTitle");
            }

        }
        public SelectList RoleList(int? id, int? ChooseBy)
        {
            var list = new List<Lup_TeamRole>();
            list = _enty.Lup_TeamRole.Select(q => q).ToList();

            if (ChooseBy != null)
            {
                int Choosen = _enty.Config_TeamMembers.Where(q => q.MemberID == ChooseBy).Select(q => q.RoleID).FirstOrDefault();
                return new SelectList((list.Select(q => q)).ToList(), "RoleID", "RoleName", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "RoleID", "RoleName");
            }

        }
        public SelectList ColumnTypeList(string Choosen)
        {
            var list = new List<Lup_TeamRole>();
            list = _enty.Lup_TeamRole.Select(q => q).ToList();

            if (Choosen != null)
            {
                return new SelectList(new Dictionary<string, string> { { "Text", "Text"}, { "Number", "Number" }, { "Other", "Other" },
            }, "Key", "Value", Choosen);
            }
            else
            {
               return new SelectList(new Dictionary<string, string> { { "Text", "Text"}, { "Number", "Number" }, { "Other", "Other" },
            }, "Key", "Value");
            }

        }
      
      
    }
}