namespace Alatau
{
    partial class Form10
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
            this.CassirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RestoranDataSet3 = new Alatau.RestoranDataSet3();
            this.CassirTableAdapter = new Alatau.RestoranDataSet3TableAdapters.CassirTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CassirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // CassirBindingSource
            // 
            this.CassirBindingSource.DataMember = "Cassir";
            this.CassirBindingSource.DataSource = this.RestoranDataSet3;
            // 
            // RestoranDataSet3
            // 
            this.RestoranDataSet3.DataSetName = "RestoranDataSet3";
            this.RestoranDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CassirTableAdapter
            // 
            this.CassirTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CassirBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Alatau.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1018, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form10";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CassirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource CassirBindingSource;
        private RestoranDataSet3 RestoranDataSet3;
        private RestoranDataSet3TableAdapters.CassirTableAdapter CassirTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}