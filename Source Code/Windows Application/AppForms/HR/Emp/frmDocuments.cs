using TMS.AppCode;
using TMS.AppCode.BLL;
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
using System.IO;

namespace TMS.AppForms.HR.Emp
{
    public partial class frmDocuments : Form
    {
        int EmployeeDocumentID;
        int btnAddFlag = 0;
        bool AttachmentInserted = false;
        public byte[] AttachedFile { get; set; }
        FileInfo Fi;
        public frmDocuments()
        {
            InitializeComponent();
        }

        private void frmDocuments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Combo_ExternalID' table. You can move, or remove it, as needed.
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            try
            {
                this.hR_Lup_DocumentsTypesTableAdapter.FillAll(this.lupDataSet.HR_Lup_DocumentsTypes);
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                RefreshGrid();
            }
            catch { }
        MakeCommonGUITaska(this);
        }

        private void MakeCommonGUITaska(Form PassedFormName)
        {
            try
            {
                GlobalEvents.GLobalGUIEventsV2(PassedFormName);
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

        private void RefreshGrid()
        {
            try
            {
                if (CbEmpID.SelectedIndex != -1)
                {
                    this.grid_Emp_DocumentsTableAdapter.FillByEmpID(this.empDataSet.Grid_Emp_Documents, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbEmpID.SelectedIndex != -1)
            {
                txtEmpID.SelectedValue = CbEmpID.SelectedValue;
            }
            RefreshGrid();
        }

        private void dtDeliverdDate_Leave(object sender, EventArgs e)
        {
            try
            {
                dtValidTo.Value = dtDeliverdDate.Value;
            }
            catch (Exception)
            {

            }
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    EmployeeDocumentID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());

                    CbEmpID.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtDocumentTypeID.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    IsDeliverd.Checked = bool.Parse(gvForm.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dtDeliverdDate.Value = DateTime.Parse(gvForm.Rows[e.RowIndex].Cells[4].Value.ToString());
                    dtValidTo.Value = DateTime.Parse(gvForm.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txtNotes.Text = gvForm.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (gvForm.Rows[e.RowIndex].Cells[6].Value.ToString() == "مرفقات")
                    {
                        CmdDownloadAttachment.Visible = true;
                    }
                    else
                    {
                        CmdDownloadAttachment.Visible = false;
                    }
                    btnAddFlag = 1;
                    ChangeControlByFlags(1);
                }
            }
            catch (Exception)
            {
            }
           
        }

        //Flag
        private void ChangeControlByFlags(int btnAddFlag)
        {
            if (btnAddFlag == 0)
            {
                btnSaveNew.Text = "حفظ / جديد";
                btnSaveClose.Text = "حفظ / اغلاق";
                btnDelete.Visible = false;
            }
            else if (btnAddFlag == 1)
            {
                btnSaveNew.Text = "تعديل";
                btnSaveClose.Text = "الغاء الامر";
                btnDelete.Visible = true;
            }
        }

        private bool EmptyOrNot()
        {
            if (CbEmpID.SelectedIndex == -1)
            {
                lblMsg.Text = "من فضلك اختر الموظف";
                CbEmpID.Focus();
                return false;
            }

            if (txtDocumentTypeID.SelectedIndex == -1)
            {
                lblMsg.Text = "من فضلك اختر المستند";
                txtDocumentTypeID.Focus();
                return false;
            }

            if (DataValidation.EnsureTodayToPast(dtDeliverdDate.Value) == false)
            {
                lblMsg.Text = "من فضلك تأكد من التاريخ";
                dtDeliverdDate.Focus();
                return false;
            }

            return true;
        }

        private void InsertMethod()
        {
            if (HR_Emp_Documents.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtDocumentTypeID.SelectedValue), IsDeliverd.Checked ,dtDeliverdDate.Value, dtValidTo.Value , txtNotes.Text) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void InsertWithAttachmentMethod()
        {
            if (HR_Emp_Documents.InsertRecordWithAttachment(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtDocumentTypeID.SelectedValue), IsDeliverd.Checked ,dtDeliverdDate.Value, dtValidTo.Value , txtNotes.Text, AttachedFile, Fi.Name.ToString()) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Emp_Documents.UpdateRecord(EmployeeDocumentID, Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtDocumentTypeID.SelectedValue),IsDeliverd.Checked ,dtDeliverdDate.Value, dtValidTo.Value, txtNotes.Text) == 1)
            {
                lblMsg.Text = "تم التعديل بنجاح";
                btnAddFlag = 0;
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        { 
            try
            {
                if (btnAddFlag == 1)
                {
                    btnAddFlag = 0;
                    ChangeControlByFlags(0);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
                else if (btnAddFlag == 0)
                {
               
                        //To Save
                        if (btnAddFlag == 0)
                        {
                            if (EmptyOrNot())
                            {
                                InsertMethod();
                                MessageBox.Show("تم الحفظ بنجاح");
                                this.Close();
                            }
                        }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1010");
            }
            
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            try 
	        {	        
                    //To Save
                    if (btnAddFlag == 0)
                    {
                        if (EmptyOrNot())
                        {
                            if (AttachmentInserted == true)
                            {
                                InsertWithAttachmentMethod();
                            }
                            else
                            {
                                InsertMethod();
                            }
                            
                            lblMsg.Text= "تم الحفظ بنجاح";
                            AttachmentInserted = false;
                            lblFileName.Text = "";
                            CmdDownloadAttachment.Visible = false;
                            RefreshGrid();
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                            CbEmpID.Focus();
                        }
                    }
                    else if (btnAddFlag == 1)
                    {
                        if (EmptyOrNot())
                        {
                            UpdateMethod();
                            lblMsg.Text= "تم التعديل بنجاح";
                            RefreshGrid();
                            CmdDownloadAttachment.Visible = false;
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                            CbEmpID.Focus();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1011");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (HR_Emp_Documents.UpdateDeleteFlagWithCheck(EmployeeDocumentID) == 1)
                {
                    RefreshGrid();
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1012");
            }
        }

        private void CmdBrowse_Click(object sender, EventArgs e)
        {
                if (AttachmentInserted == false)
                {
                    OpenFileDialog GetFileHook = new OpenFileDialog();
                    GetFileHook.Filter = "image jpg |*.jpg|image png |*.png|image bmp |*.bmp|File Word |*.docx|File Excel |*.xlsx|File Powerpoint |*.pptx|File Acrobat |*.pdf";


                    if (GetFileHook.ShowDialog() == DialogResult.OK)
                    {
                        lblFileName.Text = GetFileHook.FileName;
                        AttachedFile = File.ReadAllBytes(GetFileHook.FileName);
                        Fi = new FileInfo(GetFileHook.FileName);
                        
                        AttachmentInserted = true;
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن ارفاق اكثر من ملف واحد مع كل سجل");
                    return;
                }
        }

        private void gvForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmdDownloadAttachment_Click(object sender, EventArgs e)
        {
            if (btnAddFlag != 0)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                string AttFileName = HR_Emp_Documents.GetAttachmentName(EmployeeDocumentID);
                string PathtosaveFile = fbd.SelectedPath.ToString();

                HR_Emp_Documents.DownloadDocAttachment(EmployeeDocumentID, PathtosaveFile + "\\" + AttFileName);
            }
        }

        private void txtEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpID.SelectedIndex != -1)
            {
                CbEmpID.SelectedValue = txtEmpID.SelectedValue;
            }
        }
   }
}

