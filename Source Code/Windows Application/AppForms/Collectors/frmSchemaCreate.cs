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
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using TMS.AppCode.DAL.CollectionDept;

namespace TMS.AppForms.Collectors
{
    public partial class frmSchemaCreate : Form
    {
        int CreationSteps = 0;

        public frmSchemaCreate()
        {
            InitializeComponent();
        }

        private void frmSchemaCreate_Load(object sender, EventArgs e)
        {
            CmdStep1.ForeColor = AppCode.GlobalParamters.SuccessColor;
            ProgressBar1.Value = 0;
        }

        private void CmdStepClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Label ClickedItem = (System.Windows.Forms.Label)sender;
            
            switch(ClickedItem.Name.ToString())
            {
                case "CmdStep1":
                    {
                        return;
                    }
                case "CmdStep2":
                    {
                        CreationSteps = 1;
                        GroupBox2.Visible = true;
                        CmdStep2.ForeColor = AppCode.GlobalParamters.SuccessColor;
                        CmdStep3.Enabled = true;
                        ProgressBar1.Value = 25;
                        return;
                    }
                case "CmdStep3":
                    {
                        CreationSteps = 2;
                        GroupBox3.Visible = true;
                        CmdStep3.ForeColor = AppCode.GlobalParamters.SuccessColor;
                        return;
                    }
                case "CmdStep4":
                    {
                        CreationSteps = 3;

                        // Save Schema Basic
                        if (DomainSchema.SchemaBasicExtended_Insert(txtSchemaTitle.Text, CBSelectSheet.Text, AppCode.GlobalParamters.ActiveUserID, System.DateTime.Today, Convert.ToInt32(txtS3AccountNumber.Text) - 1, Convert.ToInt32(txtS3AccountID.Text) - 1, Convert.ToInt32(txtS3CustomerName.Text) - 1, Convert.ToInt32(txtS3Product.Text) - 1, Convert.ToInt32(txtS3Cycle.Text) - 1, Convert.ToInt32(txtS3Bucket.Text) - 1, Convert.ToInt32(txtS3PastDue.Text) - 1, Convert.ToInt32(txtS3OSBalance.Text) - 1, Convert.ToInt32(txtS3City.Text) - 1, Convert.ToInt32(txtS3Office.Text) - 1, Convert.ToInt32(txtS3CardNumber.Text) - 1, Convert.ToInt32(txtS3Nationalitly.Text) - 1, Convert.ToInt32(txtS3PassportNumber.Text) - 1, Convert.ToInt32(txtS3CreditLimit.Text) - 1, Convert.ToInt32(txtMobileNumber.Text) - 1, Convert.ToInt32(txtS3Address.Text) - 1, Convert.ToInt32(txts3Phone.Text) - 1, Convert.ToInt32(txtS3Company.Text) - 1, Convert.ToInt32(txtS3CompanyAddress.Text)-1) != 1)
                        {
                            MessageBox.Show("Failed to Save Basic Schema Data");
                            return;
                        }
                        // Get Max
                        int MaxSchemaID = DomainSchema.GetMaxSchemaID();

                        // Save Schema Extended
                         for(int i = 0; i < DGVDomainData.Columns.Count; i++)
                         {
                             DomainSchema.SchemaExtended_Insert(MaxSchemaID, i, DGVDomainData.Columns[i].Name);
                         }

                
                        CmdStep4.ForeColor = AppCode.GlobalParamters.SuccessColor;
                        ProgressBar1.Value = 100;
                        MessageBox.Show("Schema Saved");
                        return;
                    }
            }
        }

        private void CmdBrowseXLS_Click(object sender, EventArgs e)
        {
            // Load XLS Sheets
            CBSelectSheet.Items.Clear();

            OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls";
            OpenFileDialog1.ShowDialog();

            string ExcelFileName = OpenFileDialog1.FileName;

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFileName + ";Extended Properties='Excel 12.0 xml;HDR=YES;'");
            connection.Open();
            System.Data.DataTable Sheets = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            foreach (DataRow dr in Sheets.Rows)
            {
                CBSelectSheet.Items.Add(dr[2].ToString());
            }

            //Allow Sheet Select
            lblSelect.Visible = true;
            CBSelectSheet.Visible = true;
        }

        private void CBSelectSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(OpenFileDialog1.FileName.ToString());
                string SheetName = "[" + CBSelectSheet.Text + "]";
                string Excel = fi.FullName;
                string FileName = OpenFileDialog1.FileName.ToString();

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=Excel 12.0;");
                OleDbDataAdapter dta = new OleDbDataAdapter("Select * From " + SheetName, conn);
                OleDbCommand cmd = new OleDbCommand();
                DataSet dts = new DataSet();


                dta.Fill(dts, SheetName);
                DGVDomainData.DataSource = dts;
                DGVDomainData.DataMember = SheetName;
                conn.Close();

                CmdStep3.Enabled = true;
                ProgressBar1.Value = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdConfirmScSt_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.TextBox TBox in GroupBox3.Controls.OfType<System.Windows.Forms.TextBox>().ToArray() )
            {
                if(TBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Provide All Column Information");
                    return;
                }
            }

            lblS3AccountNumber.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3AccountNumber.Text) - 1].Value.ToString();
            lblS3AccountID.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3AccountID.Text) - 1].Value.ToString();
            lblS3CustomerName.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3CustomerName.Text) - 1].Value.ToString();
            
            if(IsProduct.Checked == true)
            {
                lblS3Product.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Product.Text) - 1].Value.ToString();
            }
            else
            {
                lblS3Product.Text = "Missed";
                txtS3Product.Text = "1";
            }

            if (IsCycle.Checked == true)
            {
                lblS3Cycle.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Cycle.Text) - 1].Value.ToString();
            }
            else
            {
                lblS3Cycle.Text = "Missed";
                txtS3Cycle.Text = "1";
            }

            
            lblS3Bucket.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Bucket.Text) - 1].Value.ToString();
            lblS3PastDue.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3PastDue.Text) - 1].Value.ToString();
            lblS3OSBalance.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3OSBalance.Text) - 1].Value.ToString();

            if (IsRegion.Checked == true)
            {
                lblS3City.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3City.Text) - 1].Value.ToString();
            }
            else
            {
                lblS3City.Text = "Missed";
                txtS3City.Text = "1";
            }

            if (IsOffice.Checked == true)
            {
                lblS3Office.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Office.Text) - 1].Value.ToString();
            }
            else
            {
                lblS3Office.Text = "Missed";
                txtS3Office.Text = "1";
            }

            lblS3Card.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3CardNumber.Text) - 1].Value.ToString();
            lblS3Nationality.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Nationalitly.Text) - 1].Value.ToString();
            lbls3PassportNumber.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3PassportNumber.Text) - 1].Value.ToString();
            lblS3CreditLimit.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3CreditLimit.Text) - 1].Value.ToString();
            lblS3Mobile.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtMobileNumber.Text) - 1].Value.ToString();
            lblS3CustomerAddress.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Address.Text) - 1].Value.ToString();
            lblS3WorkPhone.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txts3Phone.Text) - 1].Value.ToString();
            lblS3CompanyName.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3Company.Text) - 1].Value.ToString();
            lblS3CompanyAddress.Text = DGVDomainData.Rows[0].Cells[Convert.ToInt32(txtS3CompanyAddress.Text) - 1].Value.ToString();

            CmdStep4.Enabled = true;
            ProgressBar1.Value = 75;
        }

        private void DGVDomainData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(Convert.ToString(DGVDomainData.CurrentCell.ColumnIndex + 1));
        }


    }
}
