using TMS.AppCode;
using TMS.AppCode.DAL.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmMissions : Form
    {
        public frmMissions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Variables
        /// </summary>
        /// <param name="resalt"></param>
        public int SelectedID;
        public bool Updated = false;

        private void frmMissions_Load(object sender, EventArgs e)
        {
       
            this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
            //CbEmpID.SelectedIndex = -1;
            RefreshGrid();
            MakeCommonGUITaska(this, PictureBG);
        }

        private void MakeCommonGUITaska(Form PassedFormName, Control PassedParent)
        {
            try
            {
                GlobalEvents.GLobalGUIEvents(PassedFormName, PassedParent);
                foreach (TextBox TBox in this.Controls.OfType<TextBox>().ToArray())
                {
                    TBox.KeyDown += new KeyEventHandler(ControlKeyDown);
                }
                foreach (ComboBox CBox in this.Controls.OfType<ComboBox>().ToArray())
                {
                    CBox.KeyDown += new KeyEventHandler(ControlKeyDown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        private void ControlKeyDown(System.Object Sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                BuildGUIEffects.FormNavigation(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }

        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Updated == false)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Missions.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, dtFromDate.Value, dtToDate.Value, txtNotes.Text);
                    GetMbox(mb);
                    if (mb == 1)
                    {
                        DateTime MissionStartDate = Convert.ToDateTime(dtFromDate.Value.ToShortDateString());
                        DateTime MissionEndDate = Convert.ToDateTime(dtToDate.Value.ToShortDateString());
                        int MissionLength = Convert.ToInt32((MissionEndDate - MissionStartDate).TotalDays);
                        
                        for (int i = 0; i < MissionLength + 1; i++)
                        {
                            TimeSpan ByDay = new TimeSpan(1 * i, 0, 0, 0);
                            DateTime MissionDate = MissionStartDate + ByDay;
                            
                            // Update Trans
                            HR_Basics.UpdateInMission(Convert.ToInt32(CbEmpID.SelectedValue), MissionDate);
                        }

                        
                    }
                    TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                    SelectedID = 0;
                    Updated = false;
                }
            }
            else if (Updated == true)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Missions.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, dtFromDate.Value, dtToDate.Value, txtNotes.Text);
                    TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                    GetMbox(mb);
                    btnDelete.Visible = false;
                    btnadd.Text = "اضافة";
                    SelectedID = 0;
                    Updated = false;
                }
            }
        }

        private void GetMbox(int resalt)
        {
            if (resalt == 1)
            {
                RefreshGrid();
                lblMbox.Text = "تم الحفظ";
            }
            else
            {
                lblMbox.Text = "حدث خطاء اثناء العملية يرجى المحاولة مرة اخرى";
            }
        }
        public bool IsValed()
        {
            if (CbEmpID.Text != "" && dtTra_Date.Value != null)
            {
                //if (dtToDate.Value > dtFromDate.Value)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RefreshGrid()
        {
            try
            {
                if (CbEmpID.SelectedIndex != -1)
                {
                    this.hR_Tra_MissionsTableAdapter.FillByEmpID(this.traDataSet.HR_Tra_Missions, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            if (Updated == true)
            {
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                btnDelete.Visible = false;
                btnadd.Text = "اضافة";

                SelectedID = 0;
                Updated = false;
            }
            else
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int mb = HR_Tra_Missions.UpdateDeleteFlagWithCheck(SelectedID);
            GetMbox(mb);
            TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
            btnDelete.Visible = false;
            btnadd.Text = "اضافة";
            SelectedID = 0;
            Updated = false;

        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SelectedID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt = HR_Tra_Missions.SelectByPK(SelectedID);
                CbEmpID.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
                dtTra_Date.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                dtFromDate.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                dtToDate.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                txtNotes.Text = dt.Rows[0][5].ToString();

                btnadd.Text = "تعديل";
                btnDelete.Visible = true;
                Updated = true;
            }
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void gvForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
