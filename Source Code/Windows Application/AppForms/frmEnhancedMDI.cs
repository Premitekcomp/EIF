using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode;
using TMS.AppCode.BLL;
using TMS.AppCode.DAL;

namespace TMS.AppForms
{
    public partial class frmEnhancedMDI : Form
    {
        byte[] Img { get; set; }

        public frmEnhancedMDI()
        {
            InitializeComponent();
        }

        private void frmEnhancedMDI_Load(object sender, EventArgs e)
        {
            CustomRiboon(GlobalParamters.ClinetPrefix);
            
            ConfigUI();
            LoadUserInfo();

        }

        private void CustomRiboon(string Version)
        {
            //RGDeveloperTools.Visible = false;
            switch (Version)
            {
                case "EIF":
                    {
                        #region EIF                            
                            toolStrip1.Visible = false;
                            tabControl1.Visible = false;
                            panel1.Visible = false;
                            return;
                        #endregion
                    }
            }

        }

        private void PassLogActions(int ActionID)
        {
            try
            {
                Pre_SystemLog.InsertLog(6000, 0, ActionID);
            }
            catch { }
        }

        #region UI Buttons / Actions / Response
        private void ConfigUI()
        {
            CmdTerminate.Left = this.Width - 35;
            CmdMinimize.Left = this.Width - 70;
            CmdCollabseRiboon.Left = this.Width - 105;
        }

        private void LoadUserInfo()
        {
            DataTable UInfdt = new DataTable();
            UInfdt = Pre_Authentication.CurrentUserInfo();

            foreach (DataRow r in UInfdt.Rows)
            {
                ActiveUserNameStrip.Text = r["DisplayName"].ToString();
                if (Convert.ToBoolean(r["IsDoctor"].ToString()) == true)
                {
                    GlobalParamters.ActiveDrID = Convert.ToInt32(r["DoctorID"].ToString());
                }
                else
                {
                    GlobalParamters.ActiveDrID = 0;
                }

                if (r["EmployeeID"].ToString().Trim().Length == 0)
                {
                    GlobalParamters.ActiveEmpID = 0;
                }
                else
                {
                    GlobalParamters.ActiveEmpID = Convert.ToInt32(r["EmployeeID"].ToString());
                }
                

            }

        }

        private void CmdMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CmdCollabseRiboon_Click(object sender, EventArgs e)
        {
            if (MDIRibbon.Minimized == true)
            { 
                MDIRibbon.Minimized = false;
                CmdCollabseRiboon.Text = "^";
            }

            else
            { 
                MDIRibbon.Minimized = true;
                CmdCollabseRiboon.Text = "v";
            }
        }

        private void SolutionTerminateProceduers(object sender, EventArgs e)
        {
            try
            {
                Pre_SystemLog.ChangeUserStatus(GlobalParamters.ActiveUserID, false);
            }
            catch { }

            try
            {
                PassLogActions(22);
                Application.Exit();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.Exit();
                //this.Close();
            }

            
       

        }

        private void CallLogOff(object sender, EventArgs e)
        {
            PassLogActions(22);
            try
            {
                Pre_SystemLog.ChangeUserStatus(GlobalParamters.ActiveUserID, false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            

            #region Close All Open Forms
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                    Application.OpenForms[i].Hide();
            }
            #endregion


            frmLogin Loadfrm = new frmLogin();
            Loadfrm.Show();
            

            
        }

        private void OrbMenuChangePassword_Click(object sender, EventArgs e)
        {
            Personal.frmChangePassword Loadfrm = new Personal.frmChangePassword();
            Loadfrm.ShowDialog();
        }

        #endregion

        

        #region Call Forms from Riboo

        #region Accounting | Done 2
        private void RCmdAccountsTree_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmAccountList OpenForm = new AppForms.Accounting.frmAccountList();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RCmdAnalyticsAccounts_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmAccountListSub OpenForm = new AppForms.Accounting.frmAccountListSub();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RCmdCostCenters_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmAccountsCostCenterList OpenForm = new AppForms.Accounting.frmAccountsCostCenterList();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RCmdSimpleEntry_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmSimpleJournalEntry OpenForm = new AppForms.Accounting.frmSimpleJournalEntry(0);
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RcmdJournal_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmJournalEntryList OpenForm = new AppForms.Accounting.frmJournalEntryList();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }

        private void RCmdAssMaster_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmAssMasterBook OpenForm = new AppForms.Accounting.frmAssMasterBook();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RCmdMasterBook_Click(object sender, EventArgs e)
        {
           
            AppForms.Accounting.frmMasterBook OpenForm = new AppForms.Accounting.frmMasterBook();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }

        private void CmdRevisionBalance_Click(object sender, EventArgs e)
        {
           
            AppForms.Accounting.frmRevisionBalance OpenForm = new AppForms.Accounting.frmRevisionBalance();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void ribbonButton58_Click(object sender, EventArgs e)
        {
            
        }

        private void RCmdFinCenter_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmFinCenter OpenForm = new AppForms.Accounting.frmFinCenter();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }

        private void RCmdASTList_Click(object sender, EventArgs e)
        {
           
            AppForms.Accounting.frmASTBasicInfo OpenForm = new AppForms.Accounting.frmASTBasicInfo(this);
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RCmdASTDep_Click(object sender, EventArgs e)
        {
           

            AppForms.Accounting.frmASTDepSheet OpenForm = new AppForms.Accounting.frmASTDepSheet();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }

        private void RCmdIncomeSheetSeeting_Click(object sender, EventArgs e)
        {
           
            AppForms.Accounting.frmCashListSetting OpenForm = new AppForms.Accounting.frmCashListSetting();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();

        }

        private void RCmdAutomaticRecords_Click(object sender, EventArgs e)
        {
           
            AppForms.Accounting.frmAutomaticRecordsSetting OpenForm = new AppForms.Accounting.frmAutomaticRecordsSetting();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }

        private void CmdConfigFinCenter_Click(object sender, EventArgs e)
        {
           
            AppForms.Accounting.frmConfigFinCenter OpenForm = new AppForms.Accounting.frmConfigFinCenter();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }

        private void CmdAssestGroups_Click(object sender, EventArgs e)
        {
            
            AppForms.Accounting.frmASTGroups OpenForm = new AppForms.Accounting.frmASTGroups();
            OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            OpenForm.Show();
        }
        #endregion

        #region Admin Tab // Done
        
        private void RCmdUserNew_Click(object sender, EventArgs e)
        {
            

            AdminWork.frmUsersNew OpenForm = new AdminWork.frmUsersNew(0);
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                //OpenForm.MdiParent = this;
                OpenForm.ShowDialog();
            }
            else
            {
                OpenForm.Activate();
            }
        }

        #endregion

        #region Configuration

        

        

        

        

        #region HR
        #region Rules
        private void RCmdAllownceList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.Rules.frmAllowances OpenForm = new AdminWork.Config.HR.Rules.frmAllowances();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdBounceList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.Rules.frmBonus OpenForm = new AdminWork.Config.HR.Rules.frmBonus();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdCustodyList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.Rules.frmCustody OpenForm = new AdminWork.Config.HR.Rules.frmCustody();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdDeductionList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.Rules.frmDeductions OpenForm = new AdminWork.Config.HR.Rules.frmDeductions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdPenalitiesList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.Rules.frmPenalites OpenForm = new AdminWork.Config.HR.Rules.frmPenalites();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }
        #endregion

        #region Lup and HR Items
        private void RCmdEmploymentGroups_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmEmplymentGroup OpenForm = new AdminWork.Config.HR.HRItems.frmEmplymentGroup();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdOfficialVacLup_DoubleClick(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmYearsOfficialVacations OpenForm = new AdminWork.Config.HR.HRItems.frmYearsOfficialVacations();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdMonthIndexLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmYearsMonths OpenForm = new AdminWork.Config.HR.HRItems.frmYearsMonths();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdContractLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmContractType OpenForm = new AdminWork.Config.HR.HRItems.frmContractType();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdVacationLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmVacationTypes OpenForm = new AdminWork.Config.HR.HRItems.frmVacationTypes();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdSalaryTypeLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmSalaryTypes OpenForm = new AdminWork.Config.HR.HRItems.frmSalaryTypes();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdSocilEnsuOfficeLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmSocialInssuranceOffices OpenForm = new AdminWork.Config.HR.HRItems.frmSocialInssuranceOffices();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdPositions_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmPositions OpenForm = new AdminWork.Config.HR.HRItems.frmPositions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdDocumentTypeList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmDocumentsTypes OpenForm = new AdminWork.Config.HR.HRItems.frmDocumentsTypes();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdDgreeLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmDegrees OpenForm = new AdminWork.Config.HR.HRItems.frmDegrees();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdHEnsuranceLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmHealthInsuranceTypes OpenForm = new AdminWork.Config.HR.HRItems.frmHealthInsuranceTypes();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdCountryLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmCountries OpenForm = new AdminWork.Config.HR.LupCombo.frmCountries();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdCityLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmCites OpenForm = new AdminWork.Config.HR.LupCombo.frmCites();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdAreaLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmAreas OpenForm = new AdminWork.Config.HR.LupCombo.frmAreas();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdContactList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmContactsType OpenForm = new AdminWork.Config.HR.LupCombo.frmContactsType();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdNationalitesList_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmNationalities OpenForm = new AdminWork.Config.HR.LupCombo.frmNationalities();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdRelgionLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmReligionList OpenForm = new AdminWork.Config.HR.LupCombo.frmReligionList();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdSocial_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmSocialStatus OpenForm = new AdminWork.Config.HR.LupCombo.frmSocialStatus();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdMilitryLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmMilitaryService OpenForm = new AdminWork.Config.HR.LupCombo.frmMilitaryService();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdQualificationTypeLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmQualificationsTypes OpenForm = new AdminWork.Config.HR.LupCombo.frmQualificationsTypes();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdQualificationNameLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmQualificationNames OpenForm = new AdminWork.Config.HR.LupCombo.frmQualificationNames();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdUniLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmUniversities OpenForm = new AdminWork.Config.HR.LupCombo.frmUniversities();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdFacultyLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmFaculties OpenForm = new AdminWork.Config.HR.LupCombo.frmFaculties();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEduLup_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.LupCombo.frmEduSections OpenForm = new AdminWork.Config.HR.LupCombo.frmEduSections();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }
        #endregion
        #endregion
        #endregion

        #region HR
        #region Profile
        private void RCmdEmpProfileNew_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmBasicInfo OpenForm = new HR.Emp.frmBasicInfo();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpProfileEdit_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmBasicInfoEdit OpenForm = new HR.Emp.frmBasicInfoEdit();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpExtendNew_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmExtendedInfo OpenForm = new HR.Emp.frmExtendedInfo();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpDocuments_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmDocuments OpenForm = new HR.Emp.frmDocuments();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpCertificate_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmCertificates OpenForm = new HR.Emp.frmCertificates();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpEdu_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmEducation OpenForm = new HR.Emp.frmEducation();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpContacts_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmContacts OpenForm = new HR.Emp.frmContacts();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpPosition_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmPositions OpenForm = new HR.Emp.frmPositions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpDgree_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmEmploymentDegree OpenForm = new HR.Emp.frmEmploymentDegree();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdEmpSal_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.Emp.frmSalary OpenForm = new HR.Emp.frmSalary();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdDeduction_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmDeductions OpenForm = new HR.HR_Tra.frmDeductions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdAllowance_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmAllowances OpenForm = new HR.HR_Tra.frmAllowances();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdCustody_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmCustody OpenForm = new HR.HR_Tra.frmCustody();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        #endregion

        #region Transactions
        private void RCmdListFPSheet_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.HR.HR_Tra.frmLoadEmpFPTrans OpenForm = new AppForms.HR.HR_Tra.frmLoadEmpFPTrans();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdLeavePermissions_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.HR.HR_Tra.frmLeavePermissions OpenForm = new AppForms.HR.HR_Tra.frmLeavePermissions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdBounce_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmBonus OpenForm = new HR.HR_Tra.frmBonus();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdPenalites_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmPenalty OpenForm = new HR.HR_Tra.frmPenalty();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdMissions_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmMissions OpenForm = new HR.HR_Tra.frmMissions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdVacations_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmVacation OpenForm = new HR.HR_Tra.frmVacation();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdLoadAttendanceSheet_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmLoadFPSheet OpenForm = new HR.HR_Tra.frmLoadFPSheet();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdPenalitytrans_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmPenaltyTransactions OpenForm = new HR.HR_Tra.frmPenaltyTransactions();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdBounceTrans_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Tra.frmBonusTransaction OpenForm = new HR.HR_Tra.frmBonusTransaction();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        #endregion

        #region Rule Details
        private void RCmdWorkingTimes_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmWorkingTimes OpenForm = new AdminWork.Config.HR.HRItems.frmWorkingTimes();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdWorkingPlans_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AdminWork.Config.HR.HRItems.frmWorkingPlans OpenForm = new AdminWork.Config.HR.HRItems.frmWorkingPlans();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdGroupPolicy_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.AdminWork.Config.HR.HRItems.frmGroupPloicies OpenForm = new AppForms.AdminWork.Config.HR.HRItems.frmGroupPloicies();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdLateRule_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Rul.frmDelay OpenForm = new HR.HR_Rul.frmDelay();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdExtraTimeRule_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Rul.frmExtraTime OpenForm = new HR.HR_Rul.frmExtraTime();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdLeavePermissionRule_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(12, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            HR.HR_Rul.frmLeavePermission OpenForm = new HR.HR_Rul.frmLeavePermission();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }
        #endregion

        #endregion
        
        #region Collector
        private void RCmdAssignDomainRecords_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainCollectorAssign OpenForm = new AppForms.Collectors.frmDomainCollectorAssign();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdUpdateTeam_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmUpdateDomainTeam OpenForm = new AppForms.Collectors.frmUpdateDomainTeam();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdMatchRecords_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainMatchRecords OpenForm = new AppForms.Collectors.frmDomainMatchRecords();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void CmdNewDomainSchema_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmSchemaCreate OpenForm = new AppForms.Collectors.frmSchemaCreate();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdColTeams_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmCreateTeam OpenForm = new AppForms.Collectors.frmCreateTeam();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdColMonthlyTarget_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmOfficeMonthlyTarget OpenForm = new AppForms.Collectors.frmOfficeMonthlyTarget();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void CmdImportDomain_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainsOperationImport OpenForm = new AppForms.Collectors.frmDomainsOperationImport();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdNewRef_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainsOperationNewReferal OpenForm = new AppForms.Collectors.frmDomainsOperationNewReferal();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdDailyVisitInsert_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDailyVisitInsert OpenForm = new AppForms.Collectors.frmDailyVisitInsert();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdMasterDomain_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainsListAll OpenForm = new AppForms.Collectors.frmDomainsListAll();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdCompareDomains_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainsCompareVersion OpenForm = new AppForms.Collectors.frmDomainsCompareVersion();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void RCmdDCR_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDailyVisitShow OpenForm = new AppForms.Collectors.frmDailyVisitShow();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void CmsAppendPayment_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmDomainsOperationAppendPayment OpenForm = new AppForms.Collectors.frmDomainsOperationAppendPayment();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }

        private void CmdAnalysisTarget_Click(object sender, EventArgs e)
        {
            //if (GlobalEvents.CheckFormAccessPremission(64, 1) == 0)
            //{
            //    MessageBox.Show("لا تملك الصلاحيات الكافيه لدخول هذا النموذج");
            //    return;
            //}
            AppForms.Collectors.frmPaymentAnalysis OpenForm = new AppForms.Collectors.frmPaymentAnalysis();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this;
                OpenForm.Show();
            }
            else
            {
                OpenForm.Activate();
            }
            return;
        }
        #endregion

        #endregion

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CtxTabsMenu.Show(Cursor.Position);
            }
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        
        
    }
}
