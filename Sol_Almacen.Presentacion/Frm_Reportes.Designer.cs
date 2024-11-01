
namespace Sol_Almacen.Presentacion
{
    partial class Frm_Reportes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.Grp_01 = new System.Windows.Forms.GroupBox();
            this.Dtp_fecha_fin2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtp_fecha_ini2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Cmb_Almacenes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Grp_01.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 42);
            this.panel1.TabIndex = 14;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(104, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = ".:. Reportes";
            // 
            // Grp_01
            // 
            this.Grp_01.BackColor = System.Drawing.Color.Gainsboro;
            this.Grp_01.Controls.Add(this.Dtp_fecha_fin2);
            this.Grp_01.Controls.Add(this.label7);
            this.Grp_01.Controls.Add(this.Dtp_fecha_ini2);
            this.Grp_01.Controls.Add(this.label8);
            this.Grp_01.Controls.Add(this.Btn_reporte);
            this.Grp_01.Controls.Add(this.Cmb_Almacenes);
            this.Grp_01.Controls.Add(this.label1);
            this.Grp_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_01.Location = new System.Drawing.Point(27, 62);
            this.Grp_01.Name = "Grp_01";
            this.Grp_01.Size = new System.Drawing.Size(422, 189);
            this.Grp_01.TabIndex = 55;
            this.Grp_01.TabStop = false;
            this.Grp_01.Text = "REGISTRO DE USO DE INSUMOS";
            // 
            // Dtp_fecha_fin2
            // 
            this.Dtp_fecha_fin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha_fin2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fecha_fin2.Location = new System.Drawing.Point(100, 65);
            this.Dtp_fecha_fin2.Name = "Dtp_fecha_fin2";
            this.Dtp_fecha_fin2.Size = new System.Drawing.Size(135, 20);
            this.Dtp_fecha_fin2.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Fecha fin:";
            // 
            // Dtp_fecha_ini2
            // 
            this.Dtp_fecha_ini2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha_ini2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fecha_ini2.Location = new System.Drawing.Point(100, 39);
            this.Dtp_fecha_ini2.Name = "Dtp_fecha_ini2";
            this.Dtp_fecha_ini2.Size = new System.Drawing.Size(135, 20);
            this.Dtp_fecha_ini2.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha inicio:";
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reporte.ForeColor = System.Drawing.Color.White;
            this.Btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reporte.Location = new System.Drawing.Point(148, 144);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(110, 30);
            this.Btn_reporte.TabIndex = 56;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Cmb_Almacenes
            // 
            this.Cmb_Almacenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Almacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Almacenes.FormattingEnabled = true;
            this.Cmb_Almacenes.Location = new System.Drawing.Point(100, 103);
            this.Cmb_Almacenes.Name = "Cmb_Almacenes";
            this.Cmb_Almacenes.Size = new System.Drawing.Size(218, 21);
            this.Cmb_Almacenes.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Almacén:";
            // 
            // Frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 530);
            this.Controls.Add(this.Grp_01);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Reportes";
            this.Text = "Frm_Reportes";
            this.Load += new System.EventHandler(this.Frm_Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Grp_01.ResumeLayout(false);
            this.Grp_01.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.GroupBox Grp_01;
        internal System.Windows.Forms.DateTimePicker Dtp_fecha_fin2;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DateTimePicker Dtp_fecha_ini2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.ComboBox Cmb_Almacenes;
        private System.Windows.Forms.Label label1;
    }
}