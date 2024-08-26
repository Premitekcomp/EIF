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
    public partial class frmDomainsOperationImport : Form
    {
        public frmDomainsOperationImport()
        {
            InitializeComponent();
        }

        private void frmDomainsOperationImport_Load(object sender, EventArgs e)
        {
            LoadCombo();

        }

        private void LoadCombo()
        {
            try
            {
                this.col_Lup_SchemaListTableAdapter.Fill(this.eIFCollector.Col_Lup_SchemaList);
                this.hR_Lup_BankListTableAdapter.Fill(this.eIFCollector.HR_Lup_BankList);
                this.col_Lup_MonthListTableAdapter.Fill(this.eIFCollector.Col_Lup_MonthList);
                this.lup_BranchListTableAdapter.Fill(this.eIFCollector.Lup_BranchList);
                this.col_Lup_DomainsTypeTableAdapter.Fill(this.eIFCollector.Col_Lup_DomainsType);
            }
            catch { }
        }

        private void LoadDefaultUI()
        {
            txtBankBranch.SelectedIndex = -1;
            txtDomainSchema.SelectedIndex = -1;
            txtDomainType.SelectedIndex = -1;
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

        private void CmdImport_Click(object sender, EventArgs e)
        {        
            #region // New Domain
                // Create Col_DomainsDataPK Record
                DomainOperations.DomainPK_Insert(Convert.ToInt32(txtMonth.SelectedValue), Convert.ToInt32(txtBankBranch.SelectedValue), Convert.ToInt32(txtDomainType.SelectedValue), Convert.ToInt32(txtDomainSchema.SelectedValue), Convert.ToInt32(txtBranchID.SelectedValue));

                // Get Domain ID
                int DomainID = DomainOperations.GetMaxDomainID();

                #region Load Schema Information
                System.Data.DataTable SchemaDT = new System.Data.DataTable();
                SchemaDT = DomainOperations.GetSchemaInfo(Convert.ToInt32(txtDomainSchema.SelectedValue));

                int AccNo = 0;
                int AccID = 0;
                int CustomerName = 0;
                int Product = 0;
                int Cycle = 0;
                int Bucket = 0;
                int PastDue = 0;
                int OSBalance = 0;
                int City = 0;
                int Office = 0;
                
                int CardNoID = 0;
                int NationalityID= 0;
                int PassportNoID= 0;
                int CreditLimitID= 0;
                int MobileNumberID= 0;
                int AddressID	= 0;
                int WorkPhoneID	= 0;
                int CompanyNameID	= 0;
                int CompanyAddressID = 0;
                foreach (DataRow r in SchemaDT.Rows)
                {
                    AccNo = Convert.ToInt32(r["AccNoColID"].ToString());
                    AccID = Convert.ToInt32(r["AccIDColID"].ToString());
                    CustomerName = Convert.ToInt32(r["CustomerNameColID"].ToString());
                    Product = Convert.ToInt32(r["ProductColID"].ToString());
                    Cycle = Convert.ToInt32(r["CycleColID"].ToString());
                    Bucket = Convert.ToInt32(r["BucketColID"].ToString());
                    PastDue = Convert.ToInt32(r["PastDueColID"].ToString());
                    OSBalance = Convert.ToInt32(r["BalanceColID"].ToString());
                    City = Convert.ToInt32(r["CityColID"].ToString());
                    Office = Convert.ToInt32(r["OfficeColID"].ToString());

                    CardNoID = Convert.ToInt32(r["CardNoID"].ToString());
                    NationalityID = Convert.ToInt32(r["NationalityID"].ToString());
                    PassportNoID = Convert.ToInt32(r["PassportNoID"].ToString());
                    CreditLimitID = Convert.ToInt32(r["CreditLimitID"].ToString());
                    MobileNumberID = Convert.ToInt32(r["MobileNumberID"].ToString());
                    AddressID = Convert.ToInt32(r["AddressID"].ToString());
                    WorkPhoneID = Convert.ToInt32(r["WorkPhoneID"].ToString());
                    CompanyNameID = Convert.ToInt32(r["CompanyNameID"].ToString());
                    CompanyAddressID = Convert.ToInt32(r["CompanyAddressID"].ToString());
                }
                #endregion

                // Start Import
                DGVDomainData.Columns.Add("Result", "Upload Result");

                try
                {
                    foreach (DataGridViewRow grvRow in DGVDomainData.Rows)
                    {
                        #region Insert Domain Basic
                        string AccNoValue = DGVDomainData.Rows[grvRow.Index].Cells[AccNo].Value.ToString();
                        string AccIDValue = DGVDomainData.Rows[grvRow.Index].Cells[AccID].Value.ToString();
                        string CustomerNameValue = DGVDomainData.Rows[grvRow.Index].Cells[CustomerName].Value.ToString();
                        string ProductValue = DGVDomainData.Rows[grvRow.Index].Cells[Product].Value.ToString();
                        string CycleValue = DGVDomainData.Rows[grvRow.Index].Cells[Cycle].Value.ToString();
                        string BucketValue = DGVDomainData.Rows[grvRow.Index].Cells[Bucket].Value.ToString();
                        string PastDueValue = DGVDomainData.Rows[grvRow.Index].Cells[PastDue].Value.ToString();
                        string OSBalanceValue = DGVDomainData.Rows[grvRow.Index].Cells[OSBalance].Value.ToString();
                        string CityValue = DGVDomainData.Rows[grvRow.Index].Cells[City].Value.ToString();
                        string OfficeValue = DGVDomainData.Rows[grvRow.Index].Cells[Office].Value.ToString();

                        string CardNo = DGVDomainData.Rows[grvRow.Index].Cells[CardNoID].Value.ToString();
                        string Nationality = DGVDomainData.Rows[grvRow.Index].Cells[NationalityID].Value.ToString();
                        string PassportNo = DGVDomainData.Rows[grvRow.Index].Cells[PassportNoID].Value.ToString(); ;
                        string CreditLimit = DGVDomainData.Rows[grvRow.Index].Cells[CreditLimitID].Value.ToString();
                        string MobileNumber = DGVDomainData.Rows[grvRow.Index].Cells[MobileNumberID].Value.ToString();

                        string Address = DGVDomainData.Rows[grvRow.Index].Cells[AddressID].Value.ToString();
                        string WorkPhone = DGVDomainData.Rows[grvRow.Index].Cells[WorkPhoneID].Value.ToString();
                        string CompanyName = DGVDomainData.Rows[grvRow.Index].Cells[CompanyNameID].Value.ToString();
                        string CompanyAddress = DGVDomainData.Rows[grvRow.Index].Cells[CompanyAddressID].Value.ToString();

                        if(PastDueValue.Trim().Length == 0)
                        {
                            PastDueValue = "0";
                        }
                        if(OSBalanceValue.Trim().Length == 0)
                        {
                            OSBalanceValue = "0";
                        }

                        if (DomainOperations.DomainBasicExtended_Insert(DomainID, AccNoValue, AccIDValue, CustomerNameValue, ProductValue, CycleValue, BucketValue, PastDueValue, OSBalanceValue, CityValue, OfficeValue, CardNo, Nationality, PassportNo, CreditLimit, MobileNumber, Address, WorkPhone, CompanyName, CompanyAddress) == 1)
                        {
                            DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "Pass";
                        }
                        else
                        {
                            DGVDomainData.Rows[grvRow.Index].Cells["Result"].Value = "Fail";
                            DGVDomainData.Rows[grvRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                        }
                        #endregion

                        #region Insert Domain Extra
                        int ShorDomainID = DomainOperations.GetMaxDomainBasicRecord();

                        // Build Insert Statment
                        string ValuesStatement = "insert into Col_DomainsDataExtra values (" + ShorDomainID.ToString() + ", " + DomainID.ToString() + ",";
                        for (int ColLoop = 0; ColLoop <= 202; ColLoop++)
                        {
                            if (ColLoop < DGVDomainData.ColumnCount - 1)
                            {
                                if (DGVDomainData.Rows[grvRow.Index].Cells[ColLoop].Value.ToString() == null)
                                {
                                    ValuesStatement = ValuesStatement + "Null, ";
                                }
                                else
                                {
                                    ValuesStatement = ValuesStatement + "N'" + DGVDomainData.Rows[grvRow.Index].Cells[ColLoop].Value.ToString() + "',";
                                }
                            }
                            else
                            {
                                ValuesStatement = ValuesStatement + "Null, ";
                            }
                        }
                        ValuesStatement = ValuesStatement.Substring(0, ValuesStatement.Length - 2) + ")";
                        DomainOperations.DomainExtra_Insert(ValuesStatement);
                        #endregion
                    }

                    MessageBox.Show("Operation Compleated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion
        }
    
    }
}
