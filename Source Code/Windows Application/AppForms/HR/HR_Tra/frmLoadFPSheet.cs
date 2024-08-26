using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using TMS.AppCode.DAL.HR;

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmLoadFPSheet : Form
    {
        public frmLoadFPSheet()
        {
            InitializeComponent();
        }

        private void CmdBrowse_Click(object sender, EventArgs e)
        {
            //Load XLS Sheets
            
            OpenFileDialog OP1 = new OpenFileDialog();
            OP1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls";
            OP1.ShowDialog();

            string ExcelFileName = OP1.FileName.ToString();
            

            try
            {
                FileInfo fi = new FileInfo(OP1.FileName.ToString());
                //txtXLSSheetList.Text = fi.Name.ToString();
                string SheetName = "[" + txtXLSSheetList.Text + "$]";
                string Excel = fi.FullName;
                string FileName = OP1.FileName.ToString();

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=Excel 12.0;");
                OleDbDataAdapter dta = new OleDbDataAdapter("Select * From " + SheetName, conn);

                //OleDbDataReader dtr = new OleDbDataReader();
                OleDbCommand cmd = new OleDbCommand();
                DataSet dts = new DataSet();
                
              
                dta.Fill(dts, SheetName);
                grvLoadFP.DataSource = dts;
                grvLoadFP.DataMember = SheetName;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        

        }
        private void frmLoadFPSheet_Load(object sender, EventArgs e)
        {

        }

        private void CmdVerfiy_Click(object sender, EventArgs e)
        {
            try
            {
                lblFPNo.Text = grvLoadFP.Rows[0].Cells[Convert.ToInt32(txtFPNo.Text)].Value.ToString();
                lblFPDate.Text = grvLoadFP.Rows[0].Cells[Convert.ToInt32(txtFPDate.Text)].Value.ToString();
                lblFPType.Text = grvLoadFP.Rows[0].Cells[Convert.ToInt32(txtFPType.Text)].Value.ToString();
            }
            catch { }
            
        }

        private void CmdImport_Click(object sender, EventArgs e)
        {
            int FPNoColumnndex = Convert.ToInt32(txtFPNo.Text);
            int FPDateCoulmnIndex = Convert.ToInt32(txtFPDate.Text);
            int TransTypeCoulmnIndex = Convert.ToInt32(txtFPType.Text);
            UploadingBar.Maximum = grvLoadFP.Rows.Count - 1;
            UploadingBar.Value = 0;

            foreach (DataGridViewRow GRow in grvLoadFP.Rows)
            {
                if (GRow.Cells[FPNoColumnndex].Value == null)
                {
                    return;
                }

                int EmpID = HR_Basics.GetEmpID(Convert.ToInt32(GRow.Cells[FPNoColumnndex].Value.ToString()));

                if (EmpID == 0)
                {
                    GRow.Cells["ImportResult"].Value = "رقم الموظف غير مسجل";
                    GRow.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else
                {
                    try
                    {
                        // 1 Extract Date from Time
                        DateTime AttendanceDateTime = Convert.ToDateTime(GRow.Cells[FPDateCoulmnIndex].Value.ToString());
                        DateTime AttendanceDate = AttendanceDateTime.Date;
                        DateTime AttendanceTime = Convert.ToDateTime(Convert.ToDateTime(GRow.Cells[FPDateCoulmnIndex].Value.ToString()).ToShortTimeString());

                        #region 2 Do Update for (C/In and C/Out)
                        if (GRow.Cells[TransTypeCoulmnIndex].Value.ToString() == "C/In")
                        {
                            // Update Check In
                            if (HR_Basics.UpdateCheckIn(EmpID, AttendanceDate, AttendanceTime) == 1)
                            {
                                GRow.Cells["ImportResult"].Value = "تم تسجيل الحركة";
                                GRow.DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                GRow.Cells["ImportResult"].Value = "خطأ عند التسجيل";
                                GRow.DefaultCellStyle.BackColor = Color.LightYellow;
                            }
                        }
                        else
                        {
                            // Update Check Out
                            if (HR_Basics.UpdateCheckOut(EmpID, AttendanceDate, AttendanceTime) == 1)
                            {
                                GRow.Cells["ImportResult"].Value = "تم تسجيل الحركة";
                                GRow.DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                GRow.Cells["ImportResult"].Value = "خطأ عند التسجيل";
                                GRow.DefaultCellStyle.BackColor = Color.LightYellow;
                            }
                        }
                        #endregion
                    }
                    catch { }
                }

                UploadingBar.Value ++;
            }
        }
    }
}
