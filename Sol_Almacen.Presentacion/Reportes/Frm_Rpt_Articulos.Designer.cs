
namespace Sol_Almacen.Presentacion.Reportes
{
    partial class Frm_Rpt_Articulos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_MiAlmacen = new Sol_Almacen.Presentacion.Reportes.DataSet_MiAlmacen();
            this.Usp_mostrar_arBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Usp_mostrar_arTableAdapter = new Sol_Almacen.Presentacion.Reportes.DataSet_MiAlmacenTableAdapters.Usp_mostrar_arTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usp_mostrar_arBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Usp_mostrar_arBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Almacen.Presentacion.Reportes.Rpt_Articulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1207, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_MiAlmacen
            // 
            this.DataSet_MiAlmacen.DataSetName = "DataSet_MiAlmacen";
            this.DataSet_MiAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Usp_mostrar_arBindingSource
            // 
            this.Usp_mostrar_arBindingSource.DataMember = "Usp_mostrar_ar";
            this.Usp_mostrar_arBindingSource.DataSource = this.DataSet_MiAlmacen;
            // 
            // Usp_mostrar_arTableAdapter
            // 
            this.Usp_mostrar_arTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(29, 52);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 6;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 540);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Articulos";
            this.Text = "Frm_Rpt_Articulos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usp_mostrar_arBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Usp_mostrar_arBindingSource;
        private DataSet_MiAlmacen DataSet_MiAlmacen;
        private DataSet_MiAlmacenTableAdapters.Usp_mostrar_arTableAdapter Usp_mostrar_arTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}