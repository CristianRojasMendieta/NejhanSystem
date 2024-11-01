
namespace Sol_Almacen.Presentacion.Reportes_libre
{
    partial class Frm_Rpt_Libre_01
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_Reportes_libre = new Sol_Almacen.Presentacion.Reportes_libre.DataSet_Reportes_libre();
            this.Reporte_libre_01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_libre_01TableAdapter = new Sol_Almacen.Presentacion.Reportes_libre.DataSet_Reportes_libreTableAdapters.Reporte_libre_01TableAdapter();
            this.Txt_p3 = new System.Windows.Forms.TextBox();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_libre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_libre_01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Reporte_libre_01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Almacen.Presentacion.Reportes_libre.Rpt_Reporte_libre_01.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(994, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Reportes_libre
            // 
            this.DataSet_Reportes_libre.DataSetName = "DataSet_Reportes_libre";
            this.DataSet_Reportes_libre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_libre_01BindingSource
            // 
            this.Reporte_libre_01BindingSource.DataMember = "Reporte_libre_01";
            this.Reporte_libre_01BindingSource.DataSource = this.DataSet_Reportes_libre;
            // 
            // Reporte_libre_01TableAdapter
            // 
            this.Reporte_libre_01TableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p3
            // 
            this.Txt_p3.Location = new System.Drawing.Point(23, 118);
            this.Txt_p3.Name = "Txt_p3";
            this.Txt_p3.Size = new System.Drawing.Size(100, 20);
            this.Txt_p3.TabIndex = 17;
            this.Txt_p3.Visible = false;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(23, 83);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 16;
            this.Txt_p2.Visible = false;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(23, 47);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 15;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Libre_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 520);
            this.Controls.Add(this.Txt_p3);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Libre_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Libre_01";
            this.Load += new System.EventHandler(this.Frm_Rpt_Libre_01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_libre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_libre_01BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_libre_01BindingSource;
        private DataSet_Reportes_libre DataSet_Reportes_libre;
        private DataSet_Reportes_libreTableAdapters.Reporte_libre_01TableAdapter Reporte_libre_01TableAdapter;
        internal System.Windows.Forms.TextBox Txt_p3;
        internal System.Windows.Forms.TextBox Txt_p2;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}