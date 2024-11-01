
namespace Sol_Almacen.Presentacion.Reportes_Personalizados
{
    partial class Frm_Rpt_Personalizado_01
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
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            this.Reporte_personalizado_01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Reportes_Personalizados = new Sol_Almacen.Presentacion.Reportes_Personalizados.DataSet_Reportes_Personalizados();
            this.Reporte_personalizado_01TableAdapter = new Sol_Almacen.Presentacion.Reportes_Personalizados.DataSet_Reportes_PersonalizadosTableAdapters.Reporte_personalizado_01TableAdapter();
            this.Txt_p3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_personalizado_01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_Personalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_personalizado_01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Almacen.Presentacion.Reportes_Personalizados.Rpt_Reporte_personalizado_01.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1184, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(26, 83);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 18;
            this.Txt_p2.Visible = false;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(26, 47);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 17;
            this.Txt_p1.Visible = false;
            // 
            // Reporte_personalizado_01BindingSource
            // 
            this.Reporte_personalizado_01BindingSource.DataMember = "Reporte_personalizado_01";
            this.Reporte_personalizado_01BindingSource.DataSource = this.DataSet_Reportes_Personalizados;
            // 
            // DataSet_Reportes_Personalizados
            // 
            this.DataSet_Reportes_Personalizados.DataSetName = "DataSet_Reportes_Personalizados";
            this.DataSet_Reportes_Personalizados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_personalizado_01TableAdapter
            // 
            this.Reporte_personalizado_01TableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p3
            // 
            this.Txt_p3.Location = new System.Drawing.Point(26, 119);
            this.Txt_p3.Name = "Txt_p3";
            this.Txt_p3.Size = new System.Drawing.Size(100, 20);
            this.Txt_p3.TabIndex = 19;
            this.Txt_p3.Visible = false;
            // 
            // Frm_Rpt_Personalizado_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 520);
            this.Controls.Add(this.Txt_p3);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Personalizado_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Personalizado_01";
            this.Load += new System.EventHandler(this.Frm_Rpt_Personalizado_01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_personalizado_01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_Personalizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_personalizado_01BindingSource;
        private DataSet_Reportes_Personalizados DataSet_Reportes_Personalizados;
        private DataSet_Reportes_PersonalizadosTableAdapters.Reporte_personalizado_01TableAdapter Reporte_personalizado_01TableAdapter;
        internal System.Windows.Forms.TextBox Txt_p2;
        internal System.Windows.Forms.TextBox Txt_p1;
        internal System.Windows.Forms.TextBox Txt_p3;
    }
}