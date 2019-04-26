namespace WindowsFormsApp2
{
    partial class statistics
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DAT = new WindowsFormsApp2.DAT();
            this.VolunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VolunteerTableAdapter = new WindowsFormsApp2.DATTableAdapters.VolunteerTableAdapter();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new WindowsFormsApp2.DATTableAdapters.stockTableAdapter();
            this.charity_orgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charity_orgTableAdapter = new WindowsFormsApp2.DATTableAdapters.charity_orgTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolunteerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charity_orgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.stockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(325, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.charity_orgBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report9.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(346, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(328, 246);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.VolunteerBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report10.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(49, 252);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(527, 160);
            this.reportViewer3.TabIndex = 2;
            // 
            // DAT
            // 
            this.DAT.DataSetName = "DAT";
            this.DAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VolunteerBindingSource
            // 
            this.VolunteerBindingSource.DataMember = "Volunteer";
            this.VolunteerBindingSource.DataSource = this.DAT;
            // 
            // VolunteerTableAdapter
            // 
            this.VolunteerTableAdapter.ClearBeforeFill = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.DAT;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // charity_orgBindingSource
            // 
            this.charity_orgBindingSource.DataMember = "charity_org";
            this.charity_orgBindingSource.DataSource = this.DAT;
            // 
            // charity_orgTableAdapter
            // 
            this.charity_orgTableAdapter.ClearBeforeFill = true;
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "statistics";
            this.Text = "statistics";
            this.Load += new System.EventHandler(this.statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolunteerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charity_orgBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource VolunteerBindingSource;
        private DAT DAT;
        private DATTableAdapters.VolunteerTableAdapter VolunteerTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DATTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource charity_orgBindingSource;
        private DATTableAdapters.charity_orgTableAdapter charity_orgTableAdapter;
    }
}