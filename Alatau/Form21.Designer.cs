namespace Alatau
{
    partial class Form21
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
            this.skldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RestoranDataSet8 = new Alatau.RestoranDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.skldTableAdapter = new Alatau.RestoranDataSet8TableAdapters.skldTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // skldBindingSource
            // 
            this.skldBindingSource.DataMember = "skld";
            this.skldBindingSource.DataSource = this.RestoranDataSet8;
            // 
            // RestoranDataSet8
            // 
            this.RestoranDataSet8.DataSetName = "RestoranDataSet8";
            this.RestoranDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.skldBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Alatau.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // skldTableAdapter
            // 
            this.skldTableAdapter.ClearBeforeFill = true;
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form21";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource skldBindingSource;
        private RestoranDataSet8 RestoranDataSet8;
        private RestoranDataSet8TableAdapters.skldTableAdapter skldTableAdapter;
    }
}