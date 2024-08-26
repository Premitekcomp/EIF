using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EIF.Models
{
    public class Authentication
    {
        public static bool CheckPermissions(string FunctionUniqueName, int UserId, out List<string> AccesRights , out bool? myinformationonly)
        {
            AdminEntities _enty = new AdminEntities();
            bool haspermission = false;
            myinformationonly = false;
            AccesRights = new List<string>();
            int functionid = _enty.LicensedFunctions.Where(w => w.UniqueCode == FunctionUniqueName).Select(s => s.FinctionId).FirstOrDefault();  //select function id using funnction unique name 
            var permissionforuser = _enty.Adminpermissions.Where(w => w.domaintypeid == 1 && w.domaindataid == UserId).FirstOrDefault(); // first check if this user has direct permission or not 
            if (permissionforuser != null) // there is direct permission to this user
            {
                var permissionfunction = _enty.AdminPermission_Functions.Where(w => w.PermissionId == permissionforuser.premissionid && (w.FunctionId == functionid || w.FunctionId== 0)).FirstOrDefault();
                if (permissionfunction != null)
                {
                    haspermission = true;
                    var accessrightids = permissionfunction.AccessRightIds.Split(',').ToList();
                    List<int> AccessRightIds = accessrightids.ConvertAll(int.Parse);
                    var accessrightnames = _enty.AccessRights.Where(a => AccessRightIds.Contains(a.Accessrightid)).Select(s => s.Accessrightname).ToList();
                    AccesRights.AddRange(accessrightnames);
                    myinformationonly = permissionfunction.MyIfnfoOnly;
                }
            }
            else
            {                 //this user has no direct permissions , then check if his group has permissions
                int usergroupid = _enty.Pre_GroupsMembers.Where(w => w.UserID == UserId && w.IsDeleted == false).Select(s => s.GroupID).FirstOrDefault();
                var permissionforgroup = _enty.Adminpermissions.Where(w => w.domaintypeid == 1 && w.domaindataid == UserId).FirstOrDefault();
                if (permissionforgroup != null)
                {
                    var permissionfunction = _enty.AdminPermission_Functions.Where(w => w.PermissionId == permissionforgroup.premissionid && (w.FunctionId == functionid || w.FunctionId == 0)).FirstOrDefault();
                    if (permissionfunction != null)
                    {
                        haspermission = true;
                        var accessrightids = permissionfunction.AccessRightIds.Split(',').ToList();
                        AccesRights.AddRange(accessrightids);
                        myinformationonly = permissionfunction.MyIfnfoOnly;
                    }
                }
            }
            return haspermission;
        }
        public static List<string> GetAllPermissionsPerUser(int UserId , out List<string> MenuNames)
        {
             AdminEntities _enty = new AdminEntities();
            List<string> Permissions = new List<string>();
            MenuNames = new List<string>();
            var PermissionId = _enty.Adminpermissions.Where(a => a.domaintypeid == 1 && a.domaindataid== UserId).Select(s => s.premissionid).FirstOrDefault();
            if (PermissionId != null)
            {
                var FunctionIds = _enty.AdminPermission_Functions.Where(a => a.PermissionId == PermissionId).Select(s => s.FunctionId).ToList();
                List<string> screenNames = new List<string>();
                if (FunctionIds.Contains(0))
                {
                    screenNames = _enty.LicensedFunctions.Select(s => s.FunctionName).ToList();
                }
                else
                {
                    screenNames = _enty.LicensedFunctions.Where(a => FunctionIds.Contains(a.FinctionId)).Select(s => s.FunctionName).ToList();
                }
                MenuNames = _enty.Design_MenuItems.Where(a => screenNames.Contains(a.MenuItemName)).Select(s => s.Design_MenuBasic.MenuTitle).ToList();
                if (screenNames.Contains("Dashboard"))
                    MenuNames.Add("Dashboard");
                Permissions = screenNames;
            }
            return Permissions;
        }
    }
}