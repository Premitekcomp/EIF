using EIF.Helper;
using EIF.Models;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Validation;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using EIF.Models;
using EIF.Helper;
using System.Data;
using System.IO;
using System.Text;
namespace EIF.Controllers
{
    public class collectionController : Controller
    {
        CollectionEntities _enty = new CollectionEntities();
        string url = EIF.PublicConfig.URL;

        //
        // GET: /collection/
        public ActionResult Index()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    return View();

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        #region Dshboard
        public ActionResult Dashboard()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Dashboard", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        if (myinformationonly == true)
                        {
                            int userid = int.Parse(Session["ID"].ToString());
                            var user = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s).FirstOrDefault();
                            List<int?> BanksScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s.BankID).ToList();
                            string BankIDs = BanksScope.Count() > 0 ? string.Join(",", BanksScope) : "";
                            ViewBag.myinfo = myinformationonly; ViewBag.BranchIDs = user.BranchIDs; ViewBag.BankIDs = BankIDs;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ContentResult ContactCount(int AgencyID, int BranchID)
        {
            var ContactCount = _enty.Chrt_ContactsSP(AgencyID, BranchID).ToList();

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(ContactCount), "application/json");

        }
        public ContentResult FinanceSum(int AgencyID, int BranchID)
        {
            var ContactCount = _enty.Chrt_PD_PTP_KeptAmmountSP(AgencyID, BranchID).ToList();

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(ContactCount), "application/json");

        }
        #endregion

        #region Domain List
        public ActionResult DomainsList()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Domain List", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        if (AccessRights.Contains("All") || AccessRights.Contains("Add"))
                            ViewBag.AccessRightAdd = true;
                        if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                            ViewBag.AccessRightEdit = true;
                        if (AccessRights.Contains("All") || AccessRights.Contains("Delete"))
                            ViewBag.AccessRightDelete = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult DomainsDetails(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Domain List", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == id).Select(q => q).ToList();

                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                            ViewBag.DomainName = data.FirstOrDefault().DomainTitle;
                            ViewBag.SchemaName = data.FirstOrDefault().SchemaName;
                            ViewBag.VersionNumber = data.FirstOrDefault().VersionNumber;
                            byte VersionNumber = Convert.ToByte(ViewBag.VersionNumber);
                            int userid = int.Parse(Session["id"].ToString());
                            var USerScope = _enty.UserDataScopes.Where(a => a.UserId == userid).ToList();
                            List<Dictionary<string, object>> model = new List<Dictionary<string, object>>();
                            var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == id && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                            ViewBag.alias = alias;
                            var BankIDforDomain = _enty.Dom_DomainList.Where(a => a.DomainID == id).Select(s => s.AgencyID).FirstOrDefault();
                            if (myinformationonly == true)
                            {
                                foreach (var scopeitem in USerScope)
                                {
                                    if (scopeitem.BankID == BankIDforDomain)
                                    {
                                        int ProductID = (int)scopeitem.ProductID;
                                        int TypeID = (int)scopeitem.TypeID;
                                        string RegionIDs = scopeitem.RegionID;
                                        string CityIDs = scopeitem.CityID;
                                        string product = ""; string Type = ""; string Regions = ""; string Cities = "";
                                        GetUserScopeNmaes(ProductID, TypeID, RegionIDs, CityIDs, ref product, ref Type, ref Regions, ref Cities);
                                        using (var cmd = _enty.Database.Connection.CreateCommand())
                                        {
                                            _enty.Database.Connection.Open();
                                            cmd.CommandType = CommandType.StoredProcedure;

                                            cmd.CommandText = "Dom_GetDynamicColumn";

                                            string List = "";
                                            for (int i = 1; i <= alias.Count; i++)
                                            {
                                                List = List + "," + i;
                                            }
                                            cmd.Parameters.Add(new SqlParameter("@List", List));
                                            cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                                            cmd.Parameters.Add(new SqlParameter("@product", product));
                                            cmd.Parameters.Add(new SqlParameter("@domainttype", Type));
                                            cmd.Parameters.Add(new SqlParameter("@regions", Regions));
                                            cmd.Parameters.Add(new SqlParameter("@cities", Cities));
                                            cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinformationonly));
                                            using (var reader = cmd.ExecuteReader())
                                            {
                                                model.AddRange(Read(reader).ToList());
                                            }
                                        }
                                        _enty.Database.Connection.Close();
                                    }

                                }
                            }
                            else
                            {
                                using (var cmd = _enty.Database.Connection.CreateCommand())
                                {
                                    _enty.Database.Connection.Open();
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.CommandText = "Dom_GetDynamicColumn";

                                    string List = "";
                                    for (int i = 1; i <= alias.Count; i++)
                                    {
                                        List = List + "," + i;
                                    }
                                    cmd.Parameters.Add(new SqlParameter("@List", List));
                                    cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                                    cmd.Parameters.Add(new SqlParameter("@product", ""));
                                    cmd.Parameters.Add(new SqlParameter("@domainttype", ""));
                                    cmd.Parameters.Add(new SqlParameter("@regions", ""));
                                    cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinformationonly));
                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        model = Read(reader).ToList();
                                    }
                                }
                                _enty.Database.Connection.Close();
                            }
                            model = model.Distinct().Select(s => s).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.Tbl = model;
                            }
                        }
                        ViewBag.DomainID = id;
                        return View();

                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult CloseDomain(int id)
        {
            var rec = _enty.Dom_DomainBasic.Find(id);
            if (rec != null)
            {
                rec.StatusID = 50;
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                int res = _enty.SaveChanges();
                if (res > 0)
                {
                    ViewBag.saved = "Domain Closed";
                    string msg = "Domain : " + rec.DomainTitle + " is Closed ";
                    InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                }
            }
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Domain List", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            var data = CheckSheetDataScope(myinformationonly);
            if (data.Count > 0)
            {
                ViewBag.data = data;
            }
            return PartialView("_CollectionDomainList");

        }
        public ActionResult OpenDomain(int id)
        {
            var rec = _enty.Dom_DomainBasic.Find(id);
            if (rec != null)
            {
                rec.StatusID = 40;
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                int res = _enty.SaveChanges();
                if (res > 0)
                {
                    ViewBag.saved = "Domain Opened";
                    string msg = "Domain : " + rec.DomainTitle + " is opened ";
                    InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                }
            }
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Domain List", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            var data = CheckSheetDataScope(myinformationonly);
            if (data.Count > 0)
            {
                ViewBag.data = data;
            }
            return PartialView("_CollectionDomainList");

        }

        public ActionResult ExportDomain(long DomainID)
        {
            string sw = "";
            if (DomainID > 0)
            {

                var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).FirstOrDefault();
                byte SchemaID = data.SchemaID;
                List<int?> schema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).ToList();
                byte? VersionNumber = data.VersionNumber;
                string DomainTitle = data.DomainTitle;
                var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == DomainID && q.VersionNumber == VersionNumber).Select(q => q).ToList();

                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "Dom_GetDomainDynamicColumnForExport";

                    string List = "";
                    for (int i = 1; i <= alias.Count; i++)
                    {
                        List = List + "," + i;
                    }

                    cmd.Parameters.Add(new SqlParameter("@List", List));
                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                    cmd.Parameters.Add(new SqlParameter("@VersionNumber", VersionNumber));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            sw = ExportToExcel(model, DomainTitle + "(" + VersionNumber + ")");
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return Content(sw.ToString(), "application/ms-excel");
        }

        public ActionResult DeleteDomain(long id)
        {

            //int res = _enty.Dom_DomainDelete(id);

            //if (res > 0)
            //{
            //    ViewBag.saved = "Domain Deleted";
            //}
            //else
            //{
            //    ViewBag.saved = "Domain Can not be Deleted";
            //}
            var dom = _enty.Dom_DomainBasic.Where(a => a.DomainID == id).Select(s => s).FirstOrDefault();
            dom.ISHIDEN = true;
            _enty.Entry(dom).State = System.Data.Entity.EntityState.Modified;
            _enty.SaveChanges();
            ViewBag.saved = "Domain Deleted";
            string msg = "Domain : " + dom.DomainTitle + " is deleted ";
            InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Domain List", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            var data = CheckSheetDataScope(myinformationonly);
            if (data.Count > 0)
            {
                ViewBag.data = data;
            }
            return PartialView("_CollectionDomainList");

        }

        public ActionResult AccountDCR(long id, string DomainName)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    var PCRHistory = _enty.PCR_PCRHistoryList.Where(q => q.AccountID == id && q.DomainTitle == DomainName).Select(q => q).ToList();
                    if (PCRHistory.Count() > 0)
                    {
                        ViewBag.PCRHistory = PCRHistory;
                    }
                    ViewBag.AccountID = id;
                    return View();

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult AccountVersionsHistory(long id, string DomainName)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    long DomainID = _enty.Dom_DomainDetailsList.Where(q => q.DomainTitle == DomainName).Select(q => q.DomainID).FirstOrDefault();
                    byte? VersionNumber = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q.VersionNumber).FirstOrDefault();
                    var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == DomainID && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                    ViewBag.alias = alias;

                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "Dom_DomainDetailsAllVersionsListBy";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            List = List + "," + i;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@RecordSerial", id));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.PCRHistory = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    return View();

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }


        #endregion

        #region Domain Assign
        public ActionResult BankDomainAssign()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Bank Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult InternalDomainAssign()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Internal Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult BankDomainAssignMembers(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Bank Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        _BankDomainAssignMembers(id, (bool)myinformationonly);

                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        private void _BankDomainAssignMembers(long id, bool myinfo)
        {
            ViewBag.DomainID = id;
            var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == id).Select(q => q).ToList();

            if (data.Count > 0)
            {
                ViewBag.data = data;
                ViewBag.DomainName = data.FirstOrDefault().DomainTitle;
                ViewBag.SchemaName = data.FirstOrDefault().SchemaName;
                ViewBag.VersionNumber = data.FirstOrDefault().VersionNumber;
                byte VersionNumber = Convert.ToByte(ViewBag.VersionNumber);

                var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == id && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                ViewBag.alias = alias;
                int userid = int.Parse(Session["id"].ToString());
                var USerScope = _enty.UserDataScopes.Where(a => a.UserId == userid).ToList();
                List<Dictionary<string, object>> model = new List<Dictionary<string, object>>();
                var BankIDforDomain = _enty.Dom_DomainList.Where(a => a.DomainID == id).Select(s => s.AgencyID).FirstOrDefault();
                if (myinfo == true)
                {
                    foreach (var scopeitem in USerScope)
                    {
                        if (scopeitem.BankID == BankIDforDomain)
                        {
                            int ProductID = (int)scopeitem.ProductID;
                            int TypeID = (int)scopeitem.TypeID;
                            var RegionIDs = scopeitem.RegionID;
                            string CityIDs = scopeitem.CityID;
                            string product = ""; string Type = ""; string Regions = ""; string Cities = "";
                            GetUserScopeNmaes(ProductID, TypeID, RegionIDs, CityIDs, ref product, ref Type, ref Regions, ref Cities);
                            using (var cmd = _enty.Database.Connection.CreateCommand())
                            {
                                _enty.Database.Connection.Open();
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.CommandText = "Dom_GetDynamicColumnClearFilter";

                                string List = "";
                                for (int i = 1; i <= alias.Count; i++)
                                {
                                    List = List + "," + i;
                                }
                                cmd.Parameters.Add(new SqlParameter("@List", List));
                                cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                                cmd.Parameters.Add(new SqlParameter("@Type", true));
                                cmd.Parameters.Add(new SqlParameter("@product", product));
                                cmd.Parameters.Add(new SqlParameter("@domainttype", Type));
                                cmd.Parameters.Add(new SqlParameter("@regions", Regions));
                                cmd.Parameters.Add(new SqlParameter("@cities", Cities));
                                cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinfo));
                                using (var reader = cmd.ExecuteReader())
                                {
                                    model.AddRange(Read(reader).ToList());
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                    }
                }
                else
                {
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "Dom_GetDynamicColumnClearFilter";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            List = List + "," + i;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                        cmd.Parameters.Add(new SqlParameter("@Type", true));
                        cmd.Parameters.Add(new SqlParameter("@product", ""));
                        cmd.Parameters.Add(new SqlParameter("@domainttype", ""));
                        cmd.Parameters.Add(new SqlParameter("@regions", ""));
                        cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinfo));
                        using (var reader = cmd.ExecuteReader())
                        {
                            model = Read(reader).ToList();
                        }
                    }
                    _enty.Database.Connection.Close();
                }
                model = model.Distinct().Select(s => s).ToList();
                if (model.Count() > 0)
                {
                    ViewBag.Tbl = model;
                }
            }
        }
        public ActionResult InternalDomainAssignMembers(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Internal Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        _InternalDomainAssignMembers(id, (bool)myinformationonly);
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        private void _InternalDomainAssignMembers(long id, bool myinfo)
        {
            ViewBag.DomainID = id;
            var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == id).Select(q => q).ToList();

            if (data.Count > 0)
            {
                ViewBag.data = data;
                ViewBag.DomainName = data.FirstOrDefault().DomainTitle;
                ViewBag.SchemaName = data.FirstOrDefault().SchemaName;
                ViewBag.VersionNumber = data.FirstOrDefault().VersionNumber;
                byte VersionNumber = Convert.ToByte(ViewBag.VersionNumber);

                var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == id && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                ViewBag.alias = alias;
                int userid = int.Parse(Session["id"].ToString());
                var USerScope = _enty.UserDataScopes.Where(a => a.UserId == userid).ToList();
                List<Dictionary<string, object>> model = new List<Dictionary<string, object>>();
                var BankIDforDomain = _enty.Dom_DomainList.Where(a => a.DomainID == id).Select(s => s.AgencyID).FirstOrDefault();
                if (myinfo == true)
                {
                    foreach (var scopeitem in USerScope)
                    {
                        if (scopeitem.BankID == BankIDforDomain)
                        {
                            int ProductID = (int)scopeitem.ProductID;
                            int TypeID = (int)scopeitem.TypeID;
                            var RegionIDs = scopeitem.RegionID;
                            string CityIDs = scopeitem.CityID;
                            string product = ""; string Type = ""; string Regions = ""; string Cities = "";
                            GetUserScopeNmaes(ProductID, TypeID, RegionIDs, CityIDs, ref product, ref Type, ref Regions, ref Cities);
                            using (var cmd = _enty.Database.Connection.CreateCommand())
                            {
                                _enty.Database.Connection.Open();
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.CommandText = "Dom_GetDynamicColumnClearFilter";

                                string List = "";
                                for (int i = 1; i <= alias.Count; i++)
                                {
                                    List = List + "," + i;
                                }
                                cmd.Parameters.Add(new SqlParameter("@List", List));
                                cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                                cmd.Parameters.Add(new SqlParameter("@Type", true));
                                cmd.Parameters.Add(new SqlParameter("@product", product));
                                cmd.Parameters.Add(new SqlParameter("@domainttype", Type));
                                cmd.Parameters.Add(new SqlParameter("@regions", Regions));
                                cmd.Parameters.Add(new SqlParameter("@cities", Cities));
                                cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinfo));
                                using (var reader = cmd.ExecuteReader())
                                {
                                    model.AddRange(Read(reader).ToList());
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                    }
                }
                else
                {
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "Dom_GetDynamicColumnClearFilter";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            List = List + "," + i;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                        cmd.Parameters.Add(new SqlParameter("@Type", true));
                        cmd.Parameters.Add(new SqlParameter("@product", ""));
                        cmd.Parameters.Add(new SqlParameter("@domainttype", ""));
                        cmd.Parameters.Add(new SqlParameter("@regions", ""));
                        cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinfo));
                        using (var reader = cmd.ExecuteReader())
                        {
                            model = Read(reader).ToList();
                        }
                    }
                    _enty.Database.Connection.Close();
                }
                model = model.Distinct().Select(s => s).ToList();
                if (model.Count() > 0)
                {
                    ViewBag.Tbl = model;
                }
            }
        }
        public ActionResult GetMembers(long id, byte VersionNumber, string ColList, string ColValList, bool type)
        {
            List<string> Col;
            List<string> ColVal;
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Col = jss.Deserialize<List<string>>(ColList);
            ColVal = jss.Deserialize<List<string>>(ColValList);

            string Col_List = "";
            foreach (string c in Col)
            {
                Col_List += c + ",";
            }
            string ColVal_List = "";
            foreach (string c in ColVal)
            {
                ColVal_List += c + ",";
            }
            #region Get Data
            ViewBag.DomainID = id;
            var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == id).Select(q => q).ToList();

            if (data.Count > 0)
            {
                var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == id && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                ViewBag.alias = alias;

                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "Dom_GetDynamicColumnByFilter";

                    string List = "";
                    for (int i = 1; i <= alias.Count; i++)
                    {
                        List = List + "," + i;
                    }
                    if (Col_List.Length == 1)
                    {
                        Col_List = Col_List.Substring(1, Col_List.Length - 1);
                    }
                    if (ColVal_List.Length == 1)
                    {
                        ColVal_List.Substring(1, ColVal_List.Length - 1);
                    }
                    cmd.Parameters.Add(new SqlParameter("@List", List));
                    cmd.Parameters.Add(new SqlParameter("@Col", Col_List));
                    cmd.Parameters.Add(new SqlParameter("@ColVal", ColVal_List));
                    cmd.Parameters.Add(new SqlParameter("@DomainID", id));
                    cmd.Parameters.Add(new SqlParameter("@Type", type));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.Tbl = model;
                        }
                    }
                }
                _enty.Database.Connection.Close();
            }
            #endregion
            return PartialView("_CollectionDomainAssignMembers");

        }
        public ActionResult BankAssignMembers(int MemberId, string ins, long Domain)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Bank Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions)
            {
                #region insert
                //insert
                if (ins != "" && ins != "on")
                {
                    ins = ins.Replace("on,", "");
                    ins = ins.Replace(",on", "");

                    var Insert = ins.Split(',');
                    short RoleID = _enty.Config_TeamMembersRoleList.Where(q => q.MemberID == MemberId).Select(q => q.RoleID).FirstOrDefault();
                    int TeamID = _enty.Config_TeamMembersRoleList.Where(q => q.MemberID == MemberId).Select(q => q.TeamID).FirstOrDefault();

                    foreach (string s in Insert.ToArray())
                    {

                        var ToIns = _enty.Dom_AssignDomainToMembersInsert(Convert.ToInt16(s), MemberId, RoleID, TeamID, true);
                    }
                }
                #endregion
                #region Delete
                ////Delete
                //if (del != "" && del != "on")
                //{
                //    del = del.Replace("on,", "");
                //    del = del.Replace(",on", "");

                //    var Delete = del.Split(',');


                //    foreach (string s in Delete.ToArray())
                //    {

                //        var ToDel = _enty.Dom_AssignDomainToMembersDelete(Convert.ToInt16(s), MemberId);
                //    }
                //}

                #endregion
                _BankDomainAssignMembers(Domain, (bool)myinformationonly);

                ViewBag.saved = "Data saved successfully";
                return PartialView("_CollectionDomainAssignMembers");
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult InternalAssignMembers(int MemberId, string ins, long Domain)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Internal Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions)
            {
                #region insert
                //insert
                if (ins != "" && ins != "on")
                {
                    ins = ins.Replace("on,", "");
                    ins = ins.Replace(",on", "");

                    var Insert = ins.Split(',');
                    short RoleID = _enty.Config_TeamMembersRoleList.Where(q => q.MemberID == MemberId).Select(q => q.RoleID).FirstOrDefault();
                    int TeamID = _enty.Config_TeamMembersRoleList.Where(q => q.MemberID == MemberId).Select(q => q.TeamID).FirstOrDefault();

                    foreach (string s in Insert.ToArray())
                    {

                        var ToIns = _enty.Dom_AssignDomainToMembersInsert(Convert.ToInt16(s), MemberId, RoleID, TeamID, false);
                    }
                }
                #endregion
                #region Delete
                ////Delete
                //if (del != "" && del != "on")
                //{
                //    del = del.Replace("on,", "");
                //    del = del.Replace(",on", "");

                //    var Delete = del.Split(',');


                //    foreach (string s in Delete.ToArray())
                //    {

                //        var ToDel = _enty.Dom_AssignDomainToMembersDelete(Convert.ToInt16(s), MemberId);
                //    }
                //}

                #endregion
                _InternalDomainAssignMembers(Domain, (bool)myinformationonly);
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }
            //_InternalDomainAssignMembers(Domain);

            ViewBag.saved = "Data saved successfully";
            return PartialView("_CollectionDomainAssignMembers");
        }
        public ActionResult UnassignInternalAssignMembers(int MemberId, string del, long Domain)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Internal Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions)
            {
                #region Delete
                //Delete
                if (del != "" && del != "on")
                {
                    del = del.Replace("on,", "");
                    del = del.Replace(",on", "");

                    var Delete = del.Split(',');


                    foreach (string s in Delete.ToArray())
                    {

                        var ToDel = _enty.Dom_AssignDomainToMembersDelete(Convert.ToInt16(s), MemberId);
                    }
                }

                #endregion
                _InternalDomainAssignMembers(Domain, (bool)myinformationonly);
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }
            // _InternalDomainAssignMembers(Domain);

            ViewBag.saved = "Data saved successfully";
            return PartialView("_CollectionDomainAssignMembers");
        }

        public ActionResult UnassignBankAssignMembers(int MemberId, string del, long Domain)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("Bank Domain Assign", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions)
            {
                #region Delete
                //Delete
                if (del != "" && del != "on")
                {
                    del = del.Replace("on,", "");
                    del = del.Replace(",on", "");

                    var Delete = del.Split(',');


                    foreach (string s in Delete.ToArray())
                    {

                        var ToDel = _enty.Dom_AssignDomainToMembersDelete(Convert.ToInt16(s), MemberId);
                    }
                }

                #endregion
                _BankDomainAssignMembers(Domain, (bool)myinformationonly);

                ViewBag.saved = "Data saved successfully";
                return PartialView("_CollectionDomainAssignMembers");
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }


        }
        public ActionResult DownloadBankAssigned(long DomainID)
        {
            string sw = "";

            if (DomainID > 0)
            {

                var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).FirstOrDefault();
                byte SchemaID = data.SchemaID;
                List<int?> schema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).ToList();
                byte? VersionNumber = data.VersionNumber;
                string DomainTitle = data.DomainTitle;

                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "Dom_GetDomainAssignDynamicColumnForExport";

                    string List = "";
                    foreach (int I in schema)
                    {
                        List = List + "," + I;
                    }

                    cmd.Parameters.Add(new SqlParameter("@List", List));
                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                    cmd.Parameters.Add(new SqlParameter("@VersionNumber", VersionNumber));
                    cmd.Parameters.Add(new SqlParameter("@Type", true));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            sw = ExportToExcel(model, DomainTitle + "(" + VersionNumber + ")");
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return Content(sw.ToString(), "application/ms-excel");
        }
        public ActionResult DownloadInternalAssigned(long DomainID)
        {
            string sw = "";

            if (DomainID > 0)
            {

                var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).FirstOrDefault();
                byte SchemaID = data.SchemaID;
                List<int?> schema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).ToList();
                byte? VersionNumber = data.VersionNumber;
                string DomainTitle = data.DomainTitle;

                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "Dom_GetDomainAssignDynamicColumnForExport";

                    string List = "";
                    foreach (int I in schema)
                    {
                        List = List + "," + I;
                    }

                    cmd.Parameters.Add(new SqlParameter("@List", List));
                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                    cmd.Parameters.Add(new SqlParameter("@VersionNumber", VersionNumber));
                    cmd.Parameters.Add(new SqlParameter("@Type", false));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            sw = ExportToExcel(model, DomainTitle + "(" + VersionNumber + ")");
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return Content(sw.ToString(), "application/ms-excel");
        }
        #endregion

        #region Master Domain
        public ActionResult MasterDomain()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Master Domain", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult GetMasterDomain(FormCollection frm)
        {
            if (frm["FilterKey"].Length > 0)
            {


                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "Dom_MasterDomainSP";

                    cmd.Parameters.Add(new SqlParameter("@ColName", frm["FilterKey"]));
                    cmd.Parameters.Add(new SqlParameter("@ColVal", frm["FilterVal"]));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.Tbl = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }

            }

            return PartialView("_CollectionMasterDomain");

        }
        #endregion

        #region Schema
        public ActionResult SchemaManagement()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    //Team Data
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Schema Management", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        List<Sch_Schemas> Data = new List<Models.Sch_Schemas>();
                        if (myinformationonly == false)
                            Data = _enty.Sch_Schemas.Select(q => q).ToList();
                        else
                        {
                            int userid = int.Parse(Session["ID"].ToString());
                            string BranchIDs = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s.BranchIDs).FirstOrDefault();
                            if (!string.IsNullOrEmpty(BranchIDs))
                            {
                                var BranchLst = BranchIDs.Split(',').ToList().ConvertAll(Convert.ToByte);
                                Data = _enty.Sch_Schemas.Where(a => BranchLst.Contains((byte)a.BranchID)).Select(q => q).ToList();
                            }
                            ViewBag.BranchIDs = BranchIDs; ViewBag.myinfo = myinformationonly;
                        }
                        if (Data != null)
                        {
                            ViewBag.Data = Data;
                        }
                        if (AccessRights.Contains("Add") || AccessRights.Contains("All"))
                            TempData["AccessRightAdd"] = true;
                        if (AccessRights.Contains("Edit") || AccessRights.Contains("All"))
                            TempData["AccessRightEdit"] = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult NewSchema(string Name, byte BranchID)
        {
            if (Convert.ToString(BranchID).Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Sch_Schemas.Where(q => q.SchemaName == Name).Select(q => q.SchemaName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    int res = _enty.Sch_SchemaInsert(Name, BranchID);
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                        string msg = "Domain Schema : " + Name + " is Saved ";
                        InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                    }

                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Schema Name";
                }
                if (Convert.ToString(BranchID).Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Branch";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Branch";
                    }

                }

            }
            var data = _enty.Sch_Schemas.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            //save new agency
            return PartialView("_CollectionSchemaList");
        }
        public ActionResult EditSchema(byte id, string Name, byte BranchID)
        {
            if (Convert.ToString(BranchID).Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Sch_Schemas.Where(q => q.SchemaName == Name && q.SchemaID != id).Select(q => q.SchemaName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    var rec = _enty.Sch_Schemas.Find(id);
                    rec.BranchID = BranchID;
                    rec.SchemaName = Name;
                    _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                    int res = _enty.SaveChanges();
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                        string msg = "Domain Schema : " + Name + " is Edited ";
                        InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                    }
                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Schema Name";
                }
                if (Convert.ToString(BranchID).Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Branch";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Branch";
                    }

                }

            }

            //save new agency
            return PartialView("_result");
        }
        public ActionResult SchemaColumns(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    //assigned Col
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Schema Columns", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        var AssignedCol = _enty.Sch_SchemaColList.Where(q => q.SchemaID == id).Select(q => q).ToList().OrderBy(q => q.ColumnIndex);
                        if (AssignedCol.Count() > 0)
                        {
                            ViewBag.AssignedCol = AssignedCol;
                        }


                        var Data = _enty.Sch_SchemaList.Where(q => q.SchemaID == id).Select(q => q).FirstOrDefault();
                        if (Data != null)
                        {
                            ViewBag.Data = Data;
                        }
                        if (AccessRights.Contains("All") || AccessRights.Contains("Add"))
                            TempData["AccessRightAdd"] = true;
                        if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                            TempData["AccessRightEdit"] = true;
                        if (AccessRights.Contains("All") || AccessRights.Contains("Delete"))
                            TempData["AccessRightDelete"] = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }

        }

        public ActionResult AddSchemaColumns(string ColID, string id, int index)
        {
            byte ID = Convert.ToByte(id);
            //insert
            int res = _enty.Sch_SchemaColomnsInsert(Convert.ToByte(ColID), ID, index);
            if (res > 0)
            {
                ViewBag.saved = "Data saved successfully";
            }
            else
            {
                ViewBag.error = "This Column Already Exists";
            }


            #region Select
            //assigned Col
            var AssignedCol = _enty.Sch_SchemaColList.Where(q => q.SchemaID == ID).Select(q => q).ToList();
            if (AssignedCol.Count() > 0)
            {
                ViewBag.AssignedCol = AssignedCol;
            }

            //Team Data
            var Data = _enty.Sch_SchemaList.Where(q => q.SchemaID == ID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_CollectionSchemaCols");
        }

        public ActionResult UpdateSchemaColIndex(int SchemaID, int ColID, int index)
        {
            var rec = _enty.Sch_SchemaColumns.Where(q => q.SchemaID == SchemaID && q.CoID == ColID).Select(q => q).FirstOrDefault();
            if (rec != null)
            {
                rec.ColumnIndex = Convert.ToInt16(index);
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                int res = _enty.SaveChanges();
                if (res > 0)
                {
                    ViewBag.saved = "Data saved successfully";
                }
            }

            #region Select
            //assigned Col
            var AssignedCol = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q).ToList();
            if (AssignedCol.Count() > 0)
            {
                ViewBag.AssignedCol = AssignedCol;
            }

            var Data = _enty.Sch_SchemaList.Where(q => q.SchemaID == SchemaID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_CollectionSchemaCols");
        }
        public ActionResult RemoveColumns(int SchemaID, int ColID)
        {
            int res = _enty.Sch_SchemaColomnsDelete(Convert.ToByte(ColID), Convert.ToByte(SchemaID));
            if (res > 0)
            {
                ViewBag.saved = "Data saved successfully";
            }


            #region Select
            //assigned Col
            var AssignedCol = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q).ToList();
            if (AssignedCol.Count() > 0)
            {
                ViewBag.AssignedCol = AssignedCol;
            }


            var Data = _enty.Sch_SchemaList.Where(q => q.SchemaID == SchemaID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_CollectionSchemaCols");
        }
        #endregion

        #region New Domain
        [HttpGet]
        public ActionResult Domain()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("New Domain", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        if (myinformationonly == true)
                        {
                            int userid = int.Parse(Session["ID"].ToString());
                            var user = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s).FirstOrDefault();
                            List<int?> BanksScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s.BankID).ToList();
                            string BankIDs = BanksScope.Count() > 0 ? string.Join(",", BanksScope) : "";
                            ViewBag.myinfo = myinformationonly; ViewBag.BranchIDs = user.BranchIDs; ViewBag.BankIDs = BankIDs;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        [HttpPost]
        public ActionResult NewDomain(FormCollection frm)
        {
            List<string> Msg = new List<string>();

            string Name = frm["Name"];
            int BrunchID = string.IsNullOrWhiteSpace(frm["BrunchID"]) ? 0 : int.Parse(frm["BrunchID"]);
            int AgencyID = string.IsNullOrWhiteSpace(frm["AgencyID"]) ? 0 : int.Parse(frm["AgencyID"]);
            int Month = string.IsNullOrWhiteSpace(frm["Month"]) ? 0 : int.Parse(frm["Month"]);
            string DomainTypes = string.IsNullOrWhiteSpace(frm["TypeID"]) ? "" : frm["TypeID"];
            string Products = string.IsNullOrWhiteSpace(frm["ProductID"]) ? "" : frm["ProductID"];
            string Regions = string.IsNullOrWhiteSpace(frm["RegionID"]) ? "" : frm["RegionID"];
            string Mobile = string.IsNullOrWhiteSpace(frm["Mobile"]) ? "" : frm["Mobile"];
            string Address = string.IsNullOrWhiteSpace(frm["Address"]) ? "" : frm["Address"];
            //string DomainType = frm["DomainType"];

            try
            {
                if (Name.Length == 0)
                {
                    Msg.Add("- Enter Domain Name");
                }
                if (BrunchID == 0)
                {
                    Msg.Add("- Choose Branch");
                }
                if (AgencyID == 0)
                {
                    Msg.Add("- Choose Bank");
                }
                if (Month == 0)
                {
                    Msg.Add("- Choose Month");
                }
                if (DomainTypes.Length == 0)
                {
                    Msg.Add("- Choose Domain Type");
                }
                if (Products.Length == 0)
                {
                    Msg.Add("- Choose Product");
                }
                if (Regions.Length == 0)
                {
                    Msg.Add("- Choose Region");
                }
                string ExistUsrName = _enty.Dom_DomainBasic.Where(q => q.DomainTitle == Name && q.AgencyID == AgencyID && q.BranchID == BrunchID && q.MonthID == Month && q.SuccessDomain == true).Select(q => q.DomainTitle).FirstOrDefault();
                if (ExistUsrName != null)
                {
                    Msg.Add("- Domain Name is already exist");
                }


                //no null
                if (Msg.Count > 0)
                {
                    ViewBag.Msg = Msg;
                }
                if (ViewBag.Msg == null)
                {
                    // save basic values 
                    Dom_DomainBasic rec = new Dom_DomainBasic();
                    rec.AgencyID = Convert.ToInt16(AgencyID);
                    rec.BranchID = Convert.ToByte(BrunchID);
                    rec.MonthID = Convert.ToInt16(Month);
                    rec.DomainTitle = Name;
                    rec.StatusID = 10;
                    //rec.Mobile = Mobile;
                    //rec.Address = Address;
                    _enty.Entry(rec).State = System.Data.Entity.EntityState.Added;
                    int res = _enty.SaveChanges();
                    //save domain type values 
                    List<string> DTIds = DomainTypes.Split(',').ToList();
                    if (DTIds.Contains("-1"))
                    {
                        EIF.Helper.collection.Get _Get = new EIF.Helper.collection.Get();
                        DTIds = _Get.DomainTypes(AgencyID).Select(s => s.Value).ToList();
                        DTIds.Remove("-1");
                    }
                    foreach (var item in DTIds)
                    {
                        Domain_DomainType DDT = new Models.Domain_DomainType();
                        DDT.DomianID = rec.DomainID;
                        DDT.DomainTypeID = int.Parse(item);
                        _enty.Entry(DDT).State = System.Data.Entity.EntityState.Added;
                    }
                    _enty.SaveChanges();
                    // save region values 
                    List<string> RegionIds = Regions.Split(',').ToList();
                    foreach (var item in RegionIds)
                    {
                        Domain_Region DR = new Models.Domain_Region();
                        DR.DomainID = rec.DomainID;
                        DR.RegionID = int.Parse(item);
                        _enty.Entry(DR).State = System.Data.Entity.EntityState.Added;
                    }
                    _enty.SaveChanges();
                    // save product values 
                    List<string> ProductIds = Products.Split(',').ToList();
                    if (ProductIds.Contains("-1"))
                    {
                        EIF.Helper.collection.Get _Get = new EIF.Helper.collection.Get();
                        ProductIds = _Get.ProductLst(AgencyID).Select(s => s.Value).ToList();
                        ProductIds.Remove("-1");
                    }
                    foreach (var item in ProductIds)
                    {
                        Domain_Product DP = new Models.Domain_Product();
                        DP.DomainID = rec.DomainID;
                        DP.ProductID = int.Parse(item);
                        _enty.Entry(DP).State = System.Data.Entity.EntityState.Added;
                    }
                    _enty.SaveChanges();
                    ViewBag.DomainID = rec.DomainID;
                    Session["DomainIDToImport"] = rec.DomainID;
                    if (res > 0)
                    {
                        ViewBag.saved = "Data saved successfully";
                    }

                }


            }
            catch (Exception ex)
            {

                throw;
            }
            return PartialView("_Result");
        }

        public ActionResult GetImportDomain()
        {
            return PartialView("_CollectionImoprtDomain");
        }
        public ActionResult ImportDomain(FormCollection frm)
        {
            if (int.Parse(frm["DomainID2"]) > 0)
            {
                if (frm["SchemaID"].Length > 0)
                {
                    //save temp
                    // string pathToExcelFile = SaveExcel(Convert.FromBase64String(frm["excelFile"]), "TempExcel");
                    if (frm["filePath"].Length > 0)
                    {
                        string pathToExcelFile = frm["filePath"];
                        string SheetName = frm["SheetName"];
                        int temp;
                        int.TryParse(frm["VersionNumber"], out temp);
                        int VersionNumber = temp != 0 ? temp : 1;
                        //save to DB
                        UploadExcel(pathToExcelFile, Path.GetFileName(pathToExcelFile), Convert.ToByte(frm["SchemaID"]), int.Parse(frm["DomainID2"]), SheetName, VersionNumber);
                        if (Session["DomainIDToImport"] != null)
                        {
                            int DomianID = int.Parse(Session["DomainIDToImport"].ToString());
                            int SchemaId = int.Parse(frm["SchemaID"]);
                            var Domain = _enty.Dom_DomainBasic.Where(a => a.DomainID == DomianID).Select(s => s).FirstOrDefault();
                            Domain.SuccessDomain = true;
                            Domain.ISHIDEN = false;
                            Domain.SchemaId = SchemaId;
                            Domain.VersionNumber = VersionNumber;
                            _enty.SaveChanges();
                            var collectorCodeIndex = _enty.Sch_SchemaColList.Where(c => c.ColumnName == "Collector Code" && c.SchemaID == SchemaId).Select(a => a.ColumnIndex).FirstOrDefault();
                            var collectornameIndex = _enty.Sch_SchemaColList.Where(c => c.ColumnName == "Collector Name" && c.SchemaID == SchemaId).Select(a => a.ColumnIndex).FirstOrDefault();
                            var teamLeaderIndex = _enty.Sch_SchemaColList.Where(c => c.ColumnName == "Team Leader" && c.SchemaID == SchemaId).Select(a => a.ColumnIndex).FirstOrDefault();
                            Domain.SchemaName = _enty.Sch_SchemaList.Where(a => a.SchemaID == SchemaId).Select(s => s.SchemaName).FirstOrDefault();


                            string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;

                            var query = "insert into TeamLeaders select col" + teamLeaderIndex.ToString() + " from Dom_DomainsDataExtra where SchemaID= " + SchemaId.ToString()
                            + "insert into CollectorCodes select col" + collectorCodeIndex.ToString() + " from Dom_DomainsDataExtra where SchemaID= " + SchemaId.ToString()
                            + "insert into CollectorNames select col" + collectornameIndex.ToString() + " from Dom_DomainsDataExtra where SchemaID= " + SchemaId.ToString();

                            SqlDataAdapter adapter = new SqlDataAdapter(query, connstring);
                        }
                        Session["DomainIDToImport"] = null;
                        ////Delete temp
                        ////deleting excel file from folder  
                        //if ((System.IO.File.Exists(pathToExcelFile)))
                        //{
                        //    System.IO.File.Delete(pathToExcelFile);
                        //}
                    }

                }
                else
                {
                    ViewBag.error = "Choose Schema";
                }
            }
            else
            {
                ViewBag.error = "No Domain Exists";
            }

            return PartialView("_ImportResult");
            //if (Session["ID"] == null)
            //{
            //    Session["ID"] = 0;

            //}
            //if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            //{
            //    if (Permission())
            //    {


            //    }
            //    else
            //    {
            //        return RedirectToAction("Forbidden", "Account", new
            //        {
            //            area = ""
            //        });
            //    }
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Account", new
            //    {
            //        area = ""
            //    });
            //}
        }
        public ActionResult GetSheets(string file)
        {
            //Check for access deny and password sheet long
            string pathToExcelFile = SaveExcel(Convert.FromBase64String(file), "TempExcel");
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            List<string> excelSheets = excelFile.GetWorksheetNames().ToList();
            Dictionary<string, string> SheetList = new Dictionary<string, string>();

            int i = 0;
            foreach (var S in excelSheets)
            {
                SheetList.Add(S, S);
                i++;
            }
            if (SheetList.Count() > 1)
            {
                ViewBag.Sheets = new SelectList((SheetList.Select(q => q)).ToList(), "Key", "Value");
            }
            else
            {
                ViewBag.SingleSheets = new SelectList((SheetList.Select(q => q)).ToList(), "Key", "Value");
            }
            ViewBag.pathToExcelFile = pathToExcelFile;
            try
            {

            }
            catch (Exception ex)
            {
                ViewBag.Validation = ex.Message;
                throw;
            }

            return PartialView("_CollectionGetSheets");
        }

        public ActionResult CheckToImport(byte SchemaID, string file, string SheetName)
        {
            var connectionString = "";
            string BalanceColName = "";
            string PastDueColName = "";
            bool Error = false;
            int userid = int.Parse(Session["ID"].ToString());
            if (SheetName.Length > 0)
            {

                var excelFile = new ExcelQueryFactory(file);
                #region get in datatable
                //get in datatable
                connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", file);

                var adapter = new OleDbDataAdapter("SELECT * FROM [" + SheetName + "$]", connectionString);//[Sheet1$]
                var ds = new DataSet();

                adapter.Fill(ds, "ExcelTable");

                DataTable dtable = ds.Tables["ExcelTable"];
                #endregion
                //Check Schema
                int NumberOfColOfExcel = dtable.Columns.Count;
                int? NumberOfColOfSchema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).OrderByDescending(q => q.Value).FirstOrDefault();
                if (NumberOfColOfExcel >= NumberOfColOfSchema)
                {
                    #region count
                    //count
                    try
                    {
                        ViewBag.RowsCount = dtable.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        ViewBag.RowsCountError = ex.Message.ToString();
                        Error = true;
                    }
                    #endregion
                    #region sum of past due
                    //sum of past due
                    try
                    {
                        int PastDueCol = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Past Due").Select(q => q.ColumnIndex).FirstOrDefault());
                        PastDueColName = dtable.Columns[PastDueCol - 1].ColumnName;
                        ViewBag.PastDue = dtable.Compute("Sum([" + PastDueColName + "])", "[" + PastDueColName + "] IS NOT NULL");
                    }
                    catch (Exception ex)
                    {
                        ViewBag.PastDueError = ex.Message.ToString();
                        Error = true;
                    }
                    #endregion
                    #region sum of balance
                    //sum of balance
                    try
                    {
                        int BalanceCol = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Balance").Select(q => q.ColumnIndex).FirstOrDefault());
                        BalanceColName = dtable.Columns[BalanceCol - 1].ColumnName;
                        ViewBag.Balance = dtable.Compute("Sum([" + BalanceColName + "])", "[" + BalanceColName + "] IS NOT NULL");

                    }
                    catch (Exception ex)
                    {

                        ViewBag.BalanceError = ex.Message.ToString();
                        Error = true;
                    }
                    #endregion
                    #region datatableregion
                    List<string> Params = new List<string>();
                    int? BucketColNullable = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Bucket").Select(q => q.ColumnIndex).FirstOrDefault();
                    int? CycleColNullable = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Cycle").Select(q => q.ColumnIndex).FirstOrDefault();
                    int? DomainTypeIndex = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Domain Type").Select(q => q.ColumnIndex).FirstOrDefault());
                    int? RegionIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Region").Select(q => q.ColumnIndex).FirstOrDefault());
                    int? CollectorIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Collector Name").Select(q => q.ColumnIndex).FirstOrDefault());
                    int? CollectorCodeIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Collector Code").Select(q => q.ColumnIndex).FirstOrDefault());

                    if (BucketColNullable != null && BucketColNullable != 0)
                        Params.Add(dtable.Columns[(int)BucketColNullable - 1].ColumnName);
                    if (CycleColNullable != null && CycleColNullable != 0)
                        Params.Add(dtable.Columns[(int)CycleColNullable - 1].ColumnName);
                    if (DomainTypeIndex != null && DomainTypeIndex != 0)
                        Params.Add(dtable.Columns[(int)DomainTypeIndex - 1].ColumnName);
                    if (RegionIndexNullable != null && RegionIndexNullable != 0)
                        Params.Add(dtable.Columns[(int)RegionIndexNullable - 1].ColumnName);
                    if (CollectorIndexNullable != null && CollectorIndexNullable != 0)
                        Params.Add(dtable.Columns[(int)CollectorIndexNullable - 1].ColumnName);
                    if (CollectorCodeIndexNullable != null && CollectorCodeIndexNullable != 0)
                        Params.Add(dtable.Columns[(int)CollectorCodeIndexNullable - 1].ColumnName);
                    Params.Add(BalanceColName);
                    Params.Add(PastDueColName);
                    var arrParams = Params.ToArray();

                    //string BucketColName = BucketColNullable != null ? dtable.Columns[(int)BucketColNullable - 1].ColumnName : "";
                    //string CycleColName = CycleColNullable != null ? dtable.Columns[(int)CycleColNullable - 1].ColumnName : "";
                    //string DomainTypeColName = DomainTypeIndex != null ? dtable.Columns[(int)DomainTypeIndex - 1].ColumnName : "";
                    //string RegionColName = RegionIndexNullable != null ? dtable.Columns[(int)RegionIndexNullable - 1].ColumnName : "";
                    //string CollectorNameColumn = CollectorIndexNullable != null ? dtable.Columns[(int)CollectorIndexNullable - 1].ColumnName : "";
                    //string CollectorCodeColumn = CollectorCodeIndexNullable != null ? dtable.Columns[(int)CollectorCodeIndexNullable - 1].ColumnName : "";
                    System.Data.DataView view = new System.Data.DataView(dtable);
                    System.Data.DataTable selected = view.ToTable("Selected", false, arrParams);

                    #endregion
                    if (ViewBag.Balance != null && ViewBag.PastDue != null)
                    {
                        #region Bucket table
                        //Bucket table
                        try
                        {
                            //int? BucketColNullable = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Bucket").Select(q => q.ColumnIndex).FirstOrDefault();
                            if (BucketColNullable != null && BucketColNullable != 0)
                            {
                                //int BucketCol = Convert.ToInt16(BucketColNullable);
                                //string BucketColName = dtable.Columns[BucketCol - 1].ColumnName;
                                //System.Data.DataView view = new System.Data.DataView(dtable);
                                //System.Data.DataTable selected = view.ToTable("Selected", false, BalanceColName, PastDueColName, BucketColName);
                                List<BuckectResultLine> result = new List<BuckectResultLine>();
                                try
                                {
                                    result = selected.AsEnumerable()
                                       .GroupBy(l => Convert.ToString(l.Field<string>(dtable.Columns[(int)BucketColNullable - 1].ColumnName)))
                                       .Select(cl => new BuckectResultLine
                                       {
                                           Bucket = cl.Key,
                                           Count = cl.Count(),
                                           PastDue = string.Format("{0:N0}", cl.Sum(c => c.Field<double?>(PastDueColName))),
                                           Balance = string.Format("{0:N0}", cl.Sum(c => c.Field<double?>(BalanceColName))),
                                       }).ToList();
                                }
                                catch            // in case there is exception in bucket
                                {
                                    result = selected.AsEnumerable()
                                       .GroupBy(l => Convert.ToString(l.Field<double?>(dtable.Columns[(int)BucketColNullable - 1].ColumnName)))
                                       .Select(cl => new BuckectResultLine
                                       {
                                           Bucket = cl.Key,
                                           Count = cl.Count(),
                                           PastDue = string.Format("{0:N0}", cl.Sum(c => c.Field<double?>(PastDueColName))),
                                           Balance = string.Format("{0:N0}", cl.Sum(c => c.Field<double?>(BalanceColName))),
                                       }).ToList();
                                }
                                if (result.Count() > 0)
                                {
                                    ViewBag.Bucket = result;
                                }
                            }
                            else
                            {
                                ViewBag.BucketWarning = "Not Applied";
                            }

                        }
                        catch (Exception ex)
                        {

                            ViewBag.BucketError = ex.Message.ToString();
                            Error = true;
                        }
                        #endregion
                        #region cycle table
                        //cycle table           
                        try
                        {
                            //int? CycleColNullable = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Cycle").Select(q => q.ColumnIndex).FirstOrDefault();
                            if (CycleColNullable != null && CycleColNullable != 0)
                            {
                                //int CycleCol = Convert.ToInt16(CycleColNullable);
                                //string CycleColName = dtable.Columns[CycleCol - 1].ColumnName;
                                //System.Data.DataView view = new System.Data.DataView(dtable);
                                //System.Data.DataTable selected = new DataTable();
                                //try
                                //{
                                //    selected = view.ToTable("Selected", false, BalanceColName, PastDueColName, CycleColName);
                                //}
                                //catch(Exception ex)
                                //{

                                //}
                                //double? _PastDue = selected.AsEnumerable().Select(s => s.Field<double>(PastDueColName)).ToList().Sum(m => m);
                                //double? _Balance = selected.AsEnumerable().Select(s => s.Field<double?>(BalanceColName)).ToList().Sum(m => m);
                                List<CycleResultLine> result = selected.AsEnumerable()
                                    //.Where(l => l.Field<double>(PastDueColName) != null)
                                .GroupBy(l => Convert.ToString(l.Field<double?>(dtable.Columns[(int)CycleColNullable - 1].ColumnName)))
                                .Select(cl => new CycleResultLine
                                {
                                    Cycle = cl.Key,
                                    Count = cl.Count(),
                                    PastDue = string.Format("{0:N0}", cl.Sum(c => c.Field<double?>(PastDueColName))),
                                    Balance = string.Format("{0:N0}", cl.Sum(c => c.Field<double?>(BalanceColName))),
                                }).ToList();
                                if (result.Count() > 0)
                                {
                                    ViewBag.Cycle = result;
                                }
                            }
                            else
                            {
                                ViewBag.CycleWarning = "Not Applied";
                            }

                        }
                        catch (Exception ex)
                        {

                            ViewBag.CycleError = ex.Message.ToString();
                            Error = true;
                        }
                        #endregion
                    }
                    #region DomainType
                    try
                    {
                        //int? DomainTypeIndex = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Domain Type").Select(q => q.ColumnIndex).FirstOrDefault());
                        if (DomainTypeIndex != null && DomainTypeIndex != 0)
                        {
                            //int typeindex = Convert.ToInt16(DomainTypeIndex);
                            //string DomainTypeColName = dtable.Columns[typeindex - 1].ColumnName;
                            //System.Data.DataView view = new System.Data.DataView(dtable);
                            //System.Data.DataTable selected = view.ToTable("Selected", false, DomainTypeColName);
                            List<string> DomainValues = selected.AsEnumerable().Select(s => s.Field<string>(dtable.Columns[(int)DomainTypeIndex - 1].ColumnName)).ToList();
                            var DomainIDs = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s.TypeID).ToList();
                            var Unique_Domains = new HashSet<string>(DomainValues);
                            foreach (var domainitem in Unique_Domains)
                            {
                                if (domainitem != null && domainitem.Trim().ToLower() != "internal" && domainitem.Trim().ToLower() != "active" && domainitem.Trim().ToLower() != "external" && domainitem.Trim().ToLower() != "w/o" && domainitem.Trim().ToLower() != "skip")
                                {
                                    ViewBag.Domaintype = "Invalid data in Domain Type comlun";
                                    Error = true;
                                    break;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        ViewBag.Domaintype = ex.Message.ToString();
                        Error = true;
                    }
                    #endregion
                    #region Region
                    try
                    {
                        //int? RegionIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Region").Select(q => q.ColumnIndex).FirstOrDefault());
                        if (RegionIndexNullable != null && RegionIndexNullable != 0)
                        {
                            //int RegionIndex = Convert.ToInt16(RegionIndexNullable);
                            //string RegionColName = dtable.Columns[RegionIndex - 1].ColumnName;
                            //System.Data.DataView view = new System.Data.DataView(dtable);
                            //System.Data.DataTable selected = view.ToTable("Selected", false, RegionColName);
                            List<string> RegionValues = selected.AsEnumerable().Select(s => s.Field<string>(dtable.Columns[(int)RegionIndexNullable - 1].ColumnName)).ToList();
                            var Unique_Regions = new HashSet<string>(RegionValues);
                            foreach (var regionitem in Unique_Regions)
                            {
                                if (regionitem != null && regionitem.Trim().ToLower() != "alex" && regionitem.Trim().ToLower() != "cairo" && regionitem.Trim().ToLower().ToLower() != "regional" && regionitem.Trim().ToLower().ToLower() != "other")
                                {
                                    ViewBag.Region = "Invalid data in Region Column";
                                    Error = true;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Region = ex.Message.ToString();
                        Error = true;

                    }
                    #endregion
                    #region Product
                    //try
                    //{
                    //    int? ProductIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Product").Select(q => q.ColumnIndex).FirstOrDefault());
                    //    if (ProductIndexNullable != null)
                    //    {
                    //        int ProductIndex = Convert.ToInt16(ProductIndexNullable);
                    //        string ProductColName = dtable.Columns[ProductIndex - 1].ColumnName;
                    //        System.Data.DataView view = new System.Data.DataView(dtable);
                    //        System.Data.DataTable selected = view.ToTable("Selected", false, ProductColName);
                    //        List<string> ProductValues = selected.AsEnumerable().Select(s => s.Field<string>(ProductColName)).ToList();
                    //        var productnames = _enty.Products.Select(s=>s.ProductName.Trim().ToLower()).ToList();
                    //        foreach (var productitem in ProductValues)
                    //        {
                    //            if (!productnames.Contains(productitem.Trim().ToLower()))
                    //            {
                    //                ViewBag.Product = "Invalid data in product Column";
                    //                Error = true;
                    //                break;
                    //            }
                    //        }
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    ViewBag.Region = ex.Message.ToString();
                    //    Error = true;
                    //}
                    #endregion
                    #region Collectors
                    try
                    {
                        //int? CollectorIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Collector Name").Select(q => q.ColumnIndex).FirstOrDefault());
                        //int? CollectorCodeIndexNullable = Convert.ToInt16(_enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Collector Code").Select(q => q.ColumnIndex).FirstOrDefault());

                        if (CollectorIndexNullable != null && CollectorCodeIndexNullable != null && CollectorIndexNullable != 0 && CollectorCodeIndexNullable != 0)
                        {
                            //int CollectorIndex = Convert.ToInt16(CollectorIndexNullable);
                            //string CollectorNameColumn = dtable.Columns[CollectorIndex - 1].ColumnName;
                            //int CollectorCodeIndex = Convert.ToInt16(CollectorCodeIndexNullable);
                            //string CollectorCodeColumn = dtable.Columns[CollectorCodeIndex - 1].ColumnName;
                            //System.Data.DataView view = new System.Data.DataView(dtable);
                            //System.Data.DataTable selected = view.ToTable("Selected", false, CollectorNameColumn, CollectorCodeColumn);
                            List<string> CollectorNames = selected.AsEnumerable().Select(s => s.Field<string>(dtable.Columns[(int)CollectorIndexNullable - 1].ColumnName)).ToList();
                            List<string> CollectorCodes = new List<string>();
                            try
                            {
                                CollectorCodes = selected.AsEnumerable().Select(s => s.Field<double?>(dtable.Columns[(int)CollectorCodeIndexNullable - 1].ColumnName).ToString()).ToList();
                            }
                            catch
                            {
                                CollectorCodes = selected.AsEnumerable().Select(s => s.Field<string>(dtable.Columns[(int)CollectorCodeIndexNullable - 1].ColumnName).ToString()).ToList();
                            }
                            var Unique_Names = new HashSet<string>(CollectorNames).Where(a => !string.IsNullOrEmpty(a)).Select(s => s.ToLower()).Distinct().ToList();
                            var Unique_Codes = new HashSet<string>(CollectorCodes).Where(a => !string.IsNullOrEmpty(a)).ToList();
                            var DBCollectors = _enty.Config_MembersList.Select(s => s).ToList();
                            var DBCollectorNames = DBCollectors.Select(s => s.MemberName.ToLower()).ToList();
                            var DBCollectorCodes = DBCollectors.Select(s => s.Code).ToList();
                            //for (int item = 0; item < Unique_Names.Count; item++)
                            //{
                            //    if (Unique_Names[item] != null && !DBCollectorNames.Contains(Unique_Names[item].ToLower()) && !DBCollectorCodes.Contains(Unique_Codes[item]))
                            //    {
                            //        ViewBag.Collectors = "Invalid data in Collector Name Column or in Collector Code Column";
                            //        Error = true;
                            //        break;
                            //    }
                            //}
                        }
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Collectors = ex.Message.ToString();
                        Error = true;

                    }
                    #endregion
                }
                else
                {
                    ViewBag.error = "Number Of Columns Not Fit Number Of Schema Columns";
                    Error = true;
                }
                ds.Dispose();
            }
            else
            {
                ViewBag.error = "Choose Sheet";
                Error = true;
            }
            //if (!Error)
            //{
            //    if (Session["DomainIDToImport"] != null)
            //    {
            //        int DomianID = int.Parse(Session["DomainIDToImport"].ToString());
            //        var Domain = _enty.Dom_DomainBasic.Where(a => a.DomainID == DomianID).Select(s => s).FirstOrDefault();
            //        Domain.SuccessDomain = true;
            //        _enty.SaveChanges();                   
            //    }
            //}
            //Session["DomainIDToImport"] = null;
            return PartialView("_CollectionFileStatistic");
        }

        #endregion

        #region NewReferer
        public ActionResult DomainsToRefer()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("New Referer", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        if (AccessRights.Contains("All") || AccessRights.Contains("Add"))
                            ViewBag.AccessRightAdd = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult NewReferer(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    var data = _enty.Dom_DomainList.Where(q => q.DomainID == id).Select(q => q).FirstOrDefault();
                    if (data != null)
                    {
                        ViewBag.data = data;
                    }
                    return View();

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        #endregion

        #region Update Domain
        public ActionResult DomainsToUpdate()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Update Domain", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                            ViewBag.AccessRightEdit = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult UpdateDomain(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    var data = _enty.Dom_DomainList.Where(q => q.DomainID == id).Select(q => q).FirstOrDefault();
                    if (data != null)
                    {
                        ViewBag.data = data;
                    }
                    return View();

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult ImportDomainUpdate(FormCollection frm)
        {
            if (int.Parse(frm["DomainID2"]) > 0)
            {
                if (frm["SchemaID"].Length > 0)
                {

                    if (frm["filePath"].Length > 0)
                    {
                        string pathToExcelFile = frm["filePath"];
                        string SheetName = frm["SheetName"];
                        int VersionNumber = int.Parse(frm["VersionNumber"]) + 1;
                        //save to DB
                        int DomainID = int.Parse(frm["DomainID2"]);
                        var Domain = _enty.Dom_DomainBasic.Where(a => a.DomainID == DomainID).Select(s => s).FirstOrDefault();
                        Domain.VersionNumber = VersionNumber;
                        _enty.SaveChanges();

                        UploadUpdateExcel(pathToExcelFile, Path.GetFileName(pathToExcelFile), Convert.ToByte(frm["SchemaID"]), int.Parse(frm["DomainID2"]), SheetName, VersionNumber);

                        ////Delete temp
                        ////deleting excel file from folder  
                        //if ((System.IO.File.Exists(pathToExcelFile)))
                        //{
                        //    System.IO.File.Delete(pathToExcelFile);
                        //}
                    }

                }
                else
                {
                    ViewBag.error = "Choose Schema";
                }
            }
            else
            {
                ViewBag.error = "No Domain Exists";
            }

            return PartialView("_ImportResult");

        }
        #endregion

        #region Append payment
        public ActionResult DomainsToAppendPayments()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {

                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Append Payments", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                            ViewBag.AccessRightEdit = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult AppendPayments(int id, int type)
        {
            ViewBag.type = type;

            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Append Payments", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        var data = _enty.DomainsWithPayments.Where(q => q.DomainID == id).Select(q => q).FirstOrDefault();
                        var PaymentDate = _enty.PaymentDateVIEWs.Where(a => a.DomainID == id).Select(s => s.PaymentDate).FirstOrDefault();
                        if (data != null)
                        {
                            ViewBag.data = data;
                            if (PaymentDate != null)
                            {
                                ViewBag.paymentdate = PaymentDate.Value.ToShortDateString();
                            }
                            else
                            {
                                ViewBag.paymentdate = "";
                            }
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult GetPaymentSheets(string file)
        {
            //Check for access deny and password sheet long
            string pathToExcelFile = SaveExcel(Convert.FromBase64String(file), "TempExcel");
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            List<string> excelSheets = excelFile.GetWorksheetNames().ToList();
            Dictionary<string, string> SheetList = new Dictionary<string, string>();

            int i = 0;
            foreach (var S in excelSheets)
            {
                SheetList.Add(S, S);
                i++;
            }
            if (SheetList.Count() > 1)
            {
                ViewBag.Sheets = new SelectList((SheetList.Select(q => q)).ToList(), "Key", "Value");
            }
            else
            {
                ViewBag.SingleSheets = new SelectList((SheetList.Select(q => q)).ToList(), "Key", "Value");
            }
            ViewBag.pathToExcelFile = pathToExcelFile;
            try
            {

            }
            catch (Exception ex)
            {
                ViewBag.Validation = ex.Message;
                throw;
            }

            return PartialView("_CollectionGetPaymentsSheets");
        }

        public ActionResult GetSheetsColumn(string file, string SheetName, long DomainID)
        {
            string connectionString = "";

            var excelFile = new ExcelQueryFactory(file);

            #region get in datatable
            //get in datatable

            connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", file);

            //connectionString = string.Format("OLEDB;Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", file);



            var adapter = new OleDbDataAdapter("SELECT * FROM [" + SheetName + "$]", connectionString);//[Sheet1$]
            var ds = new DataSet();

            adapter.Fill(ds, "ExcelTable");

            DataTable dtable = ds.Tables["ExcelTable"];





            {
                Dictionary<string, string> Col = new Dictionary<string, string>();

                foreach (DataColumn column in dtable.Columns)
                {
                    Col.Add(column.ColumnName, column.ColumnName);
                }

                ViewBag.Columns = new SelectList(Col, "Key", "Value");

            #endregion

                ViewBag.DomainID = DomainID;
            }
            return PartialView("_CollectionPaymentsColumns");
        }
        public ActionResult SaveAppendPayments(FormCollection frm)
        {
            try
            {


                //get recored serial by PK where PK alias=PK excel
                //save payment by serial recored

                string file = frm["filePath"];
                string SheetName = frm["SheetName"];
                string PKFieldCol = frm["PKColumn"];
                string PKAliasCol = frm["PK"];
                string PaymentColumnCol = frm["PaymentColumn"];
                string VersionNumber = frm["VersionNumber"];
                string DomainId = frm["DomainID2"];
                string DomainName = frm["DomainName"];
                var type = frm["type"];

                if (SheetName.Length > 0 && PKFieldCol.Length > 0 && PKAliasCol.Length > 0 && PaymentColumnCol.Length > 0)
                {
                    string connectionString = "";

                    var excelFile = new ExcelQueryFactory(file);

                    #region get in datatable
                    //get in datatable
                    connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", file);

                    var adapter = new OleDbDataAdapter("SELECT * FROM [" + SheetName + "$]", connectionString);//[Sheet1$]
                    var ds = new DataSet();

                    adapter.Fill(ds, "ExcelTable");

                    DataTable dtable = ds.Tables["ExcelTable"];

                    // delete old payments 
                    _enty.Dom_AccountPaymentsDelete(DomainId);
                    //loop in file data
                    foreach (DataRow R in dtable.Rows)
                    {
                        //get PK field
                        string PKField = Convert.ToString(R[PKFieldCol]);
                        if (!string.IsNullOrEmpty(R[PaymentColumnCol].ToString()))
                        {

                            decimal PaymentColumn = Convert.ToDecimal(R[PaymentColumnCol].ToString());
                            string PaymentDate = string.IsNullOrEmpty(R["Payment Date "].ToString()) ? Convert.ToDateTime(R["Payment Date "]).ToShortDateString() : "";

                            var result = _enty.Dom_Dom_AccountsPaymentsInsert(DomainId, PKField, PKAliasCol, Convert.ToInt16(VersionNumber), PaymentColumn, PaymentDate, int.Parse(type));
                        }
                    }
                    ViewBag.saved = "Data saved successfully";
                    string msg = "new payment is added on Domain : " + DomainName + " ";
                    InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                    #endregion
                    ////Delete temp
                    ////deleting excel file from folder  
                    //if ((System.IO.File.Exists(pathToExcelFile)))
                    //{
                    //    System.IO.File.Delete(pathToExcelFile);
                    //}
                }
                else
                {
                    ViewBag.error = "Choose All Required Data";
                }

            }
            catch (Exception ex)
            {

                ViewBag.error = ex.Message;
            }



            return PartialView("_Result");

        }
        #endregion

        #region Compare Versions
        public ActionResult CompareVersions()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Compare Versions", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        //var data = _enty.Dom_DomainList.Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                        var data = CheckSheetDataScope(myinformationonly);
                        if (data.Count > 0)
                        {
                            ViewBag.data = data;
                        }
                        if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                            ViewBag.AccessRightEdit = true;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult CompareDomainVersions(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("Compare Versions", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        var data = _enty.Dom_DomainList.Where(q => q.DomainID == id).Select(q => q).FirstOrDefault();
                        if (data != null)
                        {
                            ViewBag.data = data;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult CompareVersionsResult(FormCollection frm)
        {
            if (Convert.ToInt64(frm["DomainID"]) > 0)
            {
                long DomainID = Convert.ToInt64(frm["DomainID"]);
                if (frm["PK"].Length > 0)
                {
                    ViewBag.CurrentVersionNumber = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q.VersionNumber).FirstOrDefault();
                    ViewBag.PrevVersionNumber = _enty.Dom_DomainDetailsListPrev.Where(q => q.DomainID == DomainID).Select(q => q.VersionNumber).FirstOrDefault();
                    byte VersionNumber = Convert.ToByte(ViewBag.PrevVersionNumber);

                    var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == DomainID && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                    ViewBag.alias = alias;
                    //new records
                    #region new records
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "Dom_GetDynamicColumnToNewRecoreds";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            List = List + "," + i;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                        cmd.Parameters.Add(new SqlParameter("@PK", frm["PK"]));

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.NewRecordsSummary = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    #endregion

                    //old records
                    #region old records
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "Dom_GetDynamicColumnToRemovedRecoreds";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            List = List + "," + i;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                        cmd.Parameters.Add(new SqlParameter("@PK", frm["PK"]));

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.OldRecordsSummary = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    #endregion

                    //comparison Summary
                    byte? SchemaID = _enty.Dom_DomainList.Where(q => q.DomainID == DomainID).Select(q => q.SchemaID).FirstOrDefault();
                    int? NumberOfPDColInSchema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Past Due").Select(q => q.ColumnIndex).OrderByDescending(q => q.Value).FirstOrDefault();
                    int? NumberOfBalanceColInSchema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Balance").Select(q => q.ColumnIndex).OrderByDescending(q => q.Value).FirstOrDefault();

                    string PDCol = "Col" + NumberOfPDColInSchema;
                    string BalanceCol = "Col" + NumberOfBalanceColInSchema;

                    Finance(DomainID, SchemaID, frm["PK"], PDCol, BalanceCol);
                }
                else
                {
                    ViewBag.error = "Choose Primary Key";
                }
            }
            else
            {
                ViewBag.error = "No Domain Exists";
            }

            return PartialView("_CollectionCompareVersions");

        }
        #endregion

        #region DCR
        public ActionResult DCR()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("New DCR", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        ViewBag.myinfo = myinformationonly;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult GetDomainAccounts(FormCollection frm)
        {
            if (frm["DomainID"].Length > 0)
            {
                long DomainID = Convert.ToInt64(frm["DomainID"]);
                var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).ToList();
                bool myinfo = bool.Parse(frm["myinfo"]);
                if (data.Count > 0)
                {
                    ViewBag.data = data;
                    ViewBag.DomainName = data.FirstOrDefault().DomainTitle;
                    ViewBag.SchemaName = data.FirstOrDefault().SchemaName;
                    ViewBag.VersionNumber = data.FirstOrDefault().VersionNumber;
                    byte VersionNumber = Convert.ToByte(ViewBag.VersionNumber);
                    int userid = int.Parse(Session["id"].ToString());
                    var USerScope = _enty.UserDataScopes.Where(a => a.UserId == userid).ToList();
                    List<Dictionary<string, object>> model = new List<Dictionary<string, object>>();
                    var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == DomainID && q.VersionNumber == VersionNumber).Select(q => q).ToList();
                    ViewBag.alias = alias;
                    var BankIDforDomain = _enty.Dom_DomainList.Where(a => a.DomainID == DomainID).Select(s => s.AgencyID).FirstOrDefault();
                    if (myinfo == true)
                    {
                        foreach (var scopeitem in USerScope)
                        {
                            if (scopeitem.BankID == BankIDforDomain)
                            {
                                int ProductID = (int)scopeitem.ProductID;
                                int TypeID = (int)scopeitem.TypeID;
                                var RegionIDs = scopeitem.RegionID;
                                string CityIDs = scopeitem.CityID;
                                string product = ""; string Type = ""; string Regions = ""; string Cities = "";
                                GetUserScopeNmaes(ProductID, TypeID, RegionIDs, CityIDs, ref product, ref Type, ref Regions, ref Cities);
                                using (var cmd = _enty.Database.Connection.CreateCommand())
                                {
                                    _enty.Database.Connection.Open();
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.CommandText = "Dom_GetDynamicColumn";

                                    string List = "";
                                    for (int i = 1; i <= alias.Count; i++)
                                    {
                                        List = List + "," + i;
                                    }
                                    cmd.Parameters.Add(new SqlParameter("@List", List));
                                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                                    cmd.Parameters.Add(new SqlParameter("@product", product));
                                    cmd.Parameters.Add(new SqlParameter("@domainttype", Type));
                                    cmd.Parameters.Add(new SqlParameter("@regions", Regions));
                                    cmd.Parameters.Add(new SqlParameter("@cities", Cities));
                                    cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinfo));
                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        model.AddRange(Read(reader).ToList());
                                    }
                                }
                                _enty.Database.Connection.Close();
                            }
                        }
                    }
                    else
                    {
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumn";

                            string List = "";
                            for (int i = 1; i <= alias.Count; i++)
                            {
                                List = List + "," + i;
                            }
                            cmd.Parameters.Add(new SqlParameter("@List", List));
                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@product", ""));
                            cmd.Parameters.Add(new SqlParameter("@domainttype", ""));
                            cmd.Parameters.Add(new SqlParameter("@regions", ""));
                            cmd.Parameters.Add(new SqlParameter("@myinfoonly", myinfo));
                            using (var reader = cmd.ExecuteReader())
                            {
                                model.AddRange(Read(reader).ToList());
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    model = model.Distinct().Select(s => s).ToList();
                    if (model.Count() > 0)
                    {
                        ViewBag.Tbl = model;
                    }
                }

            }
            return PartialView("_CollectionDCRDomainsDetails");

        }
        public ActionResult GetAccountDCR(long id)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("New DCR", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
            {
                var PCRHistory = _enty.PCR_PCRHistoryList.Where(q => q.AccountID == id).Select(q => q).ToList();
                if (PCRHistory.Count() > 0)
                {
                    ViewBag.PCRHistory = PCRHistory;
                }
                ViewBag.AccountID = id;
                if (AccessRights.Contains("All") || AccessRights.Contains("Add"))
                    ViewBag.AccessRightAdd = true;
                return PartialView("_CollectionAccountDCR");
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }

        }

        public string GetArabicComment(int id)
        {
            string ArabicComment = "";
            ArabicComment = _enty.Lup_Comments.Where(q => q.CommentID == id).Select(q => q.ArbicComment).FirstOrDefault();
            return ArabicComment;
        }

        public ActionResult SaveDCR(FormCollection frm)
        {
            List<string> MsgList = new List<string>();

            DateTime? ConnectionDate = frm["ConnectionDateVal"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["ConnectionDateVal"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string MembersID = frm["MembersID"].Length == 0 ? null : frm["MembersID"];
            int? DomainID = frm["DomainID2"].Length == 0 ? (int?)null : int.Parse(frm["DomainID2"]);
            int? AccountID = frm["AccountID"].Length == 0 ? (int?)null : int.Parse(frm["AccountID"]);
            string ConnectionTypeID = frm["ConnectionTypeID"].Length == 0 ? null : frm["ConnectionTypeID"];
            string ConnectionResultID = frm["ConnectionResultID"].Length == 0 ? null : frm["ConnectionResultID"];

            string Code2ID = frm["Code2ID"].Length == 0 ? null : frm["Code2ID"];

            string ReachedID = frm["ReachedID"].Length == 0 ? null : frm["ReachedID"];
            string ReachedCommentsID = frm["ReachedCommentsID"].Length == 0 ? null : frm["ReachedCommentsID"];
            string UnReachedCommentsID = frm["UnReachedCommentsID"].Length == 0 ? null : frm["UnReachedCommentsID"];

            string CustomerPhone = frm["CustomerPhone"].Length == 0 ? null : frm["CustomerPhone"];

            string PTPTypeID = frm["PTPTypeID"].Length == 0 ? null : frm["PTPTypeID"];
            DateTime? PTPDate = frm["PTPDateVal"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["PTPDateVal"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string PTPAmount = frm["PTPAmount"].Length == 0 ? null : frm["PTPAmount"];
            string Promise = frm["Promise"].Length == 0 ? null : frm["Promise"];
            string KeptAmount = frm["KeptAmount"].Length == 0 ? null : frm["KeptAmount"];
            string EngComment = frm["EngComment"].Length == 0 ? null : frm["EngComment"];
            string ArabComment = frm["ArabComment"].Length == 0 ? null : frm["ArabComment"];

            DateTime? PTPDate2 = frm["PTPDate2"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["PTPDate2"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string PTPTypeID2 = frm["PTPTypeID2"].Length == 0 ? null : frm["PTPTypeID2"];
            string PTPAmount2 = frm["PTPAmount2"].Length == 0 ? null : frm["PTPAmount2"];
            string PTPTypeID3 = frm["PTPTypeID3"].Length == 0 ? null : frm["PTPTypeID3"];
            DateTime? PTPDate3 = frm["PTPDate3"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["PTPDate3"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string PTPAmount3 = frm["PTPAmount3"].Length == 0 ? null : frm["PTPAmount3"];
            DateTime? KeptDate = frm["KeptDate"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["KeptDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string IsPromiseKept2 = frm["IsPromiseKept2"].Length == 0 ? null : frm["IsPromiseKept2"];
            DateTime? KeptDate2 = frm["KeptDate2"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["KeptDate2"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string KeptAmount2 = frm["KeptAmount2"].Length == 0 ? null : frm["KeptAmount2"];
            string IsPromiseKept3 = frm["IsPromiseKept3"].Length == 0 ? null : frm["IsPromiseKept3"];
            DateTime? KeptDate3 = frm["KeptDate3"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["KeptDate3"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string KeptAmount3 = frm["KeptAmount3"].Length == 0 ? null : frm["KeptAmount3"];


            ViewBag.ConnectionDate = ConnectionDate;
            ViewBag.MembersID = MembersID;
            ViewBag.AccountID = AccountID;
            ViewBag.ConnectionTypeID = ConnectionTypeID;
            ViewBag.ConnectionResultID = ConnectionResultID;
            ViewBag.Code2ID = Code2ID;

            ViewBag.ReachedID = ReachedID;
            ViewBag.ReachedCommentsID = ReachedCommentsID;
            ViewBag.UnReachedCommentsID = UnReachedCommentsID;

            ViewBag.CustomerPhone = CustomerPhone;

            ViewBag.PTPTypeID = PTPTypeID;
            ViewBag.PTPDate = PTPDate;
            ViewBag.PTPAmount = PTPAmount;
            ViewBag.Promise = Promise;
            ViewBag.KeptAmount = KeptAmount;
            ViewBag.EngComment = EngComment;
            ViewBag.ArabComment = ArabComment;

            ViewBag.PTPTypeID2 = PTPTypeID2;
            ViewBag.PTPDate2 = PTPDate2;
            ViewBag.PTPAmount2 = PTPAmount2;
            ViewBag.PTPTypeID3 = PTPTypeID3;
            ViewBag.PTPDate3 = PTPDate3;
            ViewBag.PTPAmount3 = PTPAmount3;
            ViewBag.KeptDate = KeptDate;
            ViewBag.IsPromiseKept2 = IsPromiseKept2;
            ViewBag.KeptDate2 = KeptDate2;
            ViewBag.KeptAmount2 = KeptAmount2;
            ViewBag.IsPromiseKept3 = IsPromiseKept3;
            ViewBag.KeptDate3 = KeptDate3;
            ViewBag.KeptAmount3 = KeptAmount3;


            if (string.IsNullOrWhiteSpace(MembersID) || MembersID == "0")
            {
                MsgList.Add("Action Maker is required");
            }

            if (string.IsNullOrWhiteSpace(ConnectionTypeID) || ConnectionTypeID == "0")
            {

                MsgList.Add("Connection Type is required");
            }

            if (string.IsNullOrWhiteSpace(ConnectionResultID) || ConnectionResultID == "0")
            {

                MsgList.Add("Connection Result is required");
            }

            if (string.IsNullOrWhiteSpace(PTPTypeID) || PTPTypeID == "0")
            {

                MsgList.Add("PTP Type Result is required");
            }

            if (PTPAmount != null)
            {
                if (IsDecimal(PTPAmount) == false)
                {
                    MsgList.Add("PTP Amount Not Valid");
                }
            }
            if (PTPAmount2 != null)
            {
                if (IsDecimal(PTPAmount2) == false)
                {
                    MsgList.Add("PTP Amount Not Valid");
                }
            }
            if (PTPAmount3 != null)
            {
                if (IsDecimal(PTPAmount3) == false)
                {
                    MsgList.Add("PTP Amount Not Valid");
                }
            }

            if (KeptAmount != null)
            {
                if (IsDecimal(KeptAmount) == false)
                {
                    MsgList.Add("Kept Amount Not Valid");
                }
            }
            if (KeptAmount2 != null)
            {
                if (IsDecimal(KeptAmount2) == false)
                {
                    MsgList.Add("Kept Amount Not Valid");
                }
            }
            if (KeptAmount3 != null)
            {
                if (IsDecimal(KeptAmount3) == false)
                {
                    MsgList.Add("Kept Amount Not Valid");
                }
            }


            if (MsgList.Count() > 0)
            {
                ViewBag.Msg = MsgList;

            }
            else
            {
                int res = _enty.PCR_PCRHistoryInsert(DomainID, Convert.ToInt16(MembersID), AccountID
                       , Convert.ToByte(ConnectionTypeID), Convert.ToByte(ConnectionResultID), CustomerPhone
                       , Convert.ToDateTime(ConnectionDate), Convert.ToByte(PTPTypeID), Convert.ToDateTime(PTPDate)
                       , Convert.ToDecimal(PTPAmount), Convert.ToBoolean(Promise), Convert.ToDecimal(KeptAmount), EngComment, ArabComment
                       , Convert.ToDateTime(PTPDate2), Convert.ToByte(PTPTypeID2), Convert.ToDecimal(PTPAmount2)
                       , Convert.ToByte(PTPTypeID3), Convert.ToDateTime(PTPDate3), Convert.ToDecimal(PTPAmount3)
                       , Convert.ToDateTime(KeptDate)
                       , Convert.ToBoolean(IsPromiseKept2), Convert.ToDateTime(KeptDate2), Convert.ToDecimal(KeptAmount2)
                       , Convert.ToBoolean(IsPromiseKept3), Convert.ToDateTime(KeptDate3), Convert.ToDecimal(KeptAmount3)
                       , Convert.ToByte(Code2ID)
                       , Convert.ToByte(ReachedID), Convert.ToByte(ReachedCommentsID), Convert.ToByte(UnReachedCommentsID));
                if (res > 1)
                {
                    ViewBag.saved = "DCR Saved Successfully";
                }

            }
            //}
            //else
            //{
            //    ViewBag.error = "Enter All Required Data";
            //}
            var PCRHistory = _enty.PCR_PCRHistoryList.Where(q => q.AccountID == AccountID).Select(q => q).ToList();
            if (PCRHistory.Count() > 0)
            {
                ViewBag.PCRHistory = PCRHistory;
            }
            ViewBag.AccountID = AccountID;
            return PartialView("_CollectionAccountDCR");

        }

        public ActionResult MyDCR()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("MY DCRs", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        ViewBag.myinfo = myinformationonly;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        public ActionResult ExportDCRWithAccounts(long DomainID)
        {
            string sw = "";
            // long DomainID = Convert.ToInt64(frm["DomainID"]);
            if (DomainID > 0)
            {

                var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).FirstOrDefault();
                byte SchemaID = data.SchemaID;
                List<int?> schema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).ToList();
                byte? VersionNumber = data.VersionNumber;
                string DomainTitle = data.DomainTitle;

                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "Dom_GetDynamicColumnForExport";

                    string List = "";
                    foreach (int I in schema)
                    {
                        List = List + "," + I;
                    }

                    cmd.Parameters.Add(new SqlParameter("@List", List));
                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                    cmd.Parameters.Add(new SqlParameter("@VersionNumber", VersionNumber));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            sw = ExportToExcel(model, DomainTitle + "(" + VersionNumber + ")");
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return Content(sw.ToString(), "application/ms-excel");
        }
        [HttpGet]
        public ActionResult UpdateDCR(long id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("MY DCRs", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("Edit") || AccessRights.Contains("All")))
                    {
                        var data = _enty.PCR_PCRHistoryList.Where(q => q.PCRID == id).Select(q => q).FirstOrDefault();

                        if (data != null)
                        {
                            ViewBag.Data = data;
                        }

                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        [HttpPost]
        public ActionResult UpdateDCR(FormCollection frm)
        {
            List<string> MsgList = new List<string>();

            DateTime? ConnectionDate = frm["ConnectionDateVal"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["ConnectionDateVal"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string MembersID = frm["MembersID"].Length == 0 ? null : frm["MembersID"];
            int? DomainID = frm["DomainID2"].Length == 0 ? (int?)null : int.Parse(frm["DomainID2"]);
            int? AccountID = frm["AccountID"].Length == 0 ? (int?)null : int.Parse(frm["AccountID"]);
            string ConnectionTypeID = frm["ConnectionTypeID"].Length == 0 ? null : frm["ConnectionTypeID"];
            string ConnectionResultID = frm["ConnectionResultID"].Length == 0 ? null : frm["ConnectionResultID"];

            string Code2ID = frm["Code2ID"].Length == 0 ? null : frm["Code2ID"];

            string ReachedID = frm["ReachedID"].Length == 0 ? null : frm["ReachedID"];
            string ReachedCommentsID = frm["ReachedCommentsID"].Length == 0 ? null : frm["ReachedCommentsID"];
            string UnReachedCommentsID = frm["UnReachedCommentsID"].Length == 0 ? null : frm["UnReachedCommentsID"];

            string CustomerPhone = frm["CustomerPhone"].Length == 0 ? null : frm["CustomerPhone"];

            string PTPTypeID = frm["PTPTypeID"].Length == 0 ? null : frm["PTPTypeID"];
            DateTime? PTPDate = frm["PTPDateVal"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["PTPDateVal"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string PTPAmount = frm["PTPAmount"].Length == 0 ? null : frm["PTPAmount"];
            string Promise = frm["Promise"].Length == 0 ? null : frm["Promise"];
            string KeptAmount = frm["KeptAmount"].Length == 0 ? null : frm["KeptAmount"];
            string EngComment = frm["EngComment"].Length == 0 ? null : frm["EngComment"];
            string ArabComment = frm["ArabComment"].Length == 0 ? null : frm["ArabComment"];

            DateTime? PTPDate2 = frm["PTPDate2"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["PTPDate2"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string PTPTypeID2 = frm["PTPTypeID2"].Length == 0 ? null : frm["PTPTypeID2"];
            string PTPAmount2 = frm["PTPAmount2"].Length == 0 ? null : frm["PTPAmount2"];
            string PTPTypeID3 = frm["PTPTypeID3"].Length == 0 ? null : frm["PTPTypeID3"];
            DateTime? PTPDate3 = frm["PTPDate3"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["PTPDate3"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string PTPAmount3 = frm["PTPAmount3"].Length == 0 ? null : frm["PTPAmount3"];
            DateTime? KeptDate = frm["KeptDate"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["KeptDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string IsPromiseKept2 = frm["IsPromiseKept2"].Length == 0 ? null : frm["IsPromiseKept2"];
            DateTime? KeptDate2 = frm["KeptDate2"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["KeptDate2"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string KeptAmount2 = frm["KeptAmount2"].Length == 0 ? null : frm["KeptAmount2"];
            string IsPromiseKept3 = frm["IsPromiseKept3"].Length == 0 ? null : frm["IsPromiseKept3"];
            DateTime? KeptDate3 = frm["KeptDate3"].Length == 0 ? (DateTime?)null : DateTime.ParseExact(frm["KeptDate3"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string KeptAmount3 = frm["KeptAmount3"].Length == 0 ? null : frm["KeptAmount3"];

            int? DCRID = frm["DCRID"].Length == 0 ? (int?)null : int.Parse(frm["DCRID"]);

            ViewBag.ConnectionDate = ConnectionDate;
            ViewBag.MembersID = MembersID;
            ViewBag.AccountID = AccountID;
            ViewBag.ConnectionTypeID = ConnectionTypeID;
            ViewBag.ConnectionResultID = ConnectionResultID;
            ViewBag.Code2ID = Code2ID;

            ViewBag.ReachedID = ReachedID;
            ViewBag.ReachedCommentsID = ReachedCommentsID;
            ViewBag.UnReachedCommentsID = UnReachedCommentsID;

            ViewBag.CustomerPhone = CustomerPhone;
            ViewBag.PTPTypeID = PTPTypeID;
            ViewBag.PTPDate = PTPDate;
            ViewBag.PTPAmount = PTPAmount;
            ViewBag.Promise = Promise;
            ViewBag.KeptAmount = KeptAmount;
            ViewBag.EngComment = EngComment;
            ViewBag.ArabComment = ArabComment;

            ViewBag.PTPTypeID2 = PTPTypeID2;
            ViewBag.PTPDate2 = PTPDate2;
            ViewBag.PTPAmount2 = PTPAmount2;
            ViewBag.PTPTypeID3 = PTPTypeID3;
            ViewBag.PTPDate3 = PTPDate3;
            ViewBag.PTPAmount3 = PTPAmount3;
            ViewBag.KeptDate = KeptDate;
            ViewBag.IsPromiseKept2 = IsPromiseKept2;
            ViewBag.KeptDate2 = KeptDate2;
            ViewBag.KeptAmount2 = KeptAmount2;
            ViewBag.IsPromiseKept3 = IsPromiseKept3;
            ViewBag.KeptDate3 = KeptDate3;
            ViewBag.KeptAmount3 = KeptAmount3;

            if (string.IsNullOrWhiteSpace(MembersID) || MembersID == "0")
            {
                MsgList.Add("Action Maker is required");
            }

            if (string.IsNullOrWhiteSpace(ConnectionTypeID) || ConnectionTypeID == "0")
            {

                MsgList.Add("Connection Type is required");
            }

            if (string.IsNullOrWhiteSpace(ConnectionResultID) || ConnectionResultID == "0")
            {

                MsgList.Add("Connection Result is required");
            }

            if (string.IsNullOrWhiteSpace(PTPTypeID) || PTPTypeID == "0")
            {

                MsgList.Add("PTP Type Result is required");
            }


            if (PTPAmount != null)
            {
                if (IsDecimal(PTPAmount) == false)
                {
                    MsgList.Add("PTP Amount Not Valid");
                }
            }
            if (PTPAmount2 != null)
            {
                if (IsDecimal(PTPAmount2) == false)
                {
                    MsgList.Add("PTP Amount Not Valid");
                }
            }
            if (PTPAmount3 != null)
            {
                if (IsDecimal(PTPAmount3) == false)
                {
                    MsgList.Add("PTP Amount Not Valid");
                }
            }

            if (KeptAmount != null)
            {
                if (IsDecimal(KeptAmount) == false)
                {
                    MsgList.Add("Kept Amount Not Valid");
                }
            }
            if (KeptAmount2 != null)
            {
                if (IsDecimal(KeptAmount2) == false)
                {
                    MsgList.Add("Kept Amount Not Valid");
                }
            }
            if (KeptAmount3 != null)
            {
                if (IsDecimal(KeptAmount3) == false)
                {
                    MsgList.Add("Kept Amount Not Valid");
                }
            }


            if (MsgList.Count() > 0)
            {
                ViewBag.Msg = MsgList;

            }
            else
            {
                int res = _enty.PCR_PCRHistoryUpdate(DCRID, DomainID, Convert.ToInt16(MembersID), AccountID
                       , Convert.ToByte(ConnectionTypeID), Convert.ToByte(ConnectionResultID), CustomerPhone
                       , Convert.ToByte(PTPTypeID), Convert.ToDateTime(ConnectionDate), Convert.ToDateTime(PTPDate)
                       , Convert.ToDecimal(PTPAmount), Convert.ToBoolean(Promise), Convert.ToDecimal(KeptAmount), EngComment, ArabComment
                       , Convert.ToByte(PTPTypeID2), Convert.ToDateTime(PTPDate2), Convert.ToDecimal(PTPAmount2)
                        , Convert.ToByte(PTPTypeID3), Convert.ToDateTime(PTPDate3), Convert.ToDecimal(PTPAmount3)
                        , Convert.ToDateTime(KeptDate)
                        , Convert.ToBoolean(IsPromiseKept2), Convert.ToDateTime(KeptDate2), Convert.ToDecimal(KeptAmount2)
                        , Convert.ToBoolean(IsPromiseKept3), Convert.ToDateTime(KeptDate3), Convert.ToDecimal(KeptAmount3)
                        , Convert.ToByte(Code2ID)
                        , Convert.ToByte(ReachedID), Convert.ToByte(ReachedCommentsID), Convert.ToByte(UnReachedCommentsID));
                if (res > 0)
                {
                    ViewBag.saved = "DCR Saved Successfully";
                }
                else
                {
                    ViewBag.saved = "Invalid data entry!";
                }

            }
            //}
            //else
            //{
            //    ViewBag.error = "Enter All Required Data";
            //}
            return PartialView("_Result");
        }
        public ActionResult GetDomainDCRHistory(FormCollection frm)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("MY DCRs", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
            {
                if (frm["DomainID"].Length > 0)
                {
                    long DomainID = Convert.ToInt64(frm["DomainID"]);
                    var data = _enty.PCR_PCRHistoryList.Where(q => q.DomainID == DomainID).Select(q => q).Distinct().ToList();

                    if (data.Count > 0)
                    {
                        ViewBag.Data = data;
                        if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                            ViewBag.AccessRightEdit = true;
                        if (AccessRights.Contains("All") || AccessRights.Contains("Delete"))
                            ViewBag.AccessRightDelte = true;
                    }

                }
                return PartialView("_CollectionDomainDCR");
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult DeleteDCR(long id, long DomainID)
        {
            var Rec = _enty.PCR_PCRHistory.Find(id);
            if (Rec != null)
            {
                _enty.Entry(Rec).State = System.Data.Entity.EntityState.Deleted;
                _enty.SaveChanges();
            }

            var data = _enty.PCR_PCRHistoryList.Where(q => q.DomainID == DomainID).Select(q => q).ToList();

            if (data.Count > 0)
            {
                ViewBag.Data = data;
            }

            return PartialView("_CollectionDomainDCR");

        }

        #region GetDCRReportByDomain
        public ActionResult DCRDomainReport()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("DCR Domain Report", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        ViewBag.myinfo = myinformationonly;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }

                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult GetDCRReportByDomain(FormCollection frm)
        {
            if (frm["DomainID"].Length > 0)
            {
                long DomainID = Convert.ToInt64(frm["DomainID"]);
                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DCR_MemberDCRSummarySP";

                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.Tbl = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }

                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DCR_MemberDCRSummaryTotalSP";

                    cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.TblTotal = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return PartialView("_CollectionDCRReport");

        }
        #endregion

        #region GetDCRReportByDomainAndType
        public ActionResult DCRReportAllDomain()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("DCR By Type Report", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions)
                    {
                        if (myinformationonly == true)
                        {
                            int userid = int.Parse(Session["ID"].ToString());
                            List<int?> DomainScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s.TypeID).ToList();
                            string DomainIDs = DomainScope.Count() > 0 ? string.Join(",", DomainScope) : "";
                            ViewBag.myinfo = myinformationonly; ViewBag.DomainIDs = DomainIDs;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult GetDCRReportByDomainAndType(FormCollection frm)
        {
            if (frm["DomainType"].Length > 0)
            {
                string DomainType = frm["DomainType"];
                bool IsOpenedDomain = Convert.ToBoolean(frm["IsOpenedDomain"]);
                if (IsOpenedDomain)
                {
                    #region IsOpenedDomain
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (DomainType != "All")
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByOpenDomainSP";

                            cmd.Parameters.Add(new SqlParameter("@DomainType", DomainType));
                        }
                        else
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByOpenDomainBothTypeSP";
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.Tbl = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (DomainType != "All")
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByOpenDomainTotalSP";

                            cmd.Parameters.Add(new SqlParameter("@DomainType", DomainType));
                        }
                        else
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByOpenDomainBothTypeTotalSP";
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.TblTotal = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    #endregion
                }
                else
                {
                    #region !IsOpenedDomain
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (DomainType != "All")
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByAllDomainSP";

                            cmd.Parameters.Add(new SqlParameter("@DomainType", DomainType));
                        }
                        else
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByAllDomainBothTypeSP";
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.Tbl = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }

                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (DomainType != "All")
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByAllDomainTotalSP";

                            cmd.Parameters.Add(new SqlParameter("@DomainType", DomainType));
                        }
                        else
                        {
                            cmd.CommandText = "DCR_MemberDCRSummaryByAllDomainBothTypeTotalSP";
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            var model = Read(reader).ToList();
                            if (model.Count() > 0)
                            {
                                ViewBag.TblTotal = model;
                            }
                        }
                        _enty.Database.Connection.Close();
                    }
                    #endregion

                }
            }
            return PartialView("_CollectionDCRReport");

        }
        #endregion

        #region GetDCRReportByAgency
        public ActionResult DCRReportByAgency()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("DCR By Banks", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        if (myinformationonly == true)
                        {
                            int userid = int.Parse(Session["ID"].ToString());
                            List<int?> BanksScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s.BankID).ToList();
                            string BankIDs = BanksScope.Count() > 0 ? string.Join(",", BanksScope) : "";
                            ViewBag.myinfo = myinformationonly; ViewBag.BankIDs = BankIDs;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult GetDCRReportByAgency(FormCollection frm)
        {
            if (frm["AgencyID"].Length > 0)
            {
                long AgencyID = Convert.ToInt64(frm["AgencyID"]);
                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DCR_MemberDCRSummaryByAgencySP";

                    cmd.Parameters.Add(new SqlParameter("@AgencyID", AgencyID));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.Tbl = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }
                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DCR_MemberDCRSummaryByAgencyTotalSP";

                    cmd.Parameters.Add(new SqlParameter("@AgencyID", AgencyID));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.TblTotal = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return PartialView("_CollectionDCRReport");
        }
        #endregion

        #region GetDCRReportByBranch
        public ActionResult DCRReportByBranch()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    List<string> AccessRights = new List<string>();
                    bool? myinformationonly;
                    bool haspermissions = Authentication.CheckPermissions("DCR By Branch", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                    if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                    {
                        if (myinformationonly == true)
                        {
                            int userid = int.Parse(Session["ID"].ToString());
                            string BranchIDs = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s.BranchIDs).FirstOrDefault();
                            ViewBag.myinfo = myinformationonly; ViewBag.BranchIDs = BranchIDs;
                        }
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Forbidden", "Account", new
                        {
                            area = ""
                        });
                    }
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult GetDCRReportByBranch(FormCollection frm)
        {
            if (frm["BranchID"].Length > 0)
            {
                long BranchID = Convert.ToInt64(frm["BranchID"]);
                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DCR_MemberDCRSummaryByBranchSP";

                    cmd.Parameters.Add(new SqlParameter("@BranchID", BranchID));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.Tbl = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }
                using (var cmd = _enty.Database.Connection.CreateCommand())
                {
                    _enty.Database.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "DCR_MemberDCRSummaryByBranchTotalSP";

                    cmd.Parameters.Add(new SqlParameter("@BranchID", BranchID));

                    using (var reader = cmd.ExecuteReader())
                    {
                        var model = Read(reader).ToList();
                        if (model.Count() > 0)
                        {
                            ViewBag.TblTotal = model;
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            return PartialView("_CollectionDCRReport");
        }
        #endregion
        #endregion

        #region Methods
        private bool Permission()
        {
            bool Allow = false;
            int ReciverID = Convert.ToInt16(Session["ID"]);
            Allow = true;
            return Allow;
        }

        private void AfterLogin()
        {
            int UserID = Convert.ToInt16(Session["ID"]);
            int SectionID = Convert.ToInt16(Session["SectionID"]);
            List<byte> SectionIDs = _enty.Pre_SectionPermissions.Where(q => q.UserID == UserID).Select(q => q.SectionID).ToList();

            //Session["Menu"] = _enty.Design_MenuBasic.Where(s => SectionIDs.Contains(s.SectionID) && s.IsDeleted == false).ToList().OrderBy(q => q.DisplayID);
            Session["Menu"] = _enty.Design_MenuBasic.Where(s => s.SectionID == SectionID && s.IsDeleted == false).ToList().OrderBy(q => q.DisplayID);

        }

        private bool IsDecimal(string S)
        {
            decimal d;
            if (decimal.TryParse(S, out d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string SaveExcel(byte[] file, string Title)
        {
            try
            {
                Stream stream = new MemoryStream(file);
                string ToSavePath = Server.MapPath(url + "/Content/Doc/Temp/");

                Random random = new Random();
                char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890".ToCharArray();
                string rand = Enumerable
                            .Range(1, 5) // for(i.. ) 
                            .Select(k => keys[random.Next(0, keys.Length - 1)])  // generate a new random char 
                            .Aggregate("", (e, c) => e + c); // join into a string

                Title = Title.Replace(" ", "_");
                string finalName = Title + rand + ".xlsx";
                var path = Path.Combine(ToSavePath, finalName);

                if (System.IO.File.Exists(Path.Combine(Title, finalName)))

                { System.IO.File.Delete(Path.Combine(Title, finalName)); }

                if (!System.IO.File.Exists(Path.Combine(Title, finalName)))
                {

                    using (var fileStream = System.IO.File.Create(path))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                return path;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public string ExportToExcel(List<Dictionary<string, object>> read, string FileName)
        {
            DataTable dt = new DataTable();

            foreach (var R in read.FirstOrDefault())
            {
                dt.Columns.Add(R.Key, typeof(string));
            }


            foreach (var R in read)
            {
                DataRow row = dt.NewRow();

                foreach (var column in R)
                {
                    if (column.Key.Contains("Date"))
                        row[column.Key] = Convert.ToDateTime(column.Value).ToString("dd/MM/yyyy");
                    else
                        row[column.Key] = column.Value;

                }
                dt.Rows.Add(row);
            }


            var gv = new GridView();
            gv.DataSource = dt;
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;

            Response.AddHeader("content-disposition", "attachment;filename=" + FileName + ".xls");

            Response.ContentType = "application/vnd.xls";

            Response.ContentEncoding = System.Text.Encoding.Unicode;
            Response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());

            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
            gv.RenderControl(objHtmlTextWriter);
            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();
            return objStringWriter.ToString();
        }

        public void UploadExcel(string pathToExcelFile, string filename, byte SchemaID, int DomainID, string SheetName, int VersionNumber)
        {

            List<string> data = new List<string>();

            var connectionString = "";

            connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", pathToExcelFile);

            var adapter = new OleDbDataAdapter("SELECT * FROM [" + SheetName + "$]", connectionString);//[Sheet1$]
            var ds = new DataSet();

            adapter.Fill(ds, "ExcelTable");

            DataTable dtable = ds.Tables["ExcelTable"];


            //Install-Package LinqToExcel -Version 1.11.0 (nuget)
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            List<string> FailureRows = new List<string>();
            int countOfSuccess = 0;
            int countOfFailure = 0;
            int NumberOfColOfExcel = dtable.Columns.Count;
            int? NumberOfColOfSchema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).OrderByDescending(q => q.Value).FirstOrDefault();
            if (NumberOfColOfExcel >= NumberOfColOfSchema)
            {
                try
                {
                    var artistAlbums = from a in excelFile.Worksheet() select a;

                    //create insert statment
                    for (int j = 0; j < dtable.Rows.Count; j++)
                    {
                        string sql = "insert into Dom_DomainsDataExtra (SchemaID,DomainID,VersionNumber";
                        //columns
                        for (int i = 1; i <= dtable.Columns.Count; i++)
                        {
                            sql = sql + ",Col" + i;
                        }
                        //values
                        sql = sql + ") values(" + SchemaID + " , " + DomainID + " , " + VersionNumber + "";

                        for (int i = 0; i < dtable.Columns.Count; i++)
                        {
                            sql = sql + ",N'" + dtable.Rows[j][i].ToString().Trim().Replace("'", "''") + "'";
                        }

                        sql = sql + ")";
                        int result2 = _enty.Database.ExecuteSqlCommand(String.Format(sql));
                        //get result summary
                        if (result2 > 0)
                        {
                            countOfSuccess++;
                        }
                        else
                        {
                            countOfFailure++;
                            FailureRows.Add("Row : " + j + 1);
                        }
                        ViewBag.RowsSuccess = countOfSuccess;
                        ViewBag.RowsFailure = countOfFailure;

                    }
                    if (FailureRows.Count > 0)
                    {
                        ViewBag.FailureRowsSummary = FailureRows;
                    }
                    else
                    {
                        for (int i = 1; i <= dtable.Columns.Count; i++)
                        {
                            Dom_DomainColumnsAlias rec = new Dom_DomainColumnsAlias();
                            rec.AliasName = dtable.Columns[i - 1].ColumnName;
                            rec.ColumnName = "Col" + i;
                            rec.VersionNumber = Convert.ToByte(VersionNumber);
                            rec.DomainID = DomainID;
                            _enty.Entry(rec).State = System.Data.Entity.EntityState.Added;
                            _enty.SaveChanges();
                        }
                    }


                }
                catch (Exception)
                {

                    ViewBag.error = "Error In Upload";
                }
            }
            else
            {
                ViewBag.error = "Number Of Columns Not Fit Number Of Schema Columns";
            }




        }

        public void UploadUpdateExcel(string pathToExcelFile, string filename, byte SchemaID, int DomainID, string SheetName, int VersionNumber)
        {

            List<string> data = new List<string>();

            var connectionString = "";

            connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", pathToExcelFile);

            var adapter = new OleDbDataAdapter("SELECT * FROM [" + SheetName + "$]", connectionString);//[Sheet1$]
            var ds = new DataSet();

            adapter.Fill(ds, "ExcelTable");

            DataTable dtable = ds.Tables["ExcelTable"];


            //Install-Package LinqToExcel -Version 1.11.0 (nuget)
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            List<string> FailureRows = new List<string>();
            int countOfSuccess = 0;
            int countOfFailure = 0;
            int NumberOfColOfExcel = dtable.Columns.Count;
            int? NumberOfColOfSchema = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).OrderByDescending(q => q.Value).FirstOrDefault();
            if (NumberOfColOfExcel >= NumberOfColOfSchema)
            {
                try
                {
                    ////Prepear before update SP
                    //int res = _enty.Dom_PrepearingBeforeUpdateDomain(DomainID);
                    //if (res>0)
                    //{

                    //}
                    var artistAlbums = from a in excelFile.Worksheet() select a;
                    #region Insert

                    //create insert statment
                    for (int j = 0; j < dtable.Rows.Count; j++)
                    {
                        string sql = "insert into Dom_DomainsDataExtra (SchemaID,DomainID,VersionNumber";
                        //columns
                        for (int i = 1; i <= dtable.Columns.Count; i++)
                        {
                            sql = sql + ",Col" + i;
                        }
                        //values
                        sql = sql + ") values(" + SchemaID + " , " + DomainID + " , " + VersionNumber + "";

                        for (int i = 0; i < dtable.Columns.Count; i++)
                        {
                            sql = sql + ",N'" + dtable.Rows[j][i].ToString().Trim().Replace("'", "''") + "'";
                        }

                        sql = sql + ")";
                        int result2 = _enty.Database.ExecuteSqlCommand(String.Format(sql));
                        //get result summary
                        if (result2 > 0)
                        {
                            countOfSuccess++;
                        }
                        else
                        {
                            countOfFailure++;
                            FailureRows.Add("Row : " + j + 1);
                        }
                        ViewBag.RowsSuccess = countOfSuccess;
                        ViewBag.RowsFailure = countOfFailure;

                    }
                    if (FailureRows.Count > 0)
                    {
                        ViewBag.FailureRowsSummary = FailureRows;
                    }
                    else
                    {
                        for (int i = 1; i <= dtable.Columns.Count; i++)
                        {
                            Dom_DomainColumnsAlias rec = new Dom_DomainColumnsAlias();
                            rec.AliasName = dtable.Columns[i - 1].ColumnName;
                            rec.ColumnName = "Col" + i;
                            rec.VersionNumber = Convert.ToByte(VersionNumber);
                            rec.DomainID = DomainID;
                            _enty.Entry(rec).State = System.Data.Entity.EntityState.Added;
                            _enty.SaveChanges();
                        }
                    }
                    #endregion

                }
                catch (Exception)
                {

                    ViewBag.error = "Error In Upload";
                }
            }
            else
            {
                ViewBag.error = "Number Of Columns Not Fit Number Of Schema Columns";
            }




        }

        public List<Dictionary<string, object>> Read(DbDataReader reader)
        {
            List<Dictionary<string, object>> expandolist = new List<Dictionary<string, object>>();
            foreach (var item in reader)
            {
                IDictionary<string, object> expando = new ExpandoObject();
                foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(item))
                {
                    var obj = propertyDescriptor.GetValue(item);
                    expando.Add(propertyDescriptor.Name, obj);
                }
                expandolist.Add(new Dictionary<string, object>(expando));
            }
            return expandolist;
        }

        public void Finance(long DomainID, byte? SchemaID, string PK, string PDCol, string BalanceCol)
        {

            if (SchemaID != null)
            {

            }
            else
            {
                ViewBag.error = "No Schema Available ";
            }

            #region count
            //count
            try
            {
                ViewBag.RowsCount = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).ToList().Count();
            }
            catch (Exception ex)
            {
                ViewBag.RowsCountError = ex.Message.ToString();
            }
            //count
            try
            {
                ViewBag.PrevRowsCount = _enty.Dom_DomainDetailsListPrev.Where(q => q.DomainID == DomainID).Select(q => q).ToList().Count();
            }
            catch (Exception ex)
            {
                ViewBag.PrevRowsCountError = ex.Message.ToString();
            }
            #endregion


            #region Balance - Past Due
            using (var cmd = _enty.Database.Connection.CreateCommand())
            {
                _enty.Database.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Dom_GetDynamicColumnToRecoredsSummary";

                cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                cmd.Parameters.Add(new SqlParameter("@PK", PK));
                cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                using (var reader = cmd.ExecuteReader())
                {
                    var model = Read(reader).ToList();
                    if (model.Count() > 0)
                    {
                        ViewBag.RecoredsSummary = model;
                    }
                }
                _enty.Database.Connection.Close();
            }
            #endregion

            if (ViewBag.RecoredsSummary != null)
            {
                #region Bucket table
                //CurrentBucket table
                try
                {
                    int? BucketColNullable = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Bucket").Select(q => q.ColumnIndex).FirstOrDefault();
                    if (BucketColNullable != null)
                    {
                        //current
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumnToCurrentBucket";

                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@BuckectCol", "Col" + BucketColNullable));
                            cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                            cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                            using (var reader = cmd.ExecuteReader())
                            {
                                var model = Read(reader).ToList();
                                if (model.Count() > 0)
                                {
                                    ViewBag.CurrentBucket = model;
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                        //prev
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumnToPrevBucket";

                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@BuckectCol", "Col" + BucketColNullable));
                            cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                            cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                            using (var reader = cmd.ExecuteReader())
                            {
                                var model = Read(reader).ToList();
                                if (model.Count() > 0)
                                {
                                    ViewBag.PrevBucket = model;
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                        #region Diff Bucket
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumnToBucketDiff";

                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@PK", PK));
                            cmd.Parameters.Add(new SqlParameter("@BuckectCol", "Col" + BucketColNullable));
                            cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                            cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                            using (var reader = cmd.ExecuteReader())
                            {
                                var model = Read(reader).ToList();
                                if (model.Count() > 0)
                                {
                                    ViewBag.BucketDiff = model;
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                        #endregion
                    }
                    else
                    {
                        ViewBag.CurrentBucketWarning = "Not Applied";
                    }

                }
                catch (Exception ex)
                {

                    ViewBag.CurrentBucketError = ex.Message.ToString();
                }
                #endregion

                #region Cycle table

                try
                {
                    int? CycleColNullable = _enty.Sch_SchemaColList.Where(q => q.SchemaID == SchemaID && q.ColumnName == "Cycle").Select(q => q.ColumnIndex).FirstOrDefault();
                    if (CycleColNullable != null)
                    {
                        //current
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumnToCurrentCycle";

                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@CycleCol", "Col" + CycleColNullable));
                            cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                            cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                            using (var reader = cmd.ExecuteReader())
                            {
                                var model = Read(reader).ToList();
                                if (model.Count() > 0)
                                {
                                    ViewBag.CurrentCycle = model;
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                        //Prev
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumnToPrevCycle";

                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@CycleCol", "Col" + CycleColNullable));
                            cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                            cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                            using (var reader = cmd.ExecuteReader())
                            {
                                var model = Read(reader).ToList();
                                if (model.Count() > 0)
                                {
                                    ViewBag.PrevCycle = model;
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                        #region Diff Cycle
                        using (var cmd = _enty.Database.Connection.CreateCommand())
                        {
                            _enty.Database.Connection.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.CommandText = "Dom_GetDynamicColumnToCycleDiff";

                            cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                            cmd.Parameters.Add(new SqlParameter("@PK", PK));
                            cmd.Parameters.Add(new SqlParameter("@CycleCol", "Col" + CycleColNullable));
                            cmd.Parameters.Add(new SqlParameter("@PDCol", PDCol));
                            cmd.Parameters.Add(new SqlParameter("@BalanceCol", BalanceCol));

                            using (var reader = cmd.ExecuteReader())
                            {
                                var model = Read(reader).ToList();
                                if (model.Count() > 0)
                                {
                                    ViewBag.CycleDiff = model;
                                }
                            }
                            _enty.Database.Connection.Close();
                        }
                        #endregion
                    }
                    else
                    {
                        ViewBag.CurrentCycleWarning = "Not Applied";
                    }

                }
                catch (Exception ex)
                {

                    ViewBag.CurrentCycleError = ex.Message.ToString();
                }
                #endregion

            }
        }

        public ActionResult addPartial(long id, int VersionNumber, int Count)
        {
            var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == id && q.VersionNumber == VersionNumber).Select(q => q).ToList();
            ViewBag.alias = alias;
            ViewBag.Count = Count;
            return PartialView("_CollectionAddNewFilter");
        }
        public List<DomainsPerUserScope> CheckSheetDataScope(bool? MyInfoOnly, string UserId = "")
        {
            List<DomainsPerUserScope> Data = new List<Models.DomainsPerUserScope>();
            if (MyInfoOnly == true)
            {
                // gat user data scope   
                int userid = !string.IsNullOrEmpty(UserId) ? int.Parse(UserId) : int.Parse(Session["ID"].ToString());
                List<int> BranchIds = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s.BranchIDs).FirstOrDefault().Split(',').ToList().ConvertAll(int.Parse);
                var UserScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s).ToList();
                List<int?> BankIds = UserScope.Select(s => s.BankID).ToList();
                var y = _enty.Domain_DataScope.ToList();
                var UserData = _enty.Domain_DataScope.Where(a => BankIds.Contains(a.AgencyID) && BranchIds.Contains(a.BranchID) && a.SuccessDomain == true && a.ISHIDEN != true).Select(s => s).ToList();
                foreach (var Scopeitem in UserScope)
                {
                    var _bankUserData = UserData.Where(a => a.AgencyID == Scopeitem.BankID).Select(s => s).ToList();
                    // filtering user data depends on 1- domain type 2- products 3- regions 
                    if (Scopeitem.TypeID != -1)
                    {
                        // this user didn't have scope to see all types 
                        _bankUserData = _bankUserData.Where(a => a.AgencyID == Scopeitem.BankID && a.DomainTypeID == Scopeitem.TypeID).Select(s => s).ToList();
                    }
                    if (Scopeitem.ProductID != -1)
                    {
                        // this user didn't have scope to see all products
                        _bankUserData = _bankUserData.Where(a => a.AgencyID == Scopeitem.BankID && a.ProductID == Scopeitem.ProductID).Select(s => s).ToList();
                    }
                    List<int> RegionIds = new List<int>();
                    RegionIds.AddRange(Scopeitem.RegionID.Split(',').ToList().ConvertAll(int.Parse));
                    if (!RegionIds.Contains(0))
                    {
                        // this user didn't have scope to see all Regions
                        _bankUserData = _bankUserData.Where(a => a.AgencyID == Scopeitem.BankID && RegionIds.Contains(a.RegionID)).Select(s => s).ToList();
                    }
                    List<long> DomainIds = _bankUserData.Select(s => s.DomainID).Distinct().ToList();
                    if (DomainIds.Count() > 0)
                    {
                        if (DomainIds.Count() < 2000)
                        {
                            // this check to avoid problems of contains query
                            Data.AddRange(_enty.DomainsPerUserScopes.Where(a => DomainIds.Contains(a.DomainID)).Select(s => s).ToList());
                        }
                        else
                        {
                            // code will reach here only if larg number of domains
                            List<long> tempdomainids = new List<long>();
                            int skip = 0;
                            do
                            {
                                tempdomainids = DomainIds.Skip(skip).Take(1000).ToList();
                                skip = skip + 1000;
                                if (tempdomainids.Count() > 0)
                                {
                                    Data.AddRange(_enty.DomainsPerUserScopes.Where(a => tempdomainids.Contains(a.DomainID)).Select(s => s).ToList());
                                }

                            } while (tempdomainids.Count() > 0);

                        }
                    }
                }
            }
            else
            {
                Data = _enty.DomainsPerUserScopes.Select(s => s).ToList();
            }
            return Data;
        }
        public List<DomainsWithPayment> _CheckSheetDataScope(bool? MyInfoOnly, string UserId = "")
        {
            UserId = UserId == "" ? Session["ID"].ToString() : UserId;
            List<DomainsWithPayment> Data = new List<Models.DomainsWithPayment>();
            if (MyInfoOnly == false)
            {
                try
                {
                    Data = _enty.DomainsWithPayments.Where(a => a.ISHIDEN != true).Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                }
                catch (Exception ex)
                {
                    InsertExcptionLog("CheckSheetDataScope : " + ex.Message, int.Parse(UserId));
                }
            }
            else
            {
                try
                {
                    int userid;
                    userid = !string.IsNullOrEmpty(UserId) ? int.Parse(UserId) : int.Parse(Session["ID"].ToString());
                    var user = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s).FirstOrDefault();
                    var DataScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s).ToList();
                    var AllData = _enty.DomainsWithPayments.Where(a => a.ISHIDEN != true).Select(q => q).OrderBy(q => q.StatusID).OrderByDescending(q => q.MonthID).ToList();
                    var BranchLst = user.BranchIDs.Split(',').ToList().ConvertAll(int.Parse);
                    var AgancyLst = DataScope.Select(s => s.BankID).ToList();
                    AllData = AllData.Where(a => AgancyLst.Contains(a.AgencyID) && BranchLst.Contains(a.BranchID)).ToList();
                    //InsertExcptionLog("CheckSheetDataScope : MyInfoOnly : true , All Data count  : " + Data.Count);
                    if (DataScope.Count() > 0 && !string.IsNullOrEmpty(user.BranchIDs))
                    {

                        foreach (var dataitem in AllData)
                        {
                            foreach (var scopeitem in DataScope)
                            {
                                if (dataitem.AgencyID == scopeitem.BankID && BranchLst.Contains(dataitem.BranchID))
                                {
                                    var Result = CheckDataScope(int.Parse(dataitem.DomainID.ToString()), int.Parse(scopeitem.ProductID.ToString()), int.Parse(scopeitem.TypeID.ToString()), scopeitem.RegionID);
                                    if (Result > 0)
                                    {
                                        Data.Add(dataitem);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    Data = Data.Select(s => s).Distinct().ToList();
                }
                catch (Exception ex)
                {
                    ExceptionLog exp = new Models.ExceptionLog();
                    exp.Meassage = "CheckSheetDataScope :" + ex.Message;
                    exp.Date = DateTime.Now;
                    _enty.ExceptionLogs.Add(exp);
                    _enty.SaveChanges();
                    Data = null;
                }
            }
            return Data;
        }
        public int CheckDataScope(int DomainID, int ProductID, int TypeID, string RegionIDs)
        {
            List<Dictionary<string, object>> model = new List<Dictionary<string, object>>();
            int count = 0;
            try
            {
                string product = ""; string Type = ""; string Regions = ""; string Cities = "";
                //GetUserScopeNmaes(ProductID, TypeID, RegionIDs, ref product, ref Type, ref Regions , ref Cities);
                var data = _enty.Dom_DomainDetailsList.Where(q => q.DomainID == DomainID).Select(q => q).ToList();

                if (data.Count > 0)
                {
                    var VersionNumber = data.FirstOrDefault().VersionNumber;

                    var alias = _enty.Dom_DomainColumnsAlias.Where(q => q.DomainID == DomainID && q.VersionNumber == VersionNumber).Select(q => q).ToList();

                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "Dom_GetDynamicColumn";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            List = List + "," + i;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                        cmd.Parameters.Add(new SqlParameter("@product", product));
                        cmd.Parameters.Add(new SqlParameter("@domainttype", Type));
                        cmd.Parameters.Add(new SqlParameter("@regions", Regions));
                        cmd.Parameters.Add(new SqlParameter("@cities", Cities));
                        cmd.Parameters.Add(new SqlParameter("@myinfoonly", true));
                        using (var reader = cmd.ExecuteReader())
                        {
                            count = Read(reader).Count();
                        }
                    }
                    _enty.Database.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                InsertExcptionLog(ex.Message, int.Parse(Session["ID"].ToString()));

            }
            return count;
        }
        public void InsertExcptionLog(string msg, int userid)
        {
            // int userid = int.Parse(Session["ID"].ToString());
            var username = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s.UserName).FirstOrDefault();
            msg += " by : " + username;
            ExceptionLog exp = new Models.ExceptionLog();
            exp.Meassage = msg;
            exp.Date = DateTime.Now;
            _enty.ExceptionLogs.Add(exp);
            _enty.SaveChanges();
        }
        public void GetUserScopeNmaes(int ProductID, int TypeID, string RegionIDs, string CityIDs, ref string product, ref string Type, ref string Regions, ref string Cities)
        {
            if (ProductID != -1)
            {
                product = _enty.Products.Where(a => a.ProductId == ProductID).Select(s => s.ProductName).FirstOrDefault();
            }
            else        // All Products
            {
                var AllProducts = _enty.Products.Select(s => s.ProductName).ToList();
                product = string.Join(",", AllProducts.ToArray());
                //for (var i = 0; i < AllProducts.Count(); i++)
                //{
                //    if (i == 0)
                //    {
                //        product += AllProducts[i];
                //    }
                //    else if (i == AllProducts.Count() - 1)
                //    {
                //        product += "','" + AllProducts[i];
                //    }
                //    else
                //    {
                //        product += "','" + AllProducts[i];
                //    }
                //}
            }
            if (TypeID != -1)
            {
                Type = _enty.Types.Where(a => a.DomainId == TypeID).Select(s => s.DomainName).FirstOrDefault();
            }
            else                                       // All Domain Types
            {
                var AllTypes = _enty.Types.Select(s => s.DomainName).ToList();
                Type = string.Join(",", AllTypes.ToArray());
                //for (var i = 0; i < AllTypes.Count(); i++)
                //{
                //    if (i == 0)
                //    {
                //        Type += AllTypes[i];
                //    }
                //    else if (i == AllTypes.Count() - 1)
                //    {
                //        Type += "','" + AllTypes[i];
                //    }
                //    else
                //    {
                //        Type += "','" + AllTypes[i];
                //    }
                //}
            }
            var RegionIdLst = RegionIDs.Split(',').ToList().ConvertAll(int.Parse);
            if (!RegionIdLst.Contains(0))
            {
                var RegionLst = _enty.Regions.Where(a => RegionIdLst.Contains(a.RegionId)).Select(s => s.RegionName).ToList();
                Regions = string.Join(",", RegionLst.ToArray());
                //for (var i = 0; i < RegionLst.Count(); i++)
                //{
                //    if (i == 0)
                //    {
                //        Regions += RegionLst[i];
                //    }
                //    else if (i == RegionLst.Count() - 1)
                //    {
                //        Regions += "','" + RegionLst[i];
                //    }
                //    else
                //    {
                //        Regions += "','" + RegionLst[i];
                //    }
                //}
            }
            else                                              // All Regions
            {
                var RegionLst = _enty.Regions.Select(s => s.RegionName).ToList();
                Regions = string.Join(",", RegionLst.ToArray());
                //for (var i = 0; i < RegionLst.Count(); i++)
                //{
                //    if (i == 0)
                //    {
                //        Regions += RegionLst[i];
                //    }
                //    else if (i == RegionLst.Count() - 1)
                //    {
                //        Regions += "','" + RegionLst[i];
                //    }
                //    else
                //    {
                //        Regions += "','" + RegionLst[i];
                //    }
                //}
            }
            var CityIdLst = !string.IsNullOrEmpty(CityIDs) ? CityIDs.Split(',').ToList().ConvertAll(int.Parse) : new List<int>();
            if (CityIdLst.Count() > 0 && !CityIdLst.Contains(0))
            {
                var CityLst = _enty.Cities.Where(a => CityIdLst.Contains(a.CityId)).Select(s => s.CityName).ToList();
                Cities = string.Join(",", CityLst.ToArray());
                //for (var i = 0; i < CityLst.Count(); i++)
                //{
                //    if (i == 0)
                //    {
                //        Cities += CityLst[i];
                //    }
                //    else if (i == CityLst.Count() - 1)
                //    {
                //        Cities += "','" + CityLst[i];
                //    }
                //    else
                //    {
                //        Cities += "','" + CityLst[i];
                //    }
                //}
            }
            else
            {
                // all cities
                Cities = "0";
            }
        }
        #endregion
        public ActionResult GetDomainReportbyTeamLeader(int DomainID)
        {
            List<DomainReoprtbyTeamLeader> result = new List<DomainReoprtbyTeamLeader>();
            var schemaID = _enty.Dom_DomainsDataExtra.Where(a => a.DomainID == DomainID).Select(s => s.SchemaID).FirstOrDefault();
            var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
            var NameIndex = schema.Where(a => a.ColumnName == "Team Leader").Select(s => s.ColumnIndex).FirstOrDefault();
            var CustNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
            var ProductIndex = schema.Where(a => a.ColumnName == "Product").Select(s => s.ColumnIndex).FirstOrDefault();
            var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
            var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
            var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();
            if (NameIndex != null && CustNameIndex != null && ProductIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
            {
                string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                string Querystring = "select  dx.Col" + NameIndex +
                    " TeamLeaderName, dx.Col" + ProductIndex + " Product , dx.Col" + DomainTypeIndex + " DomainType ,SUM (ap.PaymentValue) Payment , COUNT(ap.PaymentValue) PaymentCount ,COUNT(dx.Col" + CustNameIndex + ") CountofCustomers , SUM(ISNULL(CAST(dx.Col" + BalanceIndex + " AS float),0)) Balance , SUM(ISNULL(CAST(dx.Col" + PastdueIndex + " AS float),0)) PastDue from Dom_DomainList dl left join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial where dl.DomainID =" + DomainID + " and dx.Col" + NameIndex + " != ''"
                    + " group by dl.DomainID , dx.Col" + NameIndex + " , dx.Col" + DomainTypeIndex + " , dx.Col" + ProductIndex;
                SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "TeamLaderTable");
                DataTable dtable = ds.Tables["TeamLaderTable"];
                result = dtable.AsEnumerable().Select(s => new DomainReoprtbyTeamLeader
                {
                    TeamLeaderName = s.Field<string>("TeamLeaderName"),
                    DomainType = s.Field<string>("DomainType"),
                    Product = s.Field<string>("Product"),
                    CountOfCustomers = s.Field<int>("CountofCustomers"),
                    CountOfPayment = s.Field<int>("PaymentCount"),
                    Payment = string.Format("{0:N0}", s.Field<decimal?>("Payment")),
                    Balance = string.Format("{0:N0}", s.Field<double>("Balance")),
                    PastDue = string.Format("{0:N0}", s.Field<double>("PastDue"))
                }).ToList();
            }
            if (result.Count() > 0)
            {
                ViewBag.TeamLeaderReport = result;
            }
            else
            {
                ViewBag.TeamLeaderReportwarning = "Not Applied";
            }
            return PartialView("_CollectionTeamLeaderReport");
        }

        //report3
        public ActionResult GetPayment(string domainType = "", int type = 1, List<int> months = null, List<int> years = null, List<string> bankNames = null)
        {
            List<PaymentReport> result = new List<PaymentReport>();
            List<SelectListItem> YearsList = new List<SelectListItem>();
            List<SelectListItem> MonthsLists = new List<SelectListItem>();
            ViewBag.domainType = domainType;
            var num = 0.0;
            if (domainType == "")
            {
                ViewBag.domainType = "all";
            }
            ViewBag.BankLists = GetAllBankNames();

            var bankNameFilter = "";

            if (bankNames != null)
            {
                bankNameFilter = " and(dl.AgencyTitle = '" + bankNames[0] + "'";
                for (var index = 1; index < bankNames.Count; index++)
                {
                    bankNameFilter += " or dl.AgencyTitle= '" + bankNames[index] + "'";
                }

                bankNameFilter += ")";
            }


            var filter = "";
            if (domainType == "active")
            {
                ViewBag.paymentList = ((List<PaymentReport>)TempData["AllData"]).Where(c => c.DomainType.ToLower() == "active").ToList();
                ViewBag.type = type;
                return PartialView("_ReportPaymentList");
            }

            else if (domainType == "w/o")
            {
                ViewBag.paymentList = ((List<PaymentReport>)TempData["AllData"]).Where(c => c.DomainType.ToLower() == "w/o").ToList();
                ViewBag.type = type;
                return PartialView("_ReportPaymentList");
            }


            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;



            if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
            {
                filter = "and(ap.PaymentDate like " + "'%" + years[0] + "'" + " or  dl.MonthYear like " + "'%" + years[0] + "'";

                for (var index = 1; index < years.Count; index++)
                {
                    filter += "or ap.PaymentDate like " + "'%" + years[index] + "'" + " or  dl.MonthYear like " + "'%" + years[index] + "'";
                }

                filter += ")";
            }

            else if (months != null ? months.Count > 0 : false)
            {
                filter = "and(ap.PaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'";

                for (var index = 1; index < months.Count; index++)
                {
                    filter += "or ap.PaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'";
                }

                filter += ")";
            }


            if (years == null)
            {
                return View("PaymentReportPerDomain");

            }

            if (years != null && years.Count == 1 && years[0] == 0)
            {
                return PartialView("_ReportPayment");
            }
            var domainCondation = "";

            var schemasID = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();
            foreach (var schemaID in schemasID)
            {
                var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
                var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
                var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();
                if (domainType != "")
                {
                    domainCondation = " and dx.col" + DomainTypeIndex + " = " + "'" + domainType + "'";
                }

                else
                {
                    domainCondation = "and (dx.col" + DomainTypeIndex + "='active' or " + " dx.col" + DomainTypeIndex + "='w/o' )";
                }

                if (DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
                {

                    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;


                    string Querystring = "select dl.MonthYear as DlMonthYear, dl.DomainTitle, dl.BranchTitle  BranchTitle, dl.AgencyTitle AgencyTitle,ap.PaymentDate monthyear, dx.col"
                    + DomainTypeIndex +
                        " DomainType ,SUM (ap.PaymentValue) Payment " +
                    " ,SUM(Try_Cast(dx.Col" + BalanceIndex + " AS float)) Balance " +
                          " ,SUM(Try_Cast(dx.Col" + PastdueIndex + " AS float)) PastDue "
                        +
                       " from Dom_DomainList dl  join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial"
                        + " where  dx.SchemaID=" + schemaID + domainCondation + filter + bankNameFilter
                        + " group by dl.MonthYear, dl.DomainTitle, ap.PaymentDate, BranchTitle, dl.AgencyTitle , dx.Col" + DomainTypeIndex;


                    SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "PaymentTable");
                    DataTable dtable = ds.Tables["PaymentTable"];

                    result.AddRange(dtable.AsEnumerable().Select(s => new PaymentReport()
                    {
                        Payment = s.Field<decimal?>("Payment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("Payment")),
                        Balance = s.Field<double?>("Balance") == null ? num.ToString() : string.Format("{0:N0}", s.Field<double?>("Balance")),
                        PastDue = s.Field<double?>("PastDue") == null ? num.ToString() : string.Format("{0:N0}", s.Field<double?>("PastDue")),

                        DomainType = s.Field<string>("DomainType").ToLower(),
                        AgencyTitle = s.Field<string>("AgencyTitle"),
                        BranchTitle = s.Field<string>("BranchTitle"),
                        DomainTitle = s.Field<string>("DomainTitle"),
                        MonthYear = (s.Field<string>("monthyear") != null && s.Field<string>("monthyear") != "") ?
                        (months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0]) : (months == null ? s.Field<string>("DlMonthYear").Split('-')[1] : s.Field<string>("DlMonthYear").Split('-')[0])

                    }));
                }
            }

            if (result == null)
            {
                ViewBag.PaymentReportwarning = "No Data Found.";
            }

            if (type == 1 || type == 2)
            {
                var result1 = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.AgencyTitle, c.MonthYear, c.DomainType, c.BranchTitle, c.DomainTitle }).Select(c => new PaymentReport()
                {
                    DomainType = c.Key.DomainType,
                    MonthYear = c.Key.MonthYear,
                    AgencyTitle = c.Key.AgencyTitle,
                    BranchTitle = c.Key.BranchTitle,
                    DomainTitle = c.Key.DomainTitle,
                    Payment = c.Sum(s => double.Parse(s.Payment)).ToString(),
                    PastDue = c.Sum(s => double.Parse(s.PastDue)).ToString(),
                    Balance = c.Sum(s => double.Parse(s.Balance)).ToString()
                }).ToList();
                ViewBag.paymentList = result1;
                TempData["AllData"] = result1;
            }

            else
            {

                var result1 = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.DomainType, c.AgencyTitle, c.MonthYear }).Select(c => new PaymentReport()
                {

                    MonthYear = c.Key.MonthYear,
                    AgencyTitle = c.Key.AgencyTitle,
                    DomainType = c.Key.DomainType,
                    Payment = c.Sum(s => double.Parse(s.Payment)).ToString(),
                    PastDue = c.Sum(s => double.Parse(s.PastDue)).ToString(),
                    Balance = c.Sum(s => double.Parse(s.Balance)).ToString()
                }).ToList();
                ViewBag.paymentList = result1;
                TempData["AllData"] = result1;





            }

            if (years != null)
            {
                ViewBag.type = type;
                return PartialView("_ReportPaymentList");
            }
            return View("PaymentReportPerDomain");
        }

        public ActionResult GetTeamLeadersReport(List<int> months, List<int> years, List<string> teamLeaderNames, List<int> officesId = null, List<int> type = null, List<int> caseDivision = null)
        {
            List<DomainReoprtbyTeamLeader> result = new List<DomainReoprtbyTeamLeader>();
            List<SelectListItem> YearsList = new List<SelectListItem>();
            List<SelectListItem> MonthsLists = new List<SelectListItem>();
            var officeJoin = "";
            var officeFilter = "";
            var caseDivisionJoin = "";
            var caseDivisionFilter = "";
            var teamLeaderFilter = "";
            var num = 0.0;

            if (caseDivision == null ? false : caseDivision.Count > 0)
            {
                if (caseDivision[0] == 1)
                    caseDivisionFilter = " where employees.GroupID !=" + 0;
                if (caseDivision[0] == 2)
                    caseDivisionFilter = " where employees.GroupID =" + 6;

                if (caseDivision[0] == 3)
                    caseDivisionFilter = " where employees.GroupID !=" + 6;
            }
            ViewBag.OfficesList = GetOffices();

            if (officesId != null)
            {
                officeFilter = "and(employees.OfficeID = " + officesId[0];
                for (var index = 1; index < officesId.Count; index++)
                {
                    officeFilter += "or employees.OfficeID= " + officesId[index];
                }

                officeFilter += ")";
            }



            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;

            if (months == null && years == null && teamLeaderNames == null)
            {
                return View("_TeamLeaderReport");
            }

            else
            {
                var filter = "";

                if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
                {
                    filter = "and(ap.PaymentDate like " + "'%" + years[0] + "'" + " or  dl.MonthYear like " + "'%" + years[0] + "'";

                    for (var index = 1; index < years.Count; index++)
                    {
                        filter += "or ap.PaymentDate like " + "'%" + years[index] + "'" + " or  dl.MonthYear like " + "'%" + years[index] + "'";
                    }

                    filter += ")";
                }




                else if (months != null ? months.Count > 0 : false)
                {
                    filter = "and(ap.PaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[0] + '-' + years[0] + "'";

                    for (var index = 1; index < months.Count; index++)
                    {
                        filter += "or ap.PaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[index] + '-' + years[0] + "'"; ;
                    }

                    filter += ")";
                }

                var schemasID = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();
                foreach (var schemaID in schemasID)
                {

                    var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                    var NameIndex = schema.Where(a => a.ColumnName == "Team Leader").Select(s => s.ColumnIndex).FirstOrDefault();
                    var CustNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
                    var ProductIndex = schema.Where(a => a.ColumnName == "Product").Select(s => s.ColumnIndex).FirstOrDefault();
                    var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
                    var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
                    var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();
                    if (NameIndex != null && CustNameIndex != null && ProductIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
                    {
                        //if (officesId != null)
                        //{
                        //    officeJoin = "  join Pre_OfficesMembers on Pre_Users.UserID=Pre_OfficesMembers.UserID ";

                        //}

                        if (teamLeaderNames != null)
                        {
                            teamLeaderFilter = "and(col" + NameIndex + " like " + "'" + teamLeaderNames[0] + "'";

                            for (var index = 1; index < teamLeaderNames.Count; index++)
                            {
                                teamLeaderFilter += "or Col" + NameIndex + " like " + "'" + teamLeaderNames[index] + "'";
                            }

                            teamLeaderFilter += ")";
                        }

                        {
                            caseDivisionJoin = "  left join employees on employees.name=#temp.col" + NameIndex;

                        }

                        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;


                        var query1 = "create table #temp(RecordSerial bigint,SchemaID tinyint ,DomainID bigint, col" + NameIndex + " nvarchar(200), col" + ProductIndex + " nvarchar(200) , Col" + DomainTypeIndex + "  nvarchar(200), col" + BalanceIndex + " nvarchar(max) , col" + PastdueIndex + " nvarchar(max) , col" + CustNameIndex + " nvarchar(200) , " +
                            "DomainTitle nvarchar(250),MonthYear nvarchar(50),AgencyTitle nvarchar(300),PaymentDate nvarchar(50),"
+ "PaymentValue decimal (12,2)) ;create index index_name on #temp(col" + NameIndex + ")" +
"insert into #temp select ap.RecordSerial ,dl.SchemaID, dl.DomainID , col" + NameIndex + " ,col" + ProductIndex + "  , Col" + DomainTypeIndex + ", col" + BalanceIndex + "  , col" + PastdueIndex + ", col" + CustNameIndex +
 " ,dl.DomainTitle,dl.MonthYear,dl.AgencyTitle, ap.PaymentDate,ap.PaymentValue from Dom_DomainsDataExtra  as dx join  " +
"Dom_DomainList as dl  on dl.DomainID=dx.DomainID left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial  where dx.SchemaID=" + schemaID
+ " and (dx.Col" + DomainTypeIndex + " ='active' or dx.col" + DomainTypeIndex + " ='w/o') and  " +
                            "dx.Col" + NameIndex + " != ''"

                            + filter + teamLeaderFilter;


                        string Querystring = query1 + " ; select distinct #temp.MonthYear as DlMonthYear, employees.GroupID GroupID , #temp.AgencyTitle AgencyTitle,#temp.PaymentDate monthyear , #temp.Col" + NameIndex +
                            " TeamLeaderName, #temp.Col" + ProductIndex + " Product , #temp.Col" + DomainTypeIndex +
                            " DomainType ,SUM (#temp.PaymentValue) Payment , COUNT(#temp.PaymentValue) PaymentCount ,COUNT(#temp.Col" + CustNameIndex + ") CountofCustomers " +
                         " ,SUM(TRY_CAST(#temp.Col" + BalanceIndex + " AS float)) Balance " +
                          " ,SUM(TRY_CAST(#temp.Col" + PastdueIndex + " AS float)) PastDue from #temp " + caseDivisionJoin +
                         caseDivisionFilter + officeFilter +
                             " group by #temp.MonthYear, employees.GroupID, #temp.AgencyTitle,#temp.PaymentDate, #temp.DomainID , #temp.Col" + NameIndex + " , #temp.Col" + DomainTypeIndex + " , #temp.Col" + ProductIndex;

                        SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "TeamLaderTable");
                        DataTable dtable = ds.Tables["TeamLaderTable"];

                        result.AddRange(dtable.AsEnumerable().Select(s => new DomainReoprtbyTeamLeader
                        {
                            MonthYear = s.Field<string>("monthyear") != null ?
                               (months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0]) : (months == null ? s.Field<string>("DlMonthYear").Split('-')[1] : s.Field<string>("DlMonthYear").Split('-')[0]),
                            GroupId = s.Field<byte?>("GroupID"),
                            TeamLeaderName = s.Field<string>("TeamLeaderName"),
                            DomainType = s.Field<string>("DomainType"),
                            Product = s.Field<string>("Product"),
                            CountOfCustomers = s.Field<int>("CountofCustomers"),
                            AgencyTitle = s.Field<string>("AgencyTitle"),
                            CountOfPayment = s.Field<int>("PaymentCount") == null ? 0 : s.Field<int>("PaymentCount"),
                            Payment = s.Field<decimal?>("Payment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("Payment")),
                            Balance = string.Format("{0:N0}", s.Field<double>("Balance")),
                            PastDue = string.Format("{0:N0}", s.Field<double>("PastDue"))

                        }).ToList());
                    }
                }
                if (result.Count() > 0)
                {
                    ViewBag.type = type[0];
                    if (type[0] == 1 || type[0] == 3)
                    {
                        ViewBag.TeamLeaderReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.GroupId, c.TeamLeaderName, c.MonthYear, c.DomainType, c.Product, c.AgencyTitle }).Select(c => new DomainReoprtbyTeamLeader()
                        {
                            GroupId = c.Key.GroupId,
                            TeamLeaderName = c.Key.TeamLeaderName,
                            Product = c.Key.Product,
                            MonthYear = c.Key.MonthYear,
                            AgencyTitle = c.Key.AgencyTitle,
                            DomainType = c.Key.DomainType,
                            CountOfCustomers = c.Sum(s => s.CountOfCustomers),
                            CountOfPayment = c.Sum(s => s.CountOfPayment),
                            Payment = c.Sum(s => double.Parse(s.Payment)).ToString(),
                            Balance = c.Sum(s => double.Parse(s.Balance)).ToString(),
                            PastDue = c.Sum(s => double.Parse(s.PastDue)).ToString()

                        }).ToList();

                        if (type[0] == 3)
                        {
                            if (teamLeaderNames != null)
                            {
                                if (teamLeaderNames.Count == 1)
                                {
                                    return PartialView("_CartsForTeamLeader");
                                }
                                else if (teamLeaderNames.Count <= 4)
                                    return PartialView("_ChartsTeamLeader");
                                else
                                {
                                    ViewBag.TeamLeaderReport = null;
                                    return PartialView("_ChartsTeamLeader");
                                }
                            }

                            else
                            {
                                ViewBag.TeamLeaderReport = null;
                                return PartialView("_ChartsTeamLeader");

                            }
                        }
                    }
                    else
                    {
                        ViewBag.TeamLeaderReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.TeamLeaderName, c.MonthYear, c.AgencyTitle, c.DomainType }).Select(c => new DomainReoprtbyTeamLeader()
                        {
                            TeamLeaderName = c.Key.TeamLeaderName,

                            MonthYear = c.Key.MonthYear,
                            AgencyTitle = c.Key.AgencyTitle,
                            CountOfCustomers = c.Sum(s => s.CountOfCustomers),
                            CountOfPayment = c.Sum(s => s.CountOfPayment),
                            DomainType = c.Key.DomainType,
                            Payment = c.Sum(s => double.Parse(s.Payment)).ToString(),
                            Balance = c.Sum(s => double.Parse(s.Balance)).ToString(),
                            PastDue = c.Sum(s => double.Parse(s.PastDue)).ToString()
                        }).ToList();
                    }

                }
                else
                {
                    ViewBag.TeamLeaderReportwarning = "No Data Found";
                }

                return PartialView("_TeamLeadersList");
            }
        }


        public List<SelectListItem> GetOffices()
        {
            List<SelectListItem> offices = new List<SelectListItem>();

            var list = _enty.Pre_Offices.Where(q => q.IsDeleted == false && q.IsActive == true).Select(q => q).ToList();
            offices.AddRange(list.Select(c => new SelectListItem() { Text = c.OfficeTitle, Value = c.OfficeId.ToString() }));
            return offices;
        }
        public ActionResult GetCollectorNames(string name)
        {
            if (name == null || name == "")
                return null;


            var names = _enty.Reports_GetNames(name, "Collector Name");

            return Json(names.Select(c => new { id = c, text = c }).Distinct().ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCollectorCodes(string name)
        {
            if (name == null || name == "")
                return null;

            var names = _enty.Reports_GetNames(name, "Collector Code").ToList();

            return Json(names.Where(c => c != null).Select(c => new { id = c, text = c }).Distinct().ToList(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetTeamLeaderNames(string name)
        {
            if (name == "" || name == null)
                return null;

            var names = _enty.Reports_GetNames(name.ToLower(), "Team Leader");

            return Json(names.Select(c => new { id = c, text = c }).Distinct().ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetReportCollector(List<int> years = null, List<int> months = null, List<string> collectorNames = null, List<string> collectorCodes = null, List<int> officesId = null, List<int> type = null, List<int> caseDivision = null)
        {



            List<CollectorwithPayment> result = new List<CollectorwithPayment>();
            List<SelectListItem> YearsList = new List<SelectListItem>();
            List<SelectListItem> MonthsLists = new List<SelectListItem>();
            List<SelectListItem> CollectorNamesList = new List<SelectListItem>();
            List<SelectListItem> CollectorCodesList = new List<SelectListItem>();
            List<EIF.Helper.CollectorName> names = new List<EIF.Helper.CollectorName>();
            var officeJoin = "";
            var officeFilter = "";
            var caseDivisionJoin = "";
            var caseDivisionFilter = "";

            if (caseDivision == null ? false : caseDivision.Count > 0)
            {
                if (caseDivision[0] == 1)
                    caseDivisionFilter = " where employees.GroupId !=" + 0;
                if (caseDivision[0] == 2)
                    caseDivisionFilter = " where employees.GroupId =" + 6;

                if (caseDivision[0] == 3)
                    caseDivisionFilter = " where employees.GroupId !=" + 6;
            }

            if (officesId != null)
            {
                officeFilter = "and(employees.OfficeID = " + officesId[0];
                for (var index = 1; index < officesId.Count; index++)
                {
                    officeFilter += "or employees.OfficeID= " + officesId[index];
                }

                officeFilter += ")";
            }

            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;
            ViewBag.OfficesList = GetOffices();


            if (months == null && years == null && collectorNames == null)
            {
                return View("ReportList");
            }

            else
            {
                var filter = "";

                if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
                {
                    filter = "  and (ap.PaymentDate like " + "'%" + years[0] + "'" + " or  dl.MonthYear like " + "'%" + years[0] + "'";

                    for (var index = 1; index < years.Count; index++)
                    {
                        filter += "or ap.PaymentDate like " + "'%" + years[index] + "'" + " or  dl.MonthYear like " + "'%" + years[index] + "'";
                    }

                    filter += ")";
                }

                else if (months != null ? months.Count > 0 : false)
                {
                    filter = " and  (ap.PaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[0] + '-' + years[0] + "'";

                    for (var index = 1; index < months.Count; index++)
                    {
                        filter += "or ap.PaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[index] + '-' + years[0] + "'"; ;
                    }

                    filter += ")";
                }

                var schemaIdsList = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();

                foreach (var schemaID in schemaIdsList)
                {

                    var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                    var CodeIndex = schema.Where(a => a.ColumnName == "Collector Code").Select(s => s.ColumnIndex).FirstOrDefault();
                    var NameIndex = schema.Where(a => a.ColumnName == "Collector Name").Select(s => s.ColumnIndex).FirstOrDefault();
                    var collectorNameFilter = "";
                    var collectorCodeFilter = "";

                    if (collectorNames != null)
                    {
                        collectorNameFilter = "and(col" + NameIndex + " like " + "'" + collectorNames[0] + "'";

                        for (var index = 1; index < collectorNames.Count; index++)
                        {
                            collectorNameFilter += "or Col" + NameIndex + " like " + "'" + collectorNames[index] + "'";
                        }

                        collectorNameFilter += ")";
                    }
                    if (collectorCodes != null)
                    {
                        collectorCodeFilter = "and(col" + CodeIndex + " like " + "'" + collectorCodes[0] + "'";

                        for (var index = 1; index < collectorCodes.Count; index++)
                        {
                            collectorCodeFilter += "or Col" + CodeIndex + " like " + "'" + collectorCodes[index] + "'";
                        }

                        collectorCodeFilter += ")";
                    }


                    //if (officesId != null)
                    //{
                    //    officeJoin = "  join Pre_OfficesMembers on Pre_Users.UserID=Pre_OfficesMembers.UserID ";
                    //}

                    if (caseDivision == null ? false : caseDivision.Count > 0)
                    {
                        caseDivisionJoin = "  join Employees on Employees.Name=#temp.col" + NameIndex;

                    }

                    var CustNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
                    var ProductIndex = schema.Where(a => a.ColumnName == "Product").Select(s => s.ColumnIndex).FirstOrDefault();
                    var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
                    var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
                    var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();

                    if (CodeIndex != null && NameIndex != null && CustNameIndex != null && ProductIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
                    {
                        var query1 = "create table #temp" +
                            "(RecordSerial bigint,SchemaID tinyint ,DomainID bigint, col" + NameIndex + " nvarchar(200) ,col" + CodeIndex + " nvarchar(200), col" + CustNameIndex + " nvarchar(200),col" + ProductIndex + " nvarchar(200),col" + DomainTypeIndex + " nvarchar(200),col" + PastdueIndex + " nvarchar(max),col" + BalanceIndex + " nvarchar(max) ," +
                            "DomainTitle nvarchar(250),MonthYear nvarchar(50),AgencyTitle nvarchar(300),PaymentDate nvarchar(50),  PaymentValue decimal (12,2));"
                            +
                            "create index index_name on #temp(col" + NameIndex + ") insert into #temp select ap. RecordSerial ,dx.SchemaID, dl.DomainID,col" +
                            NameIndex + " ,col" + CodeIndex + " ,col" + CustNameIndex + ",col" + ProductIndex + " ,col" + DomainTypeIndex + " ,col" + PastdueIndex + " ,col" + BalanceIndex +

                            " ,dl.DomainTitle, dl.MonthYear,dl.AgencyTitle, ap.PaymentDate,ap.PaymentValue" +
" from Dom_DomainsDataExtra  as dx join Dom_DomainList as dl  on dl.DomainID=dx.DomainID" +
" left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial  where dx.SchemaID=" + schemaID +
                          " and  (dx.Col" + DomainTypeIndex + " = 'active' or  dx.Col" + DomainTypeIndex + " = 'w/o' ) " +
                          " and  dx.Col" + CodeIndex + "!=''" + " and dx.Col" + NameIndex + "!=''" + filter + collectorNameFilter + collectorCodeFilter;

                        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                        var Querystring = query1 + "; select DISTINCT #temp.DomainTitle,  #temp.MonthYear as DlMonthYear,   #temp.AgencyTitle,  #temp.PaymentDate monthyear,  #temp.Col" + CodeIndex + " CollectorCode ,  #temp.Col" + NameIndex +
                             " CollectorName,  #temp.Col" + ProductIndex + " Product ,  #temp.Col" + DomainTypeIndex + " DomainType ,SUM ( #temp.PaymentValue) Payment , COUNT( #temp.PaymentValue) PaymentCount ,COUNT( #temp.Col" + CustNameIndex + ") CountofCustomers" +
                          " ,SUM(Try_Cast( #temp.Col" + BalanceIndex + " AS float)) Balance " +
                           " ,SUM(Try_Cast( #temp.Col" + PastdueIndex + " AS float)) PastDue "
                         + "   from  #temp " + caseDivisionJoin +
                           officeJoin + caseDivisionFilter +
                          officeFilter +
                             " group by #temp.MonthYear ,#temp.DomainTitle, #temp.AgencyTitle, #temp.PaymentDate, #temp.DomainID, #temp.Col" + CodeIndex + " , #temp.Col" + NameIndex + " , #temp.Col" + DomainTypeIndex + " , #temp.Col" + ProductIndex;
                        SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                        DataSet ds = new DataSet();
                        var num = 0.0;
                        adapter.Fill(ds, "PaymentTable");
                        DataTable dtable = ds.Tables["PaymentTable"];
                        result.AddRange(dtable.AsEnumerable().Select(s => new CollectorwithPayment
                        {

                            MonthYear = (s.Field<string>("monthyear") != null && s.Field<string>("monthyear") != "") ?
                             (months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0]) : (months == null ? s.Field<string>("DlMonthYear").Split('-')[1] : s.Field<string>("DlMonthYear").Split('-')[0]),
                            CollectorCode = s.Field<string>("CollectorCode"),
                            CollectorName = s.Field<string>("CollectorName"),
                            DomainType = s.Field<string>("DomainType").ToLower(),
                            Product = s.Field<string>("Product"),
                            AgencyTitle = s.Field<string>("AgencyTitle"),
                            CountOfCustomers = s.Field<int>("CountofCustomers"),
                            CountOfPayment = s.Field<int>("PaymentCount"),
                            Payment = s.Field<decimal?>("Payment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("Payment")),
                            Balance = s.Field<double?>("Balance") == null ? num.ToString() : string.Format("{0:N0}", s.Field<double?>("Balance")),
                            PastDue = s.Field<double?>("PastDue") == null ? num.ToString() : string.Format("{0:N0}", s.Field<double?>("PastDue")),
                            DomainTitle = s.Field<string>("DomainTitle")
                        }).ToList());





                    }
                }

                if (result.Count() > 0)
                {
                    ViewBag.type = type[0];
                    if (type[0] == 1 || type[0] == 3)
                    {
                        ViewBag.CollectorReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max() && (c.DomainType == "w/o" || c.DomainType == "active")).GroupBy(c => new { c.DomainTitle, c.CollectorCode, c.CollectorName, c.MonthYear, c.DomainType, c.Product, c.AgencyTitle }).Select(c => new CollectorwithPayment()
                        {
                            CollectorCode = c.Key.CollectorCode,
                            CollectorName = c.Key.CollectorName,
                            MonthYear = c.Key.MonthYear,
                            DomainTitle = c.Key.DomainTitle,
                            Product = c.Key.Product,
                            DomainType = c.Key.DomainType,
                            AgencyTitle = c.Key.AgencyTitle,
                            CountOfCustomers = c.Sum(s => s.CountOfCustomers),
                            CountOfPayment = c.Sum(s => s.CountOfPayment),
                            PastDue = c.Sum(s => double.Parse(s.PastDue)).ToString(),
                            Payment = c.Sum(s => double.Parse(s.Payment)).ToString(),
                            Balance = c.Sum(s => double.Parse(s.Balance)).ToString()
                        }).ToList();
                        if (type[0] == 3)
                        {
                            if (collectorNames != null)
                            {
                                if (collectorNames.Count == 1)
                                    return PartialView("_ChartsForCollector");
                                else if (collectorNames.Count <= 4)
                                    return PartialView("_ChartsCollector");
                                else
                                {
                                    ViewBag.CollectorReport = null;
                                }
                            }
                            else
                                ViewBag.CollectorReport = null;

                        }

                    }



                    else
                    {
                        ViewBag.CollectorReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.CollectorCode, c.DomainType, c.CollectorName, c.MonthYear, c.AgencyTitle }).Select(c => new CollectorwithPayment()
                        {
                            CollectorCode = c.Key.CollectorCode,
                            CollectorName = c.Key.CollectorName,
                            MonthYear = c.Key.MonthYear,
                            AgencyTitle = c.Key.AgencyTitle,
                            DomainType = c.Key.DomainType,
                            CountOfCustomers = c.Sum(s => s.CountOfCustomers),
                            CountOfPayment = c.Sum(s => s.CountOfPayment),
                            PastDue = c.Sum(s => double.Parse(s.PastDue)).ToString(),
                            Payment = c.Sum(s => double.Parse(s.Payment)).ToString(),
                            Balance = c.Sum(s => double.Parse(s.Balance)).ToString()
                        }).ToList();
                    }
                }

                else
                {
                    ViewBag.CollectorReportwarning = "No Data Found.";
                }

                return PartialView("_CollectorReportList");
            }
        }

        public ActionResult GetDomainReportPerCollector(int DomainID)
        {
            List<CollectorwithPayment> result = new List<CollectorwithPayment>();
            var schemaID = _enty.Dom_DomainsDataExtra.Where(a => a.DomainID == DomainID).Select(s => s.SchemaID).FirstOrDefault();
            var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
            var CodeIndex = schema.Where(a => a.ColumnName == "Collector Code").Select(s => s.ColumnIndex).FirstOrDefault();
            var NameIndex = schema.Where(a => a.ColumnName == "Collector Name").Select(s => s.ColumnIndex).FirstOrDefault();
            var CustNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
            var ProductIndex = schema.Where(a => a.ColumnName == "Product").Select(s => s.ColumnIndex).FirstOrDefault();
            var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
            var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
            var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();
            if (CodeIndex != null && NameIndex != null && CustNameIndex != null && ProductIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
            {
                string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                string Querystring = "select  dx.Col" + CodeIndex + " CollectorCode , dx.Col" + NameIndex +
                    " CollectorName, dx.Col" + ProductIndex + " Product , dx.Col" + DomainTypeIndex + " DomainType ,SUM (ap.PaymentValue) Payment , COUNT(ap.PaymentValue) PaymentCount ,COUNT(dx.Col" + CustNameIndex + ") CountofCustomers , SUM(ISNULL(CAST(dx.Col" + BalanceIndex + " AS float),0)) Balance , SUM(ISNULL(CAST(dx.Col" + PastdueIndex + " AS float),0)) PastDue from Dom_DomainList dl left join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial where dl.DomainID =" + DomainID
                    + " group by dl.DomainID, dx.Col" + CodeIndex + " , dx.Col" + NameIndex + " , dx.Col" + DomainTypeIndex + " , dx.Col" + ProductIndex;
                SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "PaymentTable");
                DataTable dtable = ds.Tables["PaymentTable"];
                result = dtable.AsEnumerable().Select(s => new CollectorwithPayment
                {
                    CollectorCode = s.Field<string>("CollectorCode"),
                    CollectorName = s.Field<string>("CollectorName"),
                    DomainType = s.Field<string>("DomainType"),
                    Product = s.Field<string>("Product"),
                    CountOfCustomers = s.Field<int>("CountofCustomers"),
                    CountOfPayment = s.Field<int>("PaymentCount"),
                    Payment = string.Format("{0:N0}", s.Field<decimal?>("Payment")),
                    Balance = string.Format("{0:N0}", s.Field<double>("Balance")),
                    PastDue = string.Format("{0:N0}", s.Field<double>("PastDue"))
                }).ToList();
            }
            if (result.Count() > 0)
            {
                ViewBag.CollectorReport = result;
            }
            else
            {
                ViewBag.CollectorReportwarning = "Not Applied";
            }
            return PartialView("_CollectionCollectorReport");
        }

        #region ImportDCR
        public ActionResult GetDCRSheets(string file)
        {
            //Check for access deny and password sheet long
            string pathToExcelFile = SaveExcel(Convert.FromBase64String(file), "TempExcel");
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            List<string> excelSheets = excelFile.GetWorksheetNames().ToList();
            Dictionary<string, string> SheetList = new Dictionary<string, string>();

            int i = 0;
            foreach (var S in excelSheets)
            {
                SheetList.Add(S, S);
                i++;
            }
            if (SheetList.Count() > 1)
            {
                ViewBag.Sheets = new SelectList((SheetList.Select(q => q)).ToList(), "Key", "Value");
            }
            else
            {
                ViewBag.SingleSheets = new SelectList((SheetList.Select(q => q)).ToList(), "Key", "Value");
            }
            ViewBag.pathToExcelFile = pathToExcelFile;
            try
            {

            }
            catch (Exception ex)
            {
                ViewBag.Validation = ex.Message;
                throw;
            }

            return PartialView("_CollectionGetDCRSheets");
        }
        public ActionResult ImportDCR(FormCollection frm)
        {
            if (frm["DomainID"].Length > 0)
            {
                if (frm["SchemaID"].Length > 0)
                {
                    if (frm["filePath"].Length > 0)
                    {
                        string pathToExcelFile = frm["filePath"];
                        string SheetName = frm["SheetName"];
                        int DomainID = int.Parse(frm["DomainID"]);
                        //save to DB
                        _enty.DeleteDCRData(DomainID);
                        var ExistData = _enty.DCR_DomainList.Where(a => a.DomainId == DomainID).FirstOrDefault();
                        if (ExistData == null)
                        {
                            // save in DCR Domain List 
                            DCR_DomainList newDCRList = new Models.DCR_DomainList();
                            newDCRList.DomainId = DomainID;
                            newDCRList.DCR_SchemaId = int.Parse(frm["SchemaID"]);
                            newDCRList.DomainName = _enty.Dom_DomainDetailsList.Where(a => a.DomainID == DomainID).Select(s => s.DomainTitle).FirstOrDefault();
                            _enty.Entry(newDCRList).State = System.Data.Entity.EntityState.Added;
                            _enty.SaveChanges();
                        }
                        if (_enty.DCR_Domain_Data.Where(a => a.Domain_ID == DomainID).Select(s => s).Count() > 0)
                        {
                            // delete all data before append new data 
                            _enty.DCR_Domain_Data.RemoveRange(_enty.DCR_Domain_Data.Where(a => a.Domain_ID == DomainID));
                            _enty.SaveChanges();
                        }
                        UploadDCRExcel(pathToExcelFile, Path.GetFileName(pathToExcelFile), int.Parse(frm["SchemaID"]), int.Parse(frm["DomainID"]), SheetName);
                        string msg = "new DCR is Added ";
                        InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                    }

                }
                else
                {
                    ViewBag.error = "Choose Schema";
                }
            }
            else
            {
                ViewBag.error = "Choose Domain";
            }
            return PartialView("_ImportResult");
        }
        public void UploadDCRExcel(string pathToExcelFile, string filename, int SchemaID, int DomainID, string SheetName)
        {
            List<string> data = new List<string>();

            var connectionString = "";

            connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", pathToExcelFile);

            var adapter = new OleDbDataAdapter("SELECT * FROM [" + SheetName + "$]", connectionString);//[Sheet1$]
            var ds = new DataSet();

            adapter.Fill(ds, "ExcelTable");

            DataTable dtable = ds.Tables["ExcelTable"];


            //Install-Package LinqToExcel -Version 1.11.0 (nuget)
            var excelFile = new ExcelQueryFactory(pathToExcelFile);
            List<string> FailureRows = new List<string>();
            int countOfSuccess = 0;
            int countOfFailure = 0;
            int NumberOfColOfExcel = dtable.Columns.Count;
            int? NumberOfColOfSchema = _enty.DCR_Schema_Details.Where(q => q.SchemaID == SchemaID).Select(q => q.ColumnIndex).OrderByDescending(q => q.Value).FirstOrDefault();
            if (NumberOfColOfExcel >= NumberOfColOfSchema)
            {
                try
                {
                    var artistAlbums = from a in excelFile.Worksheet() select a;

                    //create insert statment
                    for (int j = 0; j < dtable.Rows.Count; j++)
                    {
                        if (j > 0 && string.IsNullOrEmpty(dtable.Rows[j][1].ToString()))
                        {
                            continue;
                        }
                        string sql = "insert into DCR_Domain_Data (Schema_ID,Domain_ID";
                        //columns
                        for (int i = 1; i <= dtable.Columns.Count; i++)
                        {
                            sql = sql + ",Col" + i;
                        }
                        //values
                        sql = sql + ") values(" + SchemaID + " , " + DomainID + "";
                        for (int i = 0; i < dtable.Columns.Count; i++)
                        {
                            sql = sql + ",N'" + dtable.Rows[j][i].ToString().Trim().Replace("'", "''") + "'";
                        }

                        sql = sql + ")";
                        int result2 = 0;
                        try
                        {
                            result2 = _enty.Database.ExecuteSqlCommand(String.Format(sql));
                            //get result summary
                            if (result2 > 0)
                            {
                                countOfSuccess++;
                            }
                            else
                            {
                                countOfFailure++;
                                FailureRows.Add("Row : " + j);
                            }
                        }
                        catch
                        {
                            countOfFailure++;
                            FailureRows.Add("Row : " + j);
                        }
                        ViewBag.RowsSuccess = countOfSuccess;
                        ViewBag.RowsFailure = countOfFailure;

                    }
                    if (FailureRows.Count > 0)
                    {
                        ViewBag.FailureRowsSummary = FailureRows;
                    }
                    string repeatedcolumnname = "";
                    bool IsRepeated = false; bool skipfirstrow = false;
                    for (int i = 1; i <= dtable.Columns.Count; i++)
                    {
                        DCR_Column_Alias rec = new DCR_Column_Alias();
                        if (dtable.Columns[i - 1].ColumnName != "F" + i && i < dtable.Columns.Count && dtable.Columns[i].ColumnName == "F" + (i + 1))
                        {
                            // if this column name not empty but the next column name is empty
                            repeatedcolumnname = dtable.Columns[i - 1].ColumnName;
                            IsRepeated = true; skipfirstrow = true;
                        }
                        else if (IsRepeated && dtable.Columns[i - 1].ColumnName != "F" + i && dtable.Columns[i].ColumnName != "F" + i + 1)
                        {
                            // if this column name not empty and the next column name not empty
                            repeatedcolumnname = "";
                            IsRepeated = false;
                        }
                        rec.AliasName = IsRepeated ? repeatedcolumnname + "\\" + dtable.Rows[0][i - 1].ToString().Trim() : dtable.Columns[i - 1].ColumnName;
                        //rec.AliasName = dtable.Columns[i - 1].ColumnName == "F" + i && i != 1 ? dtable.Columns[i - 2].ColumnName : dtable.Columns[i - 1].ColumnName;
                        rec.ColumnName = "Col" + i;
                        rec.DimainID = DomainID;
                        rec.SchemaID = SchemaID;
                        _enty.Entry(rec).State = System.Data.Entity.EntityState.Added;
                        _enty.SaveChanges();
                    }
                    if (skipfirstrow)
                    {
                        var DCR_list = _enty.DCR_DomainList.Where(a => a.DomainId == DomainID).Select(s => s).FirstOrDefault();
                        DCR_list.SkipFirstRow = true;
                        _enty.Entry(DCR_list).State = System.Data.Entity.EntityState.Modified;
                        _enty.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    ViewBag.error = ex.Message;
                }
            }
            else
            {
                ViewBag.error = "Number Of Columns Not Fit Number Of Schema Columns";
            }
        }
        public ActionResult DCRSchema()
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("DCR Schema", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
            {
                List<DCR_Schema> Data = new List<Models.DCR_Schema>();
                if (myinformationonly == false)
                    Data = _enty.DCR_Schema.Select(q => q).ToList();
                else
                {
                    int userid = int.Parse(Session["ID"].ToString());
                    string BranchIDs = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s.BranchIDs).FirstOrDefault();
                    if (!string.IsNullOrEmpty(BranchIDs))
                    {
                        var BranchLst = BranchIDs.Split(',').ToList().ConvertAll(Convert.ToByte);
                        Data = _enty.DCR_Schema.Where(a => BranchLst.Contains((byte)a.BranchID)).Select(q => q).ToList();
                    }
                    ViewBag.BranchIDs = BranchIDs; ViewBag.myinfo = myinformationonly;
                }
                if (Data != null)
                {
                    ViewBag.Data = Data;
                }
                if (AccessRights.Contains("Add") || AccessRights.Contains("All"))
                    ViewBag.AccessRightAdd = true;
                if (AccessRights.Contains("Edit") || AccessRights.Contains("All"))
                    ViewBag.AccessRightEdit = true;
                return View();
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult NewDCRSchema(string Name, byte BranchID)
        {
            if (Convert.ToString(BranchID).Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.DCR_Schema.Where(q => q.DCR_Schema_Name == Name).Select(q => q.DCR_Schema_Name).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    var BranchName = _enty.Lup_BranchList.Where(a => a.BranchID == BranchID).Select(s => s.BranchTitle).FirstOrDefault();
                    DCR_Schema sch = new Models.DCR_Schema();
                    sch.DCR_Schema_Name = Name;
                    sch.BranchID = BranchID;
                    sch.BranchName = BranchName;
                    _enty.Entry(sch).State = System.Data.Entity.EntityState.Added;
                    int res = _enty.SaveChanges();
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                        string msg = "DCR Schema : " + Name + "is saved ";
                        InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                    }
                    // Insert Basic Columns 
                    //try
                    //{
                    //    var ColumnsList = _enty.DCR_Schema_ColumnsList.Select(s => s).ToList();
                    //    foreach (var item in ColumnsList)
                    //    {
                    //        DCR_Schema_Details DET = new Models.DCR_Schema_Details();
                    //        DET.ColumnID = item.ColumnID;
                    //        DET.SchemaID = sch.DCR_Schema_ID;
                    //        DET.ColumnIndex = 1;
                    //        _enty.Entry(DET).State = System.Data.Entity.EntityState.Added;
                    //        _enty.SaveChanges();
                    //    }
                    //}
                    //catch
                    //{

                    //}
                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Schema Name";
                }
                if (Convert.ToString(BranchID).Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Branch";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Branch";
                    }

                }

            }
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("DCR Schema", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
            {
                List<DCR_Schema> Data = new List<Models.DCR_Schema>();
                if (myinformationonly == false)
                    Data = _enty.DCR_Schema.Select(q => q).ToList();
                else
                {
                    int userid = int.Parse(Session["ID"].ToString());
                    string BranchIDs = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s.BranchIDs).FirstOrDefault();
                    if (!string.IsNullOrEmpty(BranchIDs))
                    {
                        var BranchLst = BranchIDs.Split(',').ToList().ConvertAll(Convert.ToByte);
                        Data = _enty.DCR_Schema.Where(a => BranchLst.Contains((byte)a.BranchID)).Select(q => q).ToList();
                    }
                    ViewBag.BranchIDs = BranchIDs; ViewBag.myinfo = myinformationonly;
                }
                if (Data != null)
                {
                    ViewBag.Data = Data;
                }
            }
            return PartialView("_CollectionDCRSchemaList");
        }
        public ActionResult EditDCRSchema(byte id, string Name, byte BranchID)
        {
            if (Convert.ToString(BranchID).Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.DCR_Schema.Where(q => q.DCR_Schema_Name == Name && q.DCR_Schema_ID != id).Select(q => q.DCR_Schema_Name).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    var BranchName = _enty.Lup_BranchList.Where(a => a.BranchID == BranchID).Select(s => s.BranchTitle).FirstOrDefault();
                    var rec = _enty.DCR_Schema.Find(id);
                    rec.BranchID = BranchID;
                    rec.DCR_Schema_Name = Name;
                    rec.BranchName = BranchName;
                    _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                    int res = _enty.SaveChanges();
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                        string msg = "DCR Schema : " + Name + " is edited ";
                        InsertExcptionLog(msg, int.Parse(Session["ID"].ToString()));
                    }
                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Schema Name";
                }
                if (Convert.ToString(BranchID).Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Branch";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Branch";
                    }

                }

            }

            //save new agency
            return PartialView("_result");
        }
        public ActionResult DCRSchemaColumns(int id)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("DCR Schema Columns", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
            {
                var AssignedCol = _enty.DCR_Schema_VIEW.Where(q => q.SchemaID == id).Select(q => q).ToList().OrderBy(q => q.ColumnIndex);
                if (AssignedCol.Count() > 0)
                {
                    ViewBag.AssignedCol = AssignedCol;
                }


                var Data = _enty.DCR_Schema.Where(q => q.DCR_Schema_ID == id).Select(q => q).FirstOrDefault();
                if (Data != null)
                {
                    ViewBag.Data = Data;
                }
                if (AccessRights.Contains("All") || AccessRights.Contains("Add"))
                    ViewBag.AccessRightAdd = true;
                if (AccessRights.Contains("All") || AccessRights.Contains("Edit"))
                    ViewBag.AccessRightEdit = true;
                if (AccessRights.Contains("All") || AccessRights.Contains("Delete"))
                    ViewBag.AccessRightDelete = true;
                return View();
            }
            else
            {
                return RedirectToAction("Forbidden", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult RemoveDCRColumns(int SchemaID, int ColID)
        {
            var ColToDelete = _enty.DCR_Schema_Details.Where(a => a.ColumnID == ColID && a.SchemaID == SchemaID).FirstOrDefault();
            _enty.Entry(ColToDelete).State = System.Data.Entity.EntityState.Deleted;
            int res = _enty.SaveChanges();
            if (res > 0)
            {
                ViewBag.saved = "Data saved successfully";
            }


            #region Select
            //assigned Col
            var AssignedCol = _enty.DCR_Schema_VIEW.Where(q => q.SchemaID == SchemaID).Select(q => q).ToList().OrderBy(q => q.ColumnIndex);
            if (AssignedCol.Count() > 0)
            {
                ViewBag.AssignedCol = AssignedCol;
            }


            var Data = _enty.DCR_Schema.Where(q => q.DCR_Schema_ID == SchemaID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_CollectionDCRSchemaCols");
        }
        public ActionResult UpdateDCRSchemaColIndex(int SchemaID, int ColID, int index)
        {
            var rec = _enty.DCR_Schema_Details.Where(q => q.SchemaID == SchemaID && q.ColumnID == ColID).Select(q => q).FirstOrDefault();
            if (rec != null)
            {
                rec.ColumnIndex = index;
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                int res = _enty.SaveChanges();
                if (res > 0)
                {
                    ViewBag.saved = "Data saved successfully";
                }
            }

            #region Select
            //assigned Col
            var AssignedCol = _enty.DCR_Schema_VIEW.Where(q => q.SchemaID == SchemaID).Select(q => q).ToList().OrderBy(q => q.ColumnIndex);
            if (AssignedCol.Count() > 0)
            {
                ViewBag.AssignedCol = AssignedCol;
            }

            var Data = _enty.DCR_Schema.Where(q => q.DCR_Schema_ID == SchemaID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_CollectionDCRSchemaCols");
        }
        public ActionResult AddDCRSchemaColumns(string ColID, string id, int index)
        {
            //insert
            int SchemaID = int.Parse(id);
            DCR_Schema_Details ColToAdd = new Models.DCR_Schema_Details();
            ColToAdd.ColumnID = int.Parse(ColID);
            ColToAdd.SchemaID = SchemaID;
            ColToAdd.ColumnIndex = index;
            _enty.Entry(ColToAdd).State = System.Data.Entity.EntityState.Added;
            int res = _enty.SaveChanges();
            if (res > 0)
            {
                ViewBag.saved = "Data saved successfully";
            }
            else
            {
                ViewBag.error = "This Column Already Exists";
            }


            #region Select
            //assigned Col
            var AssignedCol = _enty.DCR_Schema_VIEW.Where(q => q.SchemaID == SchemaID).Select(q => q).ToList().OrderBy(q => q.ColumnIndex);
            if (AssignedCol.Count() > 0)
            {
                ViewBag.AssignedCol = AssignedCol;
            }

            //Team Data
            var Data = _enty.DCR_Schema.Where(q => q.DCR_Schema_ID == SchemaID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_CollectionDCRSchemaCols");
        }
        public ActionResult GetDCRDataDetails(int DomainID)
        {
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                List<string> AccessRights = new List<string>();
                bool? myinformationonly;
                bool haspermissions = Authentication.CheckPermissions("Domain List", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
                if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
                {
                    var alias = _enty.DCR_Column_Alias.Where(q => q.DimainID == DomainID).Select(q => q).ToList();
                    ViewBag.alias = alias;
                    List<Dictionary<string, object>> model = new List<Dictionary<string, object>>();
                    using (var cmd = _enty.Database.Connection.CreateCommand())
                    {
                        _enty.Database.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandText = "DCR_GetDynamicColumn";

                        string List = "";
                        for (int i = 1; i <= alias.Count; i++)
                        {
                            int j = i + 3;
                            List = List + "," + j;
                        }
                        cmd.Parameters.Add(new SqlParameter("@List", List));
                        cmd.Parameters.Add(new SqlParameter("@DomainID", DomainID));
                        using (var reader = cmd.ExecuteReader())
                        {
                            model.AddRange(Read(reader).ToList());
                        }
                    }
                    _enty.Database.Connection.Close();
                    model = model.Distinct().Select(s => s).ToList();
                    var skipfirstrow = _enty.DCR_DomainList.Where(a => a.DomainId == DomainID).Select(s => s.SkipFirstRow).FirstOrDefault();
                    if (model.Count() > 0)
                    {
                        if (skipfirstrow == true)
                            model.RemoveAt(0);
                        ViewBag.Tbl = model;
                    }
                    ViewBag.DomainID = DomainID;
                    var DomainName = _enty.Dom_DomainDetailsList.Where(a => a.DomainID == DomainID).Select(s => s.DomainTitle).FirstOrDefault();
                    ViewBag.DomainName = DomainName;
                    return View();
                }
                else
                {
                    return RedirectToAction("Forbidden", "Account", new
                    {
                        area = ""
                    });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult DCRreports()
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("DCRreports", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions && (AccessRights.Contains("View") || AccessRights.Contains("All")))
            {
                var data = CheckSheetDataScope(myinformationonly);
                var DCRDomainIds = _enty.DCR_DomainList.Select(s => s.DomainId).ToList();
                if (data.Count > 0)
                {
                    var DCRDomains = data.Where(a => DCRDomainIds.Contains((int)a.DomainID)).Select(s => new DCRDOmainData
                    {
                        DomainID = s.DomainID,
                        DomainName = s.DomainTitle,
                        BranchId = s.BranchID,
                        BranchName = s.BranchTitle,
                        AgencyId = s.AgencyID,
                        AgencyName = s.AgencyTitle
                    }).ToList();
                    ViewBag.Data = DCRDomains;
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult BankChange(string id, string Domaintitle, string branchid, string monthid)
        {
            List<string> AccessRights = new List<string>();
            bool? myinformationonly;
            bool haspermissions = Authentication.CheckPermissions("New Domain", Convert.ToInt16(Session["ID"]), out AccessRights, out myinformationonly);
            if (haspermissions)
            {
                if (myinformationonly == true)
                {
                    int userid = int.Parse(Session["ID"].ToString());
                    var user = _enty.Pre_Users.Where(a => a.UserID == userid).Select(s => s).FirstOrDefault();
                    List<int?> BanksScope = _enty.UserDataScopes.Where(a => a.UserId == userid).Select(s => s.BankID).ToList();
                    string BankIDs = BanksScope.Count() > 0 ? string.Join(",", BanksScope) : "";
                    ViewBag.myinfo = myinformationonly; ViewBag.BranchIDs = user.BranchIDs; ViewBag.BankIDs = BankIDs;
                }
            }
            ViewBag.BankId = !string.IsNullOrEmpty(id) ? id : "0";
            ViewBag.Domaintitle = Domaintitle;
            ViewBag.BranchId = !string.IsNullOrEmpty(branchid) ? branchid : "-1";
            ViewBag.MonthId = !string.IsNullOrEmpty(monthid) ? monthid : "-1";
            return PartialView("_DataScope");
        }
        public struct DCRDOmainData
        {
            public long DomainID { get; set; }
            public string DomainName { get; set; }
            public int BranchId { get; set; }
            public int AgencyId { get; set; }
            public string BranchName { get; set; }
            public string AgencyName { get; set; }
        }
        #endregion

        public List<SelectListItem> GetAllBankNames()
        {
            List<BankName> names = new List<BankName>();
            List<SelectListItem> bankNamesList = new List<SelectListItem>();

            string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
            string Querystring = "select  DISTINCT dl.AgencyTitle  AgencyTitle from Dom_DomainList dl";
            SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BankNameTable");
            DataTable dtable = ds.Tables["BankNameTable"];

            names.AddRange(dtable.AsEnumerable().Select(s => new BankName()
            {
                Name = s.Field<string>("AgencyTitle")

            }).ToList());


            bankNamesList.AddRange(names.Select(c => new SelectListItem() { Text = c.Name, Value = c.Name }));

            return bankNamesList;
            //return Json(names.Select(c => new { label = c.Name, value = c.Name }).Distinct().ToList(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetPaymentReport(List<int> years = null, List<int> months = null, List<int> type = null, List<string> bankNames = null)
        {
            List<BankReoprtbyTeamLeader> result = new List<BankReoprtbyTeamLeader>();
            List<SelectListItem> YearsList = new List<SelectListItem>();
            List<SelectListItem> MonthsLists = new List<SelectListItem>();
            ViewBag.BankLists = GetAllBankNames();
            var num = 0.0;

            var bankNameFilter = "";

            if (bankNames != null)
            {
                bankNameFilter = " and(dl.AgencyTitle = '" + bankNames[0] + "'";
                for (var index = 1; index < bankNames.Count; index++)
                {
                    bankNameFilter += " or dl.AgencyTitle= '" + bankNames[index] + "'";
                }

                bankNameFilter += ")";
            }


            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;

            var filter = "";
            if (years == null && months == null && bankNames == null)
            {
                return View("PaymentPerBank");
            }

            if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
            {
                filter = "and(ap.PaymentDate like " + "'%" + years[0] + "'" + " or  dl.MonthYear like " + "'%" + years[0] + "'";

                for (var index = 1; index < years.Count; index++)
                {
                    filter += "or ap.PaymentDate like " + "'%" + years[index] + "'" + " or  dl.MonthYear like " + "'%" + years[index] + "'";
                }

                filter += ")";
            }

            else if (months != null ? months.Count > 0 : false)
            {
                filter = "and(ap.PaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[0] + '-' + years[0] + "'";

                for (var index = 1; index < months.Count; index++)
                {
                    filter += "or ap.PaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[index] + '-' + years[0] + "'"; ;
                }

                filter += ")";
            }


            var schemasID = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();

            foreach (var schemaID in schemasID)
            {

                var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                var NameIndex = schema.Where(a => a.ColumnName == "Team Leader").Select(s => s.ColumnIndex).FirstOrDefault();
                var accountNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
                var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
                var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
                var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();
                if (NameIndex != null && accountNameIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
                {

                    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                    string Querystring = " select dl.MonthYear as DlMonthYear, dl.AgencyTitle AgencyTitle ,  dl.BranchTitle  BranchTitle ,ap.PaymentDate monthyear , dx.Col" + NameIndex +
                        " TeamLeaderName, dx.Col" + DomainTypeIndex + " DomainType ," +
                        "SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN ap.PaymentValue  ELSE 0 end) as WOPayment , "
                         + "SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN  Try_Cast(dx.Col" + PastdueIndex + " AS float)  ELSE 0 end) as WOPD"
                        + " , SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN Try_Cast (dx.Col" + BalanceIndex + " AS float)  ELSE 0 end) as WOBalance"
                        + " ,count (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN  1" + " ELSE 0 end) as WOAcountsNum" +

                   " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN ap.PaymentValue  ELSE 0 end) as ActivePayment"
                         + " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN Try_Cast(dx.Col" + PastdueIndex + " AS float)  ELSE 0 end) as ActivePD"
                        + " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN Try_Cast(dx.Col" + BalanceIndex + " AS float)  ELSE 0 end) as ActiveBalance"
                        + " ,count (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN  1 ELSE 0 end) as ActiveAccountsNum" +



                   " from Dom_DomainList dl  join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID  left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial" + " where dx.Col" + NameIndex + " != ''"
                        + " and dx.SchemaID=" + schemaID
                        + filter + bankNameFilter + " and  (dx.Col" + DomainTypeIndex + "='" + "W/O'" + " or dx.Col" + DomainTypeIndex + "='" + "Active')"
                        + " group by dl.MonthYear, dl.BranchTitle , dl.AgencyTitle,ap.PaymentDate, dl.DomainID , dx.Col" + NameIndex + " , dx.Col" + DomainTypeIndex;

                    SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "PaymentBankTable");
                    DataTable dtable = ds.Tables["PaymentBankTable"];

                    result.AddRange(dtable.AsEnumerable().Select(s => new BankReoprtbyTeamLeader
                    {
                        TeamLeaderName = s.Field<string>("TeamLeaderName"),
                        DomainType = s.Field<string>("DomainType"),
                        ActiveAccountsNum = s.Field<int>("ActiveAccountsNum"),
                        AgencyTitle = s.Field<string>("AgencyTitle"),
                        BranchName = s.Field<string>("BranchTitle"),


                        ActiveOs = string.Format("{0:N0}", s.Field<double>("ActiveBalance")),
                        ActivePD = string.Format("{0:N0}", s.Field<double>("ActivePD")),
                        ActivePayment = s.Field<decimal?>("ActivePayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("ActivePayment")),
                        WOPayment = s.Field<decimal?>("WOPayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("WOPayment")),

                        WOOs = string.Format("{0:N0}", s.Field<double>("WOBalance")),
                        WOPD = string.Format("{0:N0}", s.Field<double>("WOPD")),
                        WOAcountsNum = s.Field<int>("WOAcountsNum"),
                        MonthYear = s.Field<string>("monthyear") != null ?
                             (months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0]) : (months == null ? s.Field<string>("DlMonthYear").Split('-')[1] : s.Field<string>("DlMonthYear").Split('-')[0])

                    }).ToList());
                }
            }
            if (result.Count() > 0)
            {


                ViewBag.BankReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.AgencyTitle, c.MonthYear, c.TeamLeaderName, c.BranchName }).Select(c => new BankReoprtbyTeamLeader()
                {
                    AgencyTitle = c.Key.AgencyTitle,
                    MonthYear = c.Key.MonthYear,
                    TeamLeaderName = c.Key.TeamLeaderName,
                    BranchName = c.Key.BranchName,
                    //DomainType = c.Key.DomainType,
                    ActiveAccountsNum = c.Sum(s => s.ActiveAccountsNum),
                    ActivePayment = c.Sum(s => decimal.Parse(s.ActivePayment)).ToString(),
                    ActiveOs = c.Sum(s => double.Parse(s.ActiveOs)).ToString(),
                    ActivePD = c.Sum(s => double.Parse(s.ActivePD)).ToString(),
                    WOAcountsNum = c.Sum(s => s.WOAcountsNum),
                    WOPayment = c.Sum(s => decimal.Parse(s.WOPayment)).ToString(),
                    WOOs = c.Sum(s => double.Parse(s.WOOs)).ToString(),
                    WOPD = c.Sum(s => double.Parse(s.WOPD)).ToString(),
                }).ToList();

                if (type[0] == 2)
                {
                    return PartialView("_ChartsPerPayment");
                }

            }
            else
            {
                ViewBag.TeamLeaderReportwarning = "No Data Found.";
            }

            return PartialView("_BankList");
        }
        // report 5
        public ActionResult GetPaymentPerBank(List<int> years = null, List<int> months = null, List<int> type = null)
        {
            var schemasID = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();
            var YearsList = new List<SelectListItem>();
            var MonthsLists = new List<SelectListItem>();
            var result = new List<PaymentPerBank>();
            var filter = "";
            var num = 0.0;



            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;

            if (months == null && years == null)
            {
                return View("BankPayment");
            }

            else
            {


                if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
                {
                    filter = "and(ap.PaymentDate like " + "'%" + years[0] + "'" + " or  dl.MonthYear like " + "'%" + years[0] + "'";

                    for (var index = 1; index < years.Count; index++)
                    {
                        filter += "or ap.PaymentDate like " + "'%" + years[index] + "'" + " or  dl.MonthYear like " + "'%" + years[index] + "'";
                    }

                    filter += ")";
                }

                else if (months != null ? months.Count > 0 : false)
                {
                    filter = "and(ap.PaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[0] + '-' + years[0] + "'";

                    for (var index = 1; index < months.Count; index++)
                    {
                        filter += "or ap.PaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[index] + '-' + years[0] + "'"; ;
                    }

                    filter += ")";
                }

            }
            foreach (var schemaID in schemasID)
            {
                var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                var teamLeaderNameIndex = schema.Where(a => a.ColumnName == "Team Leader").Select(s => s.ColumnIndex).FirstOrDefault();
                var accountNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
                var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
                var CodeIndex = schema.Where(a => a.ColumnName == "Collector Code").Select(s => s.ColumnIndex).FirstOrDefault();
                var collectorNameIndex = schema.Where(a => a.ColumnName == "Collector Name").Select(s => s.ColumnIndex).FirstOrDefault();
                var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
                var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();

                if (teamLeaderNameIndex != null && collectorNameIndex != null && accountNameIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
                {

                    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                    string Querystring = " select dl.MonthYear as DlMonthYear, ap.PaymentDate as MonthYear, dl.AgencyTitle AgencyTitle , dx.Col" + teamLeaderNameIndex +
                        " TeamLeaderName , dx.Col" + collectorNameIndex + " CollectorName , " +
                        "SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN ap.PaymentValue  ELSE 0 end) as WOPayment , "
                         + "SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN Try_Cast(dx.Col" + PastdueIndex + " AS float)  ELSE 0 end) as WOPD"
                        + " , SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN Try_Cast(dx.Col" + BalanceIndex + " AS float)  ELSE 0 end) as WOBalance"
                        + " ,count (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN  1 ELSE 0 end) as WOAcountsNum" +

                   " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN ap.PaymentValue  ELSE 0 end) as ActivePayment"
                         + " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN Try_Cast(dx.Col" + PastdueIndex + " AS float)  ELSE 0 end) as ActivePD"
                        + " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN Try_Cast(dx.Col" + BalanceIndex + " AS float)  ELSE 0 end) as ActiveBalance"
                        + " ,count (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN  1 ELSE 0 end) as ActiveAcountsNum" +


                       " from Dom_DomainList dl left join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID left  join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial" + " where dx.Col" + teamLeaderNameIndex + " != ''"
                        + filter + " and dx.SchemaID=" + schemaID
                        + " and  (dx.Col" + DomainTypeIndex + "='" + "W/O'" + " or dx.Col" + DomainTypeIndex + "='" + "Active')"
                        + " group by dl.MonthYear, dl.AgencyTitle,ap.PaymentDate, dl.DomainID , dx.Col" + teamLeaderNameIndex + ", dx.col" + collectorNameIndex;

                    SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "PaymentBankTable");
                    DataTable dtable = ds.Tables["PaymentBankTable"];


                    result.AddRange(dtable.AsEnumerable().Select(s => new PaymentPerBank
                    {
                        TeamLeaderName = s.Field<string>("TeamLeaderName"),

                        AgencyTitle = s.Field<string>("AgencyTitle"),
                        CollectorName = s.Field<string>("CollectorName"),
                        ActiveOs = string.Format("{0:N0}", s.Field<double>("ActiveBalance")),
                        ActivePD = string.Format("{0:N0}", s.Field<double>("ActivePD")),
                        ActiveNumberOfAccounts = s.Field<int>("ActiveAcountsNum"),
                        ActivePayment = s.Field<decimal?>("ActivePayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("ActivePayment")),
                        WOPayment = s.Field<decimal?>("WOPayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("WOPayment")),
                        WOOs = string.Format("{0:N0}", s.Field<double>("WOBalance")),
                        WOPD = string.Format("{0:N0}", s.Field<double>("WOPD")),
                        WONumberOfAccounts = s.Field<int>("WOAcountsNum"),
                        MonthYear = s.Field<string>("monthyear") != null ?
                           (months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0]) : (months == null ? s.Field<string>("DlMonthYear").Split('-')[1] : s.Field<string>("DlMonthYear").Split('-')[0])

                    }).ToList());
                }
            }
            if (result.Count() > 0)
            {
                ViewBag.type = type[0];
                if (type[0] == 1)
                {
                    ViewBag.BankReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.CollectorName, c.TeamLeaderName, c.AgencyTitle, c.MonthYear }).Select(c => new PaymentPerBank()
                    {
                        CollectorName = c.Key.CollectorName,
                        TeamLeaderName = c.Key.TeamLeaderName,
                        AgencyTitle = c.Key.AgencyTitle,
                        MonthYear = c.Key.MonthYear,
                        ActivePayment = c.Sum(s => double.Parse(s.ActivePayment)).ToString(),
                        ActiveOs = c.Sum(s => double.Parse(s.ActiveOs)).ToString(),
                        ActivePD = c.Sum(s => double.Parse(s.ActivePD)).ToString(),
                        ActiveNumberOfAccounts = c.Sum(s => s.ActiveNumberOfAccounts),
                        WOPayment = c.Sum(s => double.Parse(s.WOPayment)).ToString(),
                        WOOs = c.Sum(s => double.Parse(s.WOOs)).ToString(),
                        WOPD = c.Sum(s => double.Parse(s.WOPD)).ToString(),
                        WONumberOfAccounts = c.Sum(s => s.WONumberOfAccounts)
                    }).ToList();
                }
                else
                {
                    ViewBag.BankReport = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.TeamLeaderName, c.AgencyTitle, c.MonthYear }).Select(c => new PaymentPerBank()
                    {

                        TeamLeaderName = c.Key.TeamLeaderName,
                        AgencyTitle = c.Key.AgencyTitle,
                        MonthYear = c.Key.MonthYear,
                        ActivePayment = c.Sum(s => double.Parse(s.ActivePayment)).ToString(),
                        ActiveOs = c.Sum(s => double.Parse(s.ActiveOs)).ToString(),
                        ActivePD = c.Sum(s => double.Parse(s.ActivePD)).ToString(),
                        ActiveNumberOfAccounts = c.Sum(s => s.ActiveNumberOfAccounts),
                        WOPayment = c.Sum(s => double.Parse(s.WOPayment)).ToString(),
                        WOOs = c.Sum(s => double.Parse(s.WOOs)).ToString(),
                        WOPD = c.Sum(s => double.Parse(s.WOPD)).ToString(),
                        WONumberOfAccounts = c.Sum(s => s.WONumberOfAccounts)
                    }).ToList();

                }
            }
            else
            {
                ViewBag.BankReportwarning = "No Dtata Found.";
            }

            return PartialView("_BankPayment");
        }

        public ActionResult GetLegalPaymentPerBank(List<int> years = null, List<int> months = null)
        {
            List<LegalPayment> result = new List<LegalPayment>();
            List<LegalPayment> result1 = new List<LegalPayment>();
            var schemasID = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();

            var YearsList = new List<SelectListItem>();
            var MonthsLists = new List<SelectListItem>();
            var filter = "";



            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;

            if (months == null && years == null)
            {
                return View("LegalPayment");
            }

            else
            {


                if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
                {
                    filter = "and(ap.PaymentDate like " + "'%" + years[0] + "'" + " or  dl.MonthYear like " + "'%" + years[0] + "'";

                    for (var index = 1; index < years.Count; index++)
                    {
                        filter += "or ap.PaymentDate like " + "'%" + years[index] + "'" + " or  dl.MonthYear like " + "'%" + years[index] + "'";
                    }

                    filter += ")";
                }

                else if (months != null ? months.Count > 0 : false)
                {
                    filter = "and(ap.PaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[0] + '-' + years[0] + "'";

                    for (var index = 1; index < months.Count; index++)
                    {
                        filter += "or ap.PaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'" + " or  dl.MonthYear like " + "'" + months[index] + '-' + years[0] + "'"; ;
                    }

                    filter += ")";
                }

            }


            foreach (var schemaID in schemasID)
            {


                var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                var NameIndex = schema.Where(a => a.ColumnName == "Team Leader").Select(s => s.ColumnIndex).FirstOrDefault();
                var legalFieldIndex = schema.Where(a => a.ColumnName == "Legal Action").Select(s => s.ColumnIndex).FirstOrDefault();
                var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();


                if (NameIndex != null && legalFieldIndex != null && DomainTypeIndex != null)
                {

                    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                    string Querystring = " select dl.MonthYear as DlMonthYear, ap.PaymentDate as MonthYear, dl.AgencyTitle AgencyTitle ,  dl.BranchTitle  BranchTitle , dx.Col" + NameIndex +
                        " TeamLeaderName " + " ,dx.col" + DomainTypeIndex + " DomainType ,SUM (ap.PaymentValue) Payment, SUM (CASE WHEN lower( dx.col" + legalFieldIndex + ") = 'yes' THEN ap.PaymentValue    ELSE 0 end) as LegalPayment ,  SUM (CASE WHEN lower( dx.col" + legalFieldIndex + ") = 'no' THEN ap.PaymentValue    ELSE 0 end) as UnLegalPayment from Dom_DomainList dl  join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID  left join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial" + " where dx.SchemaID= " + schemaID + " and ap.PaymentDate!=''and  dx.Col" + NameIndex + " != ''" + filter
                        + " group by dl.MonthYear, ap.PaymentDate,dl.BranchTitle , dl.AgencyTitle, dx.Col" + NameIndex + " ,dx.col" + legalFieldIndex + " , dx.col" + DomainTypeIndex;
                    SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "LegalPaymntTable");
                    DataTable dtable = ds.Tables["LegalPaymntTable"];
                    var num = 0.0;
                    result.AddRange(dtable.AsEnumerable().Select(s => new LegalPayment
                    {
                        TeamLeaderName = s.Field<string>("TeamLeaderName"),
                        PaymentAmount = s.Field<decimal?>("Payment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("Payment")),
                        LegalPaymentAmount = s.Field<decimal?>("LegalPayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("LegalPayment")),
                        UnLegalPayment = s.Field<decimal?>("UnLegalPayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("UnLegalPayment")),
                        AgencyTitle = s.Field<string>("AgencyTitle"),
                        BranchName = s.Field<string>("BranchTitle"),
                        MonthYear = s.Field<string>("monthyear") != null ?
                              (months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0]) : (months == null ? s.Field<string>("DlMonthYear").Split('-')[1] : s.Field<string>("DlMonthYear").Split('-')[0])
                    }).ToList());
                }
            }

            if (result.Count() > 0)
            {
                ViewBag.LegalPayment = result.Where(c => int.Parse(c.MonthYear) <= years.Max()).GroupBy(c => new { c.TeamLeaderName, c.MonthYear, c.AgencyTitle, c.BranchName }).Select(c =>
                    new LegalPayment()
                    {
                        TeamLeaderName = c.Key.TeamLeaderName,
                        MonthYear = c.Key.MonthYear,
                        AgencyTitle = c.Key.AgencyTitle,
                        BranchName = c.Key.BranchName,
                        LegalPaymentAmount = c.Sum(s => double.Parse(s.LegalPaymentAmount)).ToString(),
                        UnLegalPayment = c.Sum(s => double.Parse(s.UnLegalPayment)).ToString(),
                        PaymentAmount = c.Sum(s => double.Parse(s.PaymentAmount)).ToString(),
                    }).ToList();
            }

            else
            {
                ViewBag.LegalPaymentWarning = "No Data";
            }

            return PartialView("_LegalPayment");
        }


        public ActionResult GetDailyReportPerBranch(List<int> months = null, List<int> days = null, List<int> years = null, List<string> bankNames = null)
        {
            List<DailyBankReportPerBranch> result = new List<DailyBankReportPerBranch>();
            List<SelectListItem> YearsList = new List<SelectListItem>();
            List<SelectListItem> MonthsLists = new List<SelectListItem>();
            ViewBag.BankLists = GetAllBankNames();
            if (days != null)
            {
                ViewBag.days = days;
            }



            for (var i = DateTime.UtcNow.Year; i >= 2010; i--)
            {
                YearsList.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            var MonthsList = Enum.GetValues(typeof(enum_Months.eMonths));

            foreach (var item in MonthsList)
            {
                MonthsLists.Add(new SelectListItem { Text = Enum.GetName(typeof(enum_Months.eMonths), item), Value = ((int)item).ToString() });
            }



            var bankNameFilter = "";

            if (bankNames != null)
            {
                bankNameFilter = " and(dl.AgencyTitle = '" + bankNames[0] + "'";
                for (var index = 1; index < bankNames.Count; index++)
                {
                    bankNameFilter += " or dl.AgencyTitle= '" + bankNames[index] + "'";
                }

                bankNameFilter += ")";
            }

            ViewBag.MonthsLists = MonthsLists;
            ViewBag.YearsList = YearsList;

            var filter = "";
            if (years == null && months == null)
            {
                return View("DailyReportPerBranch");
            }

            if ((months != null ? months.Count == 0 : true) && (years != null ? years.Count > 0 : false))
            {
                filter = "and(ap.DailyPaymentDate like " + "'%" + years[0] + "'";

                for (var index = 1; index < years.Count; index++)
                {
                    filter += "or ap.DailyPaymentDate like " + "'%" + years[index] + "'";
                }

                filter += ")";
            }

            else if (months != null ? months.Count > 0 : false)
            {
                filter = "and(ap.DailyPaymentDate like " + "'" + months[0] + "/" + "%/" + years[0] + "'";

                for (var index = 1; index < months.Count; index++)
                {
                    filter += "or ap.DailyPaymentDate like  " + "'" + months[index] + "/" + "%/" + years[0] + "'";
                }

                filter += ")";
            }


            var schemasID = _enty.Dom_DomainsDataExtra.Select(s => s.SchemaID).Distinct().ToList();

            foreach (var schemaID in schemasID)
            {

                var schema = _enty.Sch_SchemaColList.Where(a => a.SchemaID == schemaID).ToList();
                var NameIndex = schema.Where(a => a.ColumnName == "Team Leader").Select(s => s.ColumnIndex).FirstOrDefault();
                var accountNameIndex = schema.Where(a => a.ColumnName == "Account Name").Select(s => s.ColumnIndex).FirstOrDefault();
                var DomainTypeIndex = schema.Where(a => a.ColumnName == "Domain Type").Select(s => s.ColumnIndex).FirstOrDefault();
                var PastdueIndex = schema.Where(a => a.ColumnName == "Past Due").Select(s => s.ColumnIndex).FirstOrDefault();
                var BalanceIndex = schema.Where(a => a.ColumnName == "Balance").Select(s => s.ColumnIndex).FirstOrDefault();
                if (NameIndex != null && accountNameIndex != null && DomainTypeIndex != null && PastdueIndex != null && BalanceIndex != null)
                {

                    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                    string Querystring = " select dl.AgencyTitle AgencyTitle ,  dl.BranchTitle  BranchTitle ,ap.DailyPaymentDate monthyear , dx.Col" + NameIndex +
                        " TeamLeaderName, dx.Col" + DomainTypeIndex + " DomainType ," +
                        "SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN ap.DailyPaymentValue  ELSE 0 end) as WOPayment , "
                         + "SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN ISNULL(Try_Cast(dx.Col" + PastdueIndex + " AS float),0)  ELSE 0 end) as WOPD"
                        + " , SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN ISNULL(Try_Cast(dx.Col" + BalanceIndex + "  AS float),0)  ELSE 0 end) as WOBalance"
                        + " ,count (CASE WHEN dx.col" + DomainTypeIndex + " = 'W/O' THEN  1" + " ELSE 0 end) as WOAcountsNum" +

                   " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN ap.DailyPaymentValue  ELSE 0 end) as ActivePayment"
                         + " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN ISNULL(Try_Cast(dx.Col" + PastdueIndex + " AS float),0)  ELSE 0 end) as ActivePD"
                        + " ,SUM (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN ISNULL(Try_Cast(dx.Col" + BalanceIndex + " AS float),0)  ELSE 0 end) as ActiveBalance"
                        + " ,count (CASE WHEN dx.col" + DomainTypeIndex + " = 'Active' THEN  1 ELSE 0 end) as ActiveAccountsNum" +



                   " from Dom_DomainList dl left join Dom_DomainsDataExtra dx on dl.DomainID = dx.DomainID  left  join Dom_AccountsPayments ap on dx.RecordSerial = ap.RecordSerial" + " where dx.Col" + NameIndex + " != ''"
                        + " and dx.SchemaID=" + schemaID
                        + filter + bankNameFilter + " and  (dx.Col" + DomainTypeIndex + "='" + "W/O'" + " or dx.Col" + DomainTypeIndex + "='" + "Active')"
                        + " group by dl.BranchTitle , dl.AgencyTitle,ap.DailyPaymentDate, dl.DomainID , dx.Col" + NameIndex + " , dx.Col" + DomainTypeIndex;

                    SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "PaymentBankTable");
                    DataTable dtable = ds.Tables["PaymentBankTable"];
                    var num = 0.0;
                    result.AddRange(dtable.AsEnumerable().Select(s => new DailyBankReportPerBranch
                    {
                        TeamLeaderName = s.Field<string>("TeamLeaderName"),
                        ActiveAccountsNum = s.Field<int>("ActiveAccountsNum"),
                        AgencyTitle = s.Field<string>("AgencyTitle"),
                        BranchName = s.Field<string>("BranchTitle"),
                        ActiveOs = string.Format("{0:N0}", s.Field<double>("ActiveBalance")),
                        ActivePD = string.Format("{0:N0}", s.Field<double>("ActivePD")),
                        ActivePayment = s.Field<decimal?>("ActivePayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("ActivePayment")),
                        WOPayment = s.Field<decimal?>("WOPayment") == null ? num.ToString() : string.Format("{0:N0}", s.Field<decimal?>("WOPayment")),
                        WOOs = string.Format("{0:N0}", s.Field<double>("WOBalance")),
                        WOPD = string.Format("{0:N0}", s.Field<double>("WOPD")),
                        WOAcountsNum = s.Field<int>("WOAcountsNum"),

                        MonthYear = days == null ? months == null ? s.Field<string>("monthyear").Split('/')[2] : s.Field<string>("monthyear").Split('/')[0] : s.Field<string>("monthyear").Split('/')[1]
                    }).ToList());
                }
            }
            if (result.Count() > 0)
            {
                if (days != null)
                {
                    result = result.Where(c => int.Parse(c.MonthYear) <= days[0]).ToList();
                    ViewBag.BankReport = result.GroupBy(c => new { c.TeamLeaderName, c.AgencyTitle, c.BranchName }).Select(c =>
                        new DailyBankReportPerBranch()
                        {
                            TeamLeaderName = c.Key.TeamLeaderName,
                            AgencyTitle = c.Key.AgencyTitle,
                            BranchName = c.Key.BranchName,
                            MonthYear = days[0].ToString(),
                            WOAcountsNum = c.Sum(s => s.WOAcountsNum),
                            WOOs = c.Sum(s => double.Parse(s.WOOs)).ToString(),
                            WOPD = c.Sum(s => double.Parse(s.WOPD)).ToString(),
                            WOPayment = c.Sum(s => double.Parse(s.WOPayment)).ToString(),
                            ActivePayment = c.Sum(s => double.Parse(s.ActivePayment)).ToString(),
                            ActiveOs = c.Sum(s => double.Parse(s.ActiveOs)).ToString(),
                            ActivePD = c.Sum(s => double.Parse(s.ActivePD)).ToString()

                        }).ToList();
                }
                else
                {

                    ViewBag.BankReport = result.GroupBy(c => new { c.TeamLeaderName, c.AgencyTitle, c.BranchName, c.MonthYear }).Select(c =>
                        new DailyBankReportPerBranch()
                        {
                            TeamLeaderName = c.Key.TeamLeaderName,
                            AgencyTitle = c.Key.AgencyTitle,
                            BranchName = c.Key.BranchName,
                            MonthYear = c.Key.MonthYear,
                            WOAcountsNum = c.Sum(s => s.WOAcountsNum),
                            WOOs = c.Sum(s => double.Parse(s.WOOs)).ToString(),
                            WOPD = c.Sum(s => double.Parse(s.WOPD)).ToString(),
                            WOPayment = c.Sum(s => double.Parse(s.WOPayment)).ToString(),
                            ActivePayment = c.Sum(s => double.Parse(s.ActivePayment)).ToString(),
                            ActiveOs = c.Sum(s => double.Parse(s.ActiveOs)).ToString(),
                            ActivePD = c.Sum(s => double.Parse(s.ActivePD)).ToString()

                        }).ToList();
                }
            }
            else
            {
                ViewBag.DailyReportwarning = "No Data Found.";
            }

            return PartialView("_dailyReportPerBranch");

        }


        public ActionResult SaveEmployeesData()
        {
            var connectionString = "";
            string BalanceColName = "";
            string PastDueColName = "";
            bool Error = false;
            int userid = int.Parse(Session["ID"].ToString());
            var file = AppDomain.CurrentDomain.BaseDirectory + "Files\\Copy of Collection codes.xlsx";
            //var file = "Files\\Copy of Collection codes.xlsx";
            var excelFile = new ExcelQueryFactory(file);
            #region get in datatable
            //get in datatable
            connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", file);
            var SheetName = "Sheet1";
            //var adapter = new OleDbDataAdapter(" Update [Sheet1$] set Name = 'New Name' where Code=10 ;",  connectionString); 
            var adapter = new OleDbDataAdapter("  SELECT * FROM [" + SheetName + "$]"
, connectionString);


            var ds = new DataSet();

            adapter.Fill(ds, "ExcelTable");

            DataTable dtable = ds.Tables["ExcelTable"];
            string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;




            //dtable.Columns[PastDueCol - 1].ColumnName;
            #endregion
            //Check Schema
            int NumberOfColOfExcel = dtable.Columns.Count;


            foreach (DataRow R in dtable.Rows)
            {
                var query = "exec InsertEmployee  '" + R["Code"] + "' , '" + R["Name"] + "' , '" + R["Job Title"] + "' , '" + R["Office"]
                    + "'";

                //SqlDataAdapter adapter2 = new SqlDataAdapter(query, connstring);
                //SqlCommand command = new SqlCommand(query);
                //adapter2.InsertCommand =command;
                // }
                //   



                connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = query;

                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                }
            }

            return View();
        }

        public FileResult Chart(string hfChartData)
        {
            var chartdata = hfChartData.Split('|');
            byte [] bytes = null;
            string html="";
            var index=1;
            foreach (var item in chartdata)
            {
                byte[] bytesImage = Convert.FromBase64String(item.Replace("data:image/jpeg;base64,", ""));
                 
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
               
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                System.IO.File.WriteAllBytes(path + "\\Chart"+ index+".jpg", bytesImage);
                html += string.Format("   <table style='padding-top:20em;'><tr><td>&nbsp;</td></tr></table><div  style='padding-top:20em;' >&nbsp;  &nbsp;   &nbsp; </div>   <img  style='padding-top:20em;' src='{0}' /> ", path + "\\Chart" + index + ".jpg");
                 index++;
            }

            bytes = Encoding.ASCII.GetBytes(html);
            
            return File(bytes, "application/vnd.ms-excel", "Grid.xls");
            
           
        }
    }
}