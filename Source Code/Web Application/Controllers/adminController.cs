using EIF.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Data;
using EIF.Helper;

namespace EIF.Controllers
{
    public class adminController : Controller
    {
        AdminEntities _enty = new AdminEntities();
        string url = EIF.PublicConfig.URL;
        // GET: /admin/
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

        #region UsersManagement
        public ActionResult UsersManagement()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    AfterLogin();
                    var Accounts = _enty.Pre_Users.Where(q => q.IsDeleted == false).Select(q => q).ToList();
                    if (Accounts.Count() > 0)
                    {
                        ViewBag.Accounts = Accounts;
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


        [HttpGet]
        public ActionResult NewUser()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;
            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                AfterLogin();

                return View();
            }
            else
            {
                //page to redirect
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        [HttpPost]
        public ActionResult NewUser(FormCollection frm)
        {
            AfterLogin();
            List<string> Msg = new List<string>();

            string DisplayName = frm["DisplayName"];
            string UserName = frm["Name"];
            string Password = frm["NewPass"];
            string ConfirmPassword = frm["ConfirmPass"];
            string SectionIDs = frm["SectionID"];
            string BranchID = frm["BrunchID"];
            string GroupID = frm["GroupID"];
            string OfficeId = frm["OfficeId"];
            //string BankID = frm["BankID"];
            //string ProductID = frm["ProductID"];
            //string TypeID = frm["TypeID"];
            //string RegionID = frm["RegionID"];

            try
            {
                if (UserName.Length == 0)
                {
                    Msg.Add("- Enter Username");
                }
                if (DisplayName.Length == 0)
                {
                    Msg.Add("- Enter Display Name");
                }
                if (Password.Length == 0)
                {
                    Msg.Add("- Enter Password");
                }
                if (ConfirmPassword.Length == 0)
                {
                    Msg.Add("- Enter Confirm Password");
                }
                if (!Password.Equals(ConfirmPassword))
                {
                    Msg.Add("- Passwrd and Confirm Password not match");
                }
                //if (SectionIDs.Length == 0)
                //{
                //    Msg.Add("- Choose Section");
                //}
                if (BranchID.Length == 0)
                {
                    Msg.Add("- Choose Branch");
                }
                if (GroupID.Length == 0)
                {
                    Msg.Add("- Choose Group");
                }
                //if (BankID.Length == 0)
                //{
                //    Msg.Add("- Choose Bank");
                //}
                //if (ProductID.Length == 0)
                //{
                //    Msg.Add("- Choose Product");
                //}
                //if (TypeID.Length == 0)
                //{
                //    Msg.Add("- Choose Type");
                //}
                //if (RegionID.Length == 0)
                //{
                //    Msg.Add("- Choose Region");
                //}
                string ExistUsrName = _enty.Pre_Users.Where(q => q.UserName == UserName).Select(q => q.UserName).FirstOrDefault();
                if (ExistUsrName != null)
                {
                    Msg.Add("- Username is already exist");
                }

                byte[] Image;
                if (frm["img-val"].Length > 0)
                {
                    Image = ResizeImg(Convert.FromBase64String(frm["img-val"]));
                }
                else
                {
                    Image = null;
                }

                //no null
                if (Msg.Count > 0)
                {
                    ViewBag.Msg = Msg;
                }
                if (ViewBag.Msg == null)
                {
                    int res = _enty.pre_UsersInsert(DisplayName, UserName, Password, Image, Convert.ToInt16(GroupID), true, DateTime.Now.Date, Convert.ToInt16(Session["ID"]), BranchID, Convert.ToInt16(OfficeId));
                    if (res > 0)
                    {
                        ViewBag.saved = "Data saved successfully";
                    }
                }
                return PartialView("_Result");


            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult EditUser(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;
            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                AfterLogin();
                Pre_UsersView usr = _enty.Pre_UsersView.Where(q => q.UserID == id).Select(q => q).FirstOrDefault();
                if (usr != null)
                {
                    ViewBag.UserData = usr;
                }
                return View();
            }
            else
            {
                //page to redirect
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        [HttpPost]
        public ActionResult EditUser(FormCollection frm)
        {
            AfterLogin();
            List<string> Msg = new List<string>();

            short id = Convert.ToInt16(frm["id"]);
            string DisplayName = frm["DisplayName"];
            string UserName = frm["Name"];
            string Password = frm["NewPass"];
            string ConfirmPassword = frm["ConfirmPass"];
            string SectionIDs = frm["SectionID"] != null ? frm["SectionID"] : "";
            string BranchID = frm["BrunchID"] != null ? frm["BrunchID"] : "";
            string GroupID = frm["GroupID"] != null ? frm["GroupID"] : "";
            string OfficeId = frm["OfficeId"] != null ? frm["OfficeId"] : "";
            //string BankID = frm["BankID"] != null ?frm["BankID"] : "" ;
            //string ProductID = frm["ProductID"] != null ?frm["ProductID"] : "" ;
            //string TypeID = frm["TypeID"] != null ? frm["TypeID"] : "";
            //string RegionID = frm["RegionID"] != null ? frm["RegionID"] : "";

            try
            {
                if (UserName.Length == 0)
                {
                    Msg.Add("- Enter Username");
                }
                if (DisplayName.Length == 0)
                {
                    Msg.Add("- Enter Display Name");
                }

                string ExistUsrName = _enty.Pre_Users.Where(q => q.UserName == UserName && q.UserID != id).Select(q => q.UserName).FirstOrDefault();
                if (ExistUsrName != null)
                {
                    Msg.Add("- Username is already exist");
                }
                //if (BankID.Length == 0)
                //{
                //    Msg.Add("- Choose Bank");
                //}
                //if (ProductID.Length == 0)
                //{
                //    Msg.Add("- Choose Product");
                //}
                //if (TypeID.Length == 0)
                //{
                //    Msg.Add("- Choose Type");
                //}
                //if (RegionID.Length == 0)
                //{
                //    Msg.Add("- Choose Region");
                //}
                byte[] Image;
                if (frm["img-val"].Length > 0)
                {
                    Image = ResizeImg(Convert.FromBase64String(frm["img-val"]));
                    Pre_Users usr = _enty.Pre_Users.Find(id);
                    if (usr != null)
                    {
                        usr.ProfileImage = Image;
                        _enty.Entry(usr).State = System.Data.Entity.EntityState.Modified;
                        _enty.SaveChanges();

                    }
                }

                //no null
                if (Msg.Count > 0)
                {
                    ViewBag.Msg = Msg;
                }
                if (ViewBag.Msg == null)
                {
                    int res = _enty.pre_UsersEdit(id, DisplayName, UserName, Convert.ToInt16(GroupID), DateTime.Now.Date, Convert.ToInt16(Session["ID"]), BranchID, Convert.ToInt16(OfficeId));
                    if (res > 0)
                    {
                        ViewBag.saved = "Data saved successfully";
                    }
                }
                return PartialView("_Result");


            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult ResetPassword(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;
            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                AfterLogin();

                ViewBag.ID = id;
                return View();
            }
            else
            {
                //page to redirect
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }

        [HttpPost]
        public ActionResult ResetPassword(FormCollection frm)
        {
            AfterLogin();
            List<string> Msg = new List<string>();

            string Password = frm["NewPass"];
            string ConfirmPassword = frm["ConfirmPass"];
            short id = Convert.ToInt16(frm["id"]);

            try
            {
                if (Password.Length == 0)
                {
                    Msg.Add("- Enter Password");
                }
                if (ConfirmPassword.Length == 0)
                {
                    Msg.Add("- Enter Confirm Password");
                }
                if (!Password.Equals(ConfirmPassword))
                {
                    Msg.Add("- Passwrd and Confirm Password not match");
                }


                //no null
                if (Msg.Count > 0)
                {
                    ViewBag.Msg = Msg;
                }
                if (ViewBag.Msg == null)
                {
                    int res = _enty.Pre_UserPasswordReset(id, Password);
                    if (res == 1)
                    {
                        ViewBag.saved = "Data saved successfully";
                    }
                }
                return PartialView("_Result");


            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult ActivateAccount(string id, string active)
        {
            int ID = Convert.ToInt16(id);
            Pre_Users usr = _enty.Pre_Users.Find(ID);
            if (usr != null)
            {
                if (active == "0")
                {
                    usr.IsActive = false;
                }
                else if (active == "1")
                {
                    usr.IsActive = true;
                }
                _enty.Entry(usr).State = System.Data.Entity.EntityState.Modified;
                _enty.SaveChanges();
            }



            //get list
            var Accounts = _enty.Pre_Users.Where(q => q.IsDeleted == false).Select(q => q).ToList();
            if (Accounts.Count() > 0)
            {
                ViewBag.Accounts = Accounts;
            }

            return PartialView("_AdminUsersManagementList");
        }
        [HttpGet]
        public ActionResult AddDataScope(int id)
        {
            var userdatascopelst = _enty.UserDataScopes.Where(a => a.UserId == id).Select(s => s).ToList();
            ViewBag.Data = userdatascopelst;
            ViewBag.UserId = id;
            return View();
        }
        public ActionResult NewDataScope(string BankID, string ProductID, string TypeID, string RegionID, string CityID, string UserId)
        {
            List<string> Msg = new List<string>();
            ViewBag.UserId = UserId;
            var _userid = int.Parse(UserId);
            if (string.IsNullOrEmpty(RegionID))
            {
                RegionID = "0";
            }
            if (string.IsNullOrEmpty(BankID))
            {
                Msg.Add("- Enter Bank");
            }
            if (string.IsNullOrEmpty(ProductID))
            {
                ProductID = "-1";
            }
            if (string.IsNullOrEmpty(TypeID))
            {
                TypeID = "-1";
            }
            if (Msg.Count > 0)
            {
                ViewBag.Msg = Msg;
                return PartialView("_Result");
            }
            else
            {
                var _productid = int.Parse(ProductID); var _typid = int.Parse(TypeID); var _bankid = int.Parse(BankID);
                try
                {
                    var res = _enty.UserDataScopeInsert(_bankid, _productid, _typid, RegionID, CityID, _userid);
                }
                catch
                {
                    ViewBag.error = "Error while saving in data base";
                    return PartialView("_Result");
                }
            }
            var userdatascopelst = _enty.UserDataScopes.Where(a => a.UserId == _userid).Select(s => s).ToList();
            ViewBag.Data = userdatascopelst;
            return PartialView("_AdminDataScope");
        }
        [HttpPost]
        public ActionResult EditDataScope(string BankID, string ProductID, string TypeID, string RegionID, string CityID, string ID)
        {
            List<string> Msg = new List<string>();
            if (string.IsNullOrEmpty(RegionID))
            {
                RegionID = "0";
            }
            if (string.IsNullOrEmpty(BankID))
            {
                Msg.Add("- Enter Bank");
            }
            if (string.IsNullOrEmpty(ProductID))
            {
                ProductID = "-1";
            }
            if (string.IsNullOrEmpty(TypeID))
            {
                TypeID = "-1";
            }
            if (Msg.Count > 0)
            {
                ViewBag.Msg = Msg;
                return PartialView("_Result");
            }
            else
            {
                var _id = int.Parse(ID); var _productid = int.Parse(ProductID); var _typid = int.Parse(TypeID); var _bankid = int.Parse(BankID); ;
                try
                {
                    var res = _enty.UserDataScopeEdit(_id, _bankid, _productid, _typid, RegionID, CityID);
                    ViewBag.saved = "Data saved successfully";
                }
                catch
                {
                    ViewBag.error = "Error while saving in data base";
                }
            }
            return PartialView("_Result");
        }
        [HttpPost]
        public ActionResult DeleteDataScope(string ID)
        {
            try
            {
                var _id = int.Parse(ID);
                var res = _enty.UserDataScopeDelete(_id);
                if (res > 0)
                    ViewBag.saved = "Data saved successfully";
            }
            catch
            {
                ViewBag.error = "Error while saving in data base";
            }
            return PartialView("_Result");
        }
        #endregion
        public ActionResult UsersGroups()
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
        public ActionResult BranchList()
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

        #region Agency
        public ActionResult Agency()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    var data = _enty.Config_AgencyList.Select(q => q).ToList();
                    if (data.Count() > 0)
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
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult NewAgency(string Name, string BranchIDs, bool Active)
        {
            if (BranchIDs.Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Config_AgencyList.Where(q => q.AgencyTitle == Name).Select(q => q.AgencyTitle).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    int res = _enty.Config_AgencyListInsert(Name, BranchIDs, Active);
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                    }

                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Agency Name";
                }
                if (BranchIDs.Length == 0)
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
            var data = _enty.Config_AgencyList.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            //save new agency
            return PartialView("_Result");
        }
        public ActionResult EditAgency(byte id, string Name, string BranchIDs, bool Active)
        {
            if (BranchIDs.Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Config_AgencyList.Where(q => q.AgencyTitle == Name && q.AgencyID != id).Select(q => q.AgencyTitle).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    int res = _enty.Config_AgencyListUpdate(id, Name, BranchIDs, Active);
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                    }
                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Agency Name";
                }
                if (BranchIDs.Length == 0)
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
        public ActionResult ActivateAgency(string id, string active)
        {
            int ID = Convert.ToInt16(id);
            var rec = _enty.Config_AgencyList.Find(ID);
            if (rec != null)
            {
                if (active == "0")
                {
                    rec.IsActive = false;
                }
                else if (active == "1")
                {
                    rec.IsActive = true;
                }
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                _enty.SaveChanges();
            }



            //get list
            var data = _enty.Config_AgencyList.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            return PartialView("_AdminAgency");
        }
        public ActionResult RefreshAgency()
        {
            var data = _enty.Config_AgencyList.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            return PartialView("_AdminAgency");
        }
        #endregion

        #region TeamManagement
        public ActionResult TeamManagement()
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    var data = _enty.Config_TeamList.Select(q => q).ToList();
                    if (data.Count() > 0)
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
                return RedirectToAction("Login", "Account", new
                {
                    area = ""
                });
            }
        }
        public ActionResult NewTeam(string Name, byte BranchID, int AgencyID, bool Active)
        {
            if (Convert.ToString(AgencyID).Length > 0 && Convert.ToString(BranchID).Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Config_TeamList.Where(q => q.TeamName == Name).Select(q => q.TeamName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    int res = _enty.Config_TeamListInsert(BranchID, AgencyID, Name, Active);
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                    }

                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Team Name";
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
                if (Convert.ToString(AgencyID).Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Agency";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Agency";
                    }

                }

            }
            var data = _enty.Config_AgencyList.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            //save new agency
            return PartialView("_Result");
        }
        public ActionResult EditTeam(byte id, string Name, byte BranchID, int AgencyID, bool Active)
        {
            if (Convert.ToString(AgencyID).Length > 0 && Convert.ToString(BranchID).Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Config_TeamList.Where(q => q.TeamName == Name && q.TeamID != id).Select(q => q.TeamName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    int res = _enty.Config_TeamListUpdate(id, BranchID, AgencyID, Name, Active);
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                    }
                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Team Name";
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
                if (Convert.ToString(AgencyID).Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Agency";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Agency";
                    }

                }

            }

            //save new agency
            return PartialView("_result");
        }
        public ActionResult ActivateTeam(string id, string active)
        {
            int ID = Convert.ToInt16(id);
            var rec = _enty.Config_TeamList.Find(ID);
            if (rec != null)
            {
                if (active == "0")
                {
                    rec.IsActive = false;
                }
                else if (active == "1")
                {
                    rec.IsActive = true;
                }
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                _enty.SaveChanges();

            }


            //get list
            var data = _enty.Config_TeamList.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            return PartialView("_AdminTeamList");
        }
        public ActionResult RefreshTeam()
        {
            var data = _enty.Config_TeamList.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            return PartialView("_AdminTeamList");
        }
        public ActionResult TeamMembers(int id)
        {
            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }
            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {
                    //assigned members
                    var AssignedMembers = _enty.Config_TeamMembersList.Where(q => q.TeamID == id).Select(q => q.MemberID).ToList();
                    if (AssignedMembers.Count() > 0)
                    {
                        ViewBag.AssignedMembers = AssignedMembers;
                    }
                    //all members
                    var Members = _enty.Config_MembersList.Select(q => q).ToList();
                    if (Members.Count() > 0)
                    {
                        ViewBag.Members = Members;
                    }
                    //Team Data
                    var Data = _enty.Config_TeamList.Where(q => q.TeamID == id).Select(q => q).FirstOrDefault();
                    if (Data != null)
                    {
                        ViewBag.Data = Data;
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
        public ActionResult AddTeamMembers(string ToDeletePageIDs, int id, string list)
        {

            //insert
            if (list.Length > 0)
            {
                List<list> data;
                JavaScriptSerializer jss = new JavaScriptSerializer();
                data = jss.Deserialize<List<list>>(list);
                if (data != null)
                {
                    //_enty.Pro_ProductPropDel(Convert.ToInt16(ProID));
                    foreach (var item in data)
                    {
                        if (item.id != null)
                        {
                            int res = _enty.Config_TeamMembersInsert(id, Convert.ToInt16(item.id), Convert.ToInt16(item.val));
                            if (res > 0)
                            {
                                ViewBag.saved = "Data saved successfully";
                            }
                        }
                    }
                }

            }
            //Delete
            if (ToDeletePageIDs != "" && ToDeletePageIDs != "on")
            {
                ToDeletePageIDs = ToDeletePageIDs.Replace("on,", "");
                ToDeletePageIDs = ToDeletePageIDs.Replace(",on", "");

                var Delete = ToDeletePageIDs.Split(',');


                foreach (string s in Delete.ToArray())
                {

                    var ToDel = _enty.Config_TeamMembersDelete(id, Convert.ToInt16(s));
                }
            }


            #region Select
            //assigned members
            var AssignedMembers = _enty.Config_TeamMembersList.Where(q => q.TeamID == id).Select(q => q.MemberID).ToList();
            if (AssignedMembers.Count() > 0)
            {
                ViewBag.AssignedMembers = AssignedMembers;
            }
            //all members
            var Members = _enty.Config_MembersList.Select(q => q).ToList();
            if (Members.Count() > 0)
            {
                ViewBag.Members = Members;
            }
            //Team Data
            var Data = _enty.Config_TeamList.Where(q => q.TeamID == id).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_AdminTeamMembers");
        }
        public ActionResult UpdateTeamMembersRole(int TeamID, int MemberID, int RoleID)
        {
            var rec = _enty.Config_TeamMembers.Where(q => q.TeamID == TeamID && q.MemberID == MemberID).Select(q => q).FirstOrDefault();
            if (rec != null)
            {
                rec.RoleID = Convert.ToInt16(RoleID);
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                int res = _enty.SaveChanges();
                if (res > 0)
                {
                    ViewBag.saved = "Data saved successfully";
                }

            }

            #region Select
            //assigned members
            var AssignedMembers = _enty.Config_TeamMembersList.Where(q => q.TeamID == TeamID).Select(q => q.MemberID).ToList();
            if (AssignedMembers.Count() > 0)
            {
                ViewBag.AssignedMembers = AssignedMembers;
            }
            //all members
            var Members = _enty.Config_MembersList.Select(q => q).ToList();
            if (Members.Count() > 0)
            {
                ViewBag.Members = Members;
            }
            //Team Data
            var Data = _enty.Config_TeamList.Where(q => q.TeamID == TeamID).Select(q => q).FirstOrDefault();
            if (Data != null)
            {
                ViewBag.Data = Data;
            }
            #endregion
            return PartialView("_AdminTeamMembers");
        }
        public ActionResult Members()
        {
            var result = new List<EmployeeData>();

            if (Session["ID"] == null)
            {
                Session["ID"] = 0;

            }

            if (Convert.ToInt16(Session["ID"]) > 0 || Session["ID"] == null)
            {
                if (Permission())
                {

                    var connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
                    var Querystring = "select * from employees ";

                    SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "EmployeesTable");
                    DataTable dtable = ds.Tables["EmployeesTable"];

                    result.AddRange(dtable.AsEnumerable().Select(s => new EmployeeData()
                    {
                        Code = s.Field<string>("code"),
                        Name = s.Field<string>("name"),
                        GroupID = s.Field<byte>("GroupID"),
                        OfficeId = s.Field<byte>("OfficeId")
                    }));

                    if (result != null)
                    {
                        ViewBag.Data = result;
                    }
                    return View(result);

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
        public ActionResult NewMember(string Name, string Code, byte OfficeId, byte GroupID)
        {
            var result = new List<EmployeeData>();
            var connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;
            if (Name.Length > 0)
            {
                //string Exists = _enty.Config_MembersList.Where(q => q.MemberName == Name && q.Code == Code).Select(q => q.MemberName).FirstOrDefault();
                //if (Exists != null)
                //{
                //    ViewBag.error = "This Name Already Exists";
                //}
                ////else
                //{
                //    Config_MembersList member = new Config_MembersList();
                //    member.MemberName = Name;
                //    member.Code = Code;
                //    _enty.Entry(member).State = System.Data.Entity.EntityState.Added;
                //    _enty.SaveChanges();
                //    ViewBag.saved = "Data Saved";
                //}

                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    var query = "insert into employees values( '" + Code + "' ,'" + Name + "', " + GroupID + " ," + OfficeId+")"  ;
                    if (GroupID == 3) //Collectors
                    {
                        query += " insert into CollectorCodes values( '" + Code + "')";
                        query += " insert into CollectorNames values( '" + Name + "')";
                    }
                    if (GroupID == 7 || GroupID == 8 || GroupID == 11) //TeamLeader
                    {
                        query += " insert into TeamLeaders values( '" + Name + "')";
                    }
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = query;

                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    ViewBag.saved = "Data Saved";
                }

            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Member Name";
                }

            }
            
            var Querystring = "select * from employees ";

            SqlDataAdapter adapter = new SqlDataAdapter(Querystring, connstring);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "EmployeesTable");
            DataTable dtable = ds.Tables["EmployeesTable"];

            result.AddRange(dtable.AsEnumerable().Select(s => new EmployeeData()
            {
                Code = s.Field<string>("code"),
                Name = s.Field<string>("name"),
                GroupID = s.Field<byte>("GroupID"),
                OfficeId = s.Field<byte>("OfficeId")
            }));

            
            return PartialView("_AdminMembers", result);
        }
        public ActionResult EditMember(int id, string Name, string Code)
        {
            if (Name.Length > 0)
            {
                string Exists = _enty.Config_MembersList.Where(q => q.MemberName == Name && q.MemberID != id).Select(q => q.MemberName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    var member = _enty.Config_MembersList.Find(id);
                    if (member != null)
                    {
                        member.MemberName = Name;
                        member.Code = Code;
                        _enty.Entry(member).State = System.Data.Entity.EntityState.Modified;
                        _enty.SaveChanges();
                        ViewBag.saved = "Data Saved";
                    }
                    else
                    {
                        ViewBag.saved = "Not Exists";

                    }

                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Member Name";
                }


            }

            //save new agency
            return PartialView("_result");
        }
        public ActionResult DeleteMember(string  code)
        {
            var connstring = System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                var query = "exec  DeleteEmployee '" + code + "'";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

            }
            ViewBag.saved = "Data Deleted";
           
            return PartialView("_result");
        }
        public ActionResult GetAgency(int? id, int? choose, int? TeamID)
        {
            var list = new List<Config_AgencyBranchList>();
            list = _enty.Config_AgencyBranchList.Where(q => q.IsActive == true).Select(q => q).ToList();


            if (id != null)
            {
                ViewBag.agency = new SelectList((list.Where(q => q.BranchID == id).Select(q => q)).ToList(), "AgencyID", "AgencyTitle", choose);
                ViewBag.AgID = "-" + TeamID;
            }
            else
            {
                ViewBag.agency = new SelectList((list.Select(q => q)).ToList(), "AgencyID", "AgencyTitle");
                ViewBag.AgID = "-" + TeamID;
            }
            return PartialView("_LupAgency");
        }
        #endregion
        public ActionResult DepartmentEmployee()
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

        #region Column
        public ActionResult ColumnList()
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
                    var Data = _enty.Sch_Columns.Select(q => q).ToList();
                    if (Data != null)
                    {
                        ViewBag.Data = Data;
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
        public ActionResult EditColumn(byte id, string Name, string Types, bool Fixed)
        {
            if (Types.Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Sch_Columns.Where(q => q.ColumnName == Name && q.CoID != id).Select(q => q.ColumnName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    var rec = _enty.Sch_Columns.Find(id);
                    if (rec != null)
                    {
                        rec.ColumnName = Name;
                        rec.ColumnType = Types;
                        rec.IsFixed = Fixed;
                        _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                        int res = _enty.SaveChanges();
                        if (res > 0)
                        {
                            ViewBag.saved = "Data Saved";
                        }
                    }
                    else
                    {
                        ViewBag.saved = "Not Exists";

                    }

                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Column Name";
                }
                if (Types.Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Type";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Type";
                    }

                }

            }

            //save new agency
            return PartialView("_result");
        }
        public ActionResult NewColumn(string Name, string Types, bool Fixed)
        {
            if (Types.Length > 0 && Name.Length > 0)
            {
                string Exists = _enty.Sch_Columns.Where(q => q.ColumnName == Name).Select(q => q.ColumnName).FirstOrDefault();
                if (Exists != null)
                {
                    ViewBag.error = "This Name Already Exists";
                }
                else
                {
                    Sch_Columns rec = new Sch_Columns();
                    rec.ColumnName = Name;
                    rec.ColumnType = Types;
                    rec.IsFixed = Fixed;
                    _enty.Entry(rec).State = System.Data.Entity.EntityState.Added;
                    int res = _enty.SaveChanges();
                    if (res > 0)
                    {
                        ViewBag.saved = "Data Saved";
                    }
                }
            }
            else
            {

                if (Name.Length == 0)
                {
                    ViewBag.error = "- Enter Column Name";
                }
                if (Types.Length == 0)
                {
                    if (ViewBag.error != null)
                    {
                        ViewBag.error = ViewBag.error + "<br> - Choose Type";
                    }
                    else
                    {
                        ViewBag.error = " - Choose Type";
                    }

                }

            }
            var data = _enty.Sch_Columns.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            //save new agency
            return PartialView("_AdminColumnsList");
        }
        public ActionResult ColFixed(string id, string fix)
        {
            int ID = Convert.ToInt16(id);
            var rec = _enty.Sch_Columns.Find(ID);
            if (rec != null)
            {
                if (fix == "0")
                {
                    rec.IsFixed = false;
                }
                else if (fix == "1")
                {
                    rec.IsFixed = true;
                }
                _enty.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                _enty.SaveChanges();
            }



            //get list
            var data = _enty.Sch_Columns.Select(q => q).ToList();
            if (data.Count() > 0)
            {
                ViewBag.Data = data;
            }
            return PartialView("_AdminColumnsList");
        }
        #endregion

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

        private string SaveImg(byte[] img, string Title)
        {
            try
            {
                Stream stream = new MemoryStream(img);
                string ToSavePath = Server.MapPath(url + "/Content/Images/accounts/");
                string AfterSavePath = "/Content/Images/accounts/";

                Title = Title.Replace(" ", "_");
                string finalName = Title + ".jpg";
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
                string image = Path.Combine(AfterSavePath, finalName); ;
                return image;
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        private byte[] ResizeImg(byte[] data)
        {
            System.Drawing.Image Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(data));
            int X = Image.Height;
            int Y = Image.Width;

            if (X > 128 && Y > 128)
            {
                using (var ms = new MemoryStream(data))
                {
                    var image = Image.FromStream(ms);

                    var ratioX = (double)228 / image.Width;
                    var ratioY = (double)128 / image.Height;
                    var ratio = Math.Min(ratioX, ratioY);

                    var width = (int)(image.Width * ratio);
                    var height = (int)(image.Height * ratio);

                    var newImage = new Bitmap(width, height);
                    Graphics.FromImage(newImage).DrawImage(image, 0, 0, width, height);
                    Bitmap bmp = new Bitmap(newImage);

                    ImageConverter converter = new ImageConverter();

                    data = (byte[])converter.ConvertTo(bmp, typeof(byte[]));

                    return data;
                }

            }
            else
            {
                return null;
            }

        }

        private bool IsChecked(string Value)
        {
            bool ValueChecked = false;
            if (Value == "on")
            {
                ValueChecked = true;
            }
            return ValueChecked;
        }
        #region permissions
        [HttpGet]
        public ActionResult Addpermission()
        {
            AddpremissionViewModel PermissionVM = new AddpremissionViewModel();
            var domaintypelst = _enty.DomainTypes.Select(s => new { value = s.Dmaintypeid, text = s.Domaintypename }).ToList();
            PermissionVM.Domaintypes = new SelectList(domaintypelst, "value", "text");
            var domaindatalstusers = _enty.Pre_Users.Select(s => new { value = s.UserID, text = s.UserName }).ToList();
            PermissionVM.Domaindatausers = new SelectList(domaindatalstusers, "value", "text");
            var sectionlst = _enty.Pre_Section.Select(s => new { value = s.SectionID, text = s.SectionName }).ToList();
            PermissionVM.portalaccess = new SelectList(sectionlst, "value", "text");
            var domaindatalstgroups = _enty.Pre_Groups.Select(s => new { value = s.GroupID, text = s.GroupTitle }).ToList();
            PermissionVM.Domaindatagroups = new SelectList(domaindatalstgroups, "value", "text");
            var permissionlst = _enty.Adminpermissions.Select(s => new EIF.Models.permission { permissionid = s.premissionid, DomaintypeId = s.domaintypeid, DomaindataId = s.domaindataid, portalaccessIds = s.portalaccessids }).ToList();
            PermissionVM.permissionslst = permissionlst;
            return View(PermissionVM);
        }
        [HttpPost]
        public ActionResult newpermission(int domaintype, int domaindata, string portalaccess)
        {
            var permissionExistbefor = _enty.Adminpermissions.Where(a => a.domaintypeid == domaintype && a.domaindataid == domaindata).ToList();
            AddpremissionViewModel PermissionVM = new AddpremissionViewModel();
            if (permissionExistbefor.Count() == 0)
            {
                _enty.Inseertnewpermission(domaintype, domaindata, portalaccess);
            }
            var domaintypelst = _enty.DomainTypes.Select(s => new { value = s.Dmaintypeid, text = s.Domaintypename }).ToList();
            PermissionVM.Domaintypes = new SelectList(domaintypelst, "value", "text");
            var domaindatalstusers = _enty.Pre_Users.Select(s => new { value = s.UserID, text = s.UserName }).ToList();
            PermissionVM.Domaindatausers = new SelectList(domaindatalstusers, "value", "text");
            var sectionlst = _enty.Pre_Section.Select(s => new { value = s.SectionID, text = s.SectionName }).ToList();
            PermissionVM.portalaccess = new SelectList(sectionlst, "value", "text");
            var domaindatalstgroups = _enty.Pre_Groups.Select(s => new { value = s.GroupID, text = s.GroupTitle }).ToList();
            PermissionVM.Domaindatagroups = new SelectList(domaindatalstgroups, "value", "text");
            var permissionlst = _enty.Adminpermissions.Select(s => new EIF.Models.permission { permissionid = s.premissionid, DomaintypeId = s.domaintypeid, DomaindataId = s.domaindataid, portalaccessIds = s.portalaccessids }).ToList();
            PermissionVM.permissionslst = permissionlst;
            return PartialView("_Addpermissions", PermissionVM);
        }
        [HttpPost]
        public ActionResult Editpermission(int permissionid, int domaintype, int domaindata, string portalaccess)
        {
            try
            {
                _enty.UpdateAdminpermission(permissionid, domaintype, domaindata, portalaccess);
                ViewBag.saved = "Data Saved";
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
            }
            return PartialView("_result");
        }
        [HttpPost]
        public ActionResult Deltepermissionss(int permissionid)
        {
            try
            {
                _enty.Deletepermission(permissionid);
                ViewBag.saved = "Data Deleted";
            }
            catch
            {
                ViewBag.error = "There is Error Occured";
            }
            return PartialView("_result");
        }
        [HttpGet]
        public ActionResult AddFunction(int permissionid)
        {
            var FunctionLst = _enty.LicensedFunctions.ToList();
            var AccessRightlst = _enty.AccessRights.ToList();
            ViewBag.FunctionModel = FunctionLst;
            ViewBag.AccessRight = AccessRightlst;
            ViewBag.permissionid = permissionid;
            var permissionFunctiolst = _enty.AdminPermission_Functions.Where(w => w.PermissionId == permissionid).ToList();
            ViewBag.permissionFunctiolst = permissionFunctiolst;
            return View("LicensedFunctions");
        }
        [HttpPost]
        public ActionResult NewFunction(int permissionid, int functionid, string accessrightid, bool myinfo)
        {
            if (string.IsNullOrEmpty(accessrightid))
            {
                accessrightid = "5";
            }
            try
            {
                var functionExistberfor = _enty.AdminPermission_Functions.Where(a => a.PermissionId == permissionid && a.FunctionId == functionid).FirstOrDefault();
                if (functionExistberfor != null)
                {
                    ViewBag.error = "Data Exist Before";
                }
                else
                {
                    _enty.InsertNewPermissionFunction(permissionid, functionid, accessrightid, myinfo);
                    ViewBag.saved = "Data Saved";
                }

                var FunctionLst = _enty.LicensedFunctions.ToList();
                var AccessRightlst = _enty.AccessRights.ToList();
                ViewBag.FunctionModel = FunctionLst;
                ViewBag.AccessRight = AccessRightlst;
                ViewBag.permissionid = permissionid;
                var permissionFunctiolst = _enty.AdminPermission_Functions.Where(w => w.PermissionId == permissionid).ToList();
                ViewBag.permissionFunctiolst = permissionFunctiolst;
            }
            catch
            {
                ViewBag.error = "There is Error Occured When saving in data base";
            }
            return PartialView("_result");
        }
        public ActionResult DelteFunction(int Id)
        {
            try
            {
                _enty.DeleteExistPermissionFunction(Id);
                ViewBag.saved = "Data Deleted";
            }
            catch
            {
                ViewBag.error = "There is Error Occured When saving in data base";
            }
            return PartialView("_result");
        }
        [HttpPost]
        public ActionResult UpdateFunction(int Id, int fuctionid, string accessids, bool myinfo, int permissionid)
        {
            if (string.IsNullOrEmpty(accessids))
            {
                accessids = "5";
            }
            try
            {
                _enty.UpdateExistPermissionFunction(Id, permissionid, fuctionid, accessids, myinfo);
                ViewBag.saved = "Data Saved";
            }
            catch
            {
                ViewBag.error = "There is Error Occured When saving in data base";
            }
            return PartialView("_result");
        }
        #endregion
        #region Product
        public ActionResult Products()
        {
            var Allproducts = _enty.Products.Select(s => s).ToList();
            ViewBag.products = Allproducts;
            return View();
        }
        public ActionResult NewProduct(string productname)
        {
            try
            {
                _enty.InsertProduct(productname);
                var Allproducts = _enty.Products.Select(s => s).ToList();
                ViewBag.products = Allproducts;
                return PartialView("_AdminProducts");
            }
            catch
            {
                ViewBag.error = "Error When saving in data base";
                return PartialView("_result");
            }

        }
        public ActionResult EditProduct(int productid, string productname)
        {
            try
            {
                _enty.UpadateExistProduct(productid, productname);
                ViewBag.saved = "Data Saved";
            }
            catch
            {
                ViewBag.error = "Error When saving in data base";
            }
            return PartialView("_result");
        }
        public ActionResult DeleteProduct(int productid)
        {
            try
            {
                _enty.DeleteExistProduct(productid);
                ViewBag.saved = "Data Deleted";
            }
            catch
            {
                ViewBag.error = "This product used in Data Scope for some users you should delete these Scopes before";
            }
            return PartialView("_result");
        }
        #endregion
        #region Cities
        public ActionResult Cities()
        {
            var AllCities = _enty.Cities.Select(s => s).ToList();
            ViewBag.Cities = AllCities;
            return View();
        }
        public ActionResult NewCity(string CityName)
        {
            try
            {
                City city = new City();
                city.CityName = CityName;
                _enty.Entry(city).State = System.Data.Entity.EntityState.Added;
                _enty.SaveChanges();
                var AllCities = _enty.Cities.Select(s => s).ToList();
                ViewBag.Cities = AllCities;
                return PartialView("_AdminCities");
            }
            catch
            {
                ViewBag.error = "Error When saving in data base";
                return PartialView("_result");
            }

        }
        public ActionResult EditCity(int cityid, string cityname)
        {
            try
            {
                City city = _enty.Cities.Where(a => a.CityId == cityid).Select(s => s).FirstOrDefault();
                city.CityName = cityname;
                _enty.Entry(city).State = System.Data.Entity.EntityState.Modified;
                _enty.SaveChanges();
                ViewBag.saved = "Data Saved";
            }
            catch
            {
                ViewBag.error = "Error When saving in data base";
            }
            return PartialView("_result");
        }
        public ActionResult DeleteCity(int cityid)
        {
            try
            {
                City city = _enty.Cities.Where(a => a.CityId == cityid).Select(s => s).FirstOrDefault();
                _enty.Entry(city).State = System.Data.Entity.EntityState.Deleted;
                _enty.SaveChanges();
                ViewBag.saved = "Data Deleted";
            }
            catch
            {
                ViewBag.error = "This product used in Data Scope for some users you should delete these Scopes before";
            }
            return PartialView("_result");
        }
        #endregion
        [HttpGet]
        public ActionResult NewEmployee()
        {

            return View();

        }
        [HttpPost]
        public ActionResult NewEmployee(FormCollection frm)
        {

            List<string> Msg = new List<string>();

            string Name = frm["Name"];
            string Code = frm["Code"];
            string OfficeId = frm["OfficeId"];
            string GroupID = frm["GroupID"];

            try
            {

                if (GroupID.Length == 0)
                {
                    Msg.Add("- Choose Group");
                }
                if (Code.Length == 0)
                {
                    Msg.Add("- Choose Code");
                }
                if (OfficeId.Length == 0)
                {
                    Msg.Add("- Choose Office");
                }
                if (Name.Length == 0)
                {
                    Msg.Add("- Choose Name");
                }




                //no null
                if (Msg.Count > 0)
                {
                    ViewBag.Msg = Msg;
                }
                if (ViewBag.Msg == null)
                {
                    var connstring = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["EIF"].ConnectionString);
                    connstring.Open();
                    var Querystring = " exec [InsertEmployee] '" + Code + " ','" + Name + "'," + Convert.ToInt16(GroupID) + "," + Convert.ToInt16(OfficeId);

                    using (var command = new SqlCommand(Querystring, connstring))
                    {
                        var result = command.ExecuteScalar();
                        ViewBag.saved = "Data saved successfully";
                    }

                    connstring.Close();
                }

                return PartialView("_Result");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public class list
    {
        public int id { get; set; }
        public int val { get; set; }

    }



}