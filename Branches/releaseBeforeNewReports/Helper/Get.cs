using EIF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EIF.Helper
{
    public class Get
    {
        UserAccountEntities _enty = new UserAccountEntities();
        public SelectList SectionList(int? id,int? Choosen)
        {
            var list = new List<Pre_Section>();
            if (id==0)
            {
                list = _enty.Pre_Section.Select(q => q).ToList();
            }
            else
            {
                var Allsections = _enty.Pre_Section.Select(s => s).ToList();
                var portalId = _enty.Adminpermissions.Where(a => a.domaintypeid == 1 && a.domaindataid == id).Select(s => s.portalaccessids).FirstOrDefault();
                var portalLst = portalId != null ? portalId.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
                list = Allsections.Where(a => portalLst.Contains(a.SectionID)).Select(s => s).ToList();
                //list = _enty.Pre_SectionsList.Where(q => q.UserID == id).Select(q => q).ToList();
            }

            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "SectionID", "SectionName",Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "SectionID", "SectionName");
            }

        }
        public MultiSelectList SectionsList(int? id, string[] Choosen)
        {
            var list = new List<Pre_Section>();
            list = _enty.Pre_Section.Select(q => q).ToList();


            if (Choosen != null)
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "SectionID", "SectionName", Choosen);
            }
            else
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "SectionID", "SectionName");
            }

        }
        public SelectList BrunchList(int? id, int? Choosen)
        {
            var list = new List<Lup_BranchList>();
            if(id ==0)
            {
                list = _enty.Lup_BranchList.Select(q => q).ToList();
            }
            else
            {
                string BranchIDs = _enty.Pre_Users.Where(a => a.UserID == id).Select(s => s.BranchIDs).FirstOrDefault();
                if (!string.IsNullOrEmpty(BranchIDs))
                {
                    var BranchLst = BranchIDs.Split(',').ToList().ConvertAll(int.Parse);
                    list = _enty.Lup_BranchList.Where(a => BranchLst.Contains(a.BranchID)).Select(q => q).ToList();
                }
                //else
                //{
                //    list = _enty.Lup_BranchList.Select(q => q).ToList();
                //}               
            }            
            //var list = new List<Pre_BrunchesList>();
            //if (id == 0)
            //{
            //    list = _enty.Pre_BrunchesList.Select(q => q).ToList();
            //}
            //else
            //{
            //    list = _enty.Pre_BrunchesList.Where(q => q.UserID == id).Select(q => q).ToList();
            //}

            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }

        }
        public SelectList AllBrunchList(int? id, int? Choosen)
        {
            var list = new List<Lup_BranchList>();
            list = _enty.Lup_BranchList.Select(q => q).ToList();

            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }

        }
        public MultiSelectList AllBrunchListMuti(int? id, string Choosen)
        {
            var list = new List<Lup_BranchList>();
            list = _enty.Lup_BranchList.Select(q => q).ToList();
           // var Value = !string.IsNullOrEmpty(Choosen) ? Choosen.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
            if (Choosen != null)
            {
                return new MultiSelectList(list.Select(s => s), "BranchID", "BranchTitle", Choosen);
            }
            else
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "BranchID", "BranchTitle");
            }

        }
        public SelectList AgencyList(int? id, string Choosen)
        {
            var list = new List<Config_AgencyList>();
            list = _enty.Config_AgencyList.Select(q => q).ToList();

            //var Value = !string.IsNullOrEmpty(Choosen) ? Choosen.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
            if (Choosen != null)
            {
                return new SelectList((list.Where(q => q.IsActive == true).Select(q => q)).ToList(), "AgencyID", "AgencyTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Where(q => q.IsActive == true).Select(q => q)).ToList(), "AgencyID", "AgencyTitle");
            }

        }
        public SelectList ProductLst(int? id, string Choosen)
        {
            var list = new List<Product>();
            list = _enty.Products.Select(q => q).ToList();
            list.Insert(0 , new Product{ProductId = -1 , ProductName="All Products"});
            //var Value = !string.IsNullOrEmpty(Choosen) ? Choosen.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "ProductId", "ProductName", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "ProductId", "ProductName");
            }

        }
        public MultiSelectList Region(string Choosen)
        {
            var list = new List<Region>();
            list = _enty.Regions.Select(q => q).ToList();
            list.Insert(0, new Region { RegionId = 0, RegionName = "All Regions" });
            //var Value = !string.IsNullOrEmpty(Choosen) ? Choosen.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
            if (Choosen != null)
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "RegionId", "RegionName", Choosen);
            }
            else
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "RegionId", "RegionName");
            }

        }
        public MultiSelectList City(string Choosen)
        {
            var list = new List<City>();
            list = _enty.Cities.Select(q => q).ToList();
            list.Insert(0, new City { CityId = 0, CityName = "All Cities" });
            //var Value = !string.IsNullOrEmpty(Choosen) ? Choosen.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
            if (Choosen != null)
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "CityId", "CityName", Choosen);
            }
            else
            {
                return new MultiSelectList((list.Select(q => q)).ToList(), "CityId", "CityName");
            }

        }
        public SelectList DomainType(string Choosen)
        {
            var list = new List<EIF.Models.Type>();
            list = _enty.Types.Select(q => q).ToList();
            list.Insert(0, new Models.Type { DomainId = -1, DomainName = "All Domains" });
            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "DomainId", "DomainName", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "DomainId", "DomainName");
            }

        }
        public SelectList GroupsList(int? id, int? Choosen)
        {
            var list = new List<Pre_Groups>();
            if (id == 0)
            {
                list = _enty.Pre_Groups.Where(q => q.IsDeleted == false && q.IsActive == true).Select(q => q).ToList();
            }
            else
            {
                list = _enty.Pre_Groups.Where(q => q.IsDeleted == false && q.IsActive == true).Select(q => q).ToList();
            }

            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "GroupID", "GroupTitle", Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "GroupID", "GroupTitle");
            }

        }
        public SelectList UsersList(int? Choosen)
        {
            var list = new List<Pre_Users>();

             list = _enty.Pre_Users.Where(q => q.IsDeleted == false).Select(q => q).ToList();

            if (Choosen != null)
            {
                return new SelectList((list.Select(q => q)).ToList(), "UserID", "UserName",Choosen);
            }
            else
            {
                return new SelectList((list.Select(q => q)).ToList(), "UserID", "UserName");
            }

        }
    }
}