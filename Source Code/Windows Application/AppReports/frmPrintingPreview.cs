using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppReports
{
    public partial class frmPrintingPreview : Form
    {
        public frmPrintingPreview()
        {
            InitializeComponent();
        }

        private void frmPrintingPreview_Load(object sender, EventArgs e)
        {
            CRViewerMain.Show();
        }
    }
}
