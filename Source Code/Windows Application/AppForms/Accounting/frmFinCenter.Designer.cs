namespace TMS.AppForms.Accounting
{
    partial class frmFinCenter
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
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.accounting = new TMS.AppDataSets.Accounting();
            this.aFinCenterBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_FinCenterBalanceTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_FinCenterBalanceTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dtStartRange = new System.Windows.Forms.DateTimePicker();
            this.dtEndRange = new System.Windows.Forms.DateTimePicker();
            this.CmdDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFinCenterBalanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(0, 40);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.Size = new System.Drawing.Size(964, 553);
            this.CRViewer.TabIndex = 0;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aFinCenterBalanceBindingSource
            // 
            this.aFinCenterBalanceBindingSource.DataMember = "A_FinCenterBalance";
            this.aFinCenterBalanceBindingSource.DataSource = this.accounting;
            // 
            // a_FinCenterBalanceTableAdapter
            // 
            this.a_FinCenterBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dtStartRange
            // 
            this.dtStartRange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartRange.Location = new System.Drawing.Point(783, 3);
            this.dtStartRange.Name = "dtStartRange";
            this.dtStartRange.Size = new System.Drawing.Size(169, 37);
            this.dtStartRange.TabIndex = 2;
            // 
            // dtEndRange
            // 
            this.dtEndRange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndRange.Location = new System.Drawing.Point(583, 3);
            this.dtEndRange.Name = "dtEndRange";
            this.dtEndRange.Size = new System.Drawing.Size(169, 37);
            this.dtEndRange.TabIndex = 3;
            // 
            // CmdDo
            // 
            this.CmdDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDo.Location = new System.Drawing.Point(469, 3);
            this.CmdDo.Name = "CmdDo";
            this.CmdDo.Size = new System.Drawing.Size(108, 37);
            this.CmdDo.TabIndex = 4;
            this.CmdDo.Text = "عرض";
            this.CmdDo.UseVisualStyleBackColor = true;
            this.CmdDo.Click += new System.EventHandler(this.CmdDo_Click);
            // 
            // frmFinCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 593);
            this.Controls.Add(this.CmdDo);
            this.Controls.Add(this.dtEndRange);
            this.Controls.Add(this.dtStartRange);
            this.Controls.Add(this.CRViewer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmFinCenter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة المركز المالي";
            this.Load += new System.EventHandler(this.frmFinCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFinCenterBalanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aFinCenterBalanceBindingSource;
        private AppDataSets.AccountingTableAdapters.A_FinCenterBalanceTableAdapter a_FinCenterBalanceTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DateTimePicker dtStartRange;
        private System.Windows.Forms.DateTimePicker dtEndRange;
        private System.Windows.Forms.Button CmdDo;
    }
}