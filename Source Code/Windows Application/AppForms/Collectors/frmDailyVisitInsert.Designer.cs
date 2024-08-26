namespace TMS.AppForms.Collectors
{
    partial class frmDailyVisitInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ConnectionDateLabel;
            System.Windows.Forms.Label ConnectionTypeLabel;
            System.Windows.Forms.Label ConnetctionResultLabel;
            System.Windows.Forms.Label PTPTypeLabel;
            System.Windows.Forms.Label PTPDateLabel;
            System.Windows.Forms.Label PTPAmountLabel;
            System.Windows.Forms.Label KeptAmountLabel;
            System.Windows.Forms.Label label1;
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdLoadDomain = new System.Windows.Forms.Button();
            this.lblDomainVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.CmdGetDomainIDs = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grvFullDomain = new System.Windows.Forms.DataGridView();
            this.domainSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainSchemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currentVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col18DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col25DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col26DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col27DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col28DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col29DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col30DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col31DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col32DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col33DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col34DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col35DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col36DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col37DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col38DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col39DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col40DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col41DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col42DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col43DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col44DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col45DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col46DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col47DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col48DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col49DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col50DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col51DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col52DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col53DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col54DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col55DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col56DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col57DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col58DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col59DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col60DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col61DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col62DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col63DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col64DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col65DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col66DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col67DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col68DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col69DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col70DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col71DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col72DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col73DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col74DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col75DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col76DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col77DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col78DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col79DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col80DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col81DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col82DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col83DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col84DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col85DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col86DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col87DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col88DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col89DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col90DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col91DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col92DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col93DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col94DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col95DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col96DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col97DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col98DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col99DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col101DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col102DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col103DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col104DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col105DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col106DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col107DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col108DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col109DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col110DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col111DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col112DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col113DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col114DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col115DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col116DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col117DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col118DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col119DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col120DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col121DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col122DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col123DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col124DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col125DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col126DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col127DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col128DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col129DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col130DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col131DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col132DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col133DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col134DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col135DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col136DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col137DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col138DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col139DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col140DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col141DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col142DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col143DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col144DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col145DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col146DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col147DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col148DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col149DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col150DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col151DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col152DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col153DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col154DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col155DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col156DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col157DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col158DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col159DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col160DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col161DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col162DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col163DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col164DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col165DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col166DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col167DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col168DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col169DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col170DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col171DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col172DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col173DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col174DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col175DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col176DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col177DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col178DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col179DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col180DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col181DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col182DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col183DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col184DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col185DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col186DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col187DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col188DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col189DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col190DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col191DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col192DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col193DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col194DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col195DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col196DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col197DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col198DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col199DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col200DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superVisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDomainFullDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.gridDomainFullDataTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridDomainFullDataTableAdapter();
            this.PTPTypeTextBox = new System.Windows.Forms.ComboBox();
            this.ConnetctionResultTextBox = new System.Windows.Forms.ComboBox();
            this.ConnectionTypeTextBox = new System.Windows.Forms.ComboBox();
            this.dtConnectionDate = new System.Windows.Forms.DateTimePicker();
            this.PTPAmountTextBox = new System.Windows.Forms.TextBox();
            this.KeptBrokenCheckBox = new System.Windows.Forms.CheckBox();
            this.KeptAmountTextBox = new System.Windows.Forms.TextBox();
            this.TrialDetailsTextBox = new System.Windows.Forms.TextBox();
            this.dtPTPDate = new System.Windows.Forms.DateTimePicker();
            this.CmdSaveVisitInfo = new System.Windows.Forms.Button();
            this.txtActionTakerID = new System.Windows.Forms.ComboBox();
            this.colLupTeamMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_Lup_TeamMembersTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamMembersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordSerialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastDue1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalityTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPhoneTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddressTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomainsDataBasicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_DomainsDataBasicTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter();
            this.txtFilterByFCust = new System.Windows.Forms.ComboBox();
            this.lupFCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.lupFCustTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.LupFCustTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colLupCommentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_Lup_CommentListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_CommentListTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lupAccountNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupAccountNoTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.LupAccountNoTableAdapter();
            this.isBroken = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmdSearchByPassport = new System.Windows.Forms.Button();
            ConnectionDateLabel = new System.Windows.Forms.Label();
            ConnectionTypeLabel = new System.Windows.Forms.Label();
            ConnetctionResultLabel = new System.Windows.Forms.Label();
            PTPTypeLabel = new System.Windows.Forms.Label();
            PTPDateLabel = new System.Windows.Forms.Label();
            PTPAmountLabel = new System.Windows.Forms.Label();
            KeptAmountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFullDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainFullDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupFCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupCommentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupAccountNoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionDateLabel
            // 
            ConnectionDateLabel.AutoSize = true;
            ConnectionDateLabel.Location = new System.Drawing.Point(873, 63);
            ConnectionDateLabel.Name = "ConnectionDateLabel";
            ConnectionDateLabel.Size = new System.Drawing.Size(116, 17);
            ConnectionDateLabel.TabIndex = 53;
            ConnectionDateLabel.Text = "Connection Date:";
            // 
            // ConnectionTypeLabel
            // 
            ConnectionTypeLabel.AutoSize = true;
            ConnectionTypeLabel.Location = new System.Drawing.Point(873, 93);
            ConnectionTypeLabel.Name = "ConnectionTypeLabel";
            ConnectionTypeLabel.Size = new System.Drawing.Size(118, 17);
            ConnectionTypeLabel.TabIndex = 55;
            ConnectionTypeLabel.Text = "Connection Type:";
            // 
            // ConnetctionResultLabel
            // 
            ConnetctionResultLabel.AutoSize = true;
            ConnetctionResultLabel.Location = new System.Drawing.Point(873, 124);
            ConnetctionResultLabel.Name = "ConnetctionResultLabel";
            ConnetctionResultLabel.Size = new System.Drawing.Size(129, 17);
            ConnetctionResultLabel.TabIndex = 58;
            ConnetctionResultLabel.Text = "Connetction Result:";
            // 
            // PTPTypeLabel
            // 
            PTPTypeLabel.AutoSize = true;
            PTPTypeLabel.Location = new System.Drawing.Point(873, 155);
            PTPTypeLabel.Name = "PTPTypeLabel";
            PTPTypeLabel.Size = new System.Drawing.Size(72, 17);
            PTPTypeLabel.TabIndex = 60;
            PTPTypeLabel.Text = "PTP Type:";
            // 
            // PTPDateLabel
            // 
            PTPDateLabel.AutoSize = true;
            PTPDateLabel.Location = new System.Drawing.Point(873, 186);
            PTPDateLabel.Name = "PTPDateLabel";
            PTPDateLabel.Size = new System.Drawing.Size(70, 17);
            PTPDateLabel.TabIndex = 61;
            PTPDateLabel.Text = "PTP Date:";
            // 
            // PTPAmountLabel
            // 
            PTPAmountLabel.AutoSize = true;
            PTPAmountLabel.Location = new System.Drawing.Point(873, 217);
            PTPAmountLabel.Name = "PTPAmountLabel";
            PTPAmountLabel.Size = new System.Drawing.Size(90, 17);
            PTPAmountLabel.TabIndex = 63;
            PTPAmountLabel.Text = "PTP Amount:";
            // 
            // KeptAmountLabel
            // 
            KeptAmountLabel.AutoSize = true;
            KeptAmountLabel.Location = new System.Drawing.Point(873, 278);
            KeptAmountLabel.Name = "KeptAmountLabel";
            KeptAmountLabel.Size = new System.Drawing.Size(94, 17);
            KeptAmountLabel.TabIndex = 67;
            KeptAmountLabel.Text = "Kept Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(873, 247);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 17);
            label1.TabIndex = 80;
            label1.Text = "Promise:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CmdLoadDomain);
            this.GroupBox1.Controls.Add(this.lblDomainVersion);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txtAvaliableIDs);
            this.GroupBox1.Controls.Add(this.CmdGetDomainIDs);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtBranchID);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtBankBranch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Location = new System.Drawing.Point(7, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(196, 433);
            this.GroupBox1.TabIndex = 51;
            this.GroupBox1.TabStop = false;
            // 
            // CmdLoadDomain
            // 
            this.CmdLoadDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLoadDomain.Location = new System.Drawing.Point(6, 318);
            this.CmdLoadDomain.Name = "CmdLoadDomain";
            this.CmdLoadDomain.Size = new System.Drawing.Size(178, 37);
            this.CmdLoadDomain.TabIndex = 55;
            this.CmdLoadDomain.Text = "Load Domain";
            this.CmdLoadDomain.UseVisualStyleBackColor = true;
            this.CmdLoadDomain.Click += new System.EventHandler(this.CmdLoadDomain_Click);
            // 
            // lblDomainVersion
            // 
            this.lblDomainVersion.AutoSize = true;
            this.lblDomainVersion.Location = new System.Drawing.Point(3, 287);
            this.lblDomainVersion.Name = "lblDomainVersion";
            this.lblDomainVersion.Size = new System.Drawing.Size(159, 17);
            this.lblDomainVersion.TabIndex = 54;
            this.lblDomainVersion.Text = "Current Domain Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avaliable Domains";
            // 
            // txtAvaliableIDs
            // 
            this.txtAvaliableIDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAvaliableIDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAvaliableIDs.DataSource = this.colLupDomainSerialFilterdBindingSource;
            this.txtAvaliableIDs.DisplayMember = "DomainSerial";
            this.txtAvaliableIDs.FormattingEnabled = true;
            this.txtAvaliableIDs.Location = new System.Drawing.Point(6, 250);
            this.txtAvaliableIDs.Name = "txtAvaliableIDs";
            this.txtAvaliableIDs.Size = new System.Drawing.Size(178, 25);
            this.txtAvaliableIDs.TabIndex = 52;
            this.txtAvaliableIDs.ValueMember = "CurrentVersion";
            this.txtAvaliableIDs.SelectedIndexChanged += new System.EventHandler(this.txtAvaliableIDs_SelectedIndexChanged);
            // 
            // colLupDomainSerialFilterdBindingSource
            // 
            this.colLupDomainSerialFilterdBindingSource.DataMember = "Col_Lup_DomainSerialFilterd";
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(6, 178);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(178, 37);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Import Data";
            this.CmdGetDomainIDs.UseVisualStyleBackColor = true;
            this.CmdGetDomainIDs.Click += new System.EventHandler(this.CmdGetDomainIDs_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMonth.DataSource = this.colLupMonthListBindingSource;
            this.txtMonth.DisplayMember = "MonthTitle";
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Location = new System.Drawing.Point(6, 39);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(178, 25);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(6, 138);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(178, 25);
            this.txtBranchID.TabIndex = 20;
            this.txtBranchID.ValueMember = "BranchID";
            // 
            // lupBranchListBindingSource
            // 
            this.lupBranchListBindingSource.DataMember = "Lup_BranchList";
            this.lupBranchListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 118);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 17);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Branch:";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBankBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBankBranch.DataSource = this.hRLupBankListBindingSource;
            this.txtBankBranch.DisplayMember = "BankTitle";
            this.txtBankBranch.FormattingEnabled = true;
            this.txtBankBranch.Location = new System.Drawing.Point(6, 87);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(178, 25);
            this.txtBankBranch.TabIndex = 1;
            this.txtBankBranch.ValueMember = "BankID";
            // 
            // hRLupBankListBindingSource
            // 
            this.hRLupBankListBindingSource.DataMember = "HR_Lup_BankList";
            this.hRLupBankListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month:";
            // 
            // grvFullDomain
            // 
            this.grvFullDomain.AllowUserToAddRows = false;
            this.grvFullDomain.AllowUserToDeleteRows = false;
            this.grvFullDomain.AllowUserToOrderColumns = true;
            this.grvFullDomain.AutoGenerateColumns = false;
            this.grvFullDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFullDomain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainSerialDataGridViewTextBoxColumn,
            this.monthIDDataGridViewTextBoxColumn,
            this.bankIDDataGridViewTextBoxColumn,
            this.domainTypeDataGridViewTextBoxColumn,
            this.domainSchemaDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.domainStatusDataGridViewCheckBoxColumn,
            this.currentVersionDataGridViewTextBoxColumn,
            this.recordSerialDataGridViewTextBoxColumn,
            this.shortLineIDDataGridViewTextBoxColumn,
            this.domainIDDataGridViewTextBoxColumn,
            this.col1DataGridViewTextBoxColumn,
            this.col2DataGridViewTextBoxColumn,
            this.col3DataGridViewTextBoxColumn,
            this.col4DataGridViewTextBoxColumn,
            this.col5DataGridViewTextBoxColumn,
            this.col6DataGridViewTextBoxColumn,
            this.col7DataGridViewTextBoxColumn,
            this.col8DataGridViewTextBoxColumn,
            this.col9DataGridViewTextBoxColumn,
            this.col10DataGridViewTextBoxColumn,
            this.col11DataGridViewTextBoxColumn,
            this.col12DataGridViewTextBoxColumn,
            this.col13DataGridViewTextBoxColumn,
            this.col14DataGridViewTextBoxColumn,
            this.col15DataGridViewTextBoxColumn,
            this.col16DataGridViewTextBoxColumn,
            this.col17DataGridViewTextBoxColumn,
            this.col18DataGridViewTextBoxColumn,
            this.col19DataGridViewTextBoxColumn,
            this.col20DataGridViewTextBoxColumn,
            this.col21DataGridViewTextBoxColumn,
            this.col22DataGridViewTextBoxColumn,
            this.col23DataGridViewTextBoxColumn,
            this.col24DataGridViewTextBoxColumn,
            this.col25DataGridViewTextBoxColumn,
            this.col26DataGridViewTextBoxColumn,
            this.col27DataGridViewTextBoxColumn,
            this.col28DataGridViewTextBoxColumn,
            this.col29DataGridViewTextBoxColumn,
            this.col30DataGridViewTextBoxColumn,
            this.col31DataGridViewTextBoxColumn,
            this.col32DataGridViewTextBoxColumn,
            this.col33DataGridViewTextBoxColumn,
            this.col34DataGridViewTextBoxColumn,
            this.col35DataGridViewTextBoxColumn,
            this.col36DataGridViewTextBoxColumn,
            this.col37DataGridViewTextBoxColumn,
            this.col38DataGridViewTextBoxColumn,
            this.col39DataGridViewTextBoxColumn,
            this.col40DataGridViewTextBoxColumn,
            this.col41DataGridViewTextBoxColumn,
            this.col42DataGridViewTextBoxColumn,
            this.col43DataGridViewTextBoxColumn,
            this.col44DataGridViewTextBoxColumn,
            this.col45DataGridViewTextBoxColumn,
            this.col46DataGridViewTextBoxColumn,
            this.col47DataGridViewTextBoxColumn,
            this.col48DataGridViewTextBoxColumn,
            this.col49DataGridViewTextBoxColumn,
            this.col50DataGridViewTextBoxColumn,
            this.col51DataGridViewTextBoxColumn,
            this.col52DataGridViewTextBoxColumn,
            this.col53DataGridViewTextBoxColumn,
            this.col54DataGridViewTextBoxColumn,
            this.col55DataGridViewTextBoxColumn,
            this.col56DataGridViewTextBoxColumn,
            this.col57DataGridViewTextBoxColumn,
            this.col58DataGridViewTextBoxColumn,
            this.col59DataGridViewTextBoxColumn,
            this.col60DataGridViewTextBoxColumn,
            this.col61DataGridViewTextBoxColumn,
            this.col62DataGridViewTextBoxColumn,
            this.col63DataGridViewTextBoxColumn,
            this.col64DataGridViewTextBoxColumn,
            this.col65DataGridViewTextBoxColumn,
            this.col66DataGridViewTextBoxColumn,
            this.col67DataGridViewTextBoxColumn,
            this.col68DataGridViewTextBoxColumn,
            this.col69DataGridViewTextBoxColumn,
            this.col70DataGridViewTextBoxColumn,
            this.col71DataGridViewTextBoxColumn,
            this.col72DataGridViewTextBoxColumn,
            this.col73DataGridViewTextBoxColumn,
            this.col74DataGridViewTextBoxColumn,
            this.col75DataGridViewTextBoxColumn,
            this.col76DataGridViewTextBoxColumn,
            this.col77DataGridViewTextBoxColumn,
            this.col78DataGridViewTextBoxColumn,
            this.col79DataGridViewTextBoxColumn,
            this.col80DataGridViewTextBoxColumn,
            this.col81DataGridViewTextBoxColumn,
            this.col82DataGridViewTextBoxColumn,
            this.col83DataGridViewTextBoxColumn,
            this.col84DataGridViewTextBoxColumn,
            this.col85DataGridViewTextBoxColumn,
            this.col86DataGridViewTextBoxColumn,
            this.col87DataGridViewTextBoxColumn,
            this.col88DataGridViewTextBoxColumn,
            this.col89DataGridViewTextBoxColumn,
            this.col90DataGridViewTextBoxColumn,
            this.col91DataGridViewTextBoxColumn,
            this.col92DataGridViewTextBoxColumn,
            this.col93DataGridViewTextBoxColumn,
            this.col94DataGridViewTextBoxColumn,
            this.col95DataGridViewTextBoxColumn,
            this.col96DataGridViewTextBoxColumn,
            this.col97DataGridViewTextBoxColumn,
            this.col98DataGridViewTextBoxColumn,
            this.col99DataGridViewTextBoxColumn,
            this.col100DataGridViewTextBoxColumn,
            this.col101DataGridViewTextBoxColumn,
            this.col102DataGridViewTextBoxColumn,
            this.col103DataGridViewTextBoxColumn,
            this.col104DataGridViewTextBoxColumn,
            this.col105DataGridViewTextBoxColumn,
            this.col106DataGridViewTextBoxColumn,
            this.col107DataGridViewTextBoxColumn,
            this.col108DataGridViewTextBoxColumn,
            this.col109DataGridViewTextBoxColumn,
            this.col110DataGridViewTextBoxColumn,
            this.col111DataGridViewTextBoxColumn,
            this.col112DataGridViewTextBoxColumn,
            this.col113DataGridViewTextBoxColumn,
            this.col114DataGridViewTextBoxColumn,
            this.col115DataGridViewTextBoxColumn,
            this.col116DataGridViewTextBoxColumn,
            this.col117DataGridViewTextBoxColumn,
            this.col118DataGridViewTextBoxColumn,
            this.col119DataGridViewTextBoxColumn,
            this.col120DataGridViewTextBoxColumn,
            this.col121DataGridViewTextBoxColumn,
            this.col122DataGridViewTextBoxColumn,
            this.col123DataGridViewTextBoxColumn,
            this.col124DataGridViewTextBoxColumn,
            this.col125DataGridViewTextBoxColumn,
            this.col126DataGridViewTextBoxColumn,
            this.col127DataGridViewTextBoxColumn,
            this.col128DataGridViewTextBoxColumn,
            this.col129DataGridViewTextBoxColumn,
            this.col130DataGridViewTextBoxColumn,
            this.col131DataGridViewTextBoxColumn,
            this.col132DataGridViewTextBoxColumn,
            this.col133DataGridViewTextBoxColumn,
            this.col134DataGridViewTextBoxColumn,
            this.col135DataGridViewTextBoxColumn,
            this.col136DataGridViewTextBoxColumn,
            this.col137DataGridViewTextBoxColumn,
            this.col138DataGridViewTextBoxColumn,
            this.col139DataGridViewTextBoxColumn,
            this.col140DataGridViewTextBoxColumn,
            this.col141DataGridViewTextBoxColumn,
            this.col142DataGridViewTextBoxColumn,
            this.col143DataGridViewTextBoxColumn,
            this.col144DataGridViewTextBoxColumn,
            this.col145DataGridViewTextBoxColumn,
            this.col146DataGridViewTextBoxColumn,
            this.col147DataGridViewTextBoxColumn,
            this.col148DataGridViewTextBoxColumn,
            this.col149DataGridViewTextBoxColumn,
            this.col150DataGridViewTextBoxColumn,
            this.col151DataGridViewTextBoxColumn,
            this.col152DataGridViewTextBoxColumn,
            this.col153DataGridViewTextBoxColumn,
            this.col154DataGridViewTextBoxColumn,
            this.col155DataGridViewTextBoxColumn,
            this.col156DataGridViewTextBoxColumn,
            this.col157DataGridViewTextBoxColumn,
            this.col158DataGridViewTextBoxColumn,
            this.col159DataGridViewTextBoxColumn,
            this.col160DataGridViewTextBoxColumn,
            this.col161DataGridViewTextBoxColumn,
            this.col162DataGridViewTextBoxColumn,
            this.col163DataGridViewTextBoxColumn,
            this.col164DataGridViewTextBoxColumn,
            this.col165DataGridViewTextBoxColumn,
            this.col166DataGridViewTextBoxColumn,
            this.col167DataGridViewTextBoxColumn,
            this.col168DataGridViewTextBoxColumn,
            this.col169DataGridViewTextBoxColumn,
            this.col170DataGridViewTextBoxColumn,
            this.col171DataGridViewTextBoxColumn,
            this.col172DataGridViewTextBoxColumn,
            this.col173DataGridViewTextBoxColumn,
            this.col174DataGridViewTextBoxColumn,
            this.col175DataGridViewTextBoxColumn,
            this.col176DataGridViewTextBoxColumn,
            this.col177DataGridViewTextBoxColumn,
            this.col178DataGridViewTextBoxColumn,
            this.col179DataGridViewTextBoxColumn,
            this.col180DataGridViewTextBoxColumn,
            this.col181DataGridViewTextBoxColumn,
            this.col182DataGridViewTextBoxColumn,
            this.col183DataGridViewTextBoxColumn,
            this.col184DataGridViewTextBoxColumn,
            this.col185DataGridViewTextBoxColumn,
            this.col186DataGridViewTextBoxColumn,
            this.col187DataGridViewTextBoxColumn,
            this.col188DataGridViewTextBoxColumn,
            this.col189DataGridViewTextBoxColumn,
            this.col190DataGridViewTextBoxColumn,
            this.col191DataGridViewTextBoxColumn,
            this.col192DataGridViewTextBoxColumn,
            this.col193DataGridViewTextBoxColumn,
            this.col194DataGridViewTextBoxColumn,
            this.col195DataGridViewTextBoxColumn,
            this.col196DataGridViewTextBoxColumn,
            this.col197DataGridViewTextBoxColumn,
            this.col198DataGridViewTextBoxColumn,
            this.col199DataGridViewTextBoxColumn,
            this.col200DataGridViewTextBoxColumn,
            this.collectorNameDataGridViewTextBoxColumn,
            this.teamLeaderDataGridViewTextBoxColumn,
            this.superVisorDataGridViewTextBoxColumn});
            this.grvFullDomain.DataSource = this.gridDomainFullDataBindingSource;
            this.grvFullDomain.Location = new System.Drawing.Point(209, 240);
            this.grvFullDomain.Name = "grvFullDomain";
            this.grvFullDomain.ReadOnly = true;
            this.grvFullDomain.Size = new System.Drawing.Size(658, 295);
            this.grvFullDomain.TabIndex = 52;
            this.grvFullDomain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvFullDomain_CellContentClick);
            // 
            // domainSerialDataGridViewTextBoxColumn
            // 
            this.domainSerialDataGridViewTextBoxColumn.DataPropertyName = "DomainSerial";
            this.domainSerialDataGridViewTextBoxColumn.HeaderText = "DomainSerial";
            this.domainSerialDataGridViewTextBoxColumn.Name = "domainSerialDataGridViewTextBoxColumn";
            this.domainSerialDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // monthIDDataGridViewTextBoxColumn
            // 
            this.monthIDDataGridViewTextBoxColumn.DataPropertyName = "MonthID";
            this.monthIDDataGridViewTextBoxColumn.HeaderText = "MonthID";
            this.monthIDDataGridViewTextBoxColumn.Name = "monthIDDataGridViewTextBoxColumn";
            this.monthIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankIDDataGridViewTextBoxColumn
            // 
            this.bankIDDataGridViewTextBoxColumn.DataPropertyName = "BankID";
            this.bankIDDataGridViewTextBoxColumn.HeaderText = "BankID";
            this.bankIDDataGridViewTextBoxColumn.Name = "bankIDDataGridViewTextBoxColumn";
            this.bankIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainTypeDataGridViewTextBoxColumn
            // 
            this.domainTypeDataGridViewTextBoxColumn.DataPropertyName = "DomainType";
            this.domainTypeDataGridViewTextBoxColumn.HeaderText = "DomainType";
            this.domainTypeDataGridViewTextBoxColumn.Name = "domainTypeDataGridViewTextBoxColumn";
            this.domainTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainSchemaDataGridViewTextBoxColumn
            // 
            this.domainSchemaDataGridViewTextBoxColumn.DataPropertyName = "DomainSchema";
            this.domainSchemaDataGridViewTextBoxColumn.HeaderText = "DomainSchema";
            this.domainSchemaDataGridViewTextBoxColumn.Name = "domainSchemaDataGridViewTextBoxColumn";
            this.domainSchemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainSchemaDataGridViewTextBoxColumn.Visible = false;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainStatusDataGridViewCheckBoxColumn
            // 
            this.domainStatusDataGridViewCheckBoxColumn.DataPropertyName = "DomainStatus";
            this.domainStatusDataGridViewCheckBoxColumn.HeaderText = "DomainStatus";
            this.domainStatusDataGridViewCheckBoxColumn.Name = "domainStatusDataGridViewCheckBoxColumn";
            this.domainStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.domainStatusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // currentVersionDataGridViewTextBoxColumn
            // 
            this.currentVersionDataGridViewTextBoxColumn.DataPropertyName = "CurrentVersion";
            this.currentVersionDataGridViewTextBoxColumn.HeaderText = "CurrentVersion";
            this.currentVersionDataGridViewTextBoxColumn.Name = "currentVersionDataGridViewTextBoxColumn";
            this.currentVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentVersionDataGridViewTextBoxColumn.Visible = false;
            // 
            // recordSerialDataGridViewTextBoxColumn
            // 
            this.recordSerialDataGridViewTextBoxColumn.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.Name = "recordSerialDataGridViewTextBoxColumn";
            this.recordSerialDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // shortLineIDDataGridViewTextBoxColumn
            // 
            this.shortLineIDDataGridViewTextBoxColumn.DataPropertyName = "ShortLineID";
            this.shortLineIDDataGridViewTextBoxColumn.HeaderText = "ShortLineID";
            this.shortLineIDDataGridViewTextBoxColumn.Name = "shortLineIDDataGridViewTextBoxColumn";
            this.shortLineIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortLineIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn
            // 
            this.domainIDDataGridViewTextBoxColumn.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn.Name = "domainIDDataGridViewTextBoxColumn";
            this.domainIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // col1DataGridViewTextBoxColumn
            // 
            this.col1DataGridViewTextBoxColumn.DataPropertyName = "Col1";
            this.col1DataGridViewTextBoxColumn.HeaderText = "Col1";
            this.col1DataGridViewTextBoxColumn.Name = "col1DataGridViewTextBoxColumn";
            this.col1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col2DataGridViewTextBoxColumn
            // 
            this.col2DataGridViewTextBoxColumn.DataPropertyName = "Col2";
            this.col2DataGridViewTextBoxColumn.HeaderText = "Col2";
            this.col2DataGridViewTextBoxColumn.Name = "col2DataGridViewTextBoxColumn";
            this.col2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col3DataGridViewTextBoxColumn
            // 
            this.col3DataGridViewTextBoxColumn.DataPropertyName = "Col3";
            this.col3DataGridViewTextBoxColumn.HeaderText = "Col3";
            this.col3DataGridViewTextBoxColumn.Name = "col3DataGridViewTextBoxColumn";
            this.col3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col4DataGridViewTextBoxColumn
            // 
            this.col4DataGridViewTextBoxColumn.DataPropertyName = "Col4";
            this.col4DataGridViewTextBoxColumn.HeaderText = "Col4";
            this.col4DataGridViewTextBoxColumn.Name = "col4DataGridViewTextBoxColumn";
            this.col4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col5DataGridViewTextBoxColumn
            // 
            this.col5DataGridViewTextBoxColumn.DataPropertyName = "Col5";
            this.col5DataGridViewTextBoxColumn.HeaderText = "Col5";
            this.col5DataGridViewTextBoxColumn.Name = "col5DataGridViewTextBoxColumn";
            this.col5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col6DataGridViewTextBoxColumn
            // 
            this.col6DataGridViewTextBoxColumn.DataPropertyName = "Col6";
            this.col6DataGridViewTextBoxColumn.HeaderText = "Col6";
            this.col6DataGridViewTextBoxColumn.Name = "col6DataGridViewTextBoxColumn";
            this.col6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col7DataGridViewTextBoxColumn
            // 
            this.col7DataGridViewTextBoxColumn.DataPropertyName = "Col7";
            this.col7DataGridViewTextBoxColumn.HeaderText = "Col7";
            this.col7DataGridViewTextBoxColumn.Name = "col7DataGridViewTextBoxColumn";
            this.col7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col8DataGridViewTextBoxColumn
            // 
            this.col8DataGridViewTextBoxColumn.DataPropertyName = "Col8";
            this.col8DataGridViewTextBoxColumn.HeaderText = "Col8";
            this.col8DataGridViewTextBoxColumn.Name = "col8DataGridViewTextBoxColumn";
            this.col8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col9DataGridViewTextBoxColumn
            // 
            this.col9DataGridViewTextBoxColumn.DataPropertyName = "Col9";
            this.col9DataGridViewTextBoxColumn.HeaderText = "Col9";
            this.col9DataGridViewTextBoxColumn.Name = "col9DataGridViewTextBoxColumn";
            this.col9DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col10DataGridViewTextBoxColumn
            // 
            this.col10DataGridViewTextBoxColumn.DataPropertyName = "Col10";
            this.col10DataGridViewTextBoxColumn.HeaderText = "Col10";
            this.col10DataGridViewTextBoxColumn.Name = "col10DataGridViewTextBoxColumn";
            this.col10DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col11DataGridViewTextBoxColumn
            // 
            this.col11DataGridViewTextBoxColumn.DataPropertyName = "Col11";
            this.col11DataGridViewTextBoxColumn.HeaderText = "Col11";
            this.col11DataGridViewTextBoxColumn.Name = "col11DataGridViewTextBoxColumn";
            this.col11DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col12DataGridViewTextBoxColumn
            // 
            this.col12DataGridViewTextBoxColumn.DataPropertyName = "Col12";
            this.col12DataGridViewTextBoxColumn.HeaderText = "Col12";
            this.col12DataGridViewTextBoxColumn.Name = "col12DataGridViewTextBoxColumn";
            this.col12DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col13DataGridViewTextBoxColumn
            // 
            this.col13DataGridViewTextBoxColumn.DataPropertyName = "Col13";
            this.col13DataGridViewTextBoxColumn.HeaderText = "Col13";
            this.col13DataGridViewTextBoxColumn.Name = "col13DataGridViewTextBoxColumn";
            this.col13DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col14DataGridViewTextBoxColumn
            // 
            this.col14DataGridViewTextBoxColumn.DataPropertyName = "Col14";
            this.col14DataGridViewTextBoxColumn.HeaderText = "Col14";
            this.col14DataGridViewTextBoxColumn.Name = "col14DataGridViewTextBoxColumn";
            this.col14DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col15DataGridViewTextBoxColumn
            // 
            this.col15DataGridViewTextBoxColumn.DataPropertyName = "Col15";
            this.col15DataGridViewTextBoxColumn.HeaderText = "Col15";
            this.col15DataGridViewTextBoxColumn.Name = "col15DataGridViewTextBoxColumn";
            this.col15DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col16DataGridViewTextBoxColumn
            // 
            this.col16DataGridViewTextBoxColumn.DataPropertyName = "Col16";
            this.col16DataGridViewTextBoxColumn.HeaderText = "Col16";
            this.col16DataGridViewTextBoxColumn.Name = "col16DataGridViewTextBoxColumn";
            this.col16DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col17DataGridViewTextBoxColumn
            // 
            this.col17DataGridViewTextBoxColumn.DataPropertyName = "Col17";
            this.col17DataGridViewTextBoxColumn.HeaderText = "Col17";
            this.col17DataGridViewTextBoxColumn.Name = "col17DataGridViewTextBoxColumn";
            this.col17DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col18DataGridViewTextBoxColumn
            // 
            this.col18DataGridViewTextBoxColumn.DataPropertyName = "Col18";
            this.col18DataGridViewTextBoxColumn.HeaderText = "Col18";
            this.col18DataGridViewTextBoxColumn.Name = "col18DataGridViewTextBoxColumn";
            this.col18DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col19DataGridViewTextBoxColumn
            // 
            this.col19DataGridViewTextBoxColumn.DataPropertyName = "Col19";
            this.col19DataGridViewTextBoxColumn.HeaderText = "Col19";
            this.col19DataGridViewTextBoxColumn.Name = "col19DataGridViewTextBoxColumn";
            this.col19DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col20DataGridViewTextBoxColumn
            // 
            this.col20DataGridViewTextBoxColumn.DataPropertyName = "Col20";
            this.col20DataGridViewTextBoxColumn.HeaderText = "Col20";
            this.col20DataGridViewTextBoxColumn.Name = "col20DataGridViewTextBoxColumn";
            this.col20DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col21DataGridViewTextBoxColumn
            // 
            this.col21DataGridViewTextBoxColumn.DataPropertyName = "Col21";
            this.col21DataGridViewTextBoxColumn.HeaderText = "Col21";
            this.col21DataGridViewTextBoxColumn.Name = "col21DataGridViewTextBoxColumn";
            this.col21DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col22DataGridViewTextBoxColumn
            // 
            this.col22DataGridViewTextBoxColumn.DataPropertyName = "Col22";
            this.col22DataGridViewTextBoxColumn.HeaderText = "Col22";
            this.col22DataGridViewTextBoxColumn.Name = "col22DataGridViewTextBoxColumn";
            this.col22DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col23DataGridViewTextBoxColumn
            // 
            this.col23DataGridViewTextBoxColumn.DataPropertyName = "Col23";
            this.col23DataGridViewTextBoxColumn.HeaderText = "Col23";
            this.col23DataGridViewTextBoxColumn.Name = "col23DataGridViewTextBoxColumn";
            this.col23DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col24DataGridViewTextBoxColumn
            // 
            this.col24DataGridViewTextBoxColumn.DataPropertyName = "Col24";
            this.col24DataGridViewTextBoxColumn.HeaderText = "Col24";
            this.col24DataGridViewTextBoxColumn.Name = "col24DataGridViewTextBoxColumn";
            this.col24DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col25DataGridViewTextBoxColumn
            // 
            this.col25DataGridViewTextBoxColumn.DataPropertyName = "Col25";
            this.col25DataGridViewTextBoxColumn.HeaderText = "Col25";
            this.col25DataGridViewTextBoxColumn.Name = "col25DataGridViewTextBoxColumn";
            this.col25DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col26DataGridViewTextBoxColumn
            // 
            this.col26DataGridViewTextBoxColumn.DataPropertyName = "Col26";
            this.col26DataGridViewTextBoxColumn.HeaderText = "Col26";
            this.col26DataGridViewTextBoxColumn.Name = "col26DataGridViewTextBoxColumn";
            this.col26DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col27DataGridViewTextBoxColumn
            // 
            this.col27DataGridViewTextBoxColumn.DataPropertyName = "Col27";
            this.col27DataGridViewTextBoxColumn.HeaderText = "Col27";
            this.col27DataGridViewTextBoxColumn.Name = "col27DataGridViewTextBoxColumn";
            this.col27DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col28DataGridViewTextBoxColumn
            // 
            this.col28DataGridViewTextBoxColumn.DataPropertyName = "Col28";
            this.col28DataGridViewTextBoxColumn.HeaderText = "Col28";
            this.col28DataGridViewTextBoxColumn.Name = "col28DataGridViewTextBoxColumn";
            this.col28DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col29DataGridViewTextBoxColumn
            // 
            this.col29DataGridViewTextBoxColumn.DataPropertyName = "Col29";
            this.col29DataGridViewTextBoxColumn.HeaderText = "Col29";
            this.col29DataGridViewTextBoxColumn.Name = "col29DataGridViewTextBoxColumn";
            this.col29DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col30DataGridViewTextBoxColumn
            // 
            this.col30DataGridViewTextBoxColumn.DataPropertyName = "Col30";
            this.col30DataGridViewTextBoxColumn.HeaderText = "Col30";
            this.col30DataGridViewTextBoxColumn.Name = "col30DataGridViewTextBoxColumn";
            this.col30DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col31DataGridViewTextBoxColumn
            // 
            this.col31DataGridViewTextBoxColumn.DataPropertyName = "Col31";
            this.col31DataGridViewTextBoxColumn.HeaderText = "Col31";
            this.col31DataGridViewTextBoxColumn.Name = "col31DataGridViewTextBoxColumn";
            this.col31DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col32DataGridViewTextBoxColumn
            // 
            this.col32DataGridViewTextBoxColumn.DataPropertyName = "Col32";
            this.col32DataGridViewTextBoxColumn.HeaderText = "Col32";
            this.col32DataGridViewTextBoxColumn.Name = "col32DataGridViewTextBoxColumn";
            this.col32DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col33DataGridViewTextBoxColumn
            // 
            this.col33DataGridViewTextBoxColumn.DataPropertyName = "Col33";
            this.col33DataGridViewTextBoxColumn.HeaderText = "Col33";
            this.col33DataGridViewTextBoxColumn.Name = "col33DataGridViewTextBoxColumn";
            this.col33DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col34DataGridViewTextBoxColumn
            // 
            this.col34DataGridViewTextBoxColumn.DataPropertyName = "Col34";
            this.col34DataGridViewTextBoxColumn.HeaderText = "Col34";
            this.col34DataGridViewTextBoxColumn.Name = "col34DataGridViewTextBoxColumn";
            this.col34DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col35DataGridViewTextBoxColumn
            // 
            this.col35DataGridViewTextBoxColumn.DataPropertyName = "Col35";
            this.col35DataGridViewTextBoxColumn.HeaderText = "Col35";
            this.col35DataGridViewTextBoxColumn.Name = "col35DataGridViewTextBoxColumn";
            this.col35DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col36DataGridViewTextBoxColumn
            // 
            this.col36DataGridViewTextBoxColumn.DataPropertyName = "Col36";
            this.col36DataGridViewTextBoxColumn.HeaderText = "Col36";
            this.col36DataGridViewTextBoxColumn.Name = "col36DataGridViewTextBoxColumn";
            this.col36DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col37DataGridViewTextBoxColumn
            // 
            this.col37DataGridViewTextBoxColumn.DataPropertyName = "Col37";
            this.col37DataGridViewTextBoxColumn.HeaderText = "Col37";
            this.col37DataGridViewTextBoxColumn.Name = "col37DataGridViewTextBoxColumn";
            this.col37DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col38DataGridViewTextBoxColumn
            // 
            this.col38DataGridViewTextBoxColumn.DataPropertyName = "Col38";
            this.col38DataGridViewTextBoxColumn.HeaderText = "Col38";
            this.col38DataGridViewTextBoxColumn.Name = "col38DataGridViewTextBoxColumn";
            this.col38DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col39DataGridViewTextBoxColumn
            // 
            this.col39DataGridViewTextBoxColumn.DataPropertyName = "Col39";
            this.col39DataGridViewTextBoxColumn.HeaderText = "Col39";
            this.col39DataGridViewTextBoxColumn.Name = "col39DataGridViewTextBoxColumn";
            this.col39DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col40DataGridViewTextBoxColumn
            // 
            this.col40DataGridViewTextBoxColumn.DataPropertyName = "Col40";
            this.col40DataGridViewTextBoxColumn.HeaderText = "Col40";
            this.col40DataGridViewTextBoxColumn.Name = "col40DataGridViewTextBoxColumn";
            this.col40DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col41DataGridViewTextBoxColumn
            // 
            this.col41DataGridViewTextBoxColumn.DataPropertyName = "Col41";
            this.col41DataGridViewTextBoxColumn.HeaderText = "Col41";
            this.col41DataGridViewTextBoxColumn.Name = "col41DataGridViewTextBoxColumn";
            this.col41DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col42DataGridViewTextBoxColumn
            // 
            this.col42DataGridViewTextBoxColumn.DataPropertyName = "Col42";
            this.col42DataGridViewTextBoxColumn.HeaderText = "Col42";
            this.col42DataGridViewTextBoxColumn.Name = "col42DataGridViewTextBoxColumn";
            this.col42DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col43DataGridViewTextBoxColumn
            // 
            this.col43DataGridViewTextBoxColumn.DataPropertyName = "Col43";
            this.col43DataGridViewTextBoxColumn.HeaderText = "Col43";
            this.col43DataGridViewTextBoxColumn.Name = "col43DataGridViewTextBoxColumn";
            this.col43DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col44DataGridViewTextBoxColumn
            // 
            this.col44DataGridViewTextBoxColumn.DataPropertyName = "Col44";
            this.col44DataGridViewTextBoxColumn.HeaderText = "Col44";
            this.col44DataGridViewTextBoxColumn.Name = "col44DataGridViewTextBoxColumn";
            this.col44DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col45DataGridViewTextBoxColumn
            // 
            this.col45DataGridViewTextBoxColumn.DataPropertyName = "Col45";
            this.col45DataGridViewTextBoxColumn.HeaderText = "Col45";
            this.col45DataGridViewTextBoxColumn.Name = "col45DataGridViewTextBoxColumn";
            this.col45DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col46DataGridViewTextBoxColumn
            // 
            this.col46DataGridViewTextBoxColumn.DataPropertyName = "Col46";
            this.col46DataGridViewTextBoxColumn.HeaderText = "Col46";
            this.col46DataGridViewTextBoxColumn.Name = "col46DataGridViewTextBoxColumn";
            this.col46DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col47DataGridViewTextBoxColumn
            // 
            this.col47DataGridViewTextBoxColumn.DataPropertyName = "Col47";
            this.col47DataGridViewTextBoxColumn.HeaderText = "Col47";
            this.col47DataGridViewTextBoxColumn.Name = "col47DataGridViewTextBoxColumn";
            this.col47DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col48DataGridViewTextBoxColumn
            // 
            this.col48DataGridViewTextBoxColumn.DataPropertyName = "Col48";
            this.col48DataGridViewTextBoxColumn.HeaderText = "Col48";
            this.col48DataGridViewTextBoxColumn.Name = "col48DataGridViewTextBoxColumn";
            this.col48DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col49DataGridViewTextBoxColumn
            // 
            this.col49DataGridViewTextBoxColumn.DataPropertyName = "Col49";
            this.col49DataGridViewTextBoxColumn.HeaderText = "Col49";
            this.col49DataGridViewTextBoxColumn.Name = "col49DataGridViewTextBoxColumn";
            this.col49DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col50DataGridViewTextBoxColumn
            // 
            this.col50DataGridViewTextBoxColumn.DataPropertyName = "Col50";
            this.col50DataGridViewTextBoxColumn.HeaderText = "Col50";
            this.col50DataGridViewTextBoxColumn.Name = "col50DataGridViewTextBoxColumn";
            this.col50DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col51DataGridViewTextBoxColumn
            // 
            this.col51DataGridViewTextBoxColumn.DataPropertyName = "Col51";
            this.col51DataGridViewTextBoxColumn.HeaderText = "Col51";
            this.col51DataGridViewTextBoxColumn.Name = "col51DataGridViewTextBoxColumn";
            this.col51DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col52DataGridViewTextBoxColumn
            // 
            this.col52DataGridViewTextBoxColumn.DataPropertyName = "Col52";
            this.col52DataGridViewTextBoxColumn.HeaderText = "Col52";
            this.col52DataGridViewTextBoxColumn.Name = "col52DataGridViewTextBoxColumn";
            this.col52DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col53DataGridViewTextBoxColumn
            // 
            this.col53DataGridViewTextBoxColumn.DataPropertyName = "Col53";
            this.col53DataGridViewTextBoxColumn.HeaderText = "Col53";
            this.col53DataGridViewTextBoxColumn.Name = "col53DataGridViewTextBoxColumn";
            this.col53DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col54DataGridViewTextBoxColumn
            // 
            this.col54DataGridViewTextBoxColumn.DataPropertyName = "Col54";
            this.col54DataGridViewTextBoxColumn.HeaderText = "Col54";
            this.col54DataGridViewTextBoxColumn.Name = "col54DataGridViewTextBoxColumn";
            this.col54DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col55DataGridViewTextBoxColumn
            // 
            this.col55DataGridViewTextBoxColumn.DataPropertyName = "Col55";
            this.col55DataGridViewTextBoxColumn.HeaderText = "Col55";
            this.col55DataGridViewTextBoxColumn.Name = "col55DataGridViewTextBoxColumn";
            this.col55DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col56DataGridViewTextBoxColumn
            // 
            this.col56DataGridViewTextBoxColumn.DataPropertyName = "Col56";
            this.col56DataGridViewTextBoxColumn.HeaderText = "Col56";
            this.col56DataGridViewTextBoxColumn.Name = "col56DataGridViewTextBoxColumn";
            this.col56DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col57DataGridViewTextBoxColumn
            // 
            this.col57DataGridViewTextBoxColumn.DataPropertyName = "Col57";
            this.col57DataGridViewTextBoxColumn.HeaderText = "Col57";
            this.col57DataGridViewTextBoxColumn.Name = "col57DataGridViewTextBoxColumn";
            this.col57DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col58DataGridViewTextBoxColumn
            // 
            this.col58DataGridViewTextBoxColumn.DataPropertyName = "Col58";
            this.col58DataGridViewTextBoxColumn.HeaderText = "Col58";
            this.col58DataGridViewTextBoxColumn.Name = "col58DataGridViewTextBoxColumn";
            this.col58DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col59DataGridViewTextBoxColumn
            // 
            this.col59DataGridViewTextBoxColumn.DataPropertyName = "Col59";
            this.col59DataGridViewTextBoxColumn.HeaderText = "Col59";
            this.col59DataGridViewTextBoxColumn.Name = "col59DataGridViewTextBoxColumn";
            this.col59DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col60DataGridViewTextBoxColumn
            // 
            this.col60DataGridViewTextBoxColumn.DataPropertyName = "Col60";
            this.col60DataGridViewTextBoxColumn.HeaderText = "Col60";
            this.col60DataGridViewTextBoxColumn.Name = "col60DataGridViewTextBoxColumn";
            this.col60DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col61DataGridViewTextBoxColumn
            // 
            this.col61DataGridViewTextBoxColumn.DataPropertyName = "Col61";
            this.col61DataGridViewTextBoxColumn.HeaderText = "Col61";
            this.col61DataGridViewTextBoxColumn.Name = "col61DataGridViewTextBoxColumn";
            this.col61DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col62DataGridViewTextBoxColumn
            // 
            this.col62DataGridViewTextBoxColumn.DataPropertyName = "Col62";
            this.col62DataGridViewTextBoxColumn.HeaderText = "Col62";
            this.col62DataGridViewTextBoxColumn.Name = "col62DataGridViewTextBoxColumn";
            this.col62DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col63DataGridViewTextBoxColumn
            // 
            this.col63DataGridViewTextBoxColumn.DataPropertyName = "Col63";
            this.col63DataGridViewTextBoxColumn.HeaderText = "Col63";
            this.col63DataGridViewTextBoxColumn.Name = "col63DataGridViewTextBoxColumn";
            this.col63DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col64DataGridViewTextBoxColumn
            // 
            this.col64DataGridViewTextBoxColumn.DataPropertyName = "Col64";
            this.col64DataGridViewTextBoxColumn.HeaderText = "Col64";
            this.col64DataGridViewTextBoxColumn.Name = "col64DataGridViewTextBoxColumn";
            this.col64DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col65DataGridViewTextBoxColumn
            // 
            this.col65DataGridViewTextBoxColumn.DataPropertyName = "Col65";
            this.col65DataGridViewTextBoxColumn.HeaderText = "Col65";
            this.col65DataGridViewTextBoxColumn.Name = "col65DataGridViewTextBoxColumn";
            this.col65DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col66DataGridViewTextBoxColumn
            // 
            this.col66DataGridViewTextBoxColumn.DataPropertyName = "Col66";
            this.col66DataGridViewTextBoxColumn.HeaderText = "Col66";
            this.col66DataGridViewTextBoxColumn.Name = "col66DataGridViewTextBoxColumn";
            this.col66DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col67DataGridViewTextBoxColumn
            // 
            this.col67DataGridViewTextBoxColumn.DataPropertyName = "Col67";
            this.col67DataGridViewTextBoxColumn.HeaderText = "Col67";
            this.col67DataGridViewTextBoxColumn.Name = "col67DataGridViewTextBoxColumn";
            this.col67DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col68DataGridViewTextBoxColumn
            // 
            this.col68DataGridViewTextBoxColumn.DataPropertyName = "Col68";
            this.col68DataGridViewTextBoxColumn.HeaderText = "Col68";
            this.col68DataGridViewTextBoxColumn.Name = "col68DataGridViewTextBoxColumn";
            this.col68DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col69DataGridViewTextBoxColumn
            // 
            this.col69DataGridViewTextBoxColumn.DataPropertyName = "Col69";
            this.col69DataGridViewTextBoxColumn.HeaderText = "Col69";
            this.col69DataGridViewTextBoxColumn.Name = "col69DataGridViewTextBoxColumn";
            this.col69DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col70DataGridViewTextBoxColumn
            // 
            this.col70DataGridViewTextBoxColumn.DataPropertyName = "Col70";
            this.col70DataGridViewTextBoxColumn.HeaderText = "Col70";
            this.col70DataGridViewTextBoxColumn.Name = "col70DataGridViewTextBoxColumn";
            this.col70DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col71DataGridViewTextBoxColumn
            // 
            this.col71DataGridViewTextBoxColumn.DataPropertyName = "Col71";
            this.col71DataGridViewTextBoxColumn.HeaderText = "Col71";
            this.col71DataGridViewTextBoxColumn.Name = "col71DataGridViewTextBoxColumn";
            this.col71DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col72DataGridViewTextBoxColumn
            // 
            this.col72DataGridViewTextBoxColumn.DataPropertyName = "Col72";
            this.col72DataGridViewTextBoxColumn.HeaderText = "Col72";
            this.col72DataGridViewTextBoxColumn.Name = "col72DataGridViewTextBoxColumn";
            this.col72DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col73DataGridViewTextBoxColumn
            // 
            this.col73DataGridViewTextBoxColumn.DataPropertyName = "Col73";
            this.col73DataGridViewTextBoxColumn.HeaderText = "Col73";
            this.col73DataGridViewTextBoxColumn.Name = "col73DataGridViewTextBoxColumn";
            this.col73DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col74DataGridViewTextBoxColumn
            // 
            this.col74DataGridViewTextBoxColumn.DataPropertyName = "Col74";
            this.col74DataGridViewTextBoxColumn.HeaderText = "Col74";
            this.col74DataGridViewTextBoxColumn.Name = "col74DataGridViewTextBoxColumn";
            this.col74DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col75DataGridViewTextBoxColumn
            // 
            this.col75DataGridViewTextBoxColumn.DataPropertyName = "Col75";
            this.col75DataGridViewTextBoxColumn.HeaderText = "Col75";
            this.col75DataGridViewTextBoxColumn.Name = "col75DataGridViewTextBoxColumn";
            this.col75DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col76DataGridViewTextBoxColumn
            // 
            this.col76DataGridViewTextBoxColumn.DataPropertyName = "Col76";
            this.col76DataGridViewTextBoxColumn.HeaderText = "Col76";
            this.col76DataGridViewTextBoxColumn.Name = "col76DataGridViewTextBoxColumn";
            this.col76DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col77DataGridViewTextBoxColumn
            // 
            this.col77DataGridViewTextBoxColumn.DataPropertyName = "Col77";
            this.col77DataGridViewTextBoxColumn.HeaderText = "Col77";
            this.col77DataGridViewTextBoxColumn.Name = "col77DataGridViewTextBoxColumn";
            this.col77DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col78DataGridViewTextBoxColumn
            // 
            this.col78DataGridViewTextBoxColumn.DataPropertyName = "Col78";
            this.col78DataGridViewTextBoxColumn.HeaderText = "Col78";
            this.col78DataGridViewTextBoxColumn.Name = "col78DataGridViewTextBoxColumn";
            this.col78DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col79DataGridViewTextBoxColumn
            // 
            this.col79DataGridViewTextBoxColumn.DataPropertyName = "Col79";
            this.col79DataGridViewTextBoxColumn.HeaderText = "Col79";
            this.col79DataGridViewTextBoxColumn.Name = "col79DataGridViewTextBoxColumn";
            this.col79DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col80DataGridViewTextBoxColumn
            // 
            this.col80DataGridViewTextBoxColumn.DataPropertyName = "Col80";
            this.col80DataGridViewTextBoxColumn.HeaderText = "Col80";
            this.col80DataGridViewTextBoxColumn.Name = "col80DataGridViewTextBoxColumn";
            this.col80DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col81DataGridViewTextBoxColumn
            // 
            this.col81DataGridViewTextBoxColumn.DataPropertyName = "Col81";
            this.col81DataGridViewTextBoxColumn.HeaderText = "Col81";
            this.col81DataGridViewTextBoxColumn.Name = "col81DataGridViewTextBoxColumn";
            this.col81DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col82DataGridViewTextBoxColumn
            // 
            this.col82DataGridViewTextBoxColumn.DataPropertyName = "Col82";
            this.col82DataGridViewTextBoxColumn.HeaderText = "Col82";
            this.col82DataGridViewTextBoxColumn.Name = "col82DataGridViewTextBoxColumn";
            this.col82DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col83DataGridViewTextBoxColumn
            // 
            this.col83DataGridViewTextBoxColumn.DataPropertyName = "Col83";
            this.col83DataGridViewTextBoxColumn.HeaderText = "Col83";
            this.col83DataGridViewTextBoxColumn.Name = "col83DataGridViewTextBoxColumn";
            this.col83DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col84DataGridViewTextBoxColumn
            // 
            this.col84DataGridViewTextBoxColumn.DataPropertyName = "Col84";
            this.col84DataGridViewTextBoxColumn.HeaderText = "Col84";
            this.col84DataGridViewTextBoxColumn.Name = "col84DataGridViewTextBoxColumn";
            this.col84DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col85DataGridViewTextBoxColumn
            // 
            this.col85DataGridViewTextBoxColumn.DataPropertyName = "Col85";
            this.col85DataGridViewTextBoxColumn.HeaderText = "Col85";
            this.col85DataGridViewTextBoxColumn.Name = "col85DataGridViewTextBoxColumn";
            this.col85DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col86DataGridViewTextBoxColumn
            // 
            this.col86DataGridViewTextBoxColumn.DataPropertyName = "Col86";
            this.col86DataGridViewTextBoxColumn.HeaderText = "Col86";
            this.col86DataGridViewTextBoxColumn.Name = "col86DataGridViewTextBoxColumn";
            this.col86DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col87DataGridViewTextBoxColumn
            // 
            this.col87DataGridViewTextBoxColumn.DataPropertyName = "Col87";
            this.col87DataGridViewTextBoxColumn.HeaderText = "Col87";
            this.col87DataGridViewTextBoxColumn.Name = "col87DataGridViewTextBoxColumn";
            this.col87DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col88DataGridViewTextBoxColumn
            // 
            this.col88DataGridViewTextBoxColumn.DataPropertyName = "Col88";
            this.col88DataGridViewTextBoxColumn.HeaderText = "Col88";
            this.col88DataGridViewTextBoxColumn.Name = "col88DataGridViewTextBoxColumn";
            this.col88DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col89DataGridViewTextBoxColumn
            // 
            this.col89DataGridViewTextBoxColumn.DataPropertyName = "Col89";
            this.col89DataGridViewTextBoxColumn.HeaderText = "Col89";
            this.col89DataGridViewTextBoxColumn.Name = "col89DataGridViewTextBoxColumn";
            this.col89DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col90DataGridViewTextBoxColumn
            // 
            this.col90DataGridViewTextBoxColumn.DataPropertyName = "Col90";
            this.col90DataGridViewTextBoxColumn.HeaderText = "Col90";
            this.col90DataGridViewTextBoxColumn.Name = "col90DataGridViewTextBoxColumn";
            this.col90DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col91DataGridViewTextBoxColumn
            // 
            this.col91DataGridViewTextBoxColumn.DataPropertyName = "Col91";
            this.col91DataGridViewTextBoxColumn.HeaderText = "Col91";
            this.col91DataGridViewTextBoxColumn.Name = "col91DataGridViewTextBoxColumn";
            this.col91DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col92DataGridViewTextBoxColumn
            // 
            this.col92DataGridViewTextBoxColumn.DataPropertyName = "Col92";
            this.col92DataGridViewTextBoxColumn.HeaderText = "Col92";
            this.col92DataGridViewTextBoxColumn.Name = "col92DataGridViewTextBoxColumn";
            this.col92DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col93DataGridViewTextBoxColumn
            // 
            this.col93DataGridViewTextBoxColumn.DataPropertyName = "Col93";
            this.col93DataGridViewTextBoxColumn.HeaderText = "Col93";
            this.col93DataGridViewTextBoxColumn.Name = "col93DataGridViewTextBoxColumn";
            this.col93DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col94DataGridViewTextBoxColumn
            // 
            this.col94DataGridViewTextBoxColumn.DataPropertyName = "Col94";
            this.col94DataGridViewTextBoxColumn.HeaderText = "Col94";
            this.col94DataGridViewTextBoxColumn.Name = "col94DataGridViewTextBoxColumn";
            this.col94DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col95DataGridViewTextBoxColumn
            // 
            this.col95DataGridViewTextBoxColumn.DataPropertyName = "Col95";
            this.col95DataGridViewTextBoxColumn.HeaderText = "Col95";
            this.col95DataGridViewTextBoxColumn.Name = "col95DataGridViewTextBoxColumn";
            this.col95DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col96DataGridViewTextBoxColumn
            // 
            this.col96DataGridViewTextBoxColumn.DataPropertyName = "Col96";
            this.col96DataGridViewTextBoxColumn.HeaderText = "Col96";
            this.col96DataGridViewTextBoxColumn.Name = "col96DataGridViewTextBoxColumn";
            this.col96DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col97DataGridViewTextBoxColumn
            // 
            this.col97DataGridViewTextBoxColumn.DataPropertyName = "Col97";
            this.col97DataGridViewTextBoxColumn.HeaderText = "Col97";
            this.col97DataGridViewTextBoxColumn.Name = "col97DataGridViewTextBoxColumn";
            this.col97DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col98DataGridViewTextBoxColumn
            // 
            this.col98DataGridViewTextBoxColumn.DataPropertyName = "Col98";
            this.col98DataGridViewTextBoxColumn.HeaderText = "Col98";
            this.col98DataGridViewTextBoxColumn.Name = "col98DataGridViewTextBoxColumn";
            this.col98DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col99DataGridViewTextBoxColumn
            // 
            this.col99DataGridViewTextBoxColumn.DataPropertyName = "Col99";
            this.col99DataGridViewTextBoxColumn.HeaderText = "Col99";
            this.col99DataGridViewTextBoxColumn.Name = "col99DataGridViewTextBoxColumn";
            this.col99DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col100DataGridViewTextBoxColumn
            // 
            this.col100DataGridViewTextBoxColumn.DataPropertyName = "Col100";
            this.col100DataGridViewTextBoxColumn.HeaderText = "Col100";
            this.col100DataGridViewTextBoxColumn.Name = "col100DataGridViewTextBoxColumn";
            this.col100DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col101DataGridViewTextBoxColumn
            // 
            this.col101DataGridViewTextBoxColumn.DataPropertyName = "Col101";
            this.col101DataGridViewTextBoxColumn.HeaderText = "Col101";
            this.col101DataGridViewTextBoxColumn.Name = "col101DataGridViewTextBoxColumn";
            this.col101DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col102DataGridViewTextBoxColumn
            // 
            this.col102DataGridViewTextBoxColumn.DataPropertyName = "Col102";
            this.col102DataGridViewTextBoxColumn.HeaderText = "Col102";
            this.col102DataGridViewTextBoxColumn.Name = "col102DataGridViewTextBoxColumn";
            this.col102DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col103DataGridViewTextBoxColumn
            // 
            this.col103DataGridViewTextBoxColumn.DataPropertyName = "Col103";
            this.col103DataGridViewTextBoxColumn.HeaderText = "Col103";
            this.col103DataGridViewTextBoxColumn.Name = "col103DataGridViewTextBoxColumn";
            this.col103DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col104DataGridViewTextBoxColumn
            // 
            this.col104DataGridViewTextBoxColumn.DataPropertyName = "Col104";
            this.col104DataGridViewTextBoxColumn.HeaderText = "Col104";
            this.col104DataGridViewTextBoxColumn.Name = "col104DataGridViewTextBoxColumn";
            this.col104DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col105DataGridViewTextBoxColumn
            // 
            this.col105DataGridViewTextBoxColumn.DataPropertyName = "Col105";
            this.col105DataGridViewTextBoxColumn.HeaderText = "Col105";
            this.col105DataGridViewTextBoxColumn.Name = "col105DataGridViewTextBoxColumn";
            this.col105DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col106DataGridViewTextBoxColumn
            // 
            this.col106DataGridViewTextBoxColumn.DataPropertyName = "Col106";
            this.col106DataGridViewTextBoxColumn.HeaderText = "Col106";
            this.col106DataGridViewTextBoxColumn.Name = "col106DataGridViewTextBoxColumn";
            this.col106DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col107DataGridViewTextBoxColumn
            // 
            this.col107DataGridViewTextBoxColumn.DataPropertyName = "Col107";
            this.col107DataGridViewTextBoxColumn.HeaderText = "Col107";
            this.col107DataGridViewTextBoxColumn.Name = "col107DataGridViewTextBoxColumn";
            this.col107DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col108DataGridViewTextBoxColumn
            // 
            this.col108DataGridViewTextBoxColumn.DataPropertyName = "Col108";
            this.col108DataGridViewTextBoxColumn.HeaderText = "Col108";
            this.col108DataGridViewTextBoxColumn.Name = "col108DataGridViewTextBoxColumn";
            this.col108DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col109DataGridViewTextBoxColumn
            // 
            this.col109DataGridViewTextBoxColumn.DataPropertyName = "Col109";
            this.col109DataGridViewTextBoxColumn.HeaderText = "Col109";
            this.col109DataGridViewTextBoxColumn.Name = "col109DataGridViewTextBoxColumn";
            this.col109DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col110DataGridViewTextBoxColumn
            // 
            this.col110DataGridViewTextBoxColumn.DataPropertyName = "Col110";
            this.col110DataGridViewTextBoxColumn.HeaderText = "Col110";
            this.col110DataGridViewTextBoxColumn.Name = "col110DataGridViewTextBoxColumn";
            this.col110DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col111DataGridViewTextBoxColumn
            // 
            this.col111DataGridViewTextBoxColumn.DataPropertyName = "Col111";
            this.col111DataGridViewTextBoxColumn.HeaderText = "Col111";
            this.col111DataGridViewTextBoxColumn.Name = "col111DataGridViewTextBoxColumn";
            this.col111DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col112DataGridViewTextBoxColumn
            // 
            this.col112DataGridViewTextBoxColumn.DataPropertyName = "Col112";
            this.col112DataGridViewTextBoxColumn.HeaderText = "Col112";
            this.col112DataGridViewTextBoxColumn.Name = "col112DataGridViewTextBoxColumn";
            this.col112DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col113DataGridViewTextBoxColumn
            // 
            this.col113DataGridViewTextBoxColumn.DataPropertyName = "Col113";
            this.col113DataGridViewTextBoxColumn.HeaderText = "Col113";
            this.col113DataGridViewTextBoxColumn.Name = "col113DataGridViewTextBoxColumn";
            this.col113DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col114DataGridViewTextBoxColumn
            // 
            this.col114DataGridViewTextBoxColumn.DataPropertyName = "Col114";
            this.col114DataGridViewTextBoxColumn.HeaderText = "Col114";
            this.col114DataGridViewTextBoxColumn.Name = "col114DataGridViewTextBoxColumn";
            this.col114DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col115DataGridViewTextBoxColumn
            // 
            this.col115DataGridViewTextBoxColumn.DataPropertyName = "Col115";
            this.col115DataGridViewTextBoxColumn.HeaderText = "Col115";
            this.col115DataGridViewTextBoxColumn.Name = "col115DataGridViewTextBoxColumn";
            this.col115DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col116DataGridViewTextBoxColumn
            // 
            this.col116DataGridViewTextBoxColumn.DataPropertyName = "Col116";
            this.col116DataGridViewTextBoxColumn.HeaderText = "Col116";
            this.col116DataGridViewTextBoxColumn.Name = "col116DataGridViewTextBoxColumn";
            this.col116DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col117DataGridViewTextBoxColumn
            // 
            this.col117DataGridViewTextBoxColumn.DataPropertyName = "Col117";
            this.col117DataGridViewTextBoxColumn.HeaderText = "Col117";
            this.col117DataGridViewTextBoxColumn.Name = "col117DataGridViewTextBoxColumn";
            this.col117DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col118DataGridViewTextBoxColumn
            // 
            this.col118DataGridViewTextBoxColumn.DataPropertyName = "Col118";
            this.col118DataGridViewTextBoxColumn.HeaderText = "Col118";
            this.col118DataGridViewTextBoxColumn.Name = "col118DataGridViewTextBoxColumn";
            this.col118DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col119DataGridViewTextBoxColumn
            // 
            this.col119DataGridViewTextBoxColumn.DataPropertyName = "Col119";
            this.col119DataGridViewTextBoxColumn.HeaderText = "Col119";
            this.col119DataGridViewTextBoxColumn.Name = "col119DataGridViewTextBoxColumn";
            this.col119DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col120DataGridViewTextBoxColumn
            // 
            this.col120DataGridViewTextBoxColumn.DataPropertyName = "Col120";
            this.col120DataGridViewTextBoxColumn.HeaderText = "Col120";
            this.col120DataGridViewTextBoxColumn.Name = "col120DataGridViewTextBoxColumn";
            this.col120DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col121DataGridViewTextBoxColumn
            // 
            this.col121DataGridViewTextBoxColumn.DataPropertyName = "Col121";
            this.col121DataGridViewTextBoxColumn.HeaderText = "Col121";
            this.col121DataGridViewTextBoxColumn.Name = "col121DataGridViewTextBoxColumn";
            this.col121DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col122DataGridViewTextBoxColumn
            // 
            this.col122DataGridViewTextBoxColumn.DataPropertyName = "Col122";
            this.col122DataGridViewTextBoxColumn.HeaderText = "Col122";
            this.col122DataGridViewTextBoxColumn.Name = "col122DataGridViewTextBoxColumn";
            this.col122DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col123DataGridViewTextBoxColumn
            // 
            this.col123DataGridViewTextBoxColumn.DataPropertyName = "Col123";
            this.col123DataGridViewTextBoxColumn.HeaderText = "Col123";
            this.col123DataGridViewTextBoxColumn.Name = "col123DataGridViewTextBoxColumn";
            this.col123DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col124DataGridViewTextBoxColumn
            // 
            this.col124DataGridViewTextBoxColumn.DataPropertyName = "Col124";
            this.col124DataGridViewTextBoxColumn.HeaderText = "Col124";
            this.col124DataGridViewTextBoxColumn.Name = "col124DataGridViewTextBoxColumn";
            this.col124DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col125DataGridViewTextBoxColumn
            // 
            this.col125DataGridViewTextBoxColumn.DataPropertyName = "Col125";
            this.col125DataGridViewTextBoxColumn.HeaderText = "Col125";
            this.col125DataGridViewTextBoxColumn.Name = "col125DataGridViewTextBoxColumn";
            this.col125DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col126DataGridViewTextBoxColumn
            // 
            this.col126DataGridViewTextBoxColumn.DataPropertyName = "Col126";
            this.col126DataGridViewTextBoxColumn.HeaderText = "Col126";
            this.col126DataGridViewTextBoxColumn.Name = "col126DataGridViewTextBoxColumn";
            this.col126DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col127DataGridViewTextBoxColumn
            // 
            this.col127DataGridViewTextBoxColumn.DataPropertyName = "Col127";
            this.col127DataGridViewTextBoxColumn.HeaderText = "Col127";
            this.col127DataGridViewTextBoxColumn.Name = "col127DataGridViewTextBoxColumn";
            this.col127DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col128DataGridViewTextBoxColumn
            // 
            this.col128DataGridViewTextBoxColumn.DataPropertyName = "Col128";
            this.col128DataGridViewTextBoxColumn.HeaderText = "Col128";
            this.col128DataGridViewTextBoxColumn.Name = "col128DataGridViewTextBoxColumn";
            this.col128DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col129DataGridViewTextBoxColumn
            // 
            this.col129DataGridViewTextBoxColumn.DataPropertyName = "Col129";
            this.col129DataGridViewTextBoxColumn.HeaderText = "Col129";
            this.col129DataGridViewTextBoxColumn.Name = "col129DataGridViewTextBoxColumn";
            this.col129DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col130DataGridViewTextBoxColumn
            // 
            this.col130DataGridViewTextBoxColumn.DataPropertyName = "Col130";
            this.col130DataGridViewTextBoxColumn.HeaderText = "Col130";
            this.col130DataGridViewTextBoxColumn.Name = "col130DataGridViewTextBoxColumn";
            this.col130DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col131DataGridViewTextBoxColumn
            // 
            this.col131DataGridViewTextBoxColumn.DataPropertyName = "Col131";
            this.col131DataGridViewTextBoxColumn.HeaderText = "Col131";
            this.col131DataGridViewTextBoxColumn.Name = "col131DataGridViewTextBoxColumn";
            this.col131DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col132DataGridViewTextBoxColumn
            // 
            this.col132DataGridViewTextBoxColumn.DataPropertyName = "Col132";
            this.col132DataGridViewTextBoxColumn.HeaderText = "Col132";
            this.col132DataGridViewTextBoxColumn.Name = "col132DataGridViewTextBoxColumn";
            this.col132DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col133DataGridViewTextBoxColumn
            // 
            this.col133DataGridViewTextBoxColumn.DataPropertyName = "Col133";
            this.col133DataGridViewTextBoxColumn.HeaderText = "Col133";
            this.col133DataGridViewTextBoxColumn.Name = "col133DataGridViewTextBoxColumn";
            this.col133DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col134DataGridViewTextBoxColumn
            // 
            this.col134DataGridViewTextBoxColumn.DataPropertyName = "Col134";
            this.col134DataGridViewTextBoxColumn.HeaderText = "Col134";
            this.col134DataGridViewTextBoxColumn.Name = "col134DataGridViewTextBoxColumn";
            this.col134DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col135DataGridViewTextBoxColumn
            // 
            this.col135DataGridViewTextBoxColumn.DataPropertyName = "Col135";
            this.col135DataGridViewTextBoxColumn.HeaderText = "Col135";
            this.col135DataGridViewTextBoxColumn.Name = "col135DataGridViewTextBoxColumn";
            this.col135DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col136DataGridViewTextBoxColumn
            // 
            this.col136DataGridViewTextBoxColumn.DataPropertyName = "Col136";
            this.col136DataGridViewTextBoxColumn.HeaderText = "Col136";
            this.col136DataGridViewTextBoxColumn.Name = "col136DataGridViewTextBoxColumn";
            this.col136DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col137DataGridViewTextBoxColumn
            // 
            this.col137DataGridViewTextBoxColumn.DataPropertyName = "Col137";
            this.col137DataGridViewTextBoxColumn.HeaderText = "Col137";
            this.col137DataGridViewTextBoxColumn.Name = "col137DataGridViewTextBoxColumn";
            this.col137DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col138DataGridViewTextBoxColumn
            // 
            this.col138DataGridViewTextBoxColumn.DataPropertyName = "Col138";
            this.col138DataGridViewTextBoxColumn.HeaderText = "Col138";
            this.col138DataGridViewTextBoxColumn.Name = "col138DataGridViewTextBoxColumn";
            this.col138DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col139DataGridViewTextBoxColumn
            // 
            this.col139DataGridViewTextBoxColumn.DataPropertyName = "Col139";
            this.col139DataGridViewTextBoxColumn.HeaderText = "Col139";
            this.col139DataGridViewTextBoxColumn.Name = "col139DataGridViewTextBoxColumn";
            this.col139DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col140DataGridViewTextBoxColumn
            // 
            this.col140DataGridViewTextBoxColumn.DataPropertyName = "Col140";
            this.col140DataGridViewTextBoxColumn.HeaderText = "Col140";
            this.col140DataGridViewTextBoxColumn.Name = "col140DataGridViewTextBoxColumn";
            this.col140DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col141DataGridViewTextBoxColumn
            // 
            this.col141DataGridViewTextBoxColumn.DataPropertyName = "Col141";
            this.col141DataGridViewTextBoxColumn.HeaderText = "Col141";
            this.col141DataGridViewTextBoxColumn.Name = "col141DataGridViewTextBoxColumn";
            this.col141DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col142DataGridViewTextBoxColumn
            // 
            this.col142DataGridViewTextBoxColumn.DataPropertyName = "Col142";
            this.col142DataGridViewTextBoxColumn.HeaderText = "Col142";
            this.col142DataGridViewTextBoxColumn.Name = "col142DataGridViewTextBoxColumn";
            this.col142DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col143DataGridViewTextBoxColumn
            // 
            this.col143DataGridViewTextBoxColumn.DataPropertyName = "Col143";
            this.col143DataGridViewTextBoxColumn.HeaderText = "Col143";
            this.col143DataGridViewTextBoxColumn.Name = "col143DataGridViewTextBoxColumn";
            this.col143DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col144DataGridViewTextBoxColumn
            // 
            this.col144DataGridViewTextBoxColumn.DataPropertyName = "Col144";
            this.col144DataGridViewTextBoxColumn.HeaderText = "Col144";
            this.col144DataGridViewTextBoxColumn.Name = "col144DataGridViewTextBoxColumn";
            this.col144DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col145DataGridViewTextBoxColumn
            // 
            this.col145DataGridViewTextBoxColumn.DataPropertyName = "Col145";
            this.col145DataGridViewTextBoxColumn.HeaderText = "Col145";
            this.col145DataGridViewTextBoxColumn.Name = "col145DataGridViewTextBoxColumn";
            this.col145DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col146DataGridViewTextBoxColumn
            // 
            this.col146DataGridViewTextBoxColumn.DataPropertyName = "Col146";
            this.col146DataGridViewTextBoxColumn.HeaderText = "Col146";
            this.col146DataGridViewTextBoxColumn.Name = "col146DataGridViewTextBoxColumn";
            this.col146DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col147DataGridViewTextBoxColumn
            // 
            this.col147DataGridViewTextBoxColumn.DataPropertyName = "Col147";
            this.col147DataGridViewTextBoxColumn.HeaderText = "Col147";
            this.col147DataGridViewTextBoxColumn.Name = "col147DataGridViewTextBoxColumn";
            this.col147DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col148DataGridViewTextBoxColumn
            // 
            this.col148DataGridViewTextBoxColumn.DataPropertyName = "Col148";
            this.col148DataGridViewTextBoxColumn.HeaderText = "Col148";
            this.col148DataGridViewTextBoxColumn.Name = "col148DataGridViewTextBoxColumn";
            this.col148DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col149DataGridViewTextBoxColumn
            // 
            this.col149DataGridViewTextBoxColumn.DataPropertyName = "Col149";
            this.col149DataGridViewTextBoxColumn.HeaderText = "Col149";
            this.col149DataGridViewTextBoxColumn.Name = "col149DataGridViewTextBoxColumn";
            this.col149DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col150DataGridViewTextBoxColumn
            // 
            this.col150DataGridViewTextBoxColumn.DataPropertyName = "Col150";
            this.col150DataGridViewTextBoxColumn.HeaderText = "Col150";
            this.col150DataGridViewTextBoxColumn.Name = "col150DataGridViewTextBoxColumn";
            this.col150DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col151DataGridViewTextBoxColumn
            // 
            this.col151DataGridViewTextBoxColumn.DataPropertyName = "Col151";
            this.col151DataGridViewTextBoxColumn.HeaderText = "Col151";
            this.col151DataGridViewTextBoxColumn.Name = "col151DataGridViewTextBoxColumn";
            this.col151DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col152DataGridViewTextBoxColumn
            // 
            this.col152DataGridViewTextBoxColumn.DataPropertyName = "Col152";
            this.col152DataGridViewTextBoxColumn.HeaderText = "Col152";
            this.col152DataGridViewTextBoxColumn.Name = "col152DataGridViewTextBoxColumn";
            this.col152DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col153DataGridViewTextBoxColumn
            // 
            this.col153DataGridViewTextBoxColumn.DataPropertyName = "Col153";
            this.col153DataGridViewTextBoxColumn.HeaderText = "Col153";
            this.col153DataGridViewTextBoxColumn.Name = "col153DataGridViewTextBoxColumn";
            this.col153DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col154DataGridViewTextBoxColumn
            // 
            this.col154DataGridViewTextBoxColumn.DataPropertyName = "Col154";
            this.col154DataGridViewTextBoxColumn.HeaderText = "Col154";
            this.col154DataGridViewTextBoxColumn.Name = "col154DataGridViewTextBoxColumn";
            this.col154DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col155DataGridViewTextBoxColumn
            // 
            this.col155DataGridViewTextBoxColumn.DataPropertyName = "Col155";
            this.col155DataGridViewTextBoxColumn.HeaderText = "Col155";
            this.col155DataGridViewTextBoxColumn.Name = "col155DataGridViewTextBoxColumn";
            this.col155DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col156DataGridViewTextBoxColumn
            // 
            this.col156DataGridViewTextBoxColumn.DataPropertyName = "Col156";
            this.col156DataGridViewTextBoxColumn.HeaderText = "Col156";
            this.col156DataGridViewTextBoxColumn.Name = "col156DataGridViewTextBoxColumn";
            this.col156DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col157DataGridViewTextBoxColumn
            // 
            this.col157DataGridViewTextBoxColumn.DataPropertyName = "Col157";
            this.col157DataGridViewTextBoxColumn.HeaderText = "Col157";
            this.col157DataGridViewTextBoxColumn.Name = "col157DataGridViewTextBoxColumn";
            this.col157DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col158DataGridViewTextBoxColumn
            // 
            this.col158DataGridViewTextBoxColumn.DataPropertyName = "Col158";
            this.col158DataGridViewTextBoxColumn.HeaderText = "Col158";
            this.col158DataGridViewTextBoxColumn.Name = "col158DataGridViewTextBoxColumn";
            this.col158DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col159DataGridViewTextBoxColumn
            // 
            this.col159DataGridViewTextBoxColumn.DataPropertyName = "Col159";
            this.col159DataGridViewTextBoxColumn.HeaderText = "Col159";
            this.col159DataGridViewTextBoxColumn.Name = "col159DataGridViewTextBoxColumn";
            this.col159DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col160DataGridViewTextBoxColumn
            // 
            this.col160DataGridViewTextBoxColumn.DataPropertyName = "Col160";
            this.col160DataGridViewTextBoxColumn.HeaderText = "Col160";
            this.col160DataGridViewTextBoxColumn.Name = "col160DataGridViewTextBoxColumn";
            this.col160DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col161DataGridViewTextBoxColumn
            // 
            this.col161DataGridViewTextBoxColumn.DataPropertyName = "Col161";
            this.col161DataGridViewTextBoxColumn.HeaderText = "Col161";
            this.col161DataGridViewTextBoxColumn.Name = "col161DataGridViewTextBoxColumn";
            this.col161DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col162DataGridViewTextBoxColumn
            // 
            this.col162DataGridViewTextBoxColumn.DataPropertyName = "Col162";
            this.col162DataGridViewTextBoxColumn.HeaderText = "Col162";
            this.col162DataGridViewTextBoxColumn.Name = "col162DataGridViewTextBoxColumn";
            this.col162DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col163DataGridViewTextBoxColumn
            // 
            this.col163DataGridViewTextBoxColumn.DataPropertyName = "Col163";
            this.col163DataGridViewTextBoxColumn.HeaderText = "Col163";
            this.col163DataGridViewTextBoxColumn.Name = "col163DataGridViewTextBoxColumn";
            this.col163DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col164DataGridViewTextBoxColumn
            // 
            this.col164DataGridViewTextBoxColumn.DataPropertyName = "Col164";
            this.col164DataGridViewTextBoxColumn.HeaderText = "Col164";
            this.col164DataGridViewTextBoxColumn.Name = "col164DataGridViewTextBoxColumn";
            this.col164DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col165DataGridViewTextBoxColumn
            // 
            this.col165DataGridViewTextBoxColumn.DataPropertyName = "Col165";
            this.col165DataGridViewTextBoxColumn.HeaderText = "Col165";
            this.col165DataGridViewTextBoxColumn.Name = "col165DataGridViewTextBoxColumn";
            this.col165DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col166DataGridViewTextBoxColumn
            // 
            this.col166DataGridViewTextBoxColumn.DataPropertyName = "Col166";
            this.col166DataGridViewTextBoxColumn.HeaderText = "Col166";
            this.col166DataGridViewTextBoxColumn.Name = "col166DataGridViewTextBoxColumn";
            this.col166DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col167DataGridViewTextBoxColumn
            // 
            this.col167DataGridViewTextBoxColumn.DataPropertyName = "Col167";
            this.col167DataGridViewTextBoxColumn.HeaderText = "Col167";
            this.col167DataGridViewTextBoxColumn.Name = "col167DataGridViewTextBoxColumn";
            this.col167DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col168DataGridViewTextBoxColumn
            // 
            this.col168DataGridViewTextBoxColumn.DataPropertyName = "Col168";
            this.col168DataGridViewTextBoxColumn.HeaderText = "Col168";
            this.col168DataGridViewTextBoxColumn.Name = "col168DataGridViewTextBoxColumn";
            this.col168DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col169DataGridViewTextBoxColumn
            // 
            this.col169DataGridViewTextBoxColumn.DataPropertyName = "Col169";
            this.col169DataGridViewTextBoxColumn.HeaderText = "Col169";
            this.col169DataGridViewTextBoxColumn.Name = "col169DataGridViewTextBoxColumn";
            this.col169DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col170DataGridViewTextBoxColumn
            // 
            this.col170DataGridViewTextBoxColumn.DataPropertyName = "Col170";
            this.col170DataGridViewTextBoxColumn.HeaderText = "Col170";
            this.col170DataGridViewTextBoxColumn.Name = "col170DataGridViewTextBoxColumn";
            this.col170DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col171DataGridViewTextBoxColumn
            // 
            this.col171DataGridViewTextBoxColumn.DataPropertyName = "Col171";
            this.col171DataGridViewTextBoxColumn.HeaderText = "Col171";
            this.col171DataGridViewTextBoxColumn.Name = "col171DataGridViewTextBoxColumn";
            this.col171DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col172DataGridViewTextBoxColumn
            // 
            this.col172DataGridViewTextBoxColumn.DataPropertyName = "Col172";
            this.col172DataGridViewTextBoxColumn.HeaderText = "Col172";
            this.col172DataGridViewTextBoxColumn.Name = "col172DataGridViewTextBoxColumn";
            this.col172DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col173DataGridViewTextBoxColumn
            // 
            this.col173DataGridViewTextBoxColumn.DataPropertyName = "Col173";
            this.col173DataGridViewTextBoxColumn.HeaderText = "Col173";
            this.col173DataGridViewTextBoxColumn.Name = "col173DataGridViewTextBoxColumn";
            this.col173DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col174DataGridViewTextBoxColumn
            // 
            this.col174DataGridViewTextBoxColumn.DataPropertyName = "Col174";
            this.col174DataGridViewTextBoxColumn.HeaderText = "Col174";
            this.col174DataGridViewTextBoxColumn.Name = "col174DataGridViewTextBoxColumn";
            this.col174DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col175DataGridViewTextBoxColumn
            // 
            this.col175DataGridViewTextBoxColumn.DataPropertyName = "Col175";
            this.col175DataGridViewTextBoxColumn.HeaderText = "Col175";
            this.col175DataGridViewTextBoxColumn.Name = "col175DataGridViewTextBoxColumn";
            this.col175DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col176DataGridViewTextBoxColumn
            // 
            this.col176DataGridViewTextBoxColumn.DataPropertyName = "Col176";
            this.col176DataGridViewTextBoxColumn.HeaderText = "Col176";
            this.col176DataGridViewTextBoxColumn.Name = "col176DataGridViewTextBoxColumn";
            this.col176DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col177DataGridViewTextBoxColumn
            // 
            this.col177DataGridViewTextBoxColumn.DataPropertyName = "Col177";
            this.col177DataGridViewTextBoxColumn.HeaderText = "Col177";
            this.col177DataGridViewTextBoxColumn.Name = "col177DataGridViewTextBoxColumn";
            this.col177DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col178DataGridViewTextBoxColumn
            // 
            this.col178DataGridViewTextBoxColumn.DataPropertyName = "Col178";
            this.col178DataGridViewTextBoxColumn.HeaderText = "Col178";
            this.col178DataGridViewTextBoxColumn.Name = "col178DataGridViewTextBoxColumn";
            this.col178DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col179DataGridViewTextBoxColumn
            // 
            this.col179DataGridViewTextBoxColumn.DataPropertyName = "Col179";
            this.col179DataGridViewTextBoxColumn.HeaderText = "Col179";
            this.col179DataGridViewTextBoxColumn.Name = "col179DataGridViewTextBoxColumn";
            this.col179DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col180DataGridViewTextBoxColumn
            // 
            this.col180DataGridViewTextBoxColumn.DataPropertyName = "Col180";
            this.col180DataGridViewTextBoxColumn.HeaderText = "Col180";
            this.col180DataGridViewTextBoxColumn.Name = "col180DataGridViewTextBoxColumn";
            this.col180DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col181DataGridViewTextBoxColumn
            // 
            this.col181DataGridViewTextBoxColumn.DataPropertyName = "Col181";
            this.col181DataGridViewTextBoxColumn.HeaderText = "Col181";
            this.col181DataGridViewTextBoxColumn.Name = "col181DataGridViewTextBoxColumn";
            this.col181DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col182DataGridViewTextBoxColumn
            // 
            this.col182DataGridViewTextBoxColumn.DataPropertyName = "Col182";
            this.col182DataGridViewTextBoxColumn.HeaderText = "Col182";
            this.col182DataGridViewTextBoxColumn.Name = "col182DataGridViewTextBoxColumn";
            this.col182DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col183DataGridViewTextBoxColumn
            // 
            this.col183DataGridViewTextBoxColumn.DataPropertyName = "Col183";
            this.col183DataGridViewTextBoxColumn.HeaderText = "Col183";
            this.col183DataGridViewTextBoxColumn.Name = "col183DataGridViewTextBoxColumn";
            this.col183DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col184DataGridViewTextBoxColumn
            // 
            this.col184DataGridViewTextBoxColumn.DataPropertyName = "Col184";
            this.col184DataGridViewTextBoxColumn.HeaderText = "Col184";
            this.col184DataGridViewTextBoxColumn.Name = "col184DataGridViewTextBoxColumn";
            this.col184DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col185DataGridViewTextBoxColumn
            // 
            this.col185DataGridViewTextBoxColumn.DataPropertyName = "Col185";
            this.col185DataGridViewTextBoxColumn.HeaderText = "Col185";
            this.col185DataGridViewTextBoxColumn.Name = "col185DataGridViewTextBoxColumn";
            this.col185DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col186DataGridViewTextBoxColumn
            // 
            this.col186DataGridViewTextBoxColumn.DataPropertyName = "Col186";
            this.col186DataGridViewTextBoxColumn.HeaderText = "Col186";
            this.col186DataGridViewTextBoxColumn.Name = "col186DataGridViewTextBoxColumn";
            this.col186DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col187DataGridViewTextBoxColumn
            // 
            this.col187DataGridViewTextBoxColumn.DataPropertyName = "Col187";
            this.col187DataGridViewTextBoxColumn.HeaderText = "Col187";
            this.col187DataGridViewTextBoxColumn.Name = "col187DataGridViewTextBoxColumn";
            this.col187DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col188DataGridViewTextBoxColumn
            // 
            this.col188DataGridViewTextBoxColumn.DataPropertyName = "Col188";
            this.col188DataGridViewTextBoxColumn.HeaderText = "Col188";
            this.col188DataGridViewTextBoxColumn.Name = "col188DataGridViewTextBoxColumn";
            this.col188DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col189DataGridViewTextBoxColumn
            // 
            this.col189DataGridViewTextBoxColumn.DataPropertyName = "Col189";
            this.col189DataGridViewTextBoxColumn.HeaderText = "Col189";
            this.col189DataGridViewTextBoxColumn.Name = "col189DataGridViewTextBoxColumn";
            this.col189DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col190DataGridViewTextBoxColumn
            // 
            this.col190DataGridViewTextBoxColumn.DataPropertyName = "Col190";
            this.col190DataGridViewTextBoxColumn.HeaderText = "Col190";
            this.col190DataGridViewTextBoxColumn.Name = "col190DataGridViewTextBoxColumn";
            this.col190DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col191DataGridViewTextBoxColumn
            // 
            this.col191DataGridViewTextBoxColumn.DataPropertyName = "Col191";
            this.col191DataGridViewTextBoxColumn.HeaderText = "Col191";
            this.col191DataGridViewTextBoxColumn.Name = "col191DataGridViewTextBoxColumn";
            this.col191DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col192DataGridViewTextBoxColumn
            // 
            this.col192DataGridViewTextBoxColumn.DataPropertyName = "Col192";
            this.col192DataGridViewTextBoxColumn.HeaderText = "Col192";
            this.col192DataGridViewTextBoxColumn.Name = "col192DataGridViewTextBoxColumn";
            this.col192DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col193DataGridViewTextBoxColumn
            // 
            this.col193DataGridViewTextBoxColumn.DataPropertyName = "Col193";
            this.col193DataGridViewTextBoxColumn.HeaderText = "Col193";
            this.col193DataGridViewTextBoxColumn.Name = "col193DataGridViewTextBoxColumn";
            this.col193DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col194DataGridViewTextBoxColumn
            // 
            this.col194DataGridViewTextBoxColumn.DataPropertyName = "Col194";
            this.col194DataGridViewTextBoxColumn.HeaderText = "Col194";
            this.col194DataGridViewTextBoxColumn.Name = "col194DataGridViewTextBoxColumn";
            this.col194DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col195DataGridViewTextBoxColumn
            // 
            this.col195DataGridViewTextBoxColumn.DataPropertyName = "Col195";
            this.col195DataGridViewTextBoxColumn.HeaderText = "Col195";
            this.col195DataGridViewTextBoxColumn.Name = "col195DataGridViewTextBoxColumn";
            this.col195DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col196DataGridViewTextBoxColumn
            // 
            this.col196DataGridViewTextBoxColumn.DataPropertyName = "Col196";
            this.col196DataGridViewTextBoxColumn.HeaderText = "Col196";
            this.col196DataGridViewTextBoxColumn.Name = "col196DataGridViewTextBoxColumn";
            this.col196DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col197DataGridViewTextBoxColumn
            // 
            this.col197DataGridViewTextBoxColumn.DataPropertyName = "Col197";
            this.col197DataGridViewTextBoxColumn.HeaderText = "Col197";
            this.col197DataGridViewTextBoxColumn.Name = "col197DataGridViewTextBoxColumn";
            this.col197DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col198DataGridViewTextBoxColumn
            // 
            this.col198DataGridViewTextBoxColumn.DataPropertyName = "Col198";
            this.col198DataGridViewTextBoxColumn.HeaderText = "Col198";
            this.col198DataGridViewTextBoxColumn.Name = "col198DataGridViewTextBoxColumn";
            this.col198DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col199DataGridViewTextBoxColumn
            // 
            this.col199DataGridViewTextBoxColumn.DataPropertyName = "Col199";
            this.col199DataGridViewTextBoxColumn.HeaderText = "Col199";
            this.col199DataGridViewTextBoxColumn.Name = "col199DataGridViewTextBoxColumn";
            this.col199DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // col200DataGridViewTextBoxColumn
            // 
            this.col200DataGridViewTextBoxColumn.DataPropertyName = "Col200";
            this.col200DataGridViewTextBoxColumn.HeaderText = "Col200";
            this.col200DataGridViewTextBoxColumn.Name = "col200DataGridViewTextBoxColumn";
            this.col200DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectorNameDataGridViewTextBoxColumn
            // 
            this.collectorNameDataGridViewTextBoxColumn.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn.HeaderText = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn.Name = "collectorNameDataGridViewTextBoxColumn";
            this.collectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamLeaderDataGridViewTextBoxColumn
            // 
            this.teamLeaderDataGridViewTextBoxColumn.DataPropertyName = "TeamLeader";
            this.teamLeaderDataGridViewTextBoxColumn.HeaderText = "TeamLeader";
            this.teamLeaderDataGridViewTextBoxColumn.Name = "teamLeaderDataGridViewTextBoxColumn";
            this.teamLeaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // superVisorDataGridViewTextBoxColumn
            // 
            this.superVisorDataGridViewTextBoxColumn.DataPropertyName = "SuperVisor";
            this.superVisorDataGridViewTextBoxColumn.HeaderText = "SuperVisor";
            this.superVisorDataGridViewTextBoxColumn.Name = "superVisorDataGridViewTextBoxColumn";
            this.superVisorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridDomainFullDataBindingSource
            // 
            this.gridDomainFullDataBindingSource.DataMember = "GridDomainFullData";
            this.gridDomainFullDataBindingSource.DataSource = this.eIFCollector;
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // gridDomainFullDataTableAdapter
            // 
            this.gridDomainFullDataTableAdapter.ClearBeforeFill = true;
            // 
            // PTPTypeTextBox
            // 
            this.PTPTypeTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Other PTP",
            "Settle Deal",
            "Partial Settle"});
            this.PTPTypeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PTPTypeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PTPTypeTextBox.FormattingEnabled = true;
            this.PTPTypeTextBox.Items.AddRange(new object[] {
            "Other PTP",
            "Settle Deal",
            "Partial Settle"});
            this.PTPTypeTextBox.Location = new System.Drawing.Point(997, 152);
            this.PTPTypeTextBox.Name = "PTPTypeTextBox";
            this.PTPTypeTextBox.Size = new System.Drawing.Size(125, 25);
            this.PTPTypeTextBox.TabIndex = 59;
            // 
            // ConnetctionResultTextBox
            // 
            this.ConnetctionResultTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "No Answer",
            "Wrong Number",
            "Wrong Address",
            "Contact",
            "PTP",
            "Left Message",
            "Left Warning",
            "Collected",
            "Decesed",
            "UR"});
            this.ConnetctionResultTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ConnetctionResultTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ConnetctionResultTextBox.FormattingEnabled = true;
            this.ConnetctionResultTextBox.Items.AddRange(new object[] {
            "No Answer",
            "Wrong Number",
            "Wrong Address",
            "Contact",
            "PTP",
            "Left Message",
            "Left Warning",
            "Collected",
            "Decesed",
            "UR"});
            this.ConnetctionResultTextBox.Location = new System.Drawing.Point(997, 121);
            this.ConnetctionResultTextBox.Name = "ConnetctionResultTextBox";
            this.ConnetctionResultTextBox.Size = new System.Drawing.Size(125, 25);
            this.ConnetctionResultTextBox.TabIndex = 57;
            // 
            // ConnectionTypeTextBox
            // 
            this.ConnectionTypeTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Call",
            "Visit",
            "Mail",
            "Client Came Office"});
            this.ConnectionTypeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ConnectionTypeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ConnectionTypeTextBox.FormattingEnabled = true;
            this.ConnectionTypeTextBox.Items.AddRange(new object[] {
            "Call",
            "Visit",
            "Mail",
            "Client Came Office"});
            this.ConnectionTypeTextBox.Location = new System.Drawing.Point(997, 91);
            this.ConnectionTypeTextBox.Name = "ConnectionTypeTextBox";
            this.ConnectionTypeTextBox.Size = new System.Drawing.Size(125, 25);
            this.ConnectionTypeTextBox.TabIndex = 56;
            // 
            // dtConnectionDate
            // 
            this.dtConnectionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConnectionDate.Location = new System.Drawing.Point(997, 59);
            this.dtConnectionDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtConnectionDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtConnectionDate.Name = "dtConnectionDate";
            this.dtConnectionDate.Size = new System.Drawing.Size(125, 24);
            this.dtConnectionDate.TabIndex = 54;
            // 
            // PTPAmountTextBox
            // 
            this.PTPAmountTextBox.Location = new System.Drawing.Point(997, 214);
            this.PTPAmountTextBox.Name = "PTPAmountTextBox";
            this.PTPAmountTextBox.Size = new System.Drawing.Size(124, 24);
            this.PTPAmountTextBox.TabIndex = 64;
            this.PTPAmountTextBox.Text = "0";
            this.PTPAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeptBrokenCheckBox
            // 
            this.KeptBrokenCheckBox.Location = new System.Drawing.Point(997, 244);
            this.KeptBrokenCheckBox.Name = "KeptBrokenCheckBox";
            this.KeptBrokenCheckBox.Size = new System.Drawing.Size(57, 24);
            this.KeptBrokenCheckBox.TabIndex = 66;
            this.KeptBrokenCheckBox.Text = "Kept";
            this.KeptBrokenCheckBox.UseVisualStyleBackColor = true;
            // 
            // KeptAmountTextBox
            // 
            this.KeptAmountTextBox.Location = new System.Drawing.Point(997, 275);
            this.KeptAmountTextBox.Name = "KeptAmountTextBox";
            this.KeptAmountTextBox.Size = new System.Drawing.Size(124, 24);
            this.KeptAmountTextBox.TabIndex = 68;
            this.KeptAmountTextBox.Text = "0";
            this.KeptAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrialDetailsTextBox
            // 
            this.TrialDetailsTextBox.Location = new System.Drawing.Point(876, 335);
            this.TrialDetailsTextBox.Multiline = true;
            this.TrialDetailsTextBox.Name = "TrialDetailsTextBox";
            this.TrialDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TrialDetailsTextBox.Size = new System.Drawing.Size(246, 149);
            this.TrialDetailsTextBox.TabIndex = 69;
            // 
            // dtPTPDate
            // 
            this.dtPTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPTPDate.Location = new System.Drawing.Point(997, 184);
            this.dtPTPDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtPTPDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPTPDate.Name = "dtPTPDate";
            this.dtPTPDate.Size = new System.Drawing.Size(125, 24);
            this.dtPTPDate.TabIndex = 70;
            // 
            // CmdSaveVisitInfo
            // 
            this.CmdSaveVisitInfo.Location = new System.Drawing.Point(875, 490);
            this.CmdSaveVisitInfo.Name = "CmdSaveVisitInfo";
            this.CmdSaveVisitInfo.Size = new System.Drawing.Size(246, 45);
            this.CmdSaveVisitInfo.TabIndex = 71;
            this.CmdSaveVisitInfo.Text = "Save and New";
            this.CmdSaveVisitInfo.UseVisualStyleBackColor = true;
            this.CmdSaveVisitInfo.Click += new System.EventHandler(this.CmdSaveVisitInfo_Click);
            // 
            // txtActionTakerID
            // 
            this.txtActionTakerID.AutoCompleteCustomSource.AddRange(new string[] {
            "Call",
            "Visit",
            "Mail",
            "Client Came Office"});
            this.txtActionTakerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtActionTakerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtActionTakerID.DataSource = this.colLupTeamMembersBindingSource;
            this.txtActionTakerID.DisplayMember = "EmpNameAR";
            this.txtActionTakerID.FormattingEnabled = true;
            this.txtActionTakerID.Location = new System.Drawing.Point(876, 28);
            this.txtActionTakerID.Name = "txtActionTakerID";
            this.txtActionTakerID.Size = new System.Drawing.Size(245, 25);
            this.txtActionTakerID.TabIndex = 72;
            this.txtActionTakerID.ValueMember = "RecordID";
            // 
            // colLupTeamMembersBindingSource
            // 
            this.colLupTeamMembersBindingSource.DataMember = "Col_Lup_TeamMembers";
            this.colLupTeamMembersBindingSource.DataSource = this.eIFCollector;
            // 
            // col_Lup_TeamMembersTableAdapter
            // 
            this.col_Lup_TeamMembersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn1,
            this.domainIDDataGridViewTextBoxColumn1,
            this.accountIDDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.bucketDataGridViewTextBoxColumn,
            this.pastDue1DataGridViewTextBoxColumn,
            this.balance1DataGridViewTextBoxColumn,
            this.pastDueDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn,
            this.CardNo,
            this.NationalityTitle,
            this.PassportNo,
            this.CreditLimit,
            this.MobileNumber,
            this.AddressT,
            this.WorkPhoneTitle,
            this.CompanyNameTitle,
            this.CompanyAddressTitle,
            this.recordVersionDataGridViewTextBoxColumn,
            this.tLNameDataGridViewTextBoxColumn,
            this.dTLNameDataGridViewTextBoxColumn,
            this.collectorNameDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.colDomainsDataBasicBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(209, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 181);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recordSerialDataGridViewTextBoxColumn1
            // 
            this.recordSerialDataGridViewTextBoxColumn1.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn1.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn1.Name = "recordSerialDataGridViewTextBoxColumn1";
            this.recordSerialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn1.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn1
            // 
            this.domainIDDataGridViewTextBoxColumn1.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn1.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn1.Name = "domainIDDataGridViewTextBoxColumn1";
            this.domainIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "FCust";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNoDataGridViewTextBoxColumn.Width = 101;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 128;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 82;
            // 
            // cycleDataGridViewTextBoxColumn
            // 
            this.cycleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cycleDataGridViewTextBoxColumn.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn.Name = "cycleDataGridViewTextBoxColumn";
            this.cycleDataGridViewTextBoxColumn.ReadOnly = true;
            this.cycleDataGridViewTextBoxColumn.Width = 66;
            // 
            // bucketDataGridViewTextBoxColumn
            // 
            this.bucketDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bucketDataGridViewTextBoxColumn.DataPropertyName = "Bucket";
            this.bucketDataGridViewTextBoxColumn.HeaderText = "Bucket";
            this.bucketDataGridViewTextBoxColumn.Name = "bucketDataGridViewTextBoxColumn";
            this.bucketDataGridViewTextBoxColumn.ReadOnly = true;
            this.bucketDataGridViewTextBoxColumn.Width = 75;
            // 
            // pastDue1DataGridViewTextBoxColumn
            // 
            this.pastDue1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pastDue1DataGridViewTextBoxColumn.DataPropertyName = "PastDue1";
            this.pastDue1DataGridViewTextBoxColumn.HeaderText = "PastDue";
            this.pastDue1DataGridViewTextBoxColumn.Name = "pastDue1DataGridViewTextBoxColumn";
            this.pastDue1DataGridViewTextBoxColumn.ReadOnly = true;
            this.pastDue1DataGridViewTextBoxColumn.Width = 84;
            // 
            // balance1DataGridViewTextBoxColumn
            // 
            this.balance1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balance1DataGridViewTextBoxColumn.DataPropertyName = "Balance1";
            this.balance1DataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balance1DataGridViewTextBoxColumn.Name = "balance1DataGridViewTextBoxColumn";
            this.balance1DataGridViewTextBoxColumn.ReadOnly = true;
            this.balance1DataGridViewTextBoxColumn.Width = 79;
            // 
            // pastDueDataGridViewTextBoxColumn
            // 
            this.pastDueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pastDueDataGridViewTextBoxColumn.DataPropertyName = "PastDue";
            this.pastDueDataGridViewTextBoxColumn.HeaderText = "PastDue";
            this.pastDueDataGridViewTextBoxColumn.Name = "pastDueDataGridViewTextBoxColumn";
            this.pastDueDataGridViewTextBoxColumn.ReadOnly = true;
            this.pastDueDataGridViewTextBoxColumn.Visible = false;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 57;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.ReadOnly = true;
            this.officeDataGridViewTextBoxColumn.Width = 67;
            // 
            // CardNo
            // 
            this.CardNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "Card No";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            this.CardNo.Width = 77;
            // 
            // NationalityTitle
            // 
            this.NationalityTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NationalityTitle.DataPropertyName = "NationalityTitle";
            this.NationalityTitle.HeaderText = "Nationality";
            this.NationalityTitle.Name = "NationalityTitle";
            this.NationalityTitle.ReadOnly = true;
            this.NationalityTitle.Width = 96;
            // 
            // PassportNo
            // 
            this.PassportNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PassportNo.DataPropertyName = "PassportNo";
            this.PassportNo.HeaderText = "Passport No";
            this.PassportNo.Name = "PassportNo";
            this.PassportNo.ReadOnly = true;
            this.PassportNo.Width = 98;
            // 
            // CreditLimit
            // 
            this.CreditLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreditLimit.DataPropertyName = "CreditLimit";
            this.CreditLimit.HeaderText = "Credit Limit";
            this.CreditLimit.Name = "CreditLimit";
            this.CreditLimit.ReadOnly = true;
            this.CreditLimit.Width = 93;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MobileNumber.DataPropertyName = "MobileNumber";
            this.MobileNumber.HeaderText = "Mobile Number";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            this.MobileNumber.Width = 113;
            // 
            // AddressT
            // 
            this.AddressT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddressT.DataPropertyName = "AddressT";
            this.AddressT.HeaderText = "Customer Address";
            this.AddressT.Name = "AddressT";
            this.AddressT.ReadOnly = true;
            this.AddressT.Width = 132;
            // 
            // WorkPhoneTitle
            // 
            this.WorkPhoneTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WorkPhoneTitle.DataPropertyName = "WorkPhoneTitle";
            this.WorkPhoneTitle.HeaderText = "Work Phone";
            this.WorkPhoneTitle.Name = "WorkPhoneTitle";
            this.WorkPhoneTitle.ReadOnly = true;
            this.WorkPhoneTitle.Width = 101;
            // 
            // CompanyNameTitle
            // 
            this.CompanyNameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyNameTitle.DataPropertyName = "CompanyNameTitle";
            this.CompanyNameTitle.HeaderText = "Company Name";
            this.CompanyNameTitle.Name = "CompanyNameTitle";
            this.CompanyNameTitle.ReadOnly = true;
            this.CompanyNameTitle.Width = 121;
            // 
            // CompanyAddressTitle
            // 
            this.CompanyAddressTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyAddressTitle.DataPropertyName = "CompanyAddressTitle";
            this.CompanyAddressTitle.HeaderText = "Company Address";
            this.CompanyAddressTitle.Name = "CompanyAddressTitle";
            this.CompanyAddressTitle.ReadOnly = true;
            this.CompanyAddressTitle.Width = 132;
            // 
            // recordVersionDataGridViewTextBoxColumn
            // 
            this.recordVersionDataGridViewTextBoxColumn.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.Name = "recordVersionDataGridViewTextBoxColumn";
            this.recordVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn.Visible = false;
            // 
            // tLNameDataGridViewTextBoxColumn
            // 
            this.tLNameDataGridViewTextBoxColumn.DataPropertyName = "TL_Name";
            this.tLNameDataGridViewTextBoxColumn.HeaderText = "TL_Name";
            this.tLNameDataGridViewTextBoxColumn.Name = "tLNameDataGridViewTextBoxColumn";
            this.tLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tLNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dTLNameDataGridViewTextBoxColumn
            // 
            this.dTLNameDataGridViewTextBoxColumn.DataPropertyName = "DTL_Name";
            this.dTLNameDataGridViewTextBoxColumn.HeaderText = "DTL_Name";
            this.dTLNameDataGridViewTextBoxColumn.Name = "dTLNameDataGridViewTextBoxColumn";
            this.dTLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTLNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // collectorNameDataGridViewTextBoxColumn1
            // 
            this.collectorNameDataGridViewTextBoxColumn1.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn1.HeaderText = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn1.Name = "collectorNameDataGridViewTextBoxColumn1";
            this.collectorNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.collectorNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // colDomainsDataBasicBindingSource
            // 
            this.colDomainsDataBasicBindingSource.DataMember = "Col_DomainsDataBasic";
            this.colDomainsDataBasicBindingSource.DataSource = this.eIFCollector;
            // 
            // col_DomainsDataBasicTableAdapter
            // 
            this.col_DomainsDataBasicTableAdapter.ClearBeforeFill = true;
            // 
            // txtFilterByFCust
            // 
            this.txtFilterByFCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFilterByFCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFilterByFCust.DataSource = this.lupFCustBindingSource;
            this.txtFilterByFCust.DisplayMember = "AccountID";
            this.txtFilterByFCust.FormattingEnabled = true;
            this.txtFilterByFCust.Location = new System.Drawing.Point(208, 26);
            this.txtFilterByFCust.Name = "txtFilterByFCust";
            this.txtFilterByFCust.Size = new System.Drawing.Size(134, 25);
            this.txtFilterByFCust.TabIndex = 75;
            this.txtFilterByFCust.ValueMember = "RecordSerial";
            this.txtFilterByFCust.SelectedIndexChanged += new System.EventHandler(this.txtFilterByFCust_SelectedIndexChanged);
            // 
            // lupFCustBindingSource
            // 
            this.lupFCustBindingSource.DataMember = "LupFCust";
            this.lupFCustBindingSource.DataSource = this.eIFCollector;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Location = new System.Drawing.Point(488, 27);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(379, 24);
            this.txtFilterByName.TabIndex = 76;
            this.txtFilterByName.TextChanged += new System.EventHandler(this.txtFilterByName_TextChanged);
            // 
            // lupFCustTableAdapter
            // 
            this.lupFCustTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.colLupCommentListBindingSource;
            this.comboBox1.DisplayMember = "CommentTitle";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(876, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 25);
            this.comboBox1.TabIndex = 77;
            this.comboBox1.ValueMember = "CommentID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // colLupCommentListBindingSource
            // 
            this.colLupCommentListBindingSource.DataMember = "Col_Lup_CommentList";
            this.colLupCommentListBindingSource.DataSource = this.eIFCollector;
            // 
            // col_Lup_CommentListTableAdapter
            // 
            this.col_Lup_CommentListTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataSource = this.lupAccountNoBindingSource;
            this.comboBox2.DisplayMember = "AccountNo";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 25);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.ValueMember = "RecordSerial";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lupAccountNoBindingSource
            // 
            this.lupAccountNoBindingSource.DataMember = "LupAccountNo";
            this.lupAccountNoBindingSource.DataSource = this.eIFCollector;
            // 
            // lupAccountNoTableAdapter
            // 
            this.lupAccountNoTableAdapter.ClearBeforeFill = true;
            // 
            // isBroken
            // 
            this.isBroken.Location = new System.Drawing.Point(1065, 244);
            this.isBroken.Name = "isBroken";
            this.isBroken.Size = new System.Drawing.Size(57, 24);
            this.isBroken.TabIndex = 81;
            this.isBroken.Text = "Broken";
            this.isBroken.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 24);
            this.textBox1.TabIndex = 82;
            // 
            // CmdSearchByPassport
            // 
            this.CmdSearchByPassport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSearchByPassport.Location = new System.Drawing.Point(745, -7);
            this.CmdSearchByPassport.Name = "CmdSearchByPassport";
            this.CmdSearchByPassport.Size = new System.Drawing.Size(122, 31);
            this.CmdSearchByPassport.TabIndex = 83;
            this.CmdSearchByPassport.Text = "Find";
            this.CmdSearchByPassport.UseVisualStyleBackColor = true;
            this.CmdSearchByPassport.Click += new System.EventHandler(this.CmdSearchByPassport_Click);
            // 
            // frmDailyVisitInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 536);
            this.Controls.Add(this.CmdSearchByPassport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.isBroken);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtFilterByName);
            this.Controls.Add(this.txtFilterByFCust);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtActionTakerID);
            this.Controls.Add(this.CmdSaveVisitInfo);
            this.Controls.Add(this.dtPTPDate);
            this.Controls.Add(this.TrialDetailsTextBox);
            this.Controls.Add(PTPDateLabel);
            this.Controls.Add(PTPAmountLabel);
            this.Controls.Add(this.PTPAmountTextBox);
            this.Controls.Add(this.KeptBrokenCheckBox);
            this.Controls.Add(KeptAmountLabel);
            this.Controls.Add(this.KeptAmountTextBox);
            this.Controls.Add(this.PTPTypeTextBox);
            this.Controls.Add(this.ConnetctionResultTextBox);
            this.Controls.Add(this.ConnectionTypeTextBox);
            this.Controls.Add(ConnectionDateLabel);
            this.Controls.Add(this.dtConnectionDate);
            this.Controls.Add(ConnectionTypeLabel);
            this.Controls.Add(ConnetctionResultLabel);
            this.Controls.Add(PTPTypeLabel);
            this.Controls.Add(this.grvFullDomain);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDailyVisitInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Visits";
            this.Load += new System.EventHandler(this.frmDailyVisitInsert_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFullDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainFullDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupFCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupCommentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupAccountNoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblDomainVersion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.ComboBox txtMonth;
        internal System.Windows.Forms.ComboBox txtBranchID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        internal System.Windows.Forms.Button CmdLoadDomain;
        private System.Windows.Forms.DataGridView grvFullDomain;
        private System.Windows.Forms.BindingSource gridDomainFullDataBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridDomainFullDataTableAdapter gridDomainFullDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainSchemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn domainStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col17DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col18DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col21DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col22DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col23DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col24DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col25DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col26DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col27DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col28DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col29DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col30DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col31DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col32DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col33DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col34DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col35DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col36DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col37DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col38DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col39DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col40DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col41DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col42DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col43DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col44DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col45DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col46DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col47DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col48DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col49DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col50DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col51DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col52DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col53DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col54DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col55DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col56DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col57DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col58DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col59DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col60DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col61DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col62DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col63DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col64DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col65DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col66DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col67DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col68DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col69DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col70DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col71DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col72DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col73DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col74DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col75DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col76DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col77DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col78DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col79DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col80DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col81DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col82DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col83DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col84DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col85DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col86DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col87DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col88DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col89DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col90DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col91DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col92DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col93DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col94DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col95DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col96DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col97DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col98DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col99DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col100DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col101DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col102DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col103DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col104DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col105DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col106DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col107DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col108DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col109DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col110DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col111DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col112DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col113DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col114DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col115DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col116DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col117DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col118DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col119DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col120DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col121DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col122DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col123DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col124DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col125DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col126DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col127DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col128DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col129DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col130DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col131DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col132DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col133DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col134DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col135DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col136DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col137DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col138DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col139DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col140DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col141DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col142DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col143DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col144DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col145DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col146DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col147DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col148DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col149DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col150DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col151DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col152DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col153DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col154DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col155DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col156DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col157DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col158DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col159DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col160DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col161DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col162DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col163DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col164DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col165DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col166DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col167DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col168DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col169DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col170DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col171DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col172DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col173DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col174DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col175DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col176DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col177DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col178DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col179DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col180DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col181DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col182DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col183DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col184DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col185DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col186DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col187DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col188DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col189DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col190DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col191DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col192DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col193DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col194DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col195DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col196DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col197DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col198DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col199DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col200DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamLeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn superVisorDataGridViewTextBoxColumn;
        internal System.Windows.Forms.ComboBox PTPTypeTextBox;
        internal System.Windows.Forms.ComboBox ConnetctionResultTextBox;
        internal System.Windows.Forms.ComboBox ConnectionTypeTextBox;
        internal System.Windows.Forms.DateTimePicker dtConnectionDate;
        internal System.Windows.Forms.TextBox PTPAmountTextBox;
        internal System.Windows.Forms.CheckBox KeptBrokenCheckBox;
        internal System.Windows.Forms.TextBox KeptAmountTextBox;
        internal System.Windows.Forms.TextBox TrialDetailsTextBox;
        internal System.Windows.Forms.DateTimePicker dtPTPDate;
        internal System.Windows.Forms.Button CmdSaveVisitInfo;
        internal System.Windows.Forms.ComboBox txtActionTakerID;
        private System.Windows.Forms.BindingSource colLupTeamMembersBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamMembersTableAdapter col_Lup_TeamMembersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource colDomainsDataBasicBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter col_DomainsDataBasicTableAdapter;
        internal System.Windows.Forms.ComboBox txtFilterByFCust;
        internal System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.BindingSource lupFCustBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.LupFCustTableAdapter lupFCustTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource colLupCommentListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_CommentListTableAdapter col_Lup_CommentListTableAdapter;
        internal System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource lupAccountNoBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.LupAccountNoTableAdapter lupAccountNoTableAdapter;
        internal System.Windows.Forms.CheckBox isBroken;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastDue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPhoneTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddressTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Button CmdSearchByPassport;
    }
}