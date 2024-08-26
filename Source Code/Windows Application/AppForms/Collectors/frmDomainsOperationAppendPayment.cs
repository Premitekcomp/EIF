using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.CollectionDept;

namespace TMS.AppForms.Collectors
{
    public partial class frmDomainsOperationAppendPayment : Form
    {
        public frmDomainsOperationAppendPayment()
        {
            InitializeComponent();
        }

        private void frmDomainsOperationAppendPayment_Load(object sender, EventArgs e)
        {
            LoadCombo();

        }

        private void LoadCombo()
        {
            try
            {
                this.hR_Lup_BankListTableAdapter.Fill(this.eIFCollector.HR_Lup_BankList);
                this.col_Lup_SchemaListTableAdapter.Fill(this.eIFCollector.Col_Lup_SchemaList);
                this.col_Lup_MonthListTableAdapter.Fill(this.eIFCollector.Col_Lup_MonthList);
                this.lup_BranchListTableAdapter.Fill(this.eIFCollector.Lup_BranchList);
                this.col_Lup_DomainSerialFullTableAdapter.Fill(this.eIFCollector.Col_Lup_DomainSerialFull);
            }
            catch { }
        }

        private void LoadDefaultUI()
        {
            txtBankBranch.SelectedIndex = -1;
            txtDomainSchema.SelectedIndex = -1;
            txtMonth.SelectedIndex = -1;
            txtBranchID.SelectedIndex = -1;
        }

        private void CmdBrowseXLS_Click(object sender, EventArgs e)
        {
            // Load XLS Sheets
            CBSelectSheet.Items.Clear();

            openFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls";
            openFileDialog1.ShowDialog();

            string ExcelFileName = openFileDialog1.FileName;

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
                FileInfo fi = new FileInfo(openFileDialog1.FileName.ToString());
                string SheetName = "[" + CBSelectSheet.Text + "]";
                string Excel = fi.FullName;
                string FileName = openFileDialog1.FileName.ToString();

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=Excel 12.0;");
                OleDbDataAdapter dta = new OleDbDataAdapter("Select * From " + SheetName, conn);
                OleDbCommand cmd = new OleDbCommand();
                DataSet dts = new DataSet();


                dta.Fill(dts, SheetName);
                DGVDomainData.DataSource = dts;
                DGVDomainData.DataMember = SheetName;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdGetDomainIDs_Click(object sender, EventArgs e)
        {
            if (txtBankBranch.SelectedIndex != -1 && txtBranchID.SelectedIndex != -1 && txtMonth.SelectedIndex != -1)
            {
                try
                {
                    this.col_Lup_DomainSerialFilterdTableAdapter.FillByFilterdData(this.eIFCollector.Col_Lup_DomainSerialFilterd, Convert.ToInt16(txtMonth.SelectedValue), Convert.ToByte(txtBankBranch.SelectedValue), Convert.ToByte(txtBranchID.SelectedValue));
                }
                catch { }
            }
        }

        private void txtAvaliableIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                try
                {
                    this.col_DomainsDataBasicTableAdapter.FillByDomainandVersion(this.eIFCollector.Col_DomainsDataBasic, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                }
                catch
                { }
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtDomainID.SelectedIndex == -1)
            {
                MessageBox.Show("Must Select Domain ID");
                txtDomainID.Focus();
                return;
            }

            if (txtDomainFieldID.SelectedIndex == -1 || txtPaymentKey.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must Select Domain And Payment Key Field");
                txtDomainID.Focus();
                return;
            }

            #endregion

            // Update Domain Version
            int DomainID = Convert.ToInt32(txtDomainID.Text);
            int CurrentDomainVersion = Convert.ToInt32(txtDomainID.SelectedValue);

            // Start Import
            DGVDomainData.Columns.Add("Result", "Upload Result");

            try
            {
                foreach (DataGridViewRow grvRow in DGVDomainData.Rows)
                {
                    #region Update Payment
                    string NewBucket = DGVDomainData.Rows[grvRow.Index].Cells[Convert.ToInt32(txtBucketCol.Text) - 1].Value.ToString();
                    string Payment = DGVDomainData.Rows[grvRow.Index].Cells[Convert.ToInt32(txtPaymentCol.Text) - 1].Value.ToString();
                    string WhereValue = DGVDomainData.Rows[grvRow.Index].Cells[Convert.ToInt32(txtPaymentKey.Text) - 1].Value.ToString();

                    switch (txtDomainFieldID.SelectedIndex)
                    {
                        case 0: // Account No
                            {
                                if (DomainOperations.UpdateDomainByAccountNo(WhereValue, DomainID, CurrentDomainVersion, Convert.ToDecimal(Payment), NewBucket) == 1)
                                {
                                    DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "Match Found";
                                }
                                else
                                {
                                    DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "No Match";
                                }
                                break;
                            }
                        case 1: // Customer ID
                            {
                                if (DomainOperations.UpdateDomainByAccountID(WhereValue, DomainID, CurrentDomainVersion, Convert.ToDecimal(Payment), NewBucket) == 1)
                                {
                                    DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "Match Found";
                                }
                                else
                                {
                                    DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "No Match";
                                }
                                break;
                            }
                        case 2: // Customer Name
                            {
                                if (DomainOperations.UpdateDomainByCustomerName(WhereValue, DomainID, CurrentDomainVersion, Convert.ToDecimal(Payment), NewBucket) == 1)
                                {
                                    DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "Match Found";
                                }
                                else
                                {
                                    DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "No Match";
                                }
                                break;
                            }
                    }

                    
                    #endregion
                }

                MessageBox.Show("Payment Appended Succefullt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
