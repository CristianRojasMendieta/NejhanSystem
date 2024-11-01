
namespace Sol_Almacen.Presentacion.Reportes_Personalizados
{
    partial class Frm_Rpt_Personalizado_02
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
            this.Reporte_personalizado_02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Reportes_Personalizados = new Sol_Almacen.Presentacion.Reportes_Personalizados.DataSet_Reportes_Personalizados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_personalizado_02TableAdapter = new Sol_Almacen.Presentacion.Reportes_Personalizados.DataSet_Reportes_PersonalizadosTableAdapters.Reporte_personalizado_02TableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_personalizado_02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_Personalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte_personalizado_02BindingSource
            // 
            this.Reporte_personalizado_02BindingSource.DataMember = "Reporte_personalizado_02";
            this.Reporte_personalizado_02BindingSource.DataSource = this.DataSet_Reportes_Personalizados;
            // 
            // DataSet_Reportes_Personalizados
            // 
            this.DataSet_Reportes_Personalizados.DataSetName = "DataSet_Reportes_Personalizados";
            this.DataSet_Reportes_Personalizados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_personalizado_02BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Almacen.Presentacion.Reportes_Personalizados.Rpt_Reporte_personalizado_02.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1184, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_personalizado_02TableAdapter
            // 
            this.Reporte_personalizado_02TableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(27, 55);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 13;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Personalizado_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 520);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Personalizado_02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePersonalizado_01";
            this.Load += new System.EventHandler(this.Frm_Rpt_Personalizado_02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_personalizado_02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_Personalizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_personalizado_02BindingSource;
        private DataSet_Reportes_Personalizados DataSet_Reportes_Personalizados;
        private DataSet_Reportes_PersonalizadosTableAdapters.Reporte_personalizado_02TableAdapter Reporte_personalizado_02TableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}