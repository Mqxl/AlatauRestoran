namespace Alatau
{
    partial class Form8
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
            this.PovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RestoranDataSet3 = new Alatau.RestoranDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PovarTableAdapter = new Alatau.RestoranDataSet3TableAdapters.PovarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // PovarBindingSource
            // 
            this.PovarBindingSource.DataMember = "Povar";
            this.PovarBindingSource.DataSource = this.RestoranDataSet3;
            // 
            // RestoranDataSet3
            // 
            this.RestoranDataSet3.DataSetName = "RestoranDataSet3";
            this.RestoranDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PovarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Alatau.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(975, 709);
            this.reportViewer1.TabIndex = 0;
            // 
            // PovarTableAdapter
            // 
            this.PovarTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 709);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form8";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PovarBindingSource;
        private RestoranDataSet3 RestoranDataSet3;
        private RestoranDataSet3TableAdapters.PovarTableAdapter PovarTableAdapter;
    }
}