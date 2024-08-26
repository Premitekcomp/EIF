using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.CollectionDept;

namespace TMS.AppForms.Collectors
{
    public partial class frmDomainsListAll : Form
    {
        public frmDomainsListAll()
        {
            InitializeComponent();
        }

        private void frmDomainsListAll_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void txtByCustomerName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gridMasterDomainBasicTableAdapter.FillCustoerNameLike(this.eIFCollector.GridMasterDomainBasic, txtByCustomerName.Text);
            }
            catch { }
        }

        private void grvBasicData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int ShortLineID = Convert.ToInt32(grvBasicData.Rows[e.RowIndex].Cells[4].Value.ToString());
                int SchemaID = Convert.ToInt32(grvBasicData.Rows[e.RowIndex].Cells[5].Value.ToString());
                try
                {
                    this.gridMasterDomainExtraTableAdapter.FillByShortLineID(this.eIFCollector.GridMasterDomainExtra, ShortLineID);
                    UpdateHeaderText(SchemaID);
                }
                catch { }
            }
        }

        private void UpdateHeaderText(int DomainSchema)
        {
            System.Data.DataTable SchemaDT = new System.Data.DataTable();
            SchemaDT = DomainOperations.GetSchemaExtendedInfo(DomainSchema);

            int PointerX = 0;
            foreach (DataRow r in SchemaDT.Rows)
            {
                grvExtraData.Columns[PointerX + 3].HeaderText = r[3].ToString();
                PointerX++;
            }
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gridMasterDomainBasicTableAdapter.FillByAccountNo(this.eIFCollector.GridMasterDomainBasic, txtAccountNo.Text);
            }
            catch { }
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gridMasterDomainBasicTableAdapter.FillByAccountID(this.eIFCollector.GridMasterDomainBasic, txtAccountID.Text);
            }
            catch { }
        }

    }
}
