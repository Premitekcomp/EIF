using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using TMS.AppReports.HR;

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmLoadEmpFPTrans : Form
    {
        public frmLoadEmpFPTrans()
        {
            InitializeComponent();
        }

        private void frmLoadEmpFPTrans_Load(object sender, EventArgs e)
        {
            try
            {
                this.combo_NameListTableAdapter.Fill(this.empDataSet.Combo_NameList);
            }
            catch { }

            txtEmpID.SelectedIndex = -1;

        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            if (txtEmpID.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                this.hR_Tra_EmpAttendanceViewTableAdapter.FillByEmpID(this.traDataSet.HR_Tra_EmpAttendanceView, Convert.ToInt16(txtEmpID.SelectedValue),dtStartRange.Value.ToString(), dtEndRange.Value.ToString());
            }
            catch { }
        }

        private void CmdXLS_Click(object sender, EventArgs e)
        {
            DailyAttendanceByEmp RepName = new DailyAttendanceByEmp();
            RepName.SetDataSource(this.traDataSet);

            frmHRRepPreview OpenForm = new frmHRRepPreview();
            OpenForm.CRViewerMain.ReportSource = RepName;
            OpenForm.Show();            
        }

        private void CmdShowTotals_Click(object sender, EventArgs e)
        {
            if (txtEmpID.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                this.hR_Tra_EmpAttendanceTotalsViewTableAdapter.FillBySingleRecord(this.traDataSet.HR_Tra_EmpAttendanceTotalsView, Convert.ToInt16(txtEmpID.SelectedValue), dtStartRange.Value.ToString(), dtEndRange.Value.ToString());
            }
            catch { }
        }
    }
}
