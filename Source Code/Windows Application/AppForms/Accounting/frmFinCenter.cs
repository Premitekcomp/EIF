using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.Accounting
{
    public partial class frmFinCenter : Form
    {
        public frmFinCenter()
        {
            InitializeComponent();
        }

        private void frmFinCenter_Load(object sender, EventArgs e)
        {
           

        }

        private void CmdDo_Click(object sender, EventArgs e)
        {
            try
            {
                this.a_FinCenterBalanceTableAdapter.Fill(this.accounting.A_FinCenterBalance, dtStartRange.Value.ToString(), dtEndRange.Value.ToString());

                AppReports.AccountingRep.RepFinCener RepName = new AppReports.AccountingRep.RepFinCener();
                RepName.SetDataSource(this.accounting);

                CRViewer.ReportSource = RepName;
                CRViewer.Show();
            }
            catch
            { }
        }
    }
}
