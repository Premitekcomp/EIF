using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using EIF.Models;

using EIF.Models;

namespace EIF.Controllers
{
    
    public class AccountController : Controller
    {
        UserAccountEntities _enty = new UserAccountEntities();

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.SectionID = null;
            ViewBag.Brunch = null;
            ViewBag.UserID = null;

            ViewBag.LoginTitle = "Login";
            #region config data

            //config data
            ViewBag.Logo = _enty.Pre_Config.ToList();
            byte[] image = _enty.Pre_Config.Select(l => l.FieldImage).FirstOrDefault();
            ViewBag.Logo = image;//File(image, "image/jpg");
            Session["Logo"] = ViewBag.Logo;
            #endregion
            //if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
            //{
            //    ViewBag.UserName = Request.Cookies["UserName"].Value;
            //    ViewBag.Password = Request.Cookies["Password"].Value;
            //    ViewBag.Remember = Request.Cookies["Remember"].Value;

            //}
            return View();
        }
        // [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost]
        public ActionResult Login(FormCollection user)
        {
            ViewBag.LoginTitle = "Login";
            #region Mapping and validate data
            ViewBag.usr = "";
            ViewBag.Pass = "";
            string UserName = user["UserName"];
            string Pswd = user["Password"];
            string SectionID=user["SectionID"];
            string BranchID=user["BrunchID"];
           // bool remember = IsChecked(user["remember"]);
            bool remember = false;

           
            #endregion


            if (!string.IsNullOrEmpty(SectionID) && !string.IsNullOrEmpty(BranchID))
            {
                if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrEmpty(Pswd) && !string.IsNullOrWhiteSpace(Pswd))//check validation
                {
                    ViewBag.SectionID = SectionID;
                    ViewBag.Brunch = BranchID;
                    ViewBag.UserID = UserName;

                    if (string.IsNullOrEmpty(UserName) && string.IsNullOrWhiteSpace(UserName))
                    {
                        ViewBag.usr = "Wrong username";
                    }
                    if (string.IsNullOrEmpty(Pswd) && string.IsNullOrWhiteSpace(Pswd))
                    {
                        ViewBag.Pass = "Wrong password";
                    }

                    #region Login
                    UsersDAL Users = new UsersDAL();

                    if (Users.IsValid(UserName, Pswd) == 1)
                    {
                        //remember me code
                        // FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);

                        ViewBag.SendingMessage = "";


                        #region Get enabled User data
                        int UserID = Convert.ToInt16(UserName);
                        var UserData = _enty.Pre_UserData(UserID, Pswd).FirstOrDefault();
                        if (UserData == null)
                        {
                            Session["ID"] = 0;
                            ViewBag.SendingMessage = "The account is closed, please back to system admin";
                            return View("Login");
                        }
                        else
                        {
                            LoginProc(UserName, Pswd, remember,Convert.ToByte(SectionID), UserData);
                            int IntSec=Convert.ToInt16(SectionID);                                                   
                            List<string> menuNames = new List<string>();
                            var screens = Authentication.GetAllPermissionsPerUser(int.Parse(UserName) , out menuNames);
                            Session["AllowedScreens"] = screens;
                            Session["AllowwdMenuNames"] = menuNames;
                            Session["SectionID"] = IntSec;
                            string SectionURL = "";
                            if (IntSec == 1)
                            {
                                if (screens.Contains("Dashboard"))
                                {
                                    SectionURL = "/collection/Dashboard";
                                }
                                else if (screens.Count() == 0)
                                {
                                    SectionURL = "/Account/Forbidden";
                                }
                                else
                                {
                                    string firstscreen = screens[0];
                                    SectionURL = _enty.LicensedFunctions.Where(a => a.FunctionName == firstscreen).Select(s => s.ScreenURL).FirstOrDefault();
                                }
                            }
                            else
                            {
                                SectionURL = _enty.Pre_Section.Where(q => q.SectionID == IntSec).Select(q => q.SectionURL).FirstOrDefault();
                            }   
                            ////page to redirect
                            return Redirect(SectionURL);
                        }
                        #endregion

                    }
                    else
                    {
                        Session["ID"] = 0;
                        ViewBag.SendingMessage = "Wrong username or password, please try again";
                        return View("Login");
                    }
                    #endregion

                }
                else
                {
                    ViewBag.SectionID = SectionID;
                    ViewBag.Brunch = BranchID;
                    ViewBag.UserID = UserName;
                    Session["ID"] = 0;
                    return View("Login");
                } 
            }
            else
            {
                ViewBag.SectionID = SectionID;
                ViewBag.Brunch = BranchID;
                ViewBag.UserID = UserName;
                ViewBag.BrunchSec = "Choose Your Section And Brunch To Login";
                Session["ID"] = 0;
                return View("Login");
            } 

        }

        private void LoginProc(string UserName, string Pswd, bool remember, byte SectionID, Pre_UserData_Result UserData)
        {
            Session["ID"] = UserData.UserID;
            Session["DisplayName"] = UserData.DisplayName;
            Session["ProfileImage"] = UserData.ProfileImage;
            Session["OldPass"] = Pswd;
            AfterLogin(SectionID);


            //if (remember)
            //{
            //    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
            //    Response.Cookies["Remember"].Expires = DateTime.Now.AddDays(30);
            //}
            //else
            //{
            //    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Cookies["Remember"].Expires = DateTime.Now.AddDays(-1);
            //}
            //Response.Cookies["UserName"].Value = UserName;
            //Response.Cookies["Password"].Value = Pswd;
            //Response.Cookies["Remember"].Value = remember.ToString();


            // var authTicket = new FormsAuthenticationTicket(
            //  1,
            //  Convert.ToString(Session["ID"]),  //user id
            //  DateTime.Now,
            //  DateTime.Now.AddDays(20),  // expiry
            //  remember,  //true to remember
            //  "", //roles 
            //  "/"
            //);
            // FormsAuthentication.SetAuthCookie(UserData.DisplayName, true);

            // //encrypt the ticket and add it to a cookie
            // HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));
            // Response.Cookies.Add(cookie);
        }

        public ActionResult GetBrunchSectionDDL(string id)
        {
            ViewBag.UserID = id;
            return PartialView("_AccBrunchSection");
        }

        public ActionResult Logout()
        {
            Session["ID"] = 0;

            //page to redirect
            return RedirectToAction("Login", "Account", new
            {
                area = ""
            });
        }
        private void AfterLogin(byte SectionID)
        {
            int UserID = Convert.ToInt16(Session["ID"]);
            Session["SectionID"] = SectionID;
            List<byte> SectionIDs = _enty.Pre_SectionPermissions.Where(q => q.UserID == UserID).Select(q => q.SectionID).ToList();
            var c =_enty.Design_MenuBasic.Where(s => s.SectionID == SectionID && s.IsDeleted == false).ToList().OrderBy(q => q.DisplayID);
            //Session["Menu"] = _enty.Design_MenuBasic.Where(s => SectionIDs.Contains(s.SectionID) && s.IsDeleted == false).ToList().OrderBy(q => q.DisplayID);
            Session["Menu"] = _enty.Design_MenuBasic.Where(s => s.SectionID==SectionID && s.IsDeleted == false).ToList().OrderBy(q => q.DisplayID);
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
        public ActionResult Forbidden()
        {
            return View();
        }
    }
}