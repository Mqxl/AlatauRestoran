namespace Alatau
{
    partial class Form6
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
            this.OfficiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RestoranDataSet123 = new Alatau.RestoranDataSet123();
            this.OfficiantTableAdapter = new Alatau.RestoranDataSet123TableAdapters.OfficiantTableAdapter();
            this.RestoranDataSet = new Alatau.RestoranDataSet();
            this.HotFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HotFoodTableAdapter = new Alatau.RestoranDataSetTableAdapters.HotFoodTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OfficiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotFoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OfficiantBindingSource
            // 
            this.OfficiantBindingSource.DataMember = "Officiant";
            this.OfficiantBindingSource.DataSource = this.RestoranDataSet123;
            // 
            // RestoranDataSet123
            // 
            this.RestoranDataSet123.DataSetName = "RestoranDataSet123";
            this.RestoranDataSet123.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OfficiantTableAdapter
            // 
            this.OfficiantTableAdapter.ClearBeforeFill = true;
            // 
            // RestoranDataSet
            // 
            this.RestoranDataSet.DataSetName = "RestoranDataSet";
            this.RestoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HotFoodBindingSource
            // 
            this.HotFoodBindingSource.DataMember = "HotFood";
            this.HotFoodBindingSource.DataSource = this.RestoranDataSet;
            // 
            // HotFoodTableAdapter
            // 
            this.HotFoodTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.OfficiantBindingSource, "Имя", true));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OfficiantBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Alatau.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1012, 566);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 566);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form6";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OfficiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotFoodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OfficiantBindingSource;
        private RestoranDataSet123 RestoranDataSet123;
        private RestoranDataSet123TableAdapters.OfficiantTableAdapter OfficiantTableAdapter;
        private System.Windows.Forms.BindingSource HotFoodBindingSource;
        private RestoranDataSet RestoranDataSet;
        private RestoranDataSetTableAdapters.HotFoodTableAdapter HotFoodTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}