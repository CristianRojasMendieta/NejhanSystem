
namespace Sol_Almacen.Presentacion.Reportes
{
    partial class Frm_Rpt_Imprimir_Entrada_Articulos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_MiAlmacen = new Sol_Almacen.Presentacion.Reportes.DataSet_MiAlmacen();
            this.USP_Imprimir_Entrada_ArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Imprimir_Entrada_ArticulosTableAdapter = new Sol_Almacen.Presentacion.Reportes.DataSet_MiAlmacenTableAdapters.USP_Imprimir_Entrada_ArticulosTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Imprimir_Entrada_ArticulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.USP_Imprimir_Entrada_ArticulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Almacen.Presentacion.Reportes.Rpt_Imprimir_Entrada_Articulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_MiAlmacen
            // 
            this.DataSet_MiAlmacen.DataSetName = "DataSet_MiAlmacen";
            this.DataSet_MiAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Imprimir_Entrada_ArticulosBindingSource
            // 
            this.USP_Imprimir_Entrada_ArticulosBindingSource.DataMember = "USP_Imprimir_Entrada_Articulos";
            this.USP_Imprimir_Entrada_ArticulosBindingSource.DataSource = this.DataSet_MiAlmacen;
            // 
            // USP_Imprimir_Entrada_ArticulosTableAdapter
            // 
            this.USP_Imprimir_Entrada_ArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(12, 42);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 8;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Imprimir_Entrada_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Imprimir_Entrada_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Imprimir_Entrada_Articulos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Imprimir_Entrada_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Imprimir_Entrada_ArticulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Imprimir_Entrada_ArticulosBindingSource;
        private DataSet_MiAlmacen DataSet_MiAlmacen;
        private DataSet_MiAlmacenTableAdapters.USP_Imprimir_Entrada_ArticulosTableAdapter USP_Imprimir_Entrada_ArticulosTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}